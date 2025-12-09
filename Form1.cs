using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace con_leds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPortSelection.DataSource = ports;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPortSelection.SelectedItem == null)
            {
                MessageBox.Show("No hay puertos disponibles.");
                return;
            }

            if (!serialPortObject.IsOpen)
            {
                try
                {
                    serialPortObject.PortName = comboBoxPortSelection.SelectedItem.ToString();
                    serialPortObject.BaudRate = int.Parse(comboBoxBaudRate.SelectedItem.ToString());
                    serialPortObject.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            } }
        private void OpenSerialPort()
        {
        }
    


private void CloseSerialPort()
        {
            try
            {
                if (serialPortObject.IsOpen)
                {
                    serialPortObject.DataReceived -= SerialPortObject_DataReceived;
                    serialPortObject.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ChangeAppStatusIndication(bool connected)
        {
            if (connected)
            {
                labelAppStatus.Text = "Status: Connected";
                // pictureBoxStatusLed.Image = Properties.Resources.GreenLed; // agregar recurso
            }
            else
            {
                labelAppStatus.Text = "Status: Disconnected";
                // pictureBoxStatusLed.Image = Properties.Resources.RedLed;
            }
        }


        private void SerialPortObject_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Si tu Arduino envía datos y quieres procesarlos, hazlo aquí
            try
            {
                string line = serialPortObject.ReadLine();
                // Invocar al hilo UI si necesitas mostrar algo
                this.BeginInvoke(new Action(() => {
                    // ejemplo: textBoxConsole.AppendText(line + "\r\n");
                }));
            }
            catch { }
        }
        private void buttonLED1On_Click(object sender, EventArgs e)
        {
            SendCommand("L1ON");
        }
        private void buttonLED1Off_Click(object sender, EventArgs e)
        {
            SendCommand("L1OFF");
        }
        private void buttonLED2On_Click(object sender, EventArgs e)
        {
            SendCommand("L2ON");
        }
        private void buttonLED2Off_Click(object sender, EventArgs e)
        {
            SendCommand("L2OFF");
        }
        private void buttonLED3On_Click(object sender, EventArgs e)
        {
            SendCommand("L3ON");
        }
        private void buttonLED3Off_Click(object sender, EventArgs e)
        {
            SendCommand("L3OFF");
        }


        // Botón TECNM
        private void buttonTECNM_Click(object sender, EventArgs e)
        {
            SendCommand("TECNM");
        }
        // Envía comando por serial (añade salto de línea)
        private void SendCommand(string cmd)
        {
            try
            {
                if (serialPortObject.IsOpen)
                {
                    serialPortObject.WriteLine(cmd);
                }
                else
                {
                    MessageBox.Show("Puerto no abierto. Por favor conecta primero.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error enviando comando: " + ex.Message);
         }
            // Auto-generado: InitializeComponent placeholder
            this.buttonLED3On.Location = new System.Drawing.Point(12, 120);
            this.buttonLED3On.Name = "buttonLED3On";
            this.buttonLED3On.Size = new System.Drawing.Size(75, 23);
            this.buttonLED3On.Text = "LED3 ON";
            this.buttonLED3On.UseVisualStyleBackColor = true;
            this.buttonLED3On.Click += new System.EventHandler(this.buttonLED3On_Click);
            //
            // buttonLED3Off
            //
            this.buttonLED3Off.Location = new System.Drawing.Point(95, 120);
            this.buttonLED3Off.Name = "buttonLED3Off";
            this.buttonLED3Off.Size = new System.Drawing.Size(75, 23);
            this.buttonLED3Off.Text = "LED3 OFF";
            this.buttonLED3Off.UseVisualStyleBackColor = true;
            this.buttonLED3Off.Click += new System.EventHandler(this.buttonLED3Off_Click);
            //
            // buttonTECNM
            //
            this.buttonTECNM.Location = new System.Drawing.Point(200, 60);
            this.buttonTECNM.Name = "buttonTECNM";
            this.buttonTECNM.Size = new System.Drawing.Size(120, 30);
            this.buttonTECNM.Text = "Mostrar TECNM";
            this.buttonTECNM.UseVisualStyleBackColor = true;
            this.buttonTECNM.Click += new System.EventHandler(this.buttonTECNM_Click);
            //
            // labelAppStatus
            //
            this.labelAppStatus.AutoSize = true;
            this.labelAppStatus.Location = new System.Drawing.Point(200, 100);
            this.labelAppStatus.Name = "labelAppStatus";
            this.labelAppStatus.Size = new System.Drawing.Size(100, 13);
            this.labelAppStatus.Text = "Status: Disconnected";
            //
            // labelClockRealTime
            //
            this.labelClockRealTime.AutoSize = true;
            this.labelClockRealTime.Location = new System.Drawing.Point(12, 160);
            this.labelClockRealTime.Name = "labelClockRealTime";
            this.labelClockRealTime.Size = new System.Drawing.Size(49, 13);
            this.labelClockRealTime.Text = "00:00:00";


            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(480, 240);
            this.Controls.Add(this.comboBoxPortSelection);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonLED1On);
            this.Controls.Add(this.buttonLED1Off);
            this.Controls.Add(this.buttonLED2On);
            this.Controls.Add(this.buttonLED2Off);
            this.Controls.Add(this.buttonLED3On);
            this.Controls.Add(this.buttonLED3Off);
            this.Controls.Add(this.buttonTECNM);
            this.Controls.Add(this.labelAppStatus);
            this.Controls.Add(this.labelClockRealTime);


            this.Name = "Form1";
            this.Text = "Proyecto HMI - Control Arduino";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
