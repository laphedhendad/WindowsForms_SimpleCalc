using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_1
{
    public partial class ConvertForm : Form
    {
        private short n = 10;
        public ConvertForm()
        {
            InitializeComponent();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            n = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            n = 8;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            n = 16;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                label2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), n);
            }
            else
            {
                label2.Text = "Введите число!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
