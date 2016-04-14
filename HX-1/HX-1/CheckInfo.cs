using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HX_1
{
    
    public class CheckInfo
    {
        /*
         *函数功能：判断地址栏输入的信息是否有效
         *返回值：int
         *  如果地址有效，则返回地址值
         *  如果无效，则返回0
         * 
         */
        public static int Check_textBox_Address(string addressStr) 
        {
            DealData.Output("In Check_textBox_Address function:");
            int address = 0;
            //如果地址栏为空
            if (addressStr.Equals(""))
            {
                DealData.Output("Address empty!");
                return 0;
            }
            try
            {
                //获取地址1-15，并进行判断
                address = int.Parse(addressStr);
                if (address < 1 || address > 15)
                {
                    DealData.Output("Address out of range!");
                    return 0;
                }
                return address;
            }catch(Exception excep) {
                DealData.Output(excep.Message);
                return 0;
            }
        }
        /*
         *函数功能：判断设定输出电流的信息是否有效
         *返回值：int
         *  如果地址有效，则返回设定值
         *  如果无效，则返回0
         * 
         */
        public static int Check_textBox_setOutputCurrent(string currentStr) 
        {
            DealData.Output("In Check_textBox_setOutputCurrent function:");
            int setOutputCurrent = 0;
            //如果设置输出电流为空
            if (currentStr.Equals(""))
            {
                DealData.Output("setOutputCurrent empty!");
                return 0;
            }
            try{
                //获取设置输出电流
                setOutputCurrent = int.Parse(currentStr);
                if (setOutputCurrent < 1 || setOutputCurrent > 500)
                {
                    DealData.Output("setOutputCurrent out of range!");
                    return 0;
                }
                //需要将设定输出电流的值乘以10
                return setOutputCurrent * 10;
            }catch (Exception excep){
                DealData.Output(excep.Message);
                return 0;
            }
        }
    }
}
