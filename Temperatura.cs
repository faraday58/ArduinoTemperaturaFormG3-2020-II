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
            saveFileDialog.Filter = "Archivos de texto | *.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.DefaultExt = ".txt";


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

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter= "Archivos de texto | *.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.DefaultExt = ".txt";

            StreamReader sr = null;

            if( openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sr = new StreamReader(openFileDialog.FileName);
                    List<string> lineas = new List<string>();
                    string linea = sr.ReadLine();
                    while( linea !=null )
                    {
                        lineas.Add(linea);
                        linea = sr.ReadLine();
                    }
                    string[] cadenas = new string[lineas.Count];
                    for(int i=0; i < lineas.Count;i++)
                    {
                        cadenas[i] = lineas[i];
                        cadenas[i] += " cadena1 ";
                    }
                    richTexto.Lines = cadenas;

                }
                catch(IOException error)
                {
                    MessageBox.Show("Error", error.Message);
                }
                finally
                {
                    sr.Close();
                }

            }



        }
    }
}
