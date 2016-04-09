using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRC16
{
    public partial class CRC16 : Form
    {
        public CRC16()
        {
            InitializeComponent();
        }
        /*
         * 
         * 
         * 
         * 
         */
        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            byte[] CRC_source = strToToHexByte(text);
            byte[] CRC_result = CRC_16(CRC_source);

            string str = text + "-" + BitConverter.ToString(CRC_result);
            this.label1.Text = str;
        }
        private static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }
        /*
         * 
         * 
         * 
         * 
         */
        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    
        /*
         * 
         * 
         * 
         * 
         */
        public static byte[] CRC_16(byte[] data)
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
    }
}
