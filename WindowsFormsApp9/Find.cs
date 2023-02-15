using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Find : Form
    {
        
        public string find_str;
        public Find(string s)
        {
            InitializeComponent();
            find_str = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Пустое поле ввода!");
            else
            {
                find_str = textBox1.Text;
                this.Close();
                
            }
        }
    }
}
