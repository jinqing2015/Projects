﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HX_1
{
    public partial class Form_HX : Form
    {
        int responseByteSize = 12;//设置返回数据的字节数

        public Form_HX()
        {
            InitializeComponent();
        }

        //窗口加载
        private void Form_HX_Load(object sender, EventArgs e)
        {
            DealData.Output("---------------------------------------------------");
            DealData.Output("IN Form_HX_Load function:SUCCESS");

            this.textBox_Address.Text = "1";   //初始化地址为0
            //获取本机的所有串口,将端口放到列表中
            string[] portList = SerialPort.GetPortNames();
            for (int i = 0; i < portList.Length; i++)
            {
                this.comboBox_COM.Items.Add(portList[i]);
            }
            return;
        }
        //设置serialPort的属性
        private void setSerialPortConfig()
        {
            DealData.Output("IN setComConfig function:");
            //获得当前选中的COM,如果COM口的名字是空的，则输出错误信息直接返回
            string portName = this.comboBox_COM.Text;
            if (portName == ""){
                DealData.Output("portName is empty");
                return;
            }

            serialPort.PortName = portName; //设置串口号
            serialPort.BaudRate = 9600;//设置波特率
            serialPort.DataBits = 8; //设置数据位
            serialPort.StopBits = StopBits.One; //设置停止位
            serialPort.Parity = Parity.None;  //设置无校验
            serialPort.ReadTimeout = 20; //设置读超时
            serialPort.WriteTimeout = 20; //设置写超时
            serialPort.ReceivedBytesThreshold = 12; //设置接受数据的长度

        }
        //连接按钮被按下时
        private void button_Connect_Click(object sender, EventArgs e)
        {
            DealData.Output("In textBox_Address_TextChanged function:");
            this.setSerialPortConfig();

            //判断地址栏是否有效
            int address = CheckInfo.Check_textBox_Address(this.textBox_Address.Text);
            if (address == 0)
                return;
            
            //获取Portname
            string portname = this.comboBox_COM.Text;
            if (portname.Equals("")) {
                DealData.Output("portName is empty");
                return;
            }

            try{
                //将串口打开并进行状态查询
                serialPort.Open();
            }catch(Exception excep){
                DealData.Output("Open exception" + excep.Message);
            }

            if (!serialPort.IsOpen){
                DealData.Output("serialPort is not open");
                return;
            }
            
            //串口成功打开，将按钮换成Disconnect
            this.button_Connect.Visible = false;
            this.button_Disconnect.Visible = true;
           
            byte[] tempData = {(byte)address, 0x10, 0x00, 0x00, 0x00, 0x00};
            byte[] crc = DealData.CRC16(tempData);
            byte[] stateOrder = { (byte)address, 0x10, 0x00, 0x00, 0x00, 0x00, crc[0],crc[1]};

            try{
                //将命令写到输出缓冲区中
                serialPort.Write(stateOrder, 0, stateOrder.Length);
            }catch (Exception excep) {
                DealData.Output("Write exception" + excep.Message);
            }
        }

        //断开连接按钮被按下
        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            DealData.Output("In button_Disconnect_Click function:");
            this.button_Disconnect.Visible = false;
            this.button_Connect.Visible = true;
            try{
                serialPort.Close();
            }catch (Exception excep) {
                DealData.Output("Close exception" + excep.Message);
            }

            //如果serialPort关闭成功
            if (!serialPort.IsOpen)
            {
                this.button_Connect.Visible = true;
                this.button_Disconnect.Visible = false;
                //将颜色还原
                this.pictureBox1.BackColor = Color.White;
                this.pictureBox3.BackColor = Color.White;
                this.pictureBox4.BackColor = Color.White;
                this.pictureBox5.BackColor = Color.White;
                this.pictureBox6.BackColor = Color.White;
                this.pictureBox7.BackColor = Color.White;
                this.pictureBox8.BackColor = Color.White;
            }
        }    

        //通过事件接受
        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DealData.Output("In DataReceived function:");
            byte[] readBuffer = new byte[this.responseByteSize];
            
            //读取数据
            try {
                int readlength = serialPort.Read(readBuffer, 0, this.responseByteSize);
                if (readlength != this.responseByteSize)
                {
                    DealData.Output("readlength != 12");
                }
                DealData.Output("Received data:" + BitConverter.ToString(readBuffer));

            }catch(Exception excep){
                DealData.Output("Read exception" + excep.Message);
            }

            //判读数据CRC16校验信息
            bool CRC16_result = DealData.Check_CRC16(readBuffer);
            if (CRC16_result == false)
            {
                DealData.Output("CRC16 check failed");
                return;
            }
            //对数据进行解析
            DealData dealObj = new DealData();
            dealObj.AnalysisResData(readBuffer);

            //判断地址是否与当前地址一致
            //判断地址栏是否有效
            int address = CheckInfo.Check_textBox_Address(this.textBox_Address.Text);
            if (address == 0)
                return;
            int address_readBuffer = (int)readBuffer[0];
            if (address != address_readBuffer)
            {
                DealData.Output("address != addressBuffer");
                return;
            }
            //按照数据解析，设置相应状态和文本框数据
            this.textBox_DirectCurrent.Text = dealObj.outputCurrent.ToString();
            this.textBox_DirectVoltage.Text = dealObj.outputVoltage.ToString();
            this.textBox_Temperature.Text = dealObj.tempature.ToString();

            if (dealObj.shutdown == true){//关机
                this.pictureBox1.BackColor = Color.Red;
            }else {
                this.pictureBox1.BackColor = Color.Green;
            }

            if(dealObj.overTempature == true){//过温
                this.pictureBox3.BackColor = Color.Red;
            }else{
                this.pictureBox3.BackColor = Color.Green;
            }

            if(dealObj.shortCircuit == true ){//短路
                this.pictureBox4.BackColor = Color.Red;
            }else{
                this.pictureBox4.BackColor = Color.Green;
            }

            if(dealObj.overVoltage == true){//输出过压
                this.pictureBox5.BackColor = Color.Red;
            }else{
                this.pictureBox5.BackColor = Color.Green;
            }

            if(dealObj.underVoltage == true){//输入欠压
                this.pictureBox6.BackColor = Color.Red;
            }else {
                this.pictureBox6.BackColor = Color.Green;
            }

            if(dealObj.overCurrent == true){//输出过流
                this.pictureBox7.BackColor = Color.Red;
            }else{
                this.pictureBox7.BackColor = Color.Green;
            }

            if(dealObj.fan == true){//风机
                this.pictureBox8.BackColor = Color.Red;
            }else{
                this.pictureBox8.BackColor = Color.Green;
            }
        }

        //设置输出电流按钮被按下
        private void button_Submit_Click(object sender, EventArgs e)
        {
            DealData.Output("In button_Submit_Click function:");
            //获得设定输出电流
            int setOutputCurrent = CheckInfo.Check_textBox_setOutputCurrent(this.textBox_setOutputCurrent.Text);
            if (setOutputCurrent == 0)      
                return;

            //判断地址栏是否有效
            int address = CheckInfo.Check_textBox_Address(this.textBox_Address.Text);
            if (address == 0)
                return;

            //将设置输出电流进行转换
            byte[] current = DealData.ConvertIntToByteArray(setOutputCurrent);
            byte[] tempData = { (byte)address, 0x11, current[0], current[1], 0x00, 0x00 };
            byte[] crc = DealData.CRC16(tempData);
            byte[] setOutputCurrentOrder = { (byte)address, 0x11, 0x00, 0x00, 0x00, 0x00, crc[0], crc[1] };

            try{
                //将命令写到输出缓冲区中
                serialPort.Write(setOutputCurrentOrder, 0, setOutputCurrentOrder.Length);
            } catch (Exception excep){
                DealData.Output("Write exception:" + excep.Message);
            }
        }
        //当输出使能按钮被按下
        private void button_OpenClose_Click(object sender, EventArgs e)
        {
            DealData.Output("In button_OpenClose_Click function:");
            //判断地址栏是否有效
            int address = CheckInfo.Check_textBox_Address(this.textBox_Address.Text);
            if (address == 0)
                return;

            byte[] tempData = { (byte)address, 0x16, 0x00, 0x00, 0x00, 0x00 };
            byte[] crc = DealData.CRC16(tempData);
            byte[] openCloseOrder = { (byte)address, 0x16, 0x00, 0x00, 0x00, 0x00, crc[0], crc[1] };

            //判断是否是开机状态
            //如果是开机状态，输出使能按钮则发出关机指令
            if (this.pictureBox1.BackColor == Color.Green) { 
                //开机状态
                tempData[1] = 23;//0x17
                crc = DealData.CRC16(tempData);
                openCloseOrder[1] = 23;
                openCloseOrder[openCloseOrder.Length - 2] = crc[0];
                openCloseOrder[openCloseOrder.Length - 1] = crc[1];
            }

            try{
                //将命令写到输出缓冲区中
                serialPort.Write(openCloseOrder, 0, openCloseOrder.Length);
            }catch (Exception excep){
                DealData.Output("Write exception:" + excep.Message);
            }
        }

        //当文本框的值发生变化时
        private void textBox_Address_TextChanged(object sender, EventArgs e)
        {
            DealData.Output("In textBox_Address_TextChanged function:");
            
            if (!serialPort.IsOpen) {
                DealData.Output("serialPort is closed!");
                return;
            }

            //判断地址栏是否有效
            int address = CheckInfo.Check_textBox_Address(this.textBox_Address.Text);
            if (address == 0)
                return;

            //设置查询指令
            byte[] tempData = { (byte)address, 0x10, 0x00, 0x00, 0x00, 0x00 };
            byte[] crc = DealData.CRC16(tempData);
            byte[] stateOrder = { (byte)address, 0x10, 0x00, 0x00, 0x00, 0x00, crc[0], crc[1] };

            try{
                //将命令写到输出缓冲区中
                serialPort.Write(stateOrder, 0, stateOrder.Length);
            }catch (Exception excep){
                DealData.Output("Write exception " + excep.Message);
            }
        }
    }
}