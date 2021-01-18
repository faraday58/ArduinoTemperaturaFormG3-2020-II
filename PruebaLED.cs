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
namespace ArduinoTemperaturaFormG3_2020_II
{
    public partial class PruebaLED : Form
    {
        SerialPort serialPort;
        bool prende;
        public PruebaLED(SerialPort serialPort)
        {
            InitializeComponent();
            this.serialPort = serialPort;
        }

        private void btnPrende_Click(object sender, EventArgs e)
        {
            if (!prende)
            {
                serialPort.Write("p");
                prende = true;
                btnPrende.Text = "Apaga";
            }
            else
            {
                btnPrende.Text = "Prende";
                serialPort.Write("a");
                prende = false;
            }
            

        }
    }
}
