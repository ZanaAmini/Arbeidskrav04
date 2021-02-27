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
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace FirstGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        string receivedConfig = ""; 
        string[] instrumentConfigs;
        string[] readconfiguration = new string[5];
        string[] readconfigurationserial;


        string password;
        int statusrequest = 0;
        int statusrequestscaled = 0;
        Boolean timeron = true;
        int timertest = 0;
        








        private void buttonOppkobling_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonOppkobling.Height;
            panelLeft.Top = buttonOppkobling.Top;
            panelOppkobling.Visible = true;
            panelKonfigurasjon.Visible = false;
            panelLiveData.Visible = false;
            

        }

        private void buttonKonfigurasjon_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonKonfigurasjon.Height;
            panelLeft.Top = buttonKonfigurasjon.Top;
            panelOppkobling.Visible = false;
            panelLiveData.Visible = false;
            panelKonfigurasjon.Visible = true;
            //panelNewSettings.Visible = false;
            //panelPassword.Visible = false;
        }

        private void buttonLiveData_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonLiveData.Height;
            panelLeft.Top = buttonLiveData.Top;
            panelOppkobling.Visible = false;
            panelKonfigurasjon.Visible = false;
            panelLiveData.Visible = true;
           
            
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonOppkobling.Enabled = true;
            panelOppkobling.Visible = true;
            panelKonfigurasjon.Visible = false;
            panelLiveData.Visible = false;
            labelOffline.Visible = true;
            labelconnected.Visible = false;
            buttonReadConfig.Visible = false;
            
            
        }

        private void comboBoxPorts_Enter(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (String port in ports)
            {
                comboBoxPorts.Items.Add(port);
            }
        }



        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPorts.SelectedIndex > -1)
            {
                serialPort1.PortName = comboBoxPorts.Items[comboBoxPorts.SelectedIndex].ToString();
                if (comboBoxBaud.SelectedIndex > -1)
                {
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Items[comboBoxBaud.SelectedIndex]);
                    serialPort1.Open();
                    pictureBoxConnected.Visible = true;
                    pictureBoxNotConnected.Visible = false;
                    textBoxReceive.Text = "Connection established.";
                    labelconnected.Visible = true;
                    labelOffline.Visible = false;

                }
                else
                {
                    MessageBox.Show("Could not connect to device!");
                    labelconnected.Visible = false;
                    labelOffline.Visible = true;
                }
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            pictureBoxNotConnected.Visible = true;
            pictureBoxConnected.Visible = false;
            textBoxReceive.Text = "No connection.";
            labelOffline.Visible = true;
            labelconnected.Visible = false;
        }

  

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close the programme?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();

            }
            else if (dialog == DialogResult.No)
            {
                
            }
            
        }



        private void buttonSendCommand_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //System.Threading.Thread.Sleep(1000);
                //textBoxReturn.Clear();
                if (textBoxCommand.Text.Equals("readconf"))
                {
                    textBoxCommand.Clear();
                    textBoxReturn.Clear();
                    textBoxReturn.AppendText("Current configuration:" + "\r\n");

                    serialPort1.WriteLine("readconf");
                    System.Threading.Thread.Sleep(2000);
                    receivedConfig= serialPort1.ReadExisting().ToString();
                    textBoxReturn.AppendText(receivedConfig);
                    timerSerialReceive.Enabled = false;
                    timerChartAdd.Enabled = false;
                    textBoxCommand.Clear();


                }



                else if (textBoxCommand.Text.Equals("writeconf"))
                {
                    textBoxCommand.Clear();
                    textBoxReturn.Clear();
                    textBoxReturn.AppendText("Data can now be read and written.");
                    //MessageBox.Show("Please write password to continue");
                    //panelPassword.Visible = true;
                    panelNewSettings.Visible = true;
                    buttonReadConfig.Visible = true;





                }
                else if (textBoxCommand.Text.Equals("readstatus"))
                {
                    textBoxReturn.Clear();
                    textBoxReturn.AppendText("Status:" + "\r\n");
                    serialPort1.WriteLine("readstatus");
                    System.Threading.Thread.Sleep(1300);
                    string receivedstatus = serialPort1.ReadExisting().ToString();
                    textBoxReturn.AppendText(receivedstatus);
                    textBoxCommand.Clear();
                }

                else if (textBoxCommand.Text.Equals("readraw"))
                {
                    textBoxCommand.Clear();
                    textBoxReturn.Clear();
                    textBoxReturn.AppendText("Data is being published in 'Live Data'" + "\r\n");
                    //serialPort1.WriteLine("readraw");
                    //timerSerialReceive.Interval = 1000;
                    timerSerialReceive.Start();
                    timerClock.Enabled = true;
                    buttonStopLoad.Visible = true;
                    checkBoxScaled.Visible = false;
                    
                    listBoxDatain.Visible = false;
                    chartVbaRaw.Visible = true;
                    checkBoxRaw.Checked = true;
                    labelRawData.Visible = true;
                


                
                    //timerStatus.Start();
                    //timerStatus.Interval = 3000;
                    //timerSerialReceive.Enabled = true;
                    //timerChartAdd.Enabled = false;

                    textBoxCommand.Clear();
                }
                else if (textBoxCommand.Text.Equals("readscaled"))
                {
                    textBoxCommand.Clear();
                    textBoxReturn.Clear();
                    textBoxReturn.AppendText("Data is being published in 'Live Data'" + "\r\n");
                    timerScaledValue.Enabled = true;
                    buttonStopLoad.Visible = true;
                    checkBoxScaled.Checked = true;
                    checkBoxRaw.Visible = false;
                    listBoxDataInRaw.Visible = false;
                    chartVba.Visible = true;
                    checkBoxRaw.Checked = false;
                    labelScaledData.Visible = true;

                    textBoxCommand.Clear();
                }

                

                else
                {

                    textBoxReturn.AppendText("Command not valid.");
                }
            }
            else
            {
                MessageBox.Show("Serial Port is not connected!");
            }
            
            





        }


        private void textBoxCommand_Enter(object sender, EventArgs e)
        {
            textBoxCommand.Clear();
        }

        

        private void buttonConfirmPassword_Click(object sender, EventArgs e)
        {
            double newdata;
            
            if (textBoxPassword.Text.Length==8)
            {
                string writestring;
                string password = textBoxPassword.Text;

                DialogResult dialog = MessageBox.Show("Are you sure you want to set new data variables?", "", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    //Combine Data from textboxes (ConfigToSend)
                    #region
                    string configToSend = textBoxNewName.Text + ";" + textBoxNewLrv.Text + ";" 
                                          + textBoxNewUrv.Text + ";" + textBoxNewLowAlarm.Text + ";" + textBoxNewHighAlarm.Text;
                    #endregion

                    writestring = ("writeconf>" + password + ">" + string.Join(";", configToSend));
                    textBoxReturn.Clear();

                    serialPort1.WriteLine(writestring);
                    System.Threading.Thread.Sleep(1300);
                    newdata = Convert.ToDouble(serialPort1.ReadExisting());
                    if (newdata ==1)
                    {
                        serialPort1.WriteLine(writestring);
                        System.Threading.Thread.Sleep(1300);
                        textBoxReturn.AppendText("New configuration has been successfully set:\r\n");
                        textBoxReturn.AppendText(serialPort1.ReadExisting());
                    }
                    else if (newdata ==0)
                    {
                        textBoxReturn.AppendText("Something went wrong, try again");
                    }
                    
                    //textBoxReturn.AppendText(serialPort1.ReadExisting());
                    //timerSerialReceive.Enabled = true;
                    //timerChartAdd.Enabled = false;


                }
                else if (dialog == DialogResult.No)
                {

                }



            }
            else
            {
                MessageBox.Show("Password must consist of 8 characters! Please try again.");
            }
        }

        private void textBoxNewLrv_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Char chr = e.KeyChar;
            //if (!Char.IsDigit(chr) && chr !=8)
            //{
            //    e.Handled = true;
            //}
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

 

        private void textBoxNewLrv_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxNewLrv, "Must be between [0-500]");
        }

        

        private void textBoxNewLowAlarm_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxNewLowAlarm, "Must be between [40-450]");
        }

        private void textBoxNewHighAlarm_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxNewHighAlarm, "Must be between [40-450]");
        }

        private void textBoxNewUrv_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxNewUrv, "Must be between [0-500]");
        }


        private void buttonReadConfig_Click(object sender, EventArgs e)
        {
            textBoxNewName.Clear();
            textBoxNewLrv.Clear();
            textBoxNewUrv.Clear();
            textBoxNewHighAlarm.Clear();
            textBoxNewLowAlarm.Clear();
            var fileName = string.Empty;
            openFileDialogSettings.InitialDirectory = "c:\\";
            //openFileDialogSettings.FilterIndex = 5;
            openFileDialogSettings.RestoreDirectory = true;
            openFileDialogSettings.FileName = "";

            textBoxReturn.Clear();

            if (openFileDialogSettings.ShowDialog() == DialogResult.OK)
            {
                var uploaddata = File.ReadAllText(openFileDialogSettings.FileName);

                string [] splits = uploaddata.ToString().Split(';');

                textBoxNewName.Text = splits[0];
                textBoxNewLrv.Text = splits[1];
                textBoxNewUrv.Text = splits[2];
                textBoxNewLowAlarm.Text = splits[3];
                textBoxNewHighAlarm.Text = splits[4];
                

            }





        }


        int countconfigifs = 0;
        private void buttonConfirmConfig_Click(object sender, EventArgs e)
        {
            countconfigifs = 0;
            if (Convert.ToDouble(textBoxNewLrv.Text) >500)
            {
                MessageBox.Show("LRV-value must me between 0-500");
                countconfigifs -= 1;
            }
            if (Convert.ToDouble(textBoxNewUrv.Text) > 500)
            {
                MessageBox.Show("URV-value must be between 0-500");
                countconfigifs -= 1;
            }
            if (Convert.ToDouble(textBoxNewHighAlarm.Text) > 500)
            {
                MessageBox.Show("HIGH ALARM-value must be between 0-500");
                countconfigifs -= 1;
            }
            if (Convert.ToDouble(textBoxNewLowAlarm.Text) > 500)
            {
                MessageBox.Show("LOW ALARM-value must be between 0-500");
                countconfigifs -= 1;
            }
            if (countconfigifs==0)
            {
                MessageBox.Show("Please write password to continue");
                panelPassword.Visible = true;
            }
            




            

        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            


            if (serialPort1.IsOpen)
            {
                timerChartAdd.Enabled = false;
                timerSerialReceive.Enabled = false;
                buttonStopLoad.Visible = true;
                buttonDataSave.Visible = false;
                buttonDataSaveScaled.Visible = false;
                listBoxDatain.Items.Clear();
                listBoxDataInRaw.Items.Clear();

                if (checkBoxRaw.Checked)
                {
                    listBoxDataInRaw.Items.Clear();
                    serialPort1.WriteLine("readraw");
                    listBoxDataInRaw.Visible = true;
                    listBoxDatain.Visible = false;
                    labelRawData.Visible = true;
                    labelScaledData.Visible = false;
                    chartVbaRaw.Visible = true;
                    //buttonSaveChart.Visible = true;
                    chartVba.Visible = false;
                    timerSerialReceive.Enabled = true;
                    timerChartAdd.Enabled = false;
                    checkBoxScaled.Visible = false;
                    //buttonSaveChart.Visible = true;
                }

                if (checkBoxScaled.Checked)
                {
                    listBoxDatain.Items.Clear();
                    serialPort1.WriteLine("readscaled");
                    listBoxDatain.Visible = true;
                    listBoxDataInRaw.Visible = false;
                    chartVba.Visible = true;
                    //buttonSaveChart.Visible = true;
                    labelRawData.Visible = false;
                    labelScaledData.Visible = true;
                    chartVbaRaw.Visible = false;
                    timerScaledValue.Enabled = true;
                    //timerClock.Enabled = true;
                    timerSerialReceive.Enabled = false;
                    timerChartAdd.Enabled = false;
                    checkBoxRaw.Visible = false;
                    //buttonSaveChartScaled.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Serial Port is not connected!");
            }

            



        }

        private void timerChartAdd_Tick(object sender, EventArgs e)
        {
            
            if (serialPort1.IsOpen)
            {
                if (serialPort1.BytesToRead > 0)
                {
                    string availabledata = "";
                    availabledata += serialPort1.ReadExisting().ToString();

                    if ((alarmRequested==true) && (availabledata == "0" || availabledata == "1" 
                        || availabledata == "2" || availabledata == "3"))
                    {

                        //string availabledata = "";
                        //availabledata += serialPort1.ReadExisting().ToString();
                        textBoxStatus.Clear();
                        string[] analogStatus = availabledata.Split(';');
                        textBoxStatus.AppendText(availabledata);
                        if (textBoxStatus.Text.Equals("0"))
                        {
                            labelStatusOk.Visible = true;
                            labelAlarml.Visible = false;
                            labelAlarmh.Visible = false;
                            labelFail.Visible = false;
                        }
                        else if (textBoxStatus.Text.Equals("1"))
                        {
                            labelFail.Visible = true;
                            labelStatusOk.Visible = false;
                            labelAlarml.Visible = false;
                            labelAlarmh.Visible = false;
                        }
                        else if (textBoxStatus.Text.Equals("2"))
                        {
                            labelAlarml.Visible = true;
                            labelFail.Visible = false;
                            labelStatusOk.Visible = false;
                            labelAlarmh.Visible = false;
                        }
                        else if (textBoxStatus.Text.Equals("3"))
                        {
                            labelAlarmh.Visible = true;
                            labelAlarml.Visible = false;
                            labelFail.Visible = false;
                            labelStatusOk.Visible = false;
                        }
                        statusrequest = 0;
                        alarmRequested = false;
                    }
                    else
                    {
                        
                        //string availabledata = "";
                        //availabledata += serialPort1.ReadExisting().ToString();

                        string[] analogStatus = availabledata.Split(';');
                        //textBoxReturn.AppendText(availabledata + "\r\n");
                        string[] tmp2 = availabledata.Split('.');
                        if (tmp2.Length <=2)
                        {
                            labelFaultyValue.Visible = false;
                            pictureBoxFValue.Visible = false;
                            listBoxDataInRaw.Items.Add((availabledata));

                            chartVbaRaw.Series[0].Points.AddXY(Convert.ToDouble(listBoxDataInRaw.Items.Count - 1),
                            Convert.ToDouble(listBoxDataInRaw.Items[listBoxDataInRaw.Items.Count - 1]));
                        }
                        else
                        {
                            labelFaultyValue.Visible = true;
                            pictureBoxFValue.Visible = true;
                        }

                        
                        

                    }


                }
               

                timerSerialReceive.Enabled = true;
                timerChartAdd.Enabled = false;
                timerStatus.Enabled = false;
                

            }



        }
        bool alarmRequested = false;

        private void timerSerialReceive_Tick(object sender, EventArgs e)
        {

            if (statusrequest >= 5)
            {
                serialPort1.WriteLine("readstatus");
                statusrequest = 0;
                alarmRequested = true;
            }
            else
            {
                serialPort1.WriteLine("readraw");

            }

            
            timerChartAdd.Enabled = true;
            timerSerialReceive.Enabled = false;
            timerClock.Enabled = true;
        }

        private void checkBoxRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRaw.Checked)
            {
                checkBoxScaled.Checked = false;
            }
        }

        private void checkBoxScaled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxScaled.Checked)
            {
                checkBoxRaw.Checked = false;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //timerChartAdd.Enabled = false;
            //timerSerialReceive.Enabled = false;
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            var savefileDataConfig = saveFileDialog1;
            savefileDataConfig.Filter = "Text (*.ssv)|*.ssv";
            


            if (savefileDataConfig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                readconfiguration[0] = textBoxNewName.Text;
                readconfiguration[1] = textBoxNewLrv.Text;
                readconfiguration[2] = textBoxNewUrv.Text;
                readconfiguration[3] = textBoxNewLowAlarm.Text;
                readconfiguration[4] = textBoxNewHighAlarm.Text;

                using (var sw = new StreamWriter(savefileDataConfig.FileName, false))
                {

                    sw.Write(String.Format("{0};{1};{2};{3};{4}", readconfiguration[0], readconfiguration[1], 
                                            readconfiguration[2], readconfiguration[3], readconfiguration[4])
                        +Environment.NewLine);
                    
                    //foreach (var item in readconfiguration)
                    //{
                    //    sw.Write(item.ToString() + Environment.NewLine);
                    //}
                    
                    MessageBox.Show("Data saved sucessfully");
                    sw.Close();

                }
                
            }






            
        }

        private void buttonReadCurrent_Click(object sender, EventArgs e)
        {
            textBoxReturn.Clear();
            textBoxNewName.Clear();
            textBoxNewLrv.Clear();
            textBoxNewUrv.Clear();
            textBoxNewHighAlarm.Clear();
            textBoxNewLowAlarm.Clear();

            serialPort1.WriteLine("readconf");
            System.Threading.Thread.Sleep(1300);
            readconfigurationserial = serialPort1.ReadExisting().ToString().Split(';');

            textBoxNewName.Text = readconfigurationserial[0];
            textBoxNewLrv.Text = readconfigurationserial[1];
            textBoxNewUrv.Text = readconfigurationserial[2];
            textBoxNewLowAlarm.Text = readconfigurationserial[3];
            textBoxNewHighAlarm.Text = readconfigurationserial[4];
            textBoxReturn.AppendText("Current configuration from instrument \r\nsuccessfully fetched.");
            
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            
            serialPort1.WriteLine("readstatus");
            
            string statusdata = "";
            statusdata += serialPort1.ReadExisting().ToString();
            string[] analogReadings = statusdata.Split(';');
            textBoxStatus.AppendText("Status:"+ statusdata + "\r\n");
            



        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            statusrequest += 1;
        }

        private void buttonSaveChart_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = saveFileDialogChart;
            saveFileDialog.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
            saveFileDialog.Title = "Save Chart As Image File";
            saveFileDialog.FileName = "Chart.png";
            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;
            

            chartVba.Visible = false;



                if (result == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    try
                    {
                        if (saveFileDialog.CheckPathExists)
                        {
                            if (saveFileDialog.FilterIndex == 2)
                            {
                                chartVbaRaw.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                            }
                            else if (saveFileDialog.FilterIndex == 1)
                            {
                                chartVbaRaw.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Given Path does not exist");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }





            
            
            
        }

        private void buttonStopLoad_Click(object sender, EventArgs e)
        {
            timerChartAdd.Enabled = false;
            timerSerialReceive.Enabled = false;
            timerScaledValue.Enabled = false;
            timerChartScaled.Enabled = false;
            checkBoxRaw.Visible = true;
            checkBoxScaled.Visible = true;
            

            if ((listBoxDataInRaw.Items.Count <= 0) && (listBoxDatain.Items.Count >= 0) && (checkBoxScaled.Checked=true))
            {

                listBoxDataInRaw.Visible = false;
                buttonDataSave.Visible = false;
                buttonDataSaveScaled.Visible = true;
                buttonSaveChartScaled.Visible = true;
                buttonSaveChart.Visible = false;
            }
            else if ((listBoxDatain.Items.Count <=0) && (listBoxDataInRaw.Items.Count >= 0) && (checkBoxRaw.Checked=true))
            {
                
                buttonDataSaveScaled.Visible = false;
                listBoxDatain.Visible = false;
                buttonDataSave.Visible = true;
                buttonSaveChartScaled.Visible = false;
                buttonSaveChart.Visible = true;
            }
            else if ((listBoxDataInRaw.Items.Count <= 0) && (listBoxDatain.Items.Count <= 0))
            {
                buttonDataSave.Visible = false;
                buttonDataSaveScaled.Visible = false;
                
            }

            
            


        }

        private void timerScaledValue_Tick(object sender, EventArgs e)
        {
            if (statusrequestscaled >= 5)
            {
                serialPort1.WriteLine("readstatus");
                statusrequestscaled = 0;
                alarmRequestedScaled = true;
            }
            else
            {
                serialPort1.WriteLine("readscaled");

            }
            timerChartScaled.Enabled = true;
            timerScaledValue.Enabled = false;
            
            timerCountScaled.Enabled = true;
        }


        private void timerCountScaled_Tick(object sender, EventArgs e)
        {
            statusrequestscaled += 1;
        }

        private void timerChartScaled_Tick(object sender, EventArgs e)
        {
            

            if (serialPort1.IsOpen)
            {
                if (serialPort1.BytesToRead > 0)
                {
                    string availabledata = "";
                    availabledata += serialPort1.ReadExisting().ToString();

                    if ((alarmRequestedScaled == true) && (availabledata == "0" || availabledata == "1"
                        || availabledata == "2" || availabledata == "3"))
                    {

                        //string availabledata = "";
                        //availabledata += serialPort1.ReadExisting().ToString();
                        textBoxStatus.Clear();
                        string[] analogStatus = availabledata.Split(';');
                        textBoxStatus.AppendText(availabledata);
                        if (textBoxStatus.Text.Equals("0"))
                        {
                            labelStatusOk.Visible = true;
                            labelAlarml.Visible = false;
                            labelAlarmh.Visible = false;
                            labelFail.Visible = false;
                        }
                        else if (textBoxStatus.Text.Equals("1"))
                        {
                            labelFail.Visible = true;
                            labelStatusOk.Visible = false;
                            labelAlarml.Visible = false;
                            labelAlarmh.Visible = false;
                        }
                        else if (textBoxStatus.Text.Equals("2"))
                        {
                            labelAlarml.Visible = true;
                            labelFail.Visible = false;
                            labelStatusOk.Visible = false;
                            labelAlarmh.Visible = false;
                        }
                        else if (textBoxStatus.Text.Equals("3"))
                        {
                            labelAlarmh.Visible = true;
                            labelAlarml.Visible = false;
                            labelFail.Visible = false;
                            labelStatusOk.Visible = false;
                        }
                        statusrequestscaled = 0;
                        alarmRequestedScaled = false;
                    }
                    else
                    {

                        //string availabledata = "";
                        //availabledata += serialPort1.ReadExisting().ToString();

                        string[] analogStatus = availabledata.Split(';');
                        //textBoxReturn.AppendText(availabledata + "\r\n");
                        string[] tmp = availabledata.Split('.');
                        //var tempcountscaled = 0.0;
                        if (tmp.Length <=2)
                        {
                            labelFaultyValue.Visible = false;
                            pictureBoxFValue.Visible = false;
                            listBoxDatain.Items.Add(availabledata);
                            chartVba.Series[0].Points.AddXY(Convert.ToDouble(listBoxDatain.Items.Count - 1),
                            Convert.ToDouble(listBoxDatain.Items[listBoxDatain.Items.Count - 1]));

                        }
                        else
                        {
                            labelFaultyValue.Visible = true;
                            pictureBoxFValue.Visible = true;


                            
                        }
                        


                    }


                }


                
                timerChartAdd.Enabled = false;
                timerStatus.Enabled = false;
                timerScaledValue.Enabled = true;
                timerChartScaled.Enabled = false;
                


            }
            
        }
        bool alarmRequestedScaled = false;

        private void buttonSaveChartScaled_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = saveFileDialogChart;
            saveFileDialog.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
            saveFileDialog.Title = "Save Chart As Image File";
            saveFileDialog.FileName = "Chart.png";
            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            chartVbaRaw.Visible = false;
            chartVba.Visible = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        if (saveFileDialog.FilterIndex == 2)
                        {
                            chartVba.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                        }
                        else if (saveFileDialog.FilterIndex == 1)
                        {
                            chartVba.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBoxSoft aboutWindow = new AboutBoxSoft();
            aboutWindow.Show();
        }

        private void buttonDataSave_Click(object sender, EventArgs e)
        {
            var savefileData = saveFileDialogRawData;
            savefileData.Filter = "Text (*.csv)|*.csv";
            listBoxDatain.Visible = false;
            
            if (savefileData.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(savefileData.FileName, false))
                {
                    
                        foreach (var item in listBoxDataInRaw.Items)
                        {
                            sw.Write(item.ToString() + Environment.NewLine);
                        }
                        MessageBox.Show("Data saved sucessfully");
                    
                }
            }


        }

        private void buttonDataSaveScaled_Click(object sender, EventArgs e)
        {
            var savefileData = saveFileDialogRawData;
            savefileData.Filter = "Text (*.csv)|*.csv";
            listBoxDataInRaw.Visible = false;


            if (savefileData.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(savefileData.FileName, false))
                {
                    
                        foreach (var item in listBoxDatain.Items)
                        {
                            sw.Write(item.ToString() + Environment.NewLine);
                        }

                        MessageBox.Show("Data saved sucessfully");
                    
                }
            }
        }

        private void labelOffline_Click(object sender, EventArgs e)
        {

        }

        private void textBoxReturn_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewLrv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewUrv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewLowAlarm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewHighAlarm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void textBoxNewLowAlarm_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

