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
    public partial class Replace : Form
    {
        public string f_str;
        public string r_str;
        public Replace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Не ввели того, что надо заменить!");
            }
            else
            {
                f_str= textBox1.Text;
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Не ввели того, на что надо заменить!");
            }
            else
            {
                r_str= textBox2.Text;
            }
        }
    }
}
