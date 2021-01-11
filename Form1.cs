using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArduinoTemperaturaFormG3_2020_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperatura FormTemp = new Temperatura(this);            
            FormTemp.MdiParent = this; //Será contenido dentro del formulario padres
            FormTemp.Show();
        }
    }
}
