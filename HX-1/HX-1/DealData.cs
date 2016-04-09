using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HX_1
{
    class DealData
    {
    
        public int tempature = 0;         //温度
        public float outputVoltage = 0;   //直流输出电压
        public float outputCurrent = 0;   //直流输出电流

        public bool shutdown = false;         //关机
        public bool overTempature = false;    //过温
        public bool shortCircuit = false;     //短路

        public bool overVoltage = false;      //输出过压
        public bool underVoltage = false;     //输入欠压
        public bool overCurrent = false;      //输出过流
        public bool fan = false;              //风机
        
        
        //分析相应数据
        public void AnalysisResData(byte[] data)
        {

            //设置文本框数据
            this.tempature = (int)data[3];
            this.outputVoltage = (float)data[4] / 10;
            this.outputCurrent = (float)data[6] / 10;

            //设置模块状态
            string DAT7 = System.Convert.ToString(data[8], 2);
            //过温
            if (DAT7[0] == '1'){
                this.overTempature = true;
            }
            //风机
            if (DAT7[1] == '1'){
                this.fan = true;
            }
            //输出过压
            if (DAT7[2] == '1'){
                this.overVoltage = true;
            }
            //输出欠压
            if (DAT7[3] == '1'){
                this.underVoltage = true;
            }
            //输出过流
            if (DAT7[4] == '1'){
                this.overCurrent = true;
            }
            //开关机
            if (DAT7[5] == '1'){
                this.shutdown = true;
            }
            //短路
            if (DAT7[7] == '1'){
                this.shortCircuit = true;
            }

        }

        //检查相应数据的CRC16校验
        public static bool Check_CRC16(byte[] data)
        {
            byte[] CRC_data = new byte[data.Length-2];
            for (int i = 0; i < data.Length - 2; i++) {
                CRC_data[i] = data[i];
            }
            
            byte[] returnValue = CRC16(CRC_data);
            //比较校验值
            if (returnValue[0] == data[data.Length - 2] && returnValue[1] == data[data.Length - 1]) {
                return true;
            }
            return false;
        }

        //CRC16校验算法
        public static byte[] CRC16(byte[] data)
        {
            //byte[] returnVal = GetCRC16ByPoly(data, 0x6886, false);
           
            byte[] returnVal = new byte[2];
            byte CRC16Lo, CRC16Hi, CL, CH, SaveHi, SaveLo;
            int i, Flag;
            
            //CRC16初始值
            CRC16Lo = 0xFF; 
            CRC16Hi = 0xFF;

            //CRC16多项式
            CL = 0x01;
            CH = 0xA0;

            for (i = 0; i < data.Length; i++)
            {
                CRC16Lo = (byte)(CRC16Lo ^ data[i]);//每一个数据与CRC寄存器进行异或
                for (Flag = 0; Flag <= 7; Flag++)
                {
                    SaveHi = CRC16Hi;
                    SaveLo = CRC16Lo;
                    CRC16Hi = (byte)(CRC16Hi >> 1);//高位右移一位
                    CRC16Lo = (byte)(CRC16Lo >> 1);//低位右移一位
                    if ((SaveHi & 0x01) == 0x01)//如果高位字节最后一位为
                    {
                        CRC16Lo = (byte)(CRC16Lo | 0x80);//则低位字节右移后前面补 否则自动补0
                    }
                    if ((SaveLo & 0x01) == 0x01)//如果LSB为1，则与多项式码进行异或
                    {
                        CRC16Hi = (byte)(CRC16Hi ^ CH);
                        CRC16Lo = (byte)(CRC16Lo ^ CL);
                    }
                }
            }
            returnVal[1] = CRC16Hi;//CRC高位
            returnVal[0] = CRC16Lo;//CRC低位 
            return returnVal;
        }
       
        /*
         * 函数功能：多项式参数 CRC16计算  
         * 参数：命令、多项式、高位是否在前
         * 返回值：校验码
         */
        public static byte[] GetCRC16ByPoly(byte[] Cmd, ushort Poly, bool IsHighBefore)
        {
            byte[] CRC = new byte[2];
            ushort CRCValue = 0xFFFF;
            for (int i = 0; i < Cmd.Length; i++)
            {
                CRCValue = (ushort)(CRCValue ^ Cmd[i]);
                for (int j = 0; j < 8; j++)
                {
                    if ((CRCValue & 0x0001) != 0)
                    {
                        CRCValue = (ushort)((CRCValue >> 1) ^ Poly);
                    }
                    else
                    {
                        CRCValue = (ushort)(CRCValue >> 1);
                    }
                }
            }
            byte[] Check = BitConverter.GetBytes(CRCValue);
            if (IsHighBefore == true)
            {
                return new byte[2] { Check[1], Check[0] };
            }
            else
            {
                return Check;
            }
        }  

        //将int转换成4byte的数组
        public static byte[] ConvertIntToByteArray(int m)
        {
            byte[] arry = new byte[4];

            arry[0] = (byte)(m & 0xFF);
            arry[1] = (byte)((m & 0xFF00) >> 8);
            arry[2] = (byte)((m & 0xFF0000) >> 16);
            arry[3] = (byte)((m >> 24) & 0xFF);

            return arry;
        }  

        /*
         *函数功能：将软件的输出信息输入到log日志当中
         *
         *
         */
        public static void Output(string log) {

            if (!File.Exists("HX_1-log.txt")){
                FileStream fs = new FileStream("HX_1-log.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(DateTime.Now.ToString("HH:mm:ss ---  ") + log);
                sw.Close();
            }else {
                FileStream fs = new FileStream("HX_1-log.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(DateTime.Now.ToString("HH:mm:ss ---  ") + log);
                sw.Close();
            }
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss ---  ") + log);  
        }
    }
}
