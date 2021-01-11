using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ArduinoTemperaturaFormG3_2020_II
{
    public partial class Temperatura : Form
    {
        Form padre;
        public Temperatura(Form padre)
        {            
            InitializeComponent();
            this.padre = padre;
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            StreamWriter sw= null;

            if( saveFileDialog.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    sw = new StreamWriter(saveFileDialog.FileName);

                    for(int i=0; i < richTexto.Lines.Length; i++  )
                    {
                        sw.WriteLine(richTexto.Lines[i]);
                    }
                }
                catch( IOException error  )
                {
                    MessageBox.Show("Error", error.Message);
                }
                catch(Exception error )
                {
                    MessageBox.Show("Error", error.Message);
                }
                finally
                {
                    sw.Close();
                }

            }

        }
    }
}
