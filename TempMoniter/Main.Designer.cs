namespace TempMoniter
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ObjPort = new System.IO.Ports.SerialPort(this.components);
            this.btn_Switch = new System.Windows.Forms.Button();
            this.btn_Engage = new System.Windows.Forms.Button();
            this.TimerCollect = new System.Windows.Forms.Timer(this.components);
            this.listView_Temp = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Cycle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_PortName = new System.Windows.Forms.ComboBox();
            this.cmb_BaudRate = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Ct_Temp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ct_Temp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObjPort
            // 
            this.ObjPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ObjPort_DataReceived);
            // 
            // btn_Switch
            // 
            this.btn_Switch.Location = new System.Drawing.Point(5, 58);
            this.btn_Switch.Name = "btn_Switch";
            this.btn_Switch.Size = new System.Drawing.Size(108, 28);
            this.btn_Switch.TabIndex = 2;
            this.btn_Switch.Text = "连接";
            this.btn_Switch.UseVisualStyleBackColor = true;
            this.btn_Switch.Click += new System.EventHandler(this.btn_Switch_Click);
            // 
            // btn_Engage
            // 
            this.btn_Engage.Location = new System.Drawing.Point(14, 134);
            this.btn_Engage.Name = "btn_Engage";
            this.btn_Engage.Size = new System.Drawing.Size(108, 28);
            this.btn_Engage.TabIndex = 4;
            this.btn_Engage.Text = "开始采集";
            this.btn_Engage.UseVisualStyleBackColor = true;
            this.btn_Engage.Click += new System.EventHandler(this.btn_Engage_Click);
            // 
            // TimerCollect
            // 
            this.TimerCollect.Tick += new System.EventHandler(this.TimerCollect_Tick);
            // 
            // listView_Temp
            // 
            this.listView_Temp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_Temp.HideSelection = false;
            this.listView_Temp.Location = new System.Drawing.Point(170, 42);
            this.listView_Temp.Name = "listView_Temp";
            this.listView_Temp.Size = new System.Drawing.Size(742, 163);
            this.listView_Temp.TabIndex = 6;
            this.listView_Temp.UseCompatibleStateImageBehavior = false;
            this.listView_Temp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "采集时间";
            this.columnHeader0.Width = 125;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CH1";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CH2";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CH3";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CH4";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CH5";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CH6";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CH7";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CH8";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Cycle
            // 
            this.txt_Cycle.Location = new System.Drawing.Point(57, 108);
            this.txt_Cycle.Name = "txt_Cycle";
            this.txt_Cycle.Size = new System.Drawing.Size(50, 21);
            this.txt_Cycle.TabIndex = 7;
            this.txt_Cycle.Text = "1";
            this.txt_Cycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "周期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "秒";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率：";
            // 
            // cmb_PortName
            // 
            this.cmb_PortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PortName.FormattingEnabled = true;
            this.cmb_PortName.Location = new System.Drawing.Point(53, -1);
            this.cmb_PortName.Name = "cmb_PortName";
            this.cmb_PortName.Size = new System.Drawing.Size(60, 20);
            this.cmb_PortName.TabIndex = 1;
            // 
            // cmb_BaudRate
            // 
            this.cmb_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_BaudRate.FormattingEnabled = true;
            this.cmb_BaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cmb_BaudRate.Location = new System.Drawing.Point(53, 29);
            this.cmb_BaudRate.Name = "cmb_BaudRate";
            this.cmb_BaudRate.Size = new System.Drawing.Size(60, 20);
            this.cmb_BaudRate.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmb_BaudRate);
            this.panel2.Controls.Add(this.cmb_PortName);
            this.panel2.Controls.Add(this.btn_Switch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 86);
            this.panel2.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(932, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开数据ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开数据ToolStripMenuItem
            // 
            this.打开数据ToolStripMenuItem.Name = "打开数据ToolStripMenuItem";
            this.打开数据ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开数据ToolStripMenuItem.Text = "打开数据";
            this.打开数据ToolStripMenuItem.Click += new System.EventHandler(this.打开数据ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem1,
            this.关于ToolStripMenuItem2});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.关于ToolStripMenuItem1.Text = "使用说明";
            this.关于ToolStripMenuItem1.Click += new System.EventHandler(this.关于ToolStripMenuItem1_Click);
            // 
            // 关于ToolStripMenuItem2
            // 
            this.关于ToolStripMenuItem2.Name = "关于ToolStripMenuItem2";
            this.关于ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.关于ToolStripMenuItem2.Text = "关于";
            this.关于ToolStripMenuItem2.Click += new System.EventHandler(this.关于ToolStripMenuItem2_Click);
            // 
            // Ct_Temp
            // 
            this.Ct_Temp.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Ct_Temp.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.Ct_Temp.Legends.Add(legend1);
            this.Ct_Temp.Location = new System.Drawing.Point(0, 217);
            this.Ct_Temp.Margin = new System.Windows.Forms.Padding(2);
            this.Ct_Temp.Name = "Ct_Temp";
            this.Ct_Temp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "CH1";
            series1.Points.Add(dataPoint1);
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "CH2";
            series2.Points.Add(dataPoint2);
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "CH3";
            series3.Points.Add(dataPoint3);
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "CH4";
            series4.Points.Add(dataPoint4);
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "CH5";
            series5.Points.Add(dataPoint5);
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "CH6";
            series6.Points.Add(dataPoint6);
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "CH7";
            series7.Points.Add(dataPoint7);
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "CH8";
            series8.Points.Add(dataPoint8);
            this.Ct_Temp.Series.Add(series1);
            this.Ct_Temp.Series.Add(series2);
            this.Ct_Temp.Series.Add(series3);
            this.Ct_Temp.Series.Add(series4);
            this.Ct_Temp.Series.Add(series5);
            this.Ct_Temp.Series.Add(series6);
            this.Ct_Temp.Series.Add(series7);
            this.Ct_Temp.Series.Add(series8);
            this.Ct_Temp.Size = new System.Drawing.Size(942, 324);
            this.Ct_Temp.TabIndex = 5;
            this.Ct_Temp.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "温度时间曲线";
            this.Ct_Temp.Titles.Add(title1);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(17, 368);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(17, 74);
            this.label8.TabIndex = 14;
            this.label8.Text = "温度/℃";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(428, 578);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "时间/s";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Cycle);
            this.groupBox1.Controls.Add(this.btn_Engage);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(20, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(135, 172);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(455, 525);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "时间/s";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listView_Temp);
            this.Controls.Add(this.Ct_Temp);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "温度采集软件";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ct_Temp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort ObjPort;
        private System.Windows.Forms.Button btn_Switch;
        private System.Windows.Forms.Button btn_Engage;
        private System.Windows.Forms.Timer TimerCollect;
        private System.Windows.Forms.ListView listView_Temp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.TextBox txt_Cycle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_PortName;
        private System.Windows.Forms.ComboBox cmb_BaudRate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Ct_Temp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}

