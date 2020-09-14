using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace TempMoniter
{
    public partial class Main : System.Windows.Forms.Form
    {
        Byte[] ReceiveData=new Byte[50]; //创建数组用于存放串口接收的数据位

        string DataStr;  //格式化为#十进制后的温度数据字符串

        DataServer ObjData = new DataServer();  //处理格式化为十进制后的温度数据字符串

        TempData Data = new TempData();  //处理为各个通道的温度数据
        int X = 0;//图标的X轴
        


        public Main()
        {
            //初始化截面
            InitializeComponent();
            //初始化可用的端口
            PortInit();
            //设置串口和波特率默认设置为第一个
            SelectId();
            //初始化图表
            InitChart();
        }



        //点击连接或者断开串口按钮的操作
        private void btn_Switch_Click(object sender, EventArgs e)
        {
            if (btn_Switch.Text == "连接")
            {
                //判断串口是否为断开状态
                if (Start(false, cmb_PortName.SelectedItem.ToString(), cmb_BaudRate.SelectedItem.ToString()) == true)
                {
                    btn_Switch.Text = "断开";
                    MessageBox.Show("连接成功", "提示：");
                }
            }
            else if (btn_Switch.Text == "断开")
            {
                //判断串口是否为开启状态
                if (Start(true, cmb_PortName.SelectedItem.ToString(), cmb_BaudRate.SelectedItem.ToString()) == true)
                {
                    btn_Switch.Text = "连接";
                    TimerCollect.Stop();
                    btn_Engage.Text = "开始采集";
                    MessageBox.Show("断开成功", "提示：");
                }
            }
        }


        //点击开始或停止采集按钮执行的操作
        private void btn_Engage_Click(object sender, EventArgs e)
        {        
                //判断串口已打开并且为开始采集状态
                if (btn_Engage.Text == "开始采集"&& ObjPort.IsOpen)
                {
                    //开启定时器
                    TimerCollect.Interval = Convert.ToInt16(txt_Cycle.Text) * 1000;
                    TimerCollect.Start();
                    btn_Engage.Text = "停止采集";
                }

            else if (!ObjPort.IsOpen)
            {
                MessageBox.Show("串口未连接，请连接串口", "提示：");
            }

            else if (btn_Engage.Text == "停止采集")
            {
                //关闭定时器
                TimerCollect.Stop();
                btn_Engage.Text = "开始采集";
            }
        }

        //定时器相关操作
        private void TimerCollect_Tick(object sender, EventArgs e)
        {
            //向串口发送读取温度的指令
            SendReadTemp();
            //将得到的十六进制温度数据转换为十进制温度数据，并将各温度数据拼接为#隔开的字符串
            ProcessReceiveData();
            //将字符串转化为温度对象
            Data = ObjData.DataAnaly(DataStr);
            //向图表中添加温度数据，并试试绘制曲线
            ShowTemp(Data);
            //向列表中实时加入最新数据
            AddDate(Data);
            //自动保存数据
            ObjData.SaveDate(Data);

        }

        //向串口发送读取温度的指令
        private void SendReadTemp()
        {
            Byte[] TxData = { 0x01, 0x03, 0x00, 0x28, 0x00, 0x08, 0xC4, 0x04 };
            ObjPort.Write(TxData, 0, 8);
        }

        #region 串口相关服务
        /// <summary>
        /// 读取可以使用的串口
        /// </summary>
        /// <string型List集合--串口号></returns>
        private void PortInit()
        {
            string[] portList = System.IO.Ports.SerialPort.GetPortNames();
            cmb_PortName.Items.Clear();
            if (portList.Length <= 0)
            {
                cmb_PortName.Items.Add("无串口");
            }
            else
            {
                for (int i = 0; i < portList.Length; ++i)
                {
                    string name = portList[i];
                    cmb_PortName.Items.Add(name);
                }
            }
        }

        /// <summary>
        /// 开启/关闭串口
        /// </summary>
        /// <param name="开启状态"></param>
        /// <param name="串口号"></param>
        /// <param name="波特率"></param>
        /// <param name="数据位"></param>
        /// <param name="停止位"></param>
        /// <param name="校验位"></param>
        /// <param name=""></param>
        private bool Start(bool IsLinked, string PortName, string Rate)
        {
            if (IsLinked == false)//串口处于关闭状态
            {
                try
                {
                    ObjPort.PortName = PortName;   //出口名
                    ObjPort.BaudRate = Convert.ToInt32(Rate);  //波特率
                    //ObjPort.DataBits = Convert.ToInt32(PortData);//数据位处理函数
                    //switch (PortStop)//停止位
                    //{
                    //    case "0": ObjPort.StopBits = StopBits.None; break;
                    //    case "1": ObjPort.StopBits = StopBits.One; break;
                    //    case "1.5": ObjPort.StopBits = StopBits.OnePointFive; break;
                    //    case "2": ObjPort.StopBits = StopBits.Two; break;
                    //}
                    //switch (PortParity)//奇偶校验位
                    //{
                    //    case "0": ObjPort.Parity = System.IO.Ports.Parity.None; break;
                    //    case "1": ObjPort.Parity = System.IO.Ports.Parity.Odd; break;
                    //    case "2": ObjPort.Parity = System.IO.Ports.Parity.Even; break;
                    //    case "3": ObjPort.Parity = System.IO.Ports.Parity.Mark; break;
                    //    case "4": ObjPort.Parity = System.IO.Ports.Parity.Space; break;
                    //}
                    ObjPort.Open();
                    cmb_PortName.Enabled = false;
                    cmb_BaudRate.Enabled = false;

                    //cmb_PortData.Enabled = false;
                    //cmb_PortParity.Enabled = false;
                    //cmb_PortStop.Enabled = false;

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接发生错误：" + ex.Message);
                    return false;
                }
            }
            else
            {
                ObjPort.Close();
                cmb_PortName.Enabled = true;
                cmb_BaudRate.Enabled = true;
                //cmb_PortData.Enabled = true;
                //cmb_PortParity.Enabled = true;
                //cmb_PortStop.Enabled = true;
                return true;
            }
        }

        /// <summary>
        /// 设置默认参数
        /// </summary>
        private void SelectId()
        {
            cmb_PortName.SelectedIndex = 0;
            cmb_BaudRate.SelectedIndex = 0;
            //cmb_PortData.SelectedIndex = 2;
            //cmb_PortParity.SelectedIndex = 0;
            //cmb_PortStop.SelectedIndex = 1;
        }

        /// <summary>
        /// 串口数据读取服务函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Byte[] readBuffer = new Byte[ObjPort.BytesToRead];//创建接收字节数组
            ObjPort.Read(readBuffer, 0, readBuffer.Length);//读取接收的数据
            if (readBuffer.Length > 0)
            {
                ReceiveData = readBuffer;
                ObjPort.DiscardInBuffer();
            }
          
        }

        //将得到的十六进制温度数据转换为十进制温度数据，并将各温度数据拼接为#隔开的字符串
        private void ProcessReceiveData()
        {

            //尝试将发送的十六进制温度数据转换为十进制温度数据
            string Temper1 = (ReceiveData[3].ToString("X2") + ReceiveData[4].ToString("X2"));  //获取十六进制温度字符串
            string Temper2 = (ReceiveData[5].ToString("X2") + ReceiveData[6].ToString("X2"));
            string Temper3 = (ReceiveData[7].ToString("X2") + ReceiveData[8].ToString("X2"));
            string Temper4 = (ReceiveData[9].ToString("X2") + ReceiveData[10].ToString("X2"));
            string Temper5 = (ReceiveData[11].ToString("X2") + ReceiveData[12].ToString("X2"));
            string Temper6 = (ReceiveData[13].ToString("X2") + ReceiveData[14].ToString("X2"));
            string Temper7 = (ReceiveData[15].ToString("X2") + ReceiveData[16].ToString("X2"));
            string Temper8 = (ReceiveData[17].ToString("X2") + ReceiveData[18].ToString("X2"));

            float ftemp1 = CaculateTemp(Temper1);
            float ftemp2 = CaculateTemp(Temper2);
            float ftemp3 = CaculateTemp(Temper3);
            float ftemp4 = CaculateTemp(Temper4);
            float ftemp5 = CaculateTemp(Temper5);
            float ftemp6 = CaculateTemp(Temper6);
            float ftemp7 = CaculateTemp(Temper7);
            float ftemp8 = CaculateTemp(Temper8);

            DataStr = ftemp1 + "#" + ftemp2 + "#" + ftemp3 + "#" + ftemp4 + "#" + ftemp5 + "#" + ftemp6 + "#" + ftemp7 + "#" + ftemp8 + "#";
        }

        private static float CaculateTemp(String str)
        {
            String Temper = str;
            float Temperature;
            if (Temper.StartsWith("F"))
            {
                int NegTemp = HexStringToNegative(Temper);
                Temperature = (float) NegTemp / 10;
            }
            else
            {
                Temperature = (float)Convert.ToInt32(Temper, 16) / 10;
            }
            return Temperature;
        }
        #endregion

        /// <summary>
        /// 有符号十六进制转为十进制负数
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        private static int HexStringToNegative(string strNumber)
        {
            int iNegate = 0;
            int iNumber = Convert.ToInt32(strNumber, 16);

            if (iNumber > 127)
            {
                short bbb = (short)~(iNumber - 1);
                string bin = Convert.ToString(bbb, 2).PadLeft(16, '0');
                iNegate = -Convert.ToInt32(bin, 2);
            }
            return iNegate;
        }

        #region UI图表相关服务
        private void InitChart()//初始化条形图
        {
            ChartArea chartArea = Ct_Temp.ChartAreas[0];
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 600;
            chartArea.AxisY.Minimum = 0d;
            chartArea.AxisY.Maximum = 50d;
            
        }


        private void ShowTemp(TempData data)//显示图像
        {
            #region 添加图线数据
            Series series1 = Ct_Temp.Series[0];
            series1.ChartType = SeriesChartType.Line;
            series1.BorderWidth = 3;
            //series1.Color = System.Drawing.Color.Red;
            //series1.LegendText = "CH1";
            series1.Points.AddXY(X, data.Line_1);

            Series series2 = Ct_Temp.Series[1];
            series2.ChartType = SeriesChartType.Line;
            series2.BorderWidth = 3;
            //series2.Color = System.Drawing.Color.Black;
            //series2.LegendText = "线路2";
            series2.Points.AddXY(X, data.Line_2);

            Series series3 = Ct_Temp.Series[2];
            series3.ChartType = SeriesChartType.Line;
            series3.BorderWidth = 3;
            //series3.Color = System.Drawing.Color.Blue;
            //series3.LegendText = "线路3";
            series3.Points.AddXY(X, data.Line_3);

            Series series4 = Ct_Temp.Series[3];
            series4.ChartType = SeriesChartType.Line;
            series4.BorderWidth = 3;
            //series4.Color = System.Drawing.Color.Yellow;
            //series4.LegendText = "线路4";
            series4.Points.AddXY(X, data.Line_4);

            Series series5 = Ct_Temp.Series[4];
            series5.ChartType = SeriesChartType.Line;
            series5.BorderWidth = 3;
            //series4.Color = System.Drawing.Color.Yellow;
            //series4.LegendText = "线路4";
            series5.Points.AddXY(X, data.Line_5);

            Series series6 = Ct_Temp.Series[5];
            series6.ChartType = SeriesChartType.Line;
            series6.BorderWidth = 3;
            //series4.Color = System.Drawing.Color.Yellow;
            //series4.LegendText = "线路4";
            series6.Points.AddXY(X, data.Line_6);

            Series series7 = Ct_Temp.Series[6];
            series7.ChartType = SeriesChartType.Line;
            series7.BorderWidth = 3;
            //series4.Color = System.Drawing.Color.Yellow;
            //series4.LegendText = "线路4";
            series7.Points.AddXY(X, data.Line_7);

            Series series8 = Ct_Temp.Series[7];
            series8.ChartType = SeriesChartType.Line;
            series8.BorderWidth = 3;
            //series4.Color = System.Drawing.Color.Yellow;
            //series4.LegendText = "线路4";
            series8.Points.AddXY(X, data.Line_8);
            #endregion

            X=X+ Convert.ToInt16(txt_Cycle.Text);
            ChartArea chartArea = Ct_Temp.ChartAreas[0];
            if (X > chartArea.AxisX.Maximum)
            {
                //chartArea.AxisX.Minimum = X - 10;
                chartArea.AxisX.Maximum += 600;
            }
            if (data.Line_1 > chartArea.AxisY.Maximum || data.Line_2 > chartArea.AxisY.Maximum || data.Line_3 > chartArea.AxisY.Maximum || data.Line_4 > chartArea.AxisY.Maximum || data.Line_5 > chartArea.AxisY.Maximum || data.Line_6 > chartArea.AxisY.Maximum || data.Line_7 > chartArea.AxisY.Maximum || data.Line_8 > chartArea.AxisY.Maximum)
            {
                chartArea.AxisY.Maximum += 20d;
            }
        }

        private void AddDate(TempData data)//数据表添加
        {
            ListViewItem List = listView_Temp.Items.Add(DateTime.Now.ToLocalTime().ToString());
            List.SubItems.Add(data.Line_1.ToString() + "℃");
            List.SubItems.Add(data.Line_2.ToString() + "℃");
            List.SubItems.Add(data.Line_3.ToString() + "℃");
            List.SubItems.Add(data.Line_4.ToString() + "℃");
            List.SubItems.Add(data.Line_5.ToString() + "℃");
            List.SubItems.Add(data.Line_6.ToString() + "℃");
            List.SubItems.Add(data.Line_7.ToString() + "℃");
            List.SubItems.Add(data.Line_8.ToString() + "℃");
            listView_Temp.Items[listView_Temp.Items.Count - 1].EnsureVisible();//滚动到最后  
        }


        #endregion

        private void 打开数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 定义一个打开文件控件  
            OpenFileDialog fileDlg = new OpenFileDialog();
            // 设置打开控件后，默认为exe运行目录  
            fileDlg.InitialDirectory = Application.StartupPath;
          
            //// 设置控件打开文件类型的显示顺序  
            fileDlg.FilterIndex = 1;
            // 设置对话框是否记忆之前打开的目录  
            fileDlg.RestoreDirectory = true;
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
              
                String fliename = fileDlg.SafeFileName;
                String Ap = Application.StartupPath;
                System.Diagnostics.Process.Start("notepad.exe",Application.StartupPath+"\\数据\\"+fliename);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            help f1 = new help();
            f1.Show();
        }

        private void 关于ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            about a1 = new about();
            a1.Show();
        }
    }
}
