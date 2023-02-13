using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public string filename="Новый";
        public bool fb=false;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Text = "NotePad: " + filename;

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    StreamReader sr=new StreamReader(openFileDialog1.FileName);
                    textBox1.Text=sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                    fb= true;
                }
            }
            catch
            {
                MessageBox.Show("Не могу открыть файл!");
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fb)
            {
                try
                {
                    filename = filename + ".txt";
                    StreamWriter sw = new StreamWriter(filename);
                    sw.WriteLine(textBox1.Text);
                    sw.Close();
                    filename = saveFileDialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("Не могу сохранить файл!");
                }
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filename = saveFileDialog1.FileName + ".txt";
                        StreamWriter sw = new StreamWriter(filename);
                        sw.WriteLine(textBox1.Text);
                        sw.Close();
                        filename = saveFileDialog1.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("Не могу сохранить файл!");
                    }
                }
            }
          
        }
        private void Savefile(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                try 
                {
                    filename = saveFileDialog1.FileName+".txt";
                    StreamWriter sw = new StreamWriter(filename);
                    sw.WriteLine(textBox1.Text);
                    sw.Close();
                    filename = saveFileDialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("Не могу сохранить файл!");
                }
            }
        }
    }
}
