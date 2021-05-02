
namespace Arbeidskrav04
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.panelDockLeft = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLiveData = new System.Windows.Forms.Button();
            this.buttonKonfigurasjon = new System.Windows.Forms.Button();
            this.buttonOppkobling = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLiveData = new System.Windows.Forms.Panel();
            this.buttonDataSaveScaled = new System.Windows.Forms.Button();
            this.buttonDataSave = new System.Windows.Forms.Button();
            this.pictureBoxFValue = new System.Windows.Forms.PictureBox();
            this.buttonSaveChartScaled = new System.Windows.Forms.Button();
            this.labelRawData = new System.Windows.Forms.Label();
            this.labelScaledData = new System.Windows.Forms.Label();
            this.labelFaultyValue = new System.Windows.Forms.Label();
            this.chartVbaRaw = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxDataInRaw = new System.Windows.Forms.ListBox();
            this.listBoxDatain = new System.Windows.Forms.ListBox();
            this.buttonSaveChart = new System.Windows.Forms.Button();
            this.buttonStopLoad = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBoxRaw = new System.Windows.Forms.CheckBox();
            this.checkBoxScaled = new System.Windows.Forms.CheckBox();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.chartVba = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelconnected = new System.Windows.Forms.Label();
            this.labelOffline = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogSettings = new System.Windows.Forms.OpenFileDialog();
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.timerSerialReceive = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.saveFileDialogChart = new System.Windows.Forms.SaveFileDialog();
            this.timerScaledValue = new System.Windows.Forms.Timer(this.components);
            this.timerChartScaled = new System.Windows.Forms.Timer(this.components);
            this.timerCountScaled = new System.Windows.Forms.Timer(this.components);
            this.labelStatusOk = new System.Windows.Forms.Label();
            this.labelFail = new System.Windows.Forms.Label();
            this.labelAlarml = new System.Windows.Forms.Label();
            this.labelAlarmh = new System.Windows.Forms.Label();
            this.saveFileDialogRawData = new System.Windows.Forms.SaveFileDialog();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelKonfigurasjon = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.buttonConfirmPassword = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelNewSettings = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonReadCurrent = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.buttonReadConfig = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNewLrv = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNewLowAlarm = new System.Windows.Forms.TextBox();
            this.textBoxNewHighAlarm = new System.Windows.Forms.TextBox();
            this.textBoxNewUrv = new System.Windows.Forms.TextBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.textBoxReturn = new System.Windows.Forms.TextBox();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConfirmConfig = new System.Windows.Forms.Button();
            this.pictureBoxConnected = new System.Windows.Forms.PictureBox();
            this.pictureBoxNotConnected = new System.Windows.Forms.PictureBox();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.comboBoxRDC = new System.Windows.Forms.ComboBox();
            this.labelRDC = new System.Windows.Forms.Label();
            this.textBoxDeviceName = new System.Windows.Forms.TextBox();
            this.labelRDCNAME = new System.Windows.Forms.Label();
            this.comboBoxDAU_Info = new System.Windows.Forms.ComboBox();
            this.labelDAU = new System.Windows.Forms.Label();
            this.textBoxDAU_Description = new System.Windows.Forms.TextBox();
            this.textBoxDAU_Comport = new System.Windows.Forms.TextBox();
            this.textBoxDAU_Baudrate = new System.Windows.Forms.TextBox();
            this.labelDAU_Description = new System.Windows.Forms.Label();
            this.panelOppkobling = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.textBoxReadToDB = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBoxReturn1 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.buttonSendToDB = new System.Windows.Forms.Button();
            this.buttonReadOnce = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.buttonTransferDAU = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelLRV = new System.Windows.Forms.Label();
            this.textBoxIN_SCANFREQ = new System.Windows.Forms.TextBox();
            this.textBoxIN_IOTYPE = new System.Windows.Forms.TextBox();
            this.textBoxIN_TAGNAME = new System.Windows.Forms.TextBox();
            this.textBoxIN_AHIGH = new System.Windows.Forms.TextBox();
            this.textBoxIN_URV = new System.Windows.Forms.TextBox();
            this.textBoxIN_ALOW = new System.Windows.Forms.TextBox();
            this.textBoxIN_LRV = new System.Windows.Forms.TextBox();
            this.labelTAG_ID = new System.Windows.Forms.Label();
            this.comboBoxTAG_ID = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDAU = new System.Windows.Forms.Panel();
            this.labelDAU_Baudrate = new System.Windows.Forms.Label();
            this.labelDAU_Comport = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.panelDockLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLiveData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVbaRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVba)).BeginInit();
            this.panelKonfigurasjon.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panelNewSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotConnected)).BeginInit();
            this.panelOppkobling.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDAU.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // panelDockLeft
            // 
            this.panelDockLeft.Controls.Add(this.buttonAbout);
            this.panelDockLeft.Controls.Add(this.buttonExit);
            this.panelDockLeft.Controls.Add(this.buttonLiveData);
            this.panelDockLeft.Controls.Add(this.buttonKonfigurasjon);
            this.panelDockLeft.Controls.Add(this.buttonOppkobling);
            this.panelDockLeft.Controls.Add(this.panel2);
            this.panelDockLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDockLeft.Location = new System.Drawing.Point(0, 0);
            this.panelDockLeft.Name = "panelDockLeft";
            this.panelDockLeft.Size = new System.Drawing.Size(181, 874);
            this.panelDockLeft.TabIndex = 0;
            // 
            // buttonAbout
            // 
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.Location = new System.Drawing.Point(0, 326);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(181, 79);
            this.buttonAbout.TabIndex = 6;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(0, 466);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(181, 79);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "  Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLiveData
            // 
            this.buttonLiveData.FlatAppearance.BorderSize = 0;
            this.buttonLiveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLiveData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLiveData.ForeColor = System.Drawing.Color.White;
            this.buttonLiveData.Image = ((System.Drawing.Image)(resources.GetObject("buttonLiveData.Image")));
            this.buttonLiveData.Location = new System.Drawing.Point(0, 229);
            this.buttonLiveData.Name = "buttonLiveData";
            this.buttonLiveData.Size = new System.Drawing.Size(181, 79);
            this.buttonLiveData.TabIndex = 4;
            this.buttonLiveData.Text = "Live Data";
            this.buttonLiveData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLiveData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLiveData.UseVisualStyleBackColor = true;
            this.buttonLiveData.Visible = false;
            this.buttonLiveData.Click += new System.EventHandler(this.buttonLiveData_Click);
            // 
            // buttonKonfigurasjon
            // 
            this.buttonKonfigurasjon.FlatAppearance.BorderSize = 0;
            this.buttonKonfigurasjon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKonfigurasjon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKonfigurasjon.ForeColor = System.Drawing.Color.White;
            this.buttonKonfigurasjon.Image = ((System.Drawing.Image)(resources.GetObject("buttonKonfigurasjon.Image")));
            this.buttonKonfigurasjon.Location = new System.Drawing.Point(0, 144);
            this.buttonKonfigurasjon.Name = "buttonKonfigurasjon";
            this.buttonKonfigurasjon.Size = new System.Drawing.Size(181, 79);
            this.buttonKonfigurasjon.TabIndex = 3;
            this.buttonKonfigurasjon.Text = "Configuration";
            this.buttonKonfigurasjon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKonfigurasjon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonKonfigurasjon.UseVisualStyleBackColor = true;
            this.buttonKonfigurasjon.Click += new System.EventHandler(this.buttonKonfigurasjon_Click);
            // 
            // buttonOppkobling
            // 
            this.buttonOppkobling.FlatAppearance.BorderSize = 0;
            this.buttonOppkobling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOppkobling.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOppkobling.ForeColor = System.Drawing.Color.White;
            this.buttonOppkobling.Image = ((System.Drawing.Image)(resources.GetObject("buttonOppkobling.Image")));
            this.buttonOppkobling.Location = new System.Drawing.Point(0, 72);
            this.buttonOppkobling.Name = "buttonOppkobling";
            this.buttonOppkobling.Size = new System.Drawing.Size(181, 79);
            this.buttonOppkobling.TabIndex = 2;
            this.buttonOppkobling.Text = "Connection";
            this.buttonOppkobling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOppkobling.UseVisualStyleBackColor = true;
            this.buttonOppkobling.Click += new System.EventHandler(this.buttonOppkobling_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 75);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SoftSenseConf";
            // 
            // panelLiveData
            // 
            this.panelLiveData.Controls.Add(this.buttonDataSaveScaled);
            this.panelLiveData.Controls.Add(this.buttonDataSave);
            this.panelLiveData.Controls.Add(this.pictureBoxFValue);
            this.panelLiveData.Controls.Add(this.buttonSaveChartScaled);
            this.panelLiveData.Controls.Add(this.labelRawData);
            this.panelLiveData.Controls.Add(this.labelScaledData);
            this.panelLiveData.Controls.Add(this.labelFaultyValue);
            this.panelLiveData.Controls.Add(this.chartVbaRaw);
            this.panelLiveData.Controls.Add(this.listBoxDataInRaw);
            this.panelLiveData.Controls.Add(this.listBoxDatain);
            this.panelLiveData.Controls.Add(this.buttonSaveChart);
            this.panelLiveData.Controls.Add(this.buttonStopLoad);
            this.panelLiveData.Controls.Add(this.label20);
            this.panelLiveData.Controls.Add(this.checkBoxRaw);
            this.panelLiveData.Controls.Add(this.checkBoxScaled);
            this.panelLiveData.Controls.Add(this.buttonLoadData);
            this.panelLiveData.Controls.Add(this.chartVba);
            this.panelLiveData.Controls.Add(this.label3);
            this.panelLiveData.Location = new System.Drawing.Point(203, 0);
            this.panelLiveData.Name = "panelLiveData";
            this.panelLiveData.Size = new System.Drawing.Size(855, 534);
            this.panelLiveData.TabIndex = 3;
            // 
            // buttonDataSaveScaled
            // 
            this.buttonDataSaveScaled.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonDataSaveScaled.ForeColor = System.Drawing.Color.Black;
            this.buttonDataSaveScaled.Location = new System.Drawing.Point(173, 287);
            this.buttonDataSaveScaled.Name = "buttonDataSaveScaled";
            this.buttonDataSaveScaled.Size = new System.Drawing.Size(99, 28);
            this.buttonDataSaveScaled.TabIndex = 28;
            this.buttonDataSaveScaled.Text = "Save data";
            this.buttonDataSaveScaled.UseVisualStyleBackColor = true;
            this.buttonDataSaveScaled.Visible = false;
            this.buttonDataSaveScaled.Click += new System.EventHandler(this.buttonDataSaveScaled_Click);
            // 
            // buttonDataSave
            // 
            this.buttonDataSave.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonDataSave.ForeColor = System.Drawing.Color.Black;
            this.buttonDataSave.Location = new System.Drawing.Point(173, 287);
            this.buttonDataSave.Name = "buttonDataSave";
            this.buttonDataSave.Size = new System.Drawing.Size(99, 28);
            this.buttonDataSave.TabIndex = 27;
            this.buttonDataSave.Text = "Save data";
            this.buttonDataSave.UseVisualStyleBackColor = true;
            this.buttonDataSave.Visible = false;
            this.buttonDataSave.Click += new System.EventHandler(this.buttonDataSave_Click);
            // 
            // pictureBoxFValue
            // 
            this.pictureBoxFValue.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFValue.Image")));
            this.pictureBoxFValue.Location = new System.Drawing.Point(295, 447);
            this.pictureBoxFValue.Name = "pictureBoxFValue";
            this.pictureBoxFValue.Size = new System.Drawing.Size(31, 33);
            this.pictureBoxFValue.TabIndex = 26;
            this.pictureBoxFValue.TabStop = false;
            this.pictureBoxFValue.Visible = false;
            // 
            // buttonSaveChartScaled
            // 
            this.buttonSaveChartScaled.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonSaveChartScaled.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveChartScaled.Location = new System.Drawing.Point(349, 351);
            this.buttonSaveChartScaled.Name = "buttonSaveChartScaled";
            this.buttonSaveChartScaled.Size = new System.Drawing.Size(106, 28);
            this.buttonSaveChartScaled.TabIndex = 25;
            this.buttonSaveChartScaled.Text = "Save chart";
            this.buttonSaveChartScaled.UseVisualStyleBackColor = true;
            this.buttonSaveChartScaled.Visible = false;
            this.buttonSaveChartScaled.Click += new System.EventHandler(this.buttonSaveChartScaled_Click);
            // 
            // labelRawData
            // 
            this.labelRawData.AutoSize = true;
            this.labelRawData.ForeColor = System.Drawing.Color.Silver;
            this.labelRawData.Location = new System.Drawing.Point(345, 65);
            this.labelRawData.Name = "labelRawData";
            this.labelRawData.Size = new System.Drawing.Size(93, 21);
            this.labelRawData.TabIndex = 23;
            this.labelRawData.Text = "Raw data:";
            this.labelRawData.Visible = false;
            // 
            // labelScaledData
            // 
            this.labelScaledData.AutoSize = true;
            this.labelScaledData.ForeColor = System.Drawing.Color.Silver;
            this.labelScaledData.Location = new System.Drawing.Point(345, 65);
            this.labelScaledData.Name = "labelScaledData";
            this.labelScaledData.Size = new System.Drawing.Size(111, 21);
            this.labelScaledData.TabIndex = 22;
            this.labelScaledData.Text = "Scaled data:";
            this.labelScaledData.Visible = false;
            // 
            // labelFaultyValue
            // 
            this.labelFaultyValue.AutoSize = true;
            this.labelFaultyValue.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelFaultyValue.ForeColor = System.Drawing.Color.White;
            this.labelFaultyValue.Location = new System.Drawing.Point(346, 454);
            this.labelFaultyValue.Name = "labelFaultyValue";
            this.labelFaultyValue.Size = new System.Drawing.Size(99, 19);
            this.labelFaultyValue.TabIndex = 24;
            this.labelFaultyValue.Text = "Faulty Value!";
            this.labelFaultyValue.Visible = false;
            // 
            // chartVbaRaw
            // 
            this.chartVbaRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.chartVbaRaw.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.Title = "Light";
            chartArea1.Name = "ChartArea1";
            this.chartVbaRaw.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.Title = "Raw data";
            legend1.TitleForeColor = System.Drawing.Color.White;
            this.chartVbaRaw.Legends.Add(legend1);
            this.chartVbaRaw.Location = new System.Drawing.Point(288, 87);
            this.chartVbaRaw.Name = "chartVbaRaw";
            this.chartVbaRaw.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Crimson;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.Transparent;
            series1.Name = "vAB";
            series1.ShadowColor = System.Drawing.Color.Gray;
            this.chartVbaRaw.Series.Add(series1);
            this.chartVbaRaw.Size = new System.Drawing.Size(526, 258);
            this.chartVbaRaw.TabIndex = 21;
            this.chartVbaRaw.Text = "chart1";
            this.chartVbaRaw.Visible = false;
            // 
            // listBoxDataInRaw
            // 
            this.listBoxDataInRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.listBoxDataInRaw.ForeColor = System.Drawing.Color.White;
            this.listBoxDataInRaw.FormattingEnabled = true;
            this.listBoxDataInRaw.ItemHeight = 21;
            this.listBoxDataInRaw.Location = new System.Drawing.Point(17, 170);
            this.listBoxDataInRaw.Name = "listBoxDataInRaw";
            this.listBoxDataInRaw.ScrollAlwaysVisible = true;
            this.listBoxDataInRaw.Size = new System.Drawing.Size(255, 109);
            this.listBoxDataInRaw.TabIndex = 20;
            // 
            // listBoxDatain
            // 
            this.listBoxDatain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.listBoxDatain.ForeColor = System.Drawing.Color.White;
            this.listBoxDatain.FormattingEnabled = true;
            this.listBoxDatain.ItemHeight = 21;
            this.listBoxDatain.Location = new System.Drawing.Point(17, 170);
            this.listBoxDatain.Name = "listBoxDatain";
            this.listBoxDatain.ScrollAlwaysVisible = true;
            this.listBoxDatain.Size = new System.Drawing.Size(255, 109);
            this.listBoxDatain.TabIndex = 19;
            // 
            // buttonSaveChart
            // 
            this.buttonSaveChart.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonSaveChart.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveChart.Location = new System.Drawing.Point(349, 351);
            this.buttonSaveChart.Name = "buttonSaveChart";
            this.buttonSaveChart.Size = new System.Drawing.Size(106, 28);
            this.buttonSaveChart.TabIndex = 18;
            this.buttonSaveChart.Text = "Save chart";
            this.buttonSaveChart.UseVisualStyleBackColor = true;
            this.buttonSaveChart.Visible = false;
            this.buttonSaveChart.Click += new System.EventHandler(this.buttonSaveChart_Click);
            // 
            // buttonStopLoad
            // 
            this.buttonStopLoad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopLoad.ForeColor = System.Drawing.Color.Red;
            this.buttonStopLoad.Location = new System.Drawing.Point(17, 287);
            this.buttonStopLoad.Name = "buttonStopLoad";
            this.buttonStopLoad.Size = new System.Drawing.Size(99, 28);
            this.buttonStopLoad.TabIndex = 17;
            this.buttonStopLoad.Text = "Stop loading";
            this.buttonStopLoad.UseVisualStyleBackColor = true;
            this.buttonStopLoad.Visible = false;
            this.buttonStopLoad.Click += new System.EventHandler(this.buttonStopLoad_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label20.Location = new System.Drawing.Point(18, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 19);
            this.label20.TabIndex = 16;
            this.label20.Text = "Datatype:";
            // 
            // checkBoxRaw
            // 
            this.checkBoxRaw.AutoSize = true;
            this.checkBoxRaw.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBoxRaw.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxRaw.Location = new System.Drawing.Point(147, 87);
            this.checkBoxRaw.Name = "checkBoxRaw";
            this.checkBoxRaw.Size = new System.Drawing.Size(101, 23);
            this.checkBoxRaw.TabIndex = 15;
            this.checkBoxRaw.Text = "Read Raw";
            this.checkBoxRaw.UseVisualStyleBackColor = true;
            this.checkBoxRaw.CheckedChanged += new System.EventHandler(this.checkBoxRaw_CheckedChanged);
            // 
            // checkBoxScaled
            // 
            this.checkBoxScaled.AutoSize = true;
            this.checkBoxScaled.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBoxScaled.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxScaled.Location = new System.Drawing.Point(23, 87);
            this.checkBoxScaled.Name = "checkBoxScaled";
            this.checkBoxScaled.Size = new System.Drawing.Size(118, 23);
            this.checkBoxScaled.TabIndex = 14;
            this.checkBoxScaled.Text = "Read Scaled";
            this.checkBoxScaled.UseVisualStyleBackColor = true;
            this.checkBoxScaled.CheckedChanged += new System.EventHandler(this.checkBoxScaled_CheckedChanged);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonLoadData.ForeColor = System.Drawing.Color.Black;
            this.buttonLoadData.Location = new System.Drawing.Point(17, 120);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(99, 28);
            this.buttonLoadData.TabIndex = 13;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // chartVba
            // 
            this.chartVba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.chartVba.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisY.Title = "Light";
            chartArea2.Name = "ChartArea1";
            this.chartVba.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            legend2.Title = "Scaled data";
            legend2.TitleBackColor = System.Drawing.Color.Transparent;
            legend2.TitleForeColor = System.Drawing.Color.White;
            this.chartVba.Legends.Add(legend2);
            this.chartVba.Location = new System.Drawing.Point(288, 87);
            this.chartVba.Name = "chartVba";
            this.chartVba.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.BorderColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.Name = "vAB";
            series2.ShadowColor = System.Drawing.Color.Gray;
            this.chartVba.Series.Add(series2);
            this.chartVba.Size = new System.Drawing.Size(526, 258);
            this.chartVba.TabIndex = 12;
            this.chartVba.Text = "chart1";
            this.chartVba.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(24, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "Live Data";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxStatus.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxStatus.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxStatus.Location = new System.Drawing.Point(994, 554);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(14, 24);
            this.textBoxStatus.TabIndex = 16;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightGray;
            this.panelLeft.Location = new System.Drawing.Point(187, 72);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 79);
            this.panelLeft.TabIndex = 1;
            // 
            // labelconnected
            // 
            this.labelconnected.AutoSize = true;
            this.labelconnected.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelconnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelconnected.Location = new System.Drawing.Point(237, 557);
            this.labelconnected.Name = "labelconnected";
            this.labelconnected.Size = new System.Drawing.Size(89, 19);
            this.labelconnected.TabIndex = 2;
            this.labelconnected.Text = "Connected";
            // 
            // labelOffline
            // 
            this.labelOffline.AutoSize = true;
            this.labelOffline.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelOffline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOffline.Location = new System.Drawing.Point(240, 557);
            this.labelOffline.Name = "labelOffline";
            this.labelOffline.Size = new System.Drawing.Size(53, 19);
            this.labelOffline.TabIndex = 3;
            this.labelOffline.Text = "Offline";
            this.labelOffline.Click += new System.EventHandler(this.labelOffline_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkGray;
            this.label19.Location = new System.Drawing.Point(184, 557);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 17);
            this.label19.TabIndex = 5;
            this.label19.Text = "Status:";
            // 
            // openFileDialogSettings
            // 
            this.openFileDialogSettings.FileName = "openFileDialog1";
            // 
            // timerChartAdd
            // 
            this.timerChartAdd.Interval = 1000;
            this.timerChartAdd.Tick += new System.EventHandler(this.timerChartAdd_Tick);
            // 
            // timerSerialReceive
            // 
            this.timerSerialReceive.Interval = 1000;
            this.timerSerialReceive.Tick += new System.EventHandler(this.timerSerialReceive_Tick);
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 1000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label22.ForeColor = System.Drawing.Color.Silver;
            this.label22.Location = new System.Drawing.Point(883, 554);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 19);
            this.label22.TabIndex = 17;
            this.label22.Text = "Process status:";
            // 
            // saveFileDialogChart
            // 
            this.saveFileDialogChart.SupportMultiDottedExtensions = true;
            // 
            // timerScaledValue
            // 
            this.timerScaledValue.Interval = 1000;
            this.timerScaledValue.Tick += new System.EventHandler(this.timerScaledValue_Tick);
            // 
            // timerChartScaled
            // 
            this.timerChartScaled.Interval = 1000;
            this.timerChartScaled.Tick += new System.EventHandler(this.timerChartScaled_Tick);
            // 
            // timerCountScaled
            // 
            this.timerCountScaled.Interval = 1000;
            this.timerCountScaled.Tick += new System.EventHandler(this.timerCountScaled_Tick);
            // 
            // labelStatusOk
            // 
            this.labelStatusOk.AutoSize = true;
            this.labelStatusOk.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelStatusOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelStatusOk.Location = new System.Drawing.Point(1012, 554);
            this.labelStatusOk.Name = "labelStatusOk";
            this.labelStatusOk.Size = new System.Drawing.Size(29, 19);
            this.labelStatusOk.TabIndex = 18;
            this.labelStatusOk.Text = "OK";
            this.labelStatusOk.Visible = false;
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelFail.ForeColor = System.Drawing.Color.White;
            this.labelFail.Location = new System.Drawing.Point(1016, 555);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(34, 19);
            this.labelFail.TabIndex = 19;
            this.labelFail.Text = "FAIL";
            this.labelFail.Visible = false;
            // 
            // labelAlarml
            // 
            this.labelAlarml.AutoSize = true;
            this.labelAlarml.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelAlarml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelAlarml.Location = new System.Drawing.Point(1016, 555);
            this.labelAlarml.Name = "labelAlarml";
            this.labelAlarml.Size = new System.Drawing.Size(92, 19);
            this.labelAlarml.TabIndex = 27;
            this.labelAlarml.Text = "LOW ALARM";
            this.labelAlarml.Visible = false;
            // 
            // labelAlarmh
            // 
            this.labelAlarmh.AutoSize = true;
            this.labelAlarmh.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelAlarmh.ForeColor = System.Drawing.Color.Red;
            this.labelAlarmh.Location = new System.Drawing.Point(1014, 554);
            this.labelAlarmh.Name = "labelAlarmh";
            this.labelAlarmh.Size = new System.Drawing.Size(94, 19);
            this.labelAlarmh.TabIndex = 28;
            this.labelAlarmh.Text = "HIGH ALARM";
            this.labelAlarmh.Visible = false;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.comboBoxPorts.ForeColor = System.Drawing.Color.White;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(848, 57);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 29);
            this.comboBoxPorts.TabIndex = 0;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            this.comboBoxPorts.Enter += new System.EventHandler(this.comboBoxPorts_Enter);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.comboBoxBaud.ForeColor = System.Drawing.Color.White;
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBoxBaud.Location = new System.Drawing.Point(980, 57);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 29);
            this.comboBoxBaud.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonConnect.ForeColor = System.Drawing.Color.Black;
            this.buttonConnect.Location = new System.Drawing.Point(848, 92);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(183, 36);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.ForeColor = System.Drawing.Color.Black;
            this.buttonDisconnect.Location = new System.Drawing.Point(848, 133);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(183, 37);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(24, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Connect to Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(845, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "COM ports";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(976, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "BAUD Rate";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelKonfigurasjon
            // 
            this.panelKonfigurasjon.Controls.Add(this.panelPassword);
            this.panelKonfigurasjon.Controls.Add(this.panelNewSettings);
            this.panelKonfigurasjon.Controls.Add(this.textBoxReturn);
            this.panelKonfigurasjon.Controls.Add(this.buttonSendCommand);
            this.panelKonfigurasjon.Controls.Add(this.label11);
            this.panelKonfigurasjon.Controls.Add(this.label10);
            this.panelKonfigurasjon.Controls.Add(this.textBoxCommand);
            this.panelKonfigurasjon.Controls.Add(this.label4);
            this.panelKonfigurasjon.Location = new System.Drawing.Point(1614, 554);
            this.panelKonfigurasjon.Name = "panelKonfigurasjon";
            this.panelKonfigurasjon.Size = new System.Drawing.Size(868, 539);
            this.panelKonfigurasjon.TabIndex = 4;
            this.panelKonfigurasjon.Visible = false;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.buttonConfirmPassword);
            this.panelPassword.Controls.Add(this.label18);
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Location = new System.Drawing.Point(14, 122);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(305, 76);
            this.panelPassword.TabIndex = 14;
            this.panelPassword.Visible = false;
            // 
            // buttonConfirmPassword
            // 
            this.buttonConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirmPassword.Location = new System.Drawing.Point(194, 35);
            this.buttonConfirmPassword.Name = "buttonConfirmPassword";
            this.buttonConfirmPassword.Size = new System.Drawing.Size(69, 23);
            this.buttonConfirmPassword.TabIndex = 16;
            this.buttonConfirmPassword.Text = "Confirm";
            this.buttonConfirmPassword.UseVisualStyleBackColor = true;
            this.buttonConfirmPassword.Click += new System.EventHandler(this.buttonConfirmPassword_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(15, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(14, 34);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(166, 27);
            this.textBoxPassword.TabIndex = 14;
            // 
            // panelNewSettings
            // 
            this.panelNewSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNewSettings.Controls.Add(this.label8);
            this.panelNewSettings.Controls.Add(this.label7);
            this.panelNewSettings.Controls.Add(this.label21);
            this.panelNewSettings.Controls.Add(this.buttonReadCurrent);
            this.panelNewSettings.Controls.Add(this.label17);
            this.panelNewSettings.Controls.Add(this.buttonSaveConfig);
            this.panelNewSettings.Controls.Add(this.buttonReadConfig);
            this.panelNewSettings.Controls.Add(this.label16);
            this.panelNewSettings.Controls.Add(this.label15);
            this.panelNewSettings.Controls.Add(this.label14);
            this.panelNewSettings.Controls.Add(this.textBoxNewLrv);
            this.panelNewSettings.Controls.Add(this.label13);
            this.panelNewSettings.Controls.Add(this.label12);
            this.panelNewSettings.Controls.Add(this.textBoxNewLowAlarm);
            this.panelNewSettings.Controls.Add(this.textBoxNewHighAlarm);
            this.panelNewSettings.Controls.Add(this.textBoxNewUrv);
            this.panelNewSettings.Controls.Add(this.textBoxNewName);
            this.panelNewSettings.Location = new System.Drawing.Point(376, 60);
            this.panelNewSettings.Name = "panelNewSettings";
            this.panelNewSettings.Size = new System.Drawing.Size(440, 456);
            this.panelNewSettings.TabIndex = 10;
            this.panelNewSettings.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Save configuration to file";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Load configuration from file";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(18, 305);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(196, 19);
            this.label21.TabIndex = 38;
            this.label21.Text = "Read current configuration";
            // 
            // buttonReadCurrent
            // 
            this.buttonReadCurrent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadCurrent.ForeColor = System.Drawing.Color.Black;
            this.buttonReadCurrent.Location = new System.Drawing.Point(258, 302);
            this.buttonReadCurrent.Name = "buttonReadCurrent";
            this.buttonReadCurrent.Size = new System.Drawing.Size(86, 23);
            this.buttonReadCurrent.TabIndex = 37;
            this.buttonReadCurrent.Text = "Read";
            this.buttonReadCurrent.UseVisualStyleBackColor = true;
            this.buttonReadCurrent.Click += new System.EventHandler(this.buttonReadCurrent_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(18, 331);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 19);
            this.label17.TabIndex = 36;
            this.label17.Text = "Set new configuration";
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveConfig.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveConfig.Location = new System.Drawing.Point(258, 411);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(86, 23);
            this.buttonSaveConfig.TabIndex = 8;
            this.buttonSaveConfig.Text = "Save";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // buttonReadConfig
            // 
            this.buttonReadConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadConfig.ForeColor = System.Drawing.Color.Black;
            this.buttonReadConfig.Location = new System.Drawing.Point(258, 382);
            this.buttonReadConfig.Name = "buttonReadConfig";
            this.buttonReadConfig.Size = new System.Drawing.Size(86, 23);
            this.buttonReadConfig.TabIndex = 7;
            this.buttonReadConfig.Text = "Load";
            this.buttonReadConfig.UseVisualStyleBackColor = true;
            this.buttonReadConfig.Click += new System.EventHandler(this.buttonReadConfig_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(19, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "High alarm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(19, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Low alarm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(19, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Upper range value";
            // 
            // textBoxNewLrv
            // 
            this.textBoxNewLrv.Location = new System.Drawing.Point(176, 77);
            this.textBoxNewLrv.Name = "textBoxNewLrv";
            this.textBoxNewLrv.Size = new System.Drawing.Size(168, 27);
            this.textBoxNewLrv.TabIndex = 31;
            this.textBoxNewLrv.TextChanged += new System.EventHandler(this.textBoxNewLrv_TextChanged);
            this.textBoxNewLrv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewLrv_KeyPress);
            this.textBoxNewLrv.MouseHover += new System.EventHandler(this.textBoxNewLrv_MouseHover);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(19, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Lower range value";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(19, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Name";
            // 
            // textBoxNewLowAlarm
            // 
            this.textBoxNewLowAlarm.Location = new System.Drawing.Point(176, 172);
            this.textBoxNewLowAlarm.Name = "textBoxNewLowAlarm";
            this.textBoxNewLowAlarm.Size = new System.Drawing.Size(168, 27);
            this.textBoxNewLowAlarm.TabIndex = 28;
            this.textBoxNewLowAlarm.TextChanged += new System.EventHandler(this.textBoxNewLowAlarm_TextChanged);
            this.textBoxNewLowAlarm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewLowAlarm_KeyPress);
            this.textBoxNewLowAlarm.MouseHover += new System.EventHandler(this.textBoxNewLowAlarm_MouseHover);
            // 
            // textBoxNewHighAlarm
            // 
            this.textBoxNewHighAlarm.Location = new System.Drawing.Point(176, 216);
            this.textBoxNewHighAlarm.Name = "textBoxNewHighAlarm";
            this.textBoxNewHighAlarm.Size = new System.Drawing.Size(168, 27);
            this.textBoxNewHighAlarm.TabIndex = 27;
            this.textBoxNewHighAlarm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewHighAlarm_KeyPress);
            this.textBoxNewHighAlarm.MouseHover += new System.EventHandler(this.textBoxNewHighAlarm_MouseHover);
            // 
            // textBoxNewUrv
            // 
            this.textBoxNewUrv.Location = new System.Drawing.Point(176, 125);
            this.textBoxNewUrv.Name = "textBoxNewUrv";
            this.textBoxNewUrv.Size = new System.Drawing.Size(168, 27);
            this.textBoxNewUrv.TabIndex = 26;
            this.textBoxNewUrv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewUrv_KeyPress);
            this.textBoxNewUrv.MouseHover += new System.EventHandler(this.textBoxNewUrv_MouseHover);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(176, 35);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(168, 27);
            this.textBoxNewName.TabIndex = 25;
            // 
            // textBoxReturn
            // 
            this.textBoxReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReturn.ForeColor = System.Drawing.Color.White;
            this.textBoxReturn.Location = new System.Drawing.Point(25, 226);
            this.textBoxReturn.Multiline = true;
            this.textBoxReturn.Name = "textBoxReturn";
            this.textBoxReturn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReturn.Size = new System.Drawing.Size(275, 187);
            this.textBoxReturn.TabIndex = 9;
            this.textBoxReturn.TextChanged += new System.EventHandler(this.textBoxReturn_TextChanged);
            // 
            // buttonSendCommand
            // 
            this.buttonSendCommand.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendCommand.ForeColor = System.Drawing.Color.Black;
            this.buttonSendCommand.Location = new System.Drawing.Point(204, 86);
            this.buttonSendCommand.Name = "buttonSendCommand";
            this.buttonSendCommand.Size = new System.Drawing.Size(69, 23);
            this.buttonSendCommand.TabIndex = 6;
            this.buttonSendCommand.Text = "Send";
            this.buttonSendCommand.UseVisualStyleBackColor = true;
            this.buttonSendCommand.Click += new System.EventHandler(this.buttonSendCommand_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Return:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Send command:";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCommand.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommand.ForeColor = System.Drawing.Color.White;
            this.textBoxCommand.Location = new System.Drawing.Point(25, 81);
            this.textBoxCommand.Multiline = true;
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(162, 35);
            this.textBoxCommand.TabIndex = 2;
            this.textBoxCommand.Enter += new System.EventHandler(this.textBoxCommand_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(20, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 44);
            this.label4.TabIndex = 1;
            this.label4.Text = "Configuration";
            // 
            // buttonConfirmConfig
            // 
            this.buttonConfirmConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmConfig.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirmConfig.Location = new System.Drawing.Point(627, 311);
            this.buttonConfirmConfig.Name = "buttonConfirmConfig";
            this.buttonConfirmConfig.Size = new System.Drawing.Size(121, 23);
            this.buttonConfirmConfig.TabIndex = 35;
            this.buttonConfirmConfig.Text = "Confirm";
            this.buttonConfirmConfig.UseVisualStyleBackColor = true;
            this.buttonConfirmConfig.Click += new System.EventHandler(this.buttonConfirmConfig_Click);
            // 
            // pictureBoxConnected
            // 
            this.pictureBoxConnected.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxConnected.Image")));
            this.pictureBoxConnected.Location = new System.Drawing.Point(1037, 94);
            this.pictureBoxConnected.Name = "pictureBoxConnected";
            this.pictureBoxConnected.Size = new System.Drawing.Size(64, 67);
            this.pictureBoxConnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConnected.TabIndex = 8;
            this.pictureBoxConnected.TabStop = false;
            // 
            // pictureBoxNotConnected
            // 
            this.pictureBoxNotConnected.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNotConnected.Image")));
            this.pictureBoxNotConnected.Location = new System.Drawing.Point(1037, 94);
            this.pictureBoxNotConnected.Name = "pictureBoxNotConnected";
            this.pictureBoxNotConnected.Size = new System.Drawing.Size(64, 67);
            this.pictureBoxNotConnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNotConnected.TabIndex = 9;
            this.pictureBoxNotConnected.TabStop = false;
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxReceive.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReceive.ForeColor = System.Drawing.Color.White;
            this.textBoxReceive.Location = new System.Drawing.Point(848, 173);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.Size = new System.Drawing.Size(253, 54);
            this.textBoxReceive.TabIndex = 10;
            // 
            // comboBoxRDC
            // 
            this.comboBoxRDC.FormattingEnabled = true;
            this.comboBoxRDC.Location = new System.Drawing.Point(7, 73);
            this.comboBoxRDC.Name = "comboBoxRDC";
            this.comboBoxRDC.Size = new System.Drawing.Size(121, 29);
            this.comboBoxRDC.TabIndex = 11;
            this.comboBoxRDC.SelectedIndexChanged += new System.EventHandler(this.comboBoxRDC_SelectedIndexChanged);
            // 
            // labelRDC
            // 
            this.labelRDC.AutoSize = true;
            this.labelRDC.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelRDC.ForeColor = System.Drawing.Color.Silver;
            this.labelRDC.Location = new System.Drawing.Point(9, 49);
            this.labelRDC.Name = "labelRDC";
            this.labelRDC.Size = new System.Drawing.Size(95, 19);
            this.labelRDC.TabIndex = 12;
            this.labelRDC.Text = "Choose RDC";
            // 
            // textBoxDeviceName
            // 
            this.textBoxDeviceName.Location = new System.Drawing.Point(156, 75);
            this.textBoxDeviceName.Name = "textBoxDeviceName";
            this.textBoxDeviceName.Size = new System.Drawing.Size(131, 27);
            this.textBoxDeviceName.TabIndex = 13;
            // 
            // labelRDCNAME
            // 
            this.labelRDCNAME.AutoSize = true;
            this.labelRDCNAME.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelRDCNAME.ForeColor = System.Drawing.Color.Silver;
            this.labelRDCNAME.Location = new System.Drawing.Point(153, 49);
            this.labelRDCNAME.Name = "labelRDCNAME";
            this.labelRDCNAME.Size = new System.Drawing.Size(103, 19);
            this.labelRDCNAME.TabIndex = 14;
            this.labelRDCNAME.Text = "Device Name";
            // 
            // comboBoxDAU_Info
            // 
            this.comboBoxDAU_Info.FormattingEnabled = true;
            this.comboBoxDAU_Info.Location = new System.Drawing.Point(15, 81);
            this.comboBoxDAU_Info.Name = "comboBoxDAU_Info";
            this.comboBoxDAU_Info.Size = new System.Drawing.Size(121, 29);
            this.comboBoxDAU_Info.TabIndex = 15;
            this.comboBoxDAU_Info.SelectedIndexChanged += new System.EventHandler(this.comboBoxDAU_Info_SelectedIndexChanged);
            // 
            // labelDAU
            // 
            this.labelDAU.AutoSize = true;
            this.labelDAU.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelDAU.ForeColor = System.Drawing.Color.Silver;
            this.labelDAU.Location = new System.Drawing.Point(11, 57);
            this.labelDAU.Name = "labelDAU";
            this.labelDAU.Size = new System.Drawing.Size(37, 19);
            this.labelDAU.TabIndex = 16;
            this.labelDAU.Text = "DAU";
            // 
            // textBoxDAU_Description
            // 
            this.textBoxDAU_Description.Location = new System.Drawing.Point(16, 143);
            this.textBoxDAU_Description.Name = "textBoxDAU_Description";
            this.textBoxDAU_Description.Size = new System.Drawing.Size(121, 27);
            this.textBoxDAU_Description.TabIndex = 17;
            this.textBoxDAU_Description.TextChanged += new System.EventHandler(this.textBoxDAU_Description_TextChanged);
            // 
            // textBoxDAU_Comport
            // 
            this.textBoxDAU_Comport.Location = new System.Drawing.Point(161, 81);
            this.textBoxDAU_Comport.Name = "textBoxDAU_Comport";
            this.textBoxDAU_Comport.Size = new System.Drawing.Size(122, 27);
            this.textBoxDAU_Comport.TabIndex = 18;
            // 
            // textBoxDAU_Baudrate
            // 
            this.textBoxDAU_Baudrate.Location = new System.Drawing.Point(161, 143);
            this.textBoxDAU_Baudrate.Name = "textBoxDAU_Baudrate";
            this.textBoxDAU_Baudrate.Size = new System.Drawing.Size(122, 27);
            this.textBoxDAU_Baudrate.TabIndex = 19;
            // 
            // labelDAU_Description
            // 
            this.labelDAU_Description.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelDAU_Description.ForeColor = System.Drawing.Color.Silver;
            this.labelDAU_Description.Location = new System.Drawing.Point(11, 119);
            this.labelDAU_Description.Name = "labelDAU_Description";
            this.labelDAU_Description.Size = new System.Drawing.Size(123, 21);
            this.labelDAU_Description.TabIndex = 0;
            this.labelDAU_Description.Text = "Device Name";
            // 
            // panelOppkobling
            // 
            this.panelOppkobling.Controls.Add(this.label32);
            this.panelOppkobling.Controls.Add(this.textBoxReadToDB);
            this.panelOppkobling.Controls.Add(this.label31);
            this.panelOppkobling.Controls.Add(this.textBoxReturn1);
            this.panelOppkobling.Controls.Add(this.label30);
            this.panelOppkobling.Controls.Add(this.label29);
            this.panelOppkobling.Controls.Add(this.buttonSendToDB);
            this.panelOppkobling.Controls.Add(this.buttonReadOnce);
            this.panelOppkobling.Controls.Add(this.label28);
            this.panelOppkobling.Controls.Add(this.buttonTransferDAU);
            this.panelOppkobling.Controls.Add(this.buttonConfirmConfig);
            this.panelOppkobling.Controls.Add(this.panel3);
            this.panelOppkobling.Controls.Add(this.panel1);
            this.panelOppkobling.Controls.Add(this.panelDAU);
            this.panelOppkobling.Controls.Add(this.textBoxReceive);
            this.panelOppkobling.Controls.Add(this.pictureBoxNotConnected);
            this.panelOppkobling.Controls.Add(this.pictureBoxConnected);
            this.panelOppkobling.Controls.Add(this.panelKonfigurasjon);
            this.panelOppkobling.Controls.Add(this.label6);
            this.panelOppkobling.Controls.Add(this.label5);
            this.panelOppkobling.Controls.Add(this.label2);
            this.panelOppkobling.Controls.Add(this.buttonDisconnect);
            this.panelOppkobling.Controls.Add(this.buttonConnect);
            this.panelOppkobling.Controls.Add(this.comboBoxBaud);
            this.panelOppkobling.Controls.Add(this.comboBoxPorts);
            this.panelOppkobling.Location = new System.Drawing.Point(203, 0);
            this.panelOppkobling.Name = "panelOppkobling";
            this.panelOppkobling.Size = new System.Drawing.Size(1741, 874);
            this.panelOppkobling.TabIndex = 2;
            this.panelOppkobling.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOppkobling_Paint);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(355, 447);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(211, 19);
            this.label32.TabIndex = 39;
            this.label32.Text = "Value from current instrument";
            // 
            // textBoxReadToDB
            // 
            this.textBoxReadToDB.Location = new System.Drawing.Point(627, 441);
            this.textBoxReadToDB.Name = "textBoxReadToDB";
            this.textBoxReadToDB.Size = new System.Drawing.Size(121, 27);
            this.textBoxReadToDB.TabIndex = 38;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(355, 311);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(233, 19);
            this.label31.TabIndex = 37;
            this.label31.Text = "Choose instrument-configuration";
            // 
            // textBoxReturn1
            // 
            this.textBoxReturn1.Location = new System.Drawing.Point(352, 335);
            this.textBoxReturn1.Multiline = true;
            this.textBoxReturn1.Name = "textBoxReturn1";
            this.textBoxReturn1.Size = new System.Drawing.Size(396, 51);
            this.textBoxReturn1.TabIndex = 36;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(355, 510);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(178, 19);
            this.label30.TabIndex = 30;
            this.label30.Text = "Send value to Database";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(355, 397);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(156, 19);
            this.label29.TabIndex = 29;
            this.label29.Text = "Read from instrument";
            // 
            // buttonSendToDB
            // 
            this.buttonSendToDB.ForeColor = System.Drawing.Color.Black;
            this.buttonSendToDB.Location = new System.Drawing.Point(627, 501);
            this.buttonSendToDB.Name = "buttonSendToDB";
            this.buttonSendToDB.Size = new System.Drawing.Size(121, 30);
            this.buttonSendToDB.TabIndex = 28;
            this.buttonSendToDB.Text = "Send";
            this.buttonSendToDB.UseVisualStyleBackColor = true;
            this.buttonSendToDB.Click += new System.EventHandler(this.buttonSendToDB_Click);
            // 
            // buttonReadOnce
            // 
            this.buttonReadOnce.ForeColor = System.Drawing.Color.Black;
            this.buttonReadOnce.Location = new System.Drawing.Point(627, 388);
            this.buttonReadOnce.Name = "buttonReadOnce";
            this.buttonReadOnce.Size = new System.Drawing.Size(121, 30);
            this.buttonReadOnce.TabIndex = 27;
            this.buttonReadOnce.Text = "Read Once";
            this.buttonReadOnce.UseVisualStyleBackColor = true;
            this.buttonReadOnce.Click += new System.EventHandler(this.buttonReadOnce_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Silver;
            this.label28.Location = new System.Drawing.Point(697, 85);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 42);
            this.label28.TabIndex = 26;
            this.label28.Text = "Send \r\nConfig";
            // 
            // buttonTransferDAU
            // 
            this.buttonTransferDAU.Image = ((System.Drawing.Image)(resources.GetObject("buttonTransferDAU.Image")));
            this.buttonTransferDAU.Location = new System.Drawing.Point(701, 130);
            this.buttonTransferDAU.Name = "buttonTransferDAU";
            this.buttonTransferDAU.Size = new System.Drawing.Size(58, 44);
            this.buttonTransferDAU.TabIndex = 25;
            this.buttonTransferDAU.UseVisualStyleBackColor = true;
            this.buttonTransferDAU.Click += new System.EventHandler(this.buttonTransferDAU_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label35);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.labelLRV);
            this.panel3.Controls.Add(this.textBoxIN_SCANFREQ);
            this.panel3.Controls.Add(this.textBoxIN_IOTYPE);
            this.panel3.Controls.Add(this.textBoxIN_TAGNAME);
            this.panel3.Controls.Add(this.textBoxIN_AHIGH);
            this.panel3.Controls.Add(this.textBoxIN_URV);
            this.panel3.Controls.Add(this.textBoxIN_ALOW);
            this.panel3.Controls.Add(this.textBoxIN_LRV);
            this.panel3.Controls.Add(this.labelTAG_ID);
            this.panel3.Controls.Add(this.comboBoxTAG_ID);
            this.panel3.Location = new System.Drawing.Point(23, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 321);
            this.panel3.TabIndex = 24;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label27.ForeColor = System.Drawing.Color.Silver;
            this.label27.Location = new System.Drawing.Point(165, 81);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 19);
            this.label27.TabIndex = 17;
            this.label27.Text = "Instrument";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label26.ForeColor = System.Drawing.Color.Silver;
            this.label26.Location = new System.Drawing.Point(162, 266);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(122, 19);
            this.label26.TabIndex = 16;
            this.label26.Text = "Scan Frequency";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label25.ForeColor = System.Drawing.Color.Silver;
            this.label25.Location = new System.Drawing.Point(17, 266);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 19);
            this.label25.TabIndex = 15;
            this.label25.Text = "IN/OUT Type";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label24.ForeColor = System.Drawing.Color.Silver;
            this.label24.Location = new System.Drawing.Point(162, 202);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 19);
            this.label24.TabIndex = 14;
            this.label24.Text = "Alarm High";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label23.ForeColor = System.Drawing.Color.Silver;
            this.label23.Location = new System.Drawing.Point(17, 202);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 19);
            this.label23.TabIndex = 13;
            this.label23.Text = "Alarm Low";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(162, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "URV";
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelLRV.ForeColor = System.Drawing.Color.Silver;
            this.labelLRV.Location = new System.Drawing.Point(17, 141);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(33, 19);
            this.labelLRV.TabIndex = 11;
            this.labelLRV.Text = "LRV";
            // 
            // textBoxIN_SCANFREQ
            // 
            this.textBoxIN_SCANFREQ.Location = new System.Drawing.Point(165, 288);
            this.textBoxIN_SCANFREQ.Name = "textBoxIN_SCANFREQ";
            this.textBoxIN_SCANFREQ.Size = new System.Drawing.Size(124, 27);
            this.textBoxIN_SCANFREQ.TabIndex = 9;
            // 
            // textBoxIN_IOTYPE
            // 
            this.textBoxIN_IOTYPE.Location = new System.Drawing.Point(21, 288);
            this.textBoxIN_IOTYPE.Name = "textBoxIN_IOTYPE";
            this.textBoxIN_IOTYPE.Size = new System.Drawing.Size(121, 27);
            this.textBoxIN_IOTYPE.TabIndex = 8;
            // 
            // textBoxIN_TAGNAME
            // 
            this.textBoxIN_TAGNAME.Location = new System.Drawing.Point(165, 103);
            this.textBoxIN_TAGNAME.Name = "textBoxIN_TAGNAME";
            this.textBoxIN_TAGNAME.Size = new System.Drawing.Size(124, 27);
            this.textBoxIN_TAGNAME.TabIndex = 6;
            // 
            // textBoxIN_AHIGH
            // 
            this.textBoxIN_AHIGH.Location = new System.Drawing.Point(165, 227);
            this.textBoxIN_AHIGH.Name = "textBoxIN_AHIGH";
            this.textBoxIN_AHIGH.Size = new System.Drawing.Size(122, 27);
            this.textBoxIN_AHIGH.TabIndex = 5;
            // 
            // textBoxIN_URV
            // 
            this.textBoxIN_URV.Location = new System.Drawing.Point(166, 165);
            this.textBoxIN_URV.Name = "textBoxIN_URV";
            this.textBoxIN_URV.Size = new System.Drawing.Size(123, 27);
            this.textBoxIN_URV.TabIndex = 4;
            // 
            // textBoxIN_ALOW
            // 
            this.textBoxIN_ALOW.Location = new System.Drawing.Point(18, 224);
            this.textBoxIN_ALOW.Name = "textBoxIN_ALOW";
            this.textBoxIN_ALOW.Size = new System.Drawing.Size(124, 27);
            this.textBoxIN_ALOW.TabIndex = 3;
            // 
            // textBoxIN_LRV
            // 
            this.textBoxIN_LRV.Location = new System.Drawing.Point(21, 165);
            this.textBoxIN_LRV.Name = "textBoxIN_LRV";
            this.textBoxIN_LRV.Size = new System.Drawing.Size(121, 27);
            this.textBoxIN_LRV.TabIndex = 2;
            // 
            // labelTAG_ID
            // 
            this.labelTAG_ID.AutoSize = true;
            this.labelTAG_ID.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelTAG_ID.ForeColor = System.Drawing.Color.Silver;
            this.labelTAG_ID.Location = new System.Drawing.Point(14, 77);
            this.labelTAG_ID.Name = "labelTAG_ID";
            this.labelTAG_ID.Size = new System.Drawing.Size(52, 19);
            this.labelTAG_ID.TabIndex = 1;
            this.labelTAG_ID.Text = "TAG ID";
            // 
            // comboBoxTAG_ID
            // 
            this.comboBoxTAG_ID.FormattingEnabled = true;
            this.comboBoxTAG_ID.Location = new System.Drawing.Point(20, 101);
            this.comboBoxTAG_ID.Name = "comboBoxTAG_ID";
            this.comboBoxTAG_ID.Size = new System.Drawing.Size(121, 29);
            this.comboBoxTAG_ID.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.comboBoxRDC);
            this.panel1.Controls.Add(this.labelRDC);
            this.panel1.Controls.Add(this.labelRDCNAME);
            this.panel1.Controls.Add(this.textBoxDeviceName);
            this.panel1.Location = new System.Drawing.Point(23, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 174);
            this.panel1.TabIndex = 23;
            // 
            // panelDAU
            // 
            this.panelDAU.Controls.Add(this.label34);
            this.panelDAU.Controls.Add(this.textBoxDAU_Comport);
            this.panelDAU.Controls.Add(this.labelDAU_Baudrate);
            this.panelDAU.Controls.Add(this.comboBoxDAU_Info);
            this.panelDAU.Controls.Add(this.labelDAU_Comport);
            this.panelDAU.Controls.Add(this.labelDAU);
            this.panelDAU.Controls.Add(this.labelDAU_Description);
            this.panelDAU.Controls.Add(this.textBoxDAU_Description);
            this.panelDAU.Controls.Add(this.textBoxDAU_Baudrate);
            this.panelDAU.Location = new System.Drawing.Point(379, 45);
            this.panelDAU.Name = "panelDAU";
            this.panelDAU.Size = new System.Drawing.Size(312, 182);
            this.panelDAU.TabIndex = 22;
            // 
            // labelDAU_Baudrate
            // 
            this.labelDAU_Baudrate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelDAU_Baudrate.ForeColor = System.Drawing.Color.Silver;
            this.labelDAU_Baudrate.Location = new System.Drawing.Point(157, 119);
            this.labelDAU_Baudrate.Name = "labelDAU_Baudrate";
            this.labelDAU_Baudrate.Size = new System.Drawing.Size(119, 21);
            this.labelDAU_Baudrate.TabIndex = 21;
            this.labelDAU_Baudrate.Text = "BAUD rate";
            // 
            // labelDAU_Comport
            // 
            this.labelDAU_Comport.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelDAU_Comport.ForeColor = System.Drawing.Color.Silver;
            this.labelDAU_Comport.Location = new System.Drawing.Point(157, 57);
            this.labelDAU_Comport.Name = "labelDAU_Comport";
            this.labelDAU_Comport.Size = new System.Drawing.Size(108, 21);
            this.labelDAU_Comport.TabIndex = 20;
            this.labelDAU_Comport.Text = "COM Port";
            this.labelDAU_Comport.Click += new System.EventHandler(this.labelDAU_Comport_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(9, 12);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(192, 21);
            this.label33.TabIndex = 15;
            this.label33.Text = "Remote Data Collector";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(11, 9);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(176, 21);
            this.label34.TabIndex = 16;
            this.label34.Text = "Data Acquisition Unit";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(14, 25);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(95, 21);
            this.label35.TabIndex = 16;
            this.label35.Text = "Instrument";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.labelAlarml);
            this.Controls.Add(this.labelAlarmh);
            this.Controls.Add(this.labelStatusOk);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panelOppkobling);
            this.Controls.Add(this.labelOffline);
            this.Controls.Add(this.labelconnected);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelLiveData);
            this.Controls.Add(this.panelDockLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSenseConf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDockLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelLiveData.ResumeLayout(false);
            this.panelLiveData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVbaRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVba)).EndInit();
            this.panelKonfigurasjon.ResumeLayout(false);
            this.panelKonfigurasjon.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelNewSettings.ResumeLayout(false);
            this.panelNewSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotConnected)).EndInit();
            this.panelOppkobling.ResumeLayout(false);
            this.panelOppkobling.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDAU.ResumeLayout(false);
            this.panelDAU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private System.Windows.Forms.Panel panelDockLeft;
        private System.Windows.Forms.Button buttonLiveData;
        private System.Windows.Forms.Button buttonKonfigurasjon;
        private System.Windows.Forms.Button buttonOppkobling;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLiveData;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVba;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelconnected;
        private System.Windows.Forms.Label labelOffline;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogSettings;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Timer timerChartAdd;
        private System.Windows.Forms.Timer timerSerialReceive;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox checkBoxRaw;
        private System.Windows.Forms.CheckBox checkBoxScaled;
        private System.Windows.Forms.Button buttonStopLoad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonSaveChart;
        private System.Windows.Forms.SaveFileDialog saveFileDialogChart;
        private System.Windows.Forms.ListBox listBoxDatain;
        private System.Windows.Forms.ListBox listBoxDataInRaw;
        private System.Windows.Forms.Label labelRawData;
        private System.Windows.Forms.Label labelScaledData;
        private System.Windows.Forms.Timer timerScaledValue;
        private System.Windows.Forms.Timer timerChartScaled;
        private System.Windows.Forms.Timer timerCountScaled;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVbaRaw;
        private System.Windows.Forms.Label labelFaultyValue;
        private System.Windows.Forms.Button buttonSaveChartScaled;
        private System.Windows.Forms.Label labelStatusOk;
        private System.Windows.Forms.PictureBox pictureBoxFValue;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.Label labelAlarml;
        private System.Windows.Forms.Label labelAlarmh;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonDataSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialogRawData;
        private System.Windows.Forms.Button buttonDataSaveScaled;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelKonfigurasjon;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Button buttonConfirmPassword;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelNewSettings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonReadCurrent;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Button buttonConfirmConfig;
        private System.Windows.Forms.Button buttonReadConfig;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxNewLrv;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNewLowAlarm;
        private System.Windows.Forms.TextBox textBoxNewHighAlarm;
        private System.Windows.Forms.TextBox textBoxNewUrv;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.TextBox textBoxReturn;
        private System.Windows.Forms.Button buttonSendCommand;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxConnected;
        private System.Windows.Forms.PictureBox pictureBoxNotConnected;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.ComboBox comboBoxRDC;
        private System.Windows.Forms.Label labelRDC;
        private System.Windows.Forms.TextBox textBoxDeviceName;
        private System.Windows.Forms.Label labelRDCNAME;
        private System.Windows.Forms.ComboBox comboBoxDAU_Info;
        private System.Windows.Forms.Label labelDAU;
        private System.Windows.Forms.TextBox textBoxDAU_Description;
        private System.Windows.Forms.TextBox textBoxDAU_Comport;
        private System.Windows.Forms.TextBox textBoxDAU_Baudrate;
        private System.Windows.Forms.Label labelDAU_Description;
        private System.Windows.Forms.Panel panelOppkobling;
        private System.Windows.Forms.Label labelDAU_Baudrate;
        private System.Windows.Forms.Label labelDAU_Comport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDAU;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.TextBox textBoxIN_SCANFREQ;
        private System.Windows.Forms.TextBox textBoxIN_IOTYPE;
        private System.Windows.Forms.TextBox textBoxIN_TAGNAME;
        private System.Windows.Forms.TextBox textBoxIN_AHIGH;
        private System.Windows.Forms.TextBox textBoxIN_URV;
        private System.Windows.Forms.TextBox textBoxIN_ALOW;
        private System.Windows.Forms.TextBox textBoxIN_LRV;
        private System.Windows.Forms.Label labelTAG_ID;
        private System.Windows.Forms.ComboBox comboBoxTAG_ID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button buttonTransferDAU;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button buttonSendToDB;
        private System.Windows.Forms.Button buttonReadOnce;
        private System.Windows.Forms.TextBox textBoxReturn1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBoxReadToDB;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
    }
}

