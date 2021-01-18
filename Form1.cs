using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace ArduinoTemperaturaFormG3_2020_II
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            selecciona();
        }

        private void selecciona()
        {
            string[] v = SerialPort.GetPortNames();
            Array.Sort(v);
            toolStripCMBpuertos.Items.AddRange(v);
            toolStripCMBVelocidad.SelectedIndex=2;
        }


        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperatura FormTemp = new Temperatura(this);            
            FormTemp.MdiParent = this; //Será contenido dentro del formulario padres
            FormTemp.Show();
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.BaudRate = int.Parse(toolStripCMBVelocidad.SelectedItem.ToString());
                serialPort.PortName = toolStripCMBpuertos.SelectedItem.ToString();

            }
            catch(IOException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort.Open();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaLED prueba = new PruebaLED(serialPort);
            prueba.MdiParent = this;
            prueba.Show();
        }
    }
}
