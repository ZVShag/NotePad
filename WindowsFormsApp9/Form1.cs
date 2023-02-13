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
        public string buff;
        public string snif;
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

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode==Keys.C)
                buff=textBox1.SelectedText;
           
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buff=textBox1.SelectedText;
            textBox1.SelectedText = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            snif = snif + e.KeyChar+"/n";
            
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void изменитьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Font=fontDialog1.Font;
            }

        }

        private void изменитьФонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                textBox1.BackColor=colorDialog1.Color;
            }
        }
    }
}
