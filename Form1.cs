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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm IForm = new InputForm();
            IForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcForm CForm = new CalcForm();
            CForm.ShowDialog();
        }

        private void convertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertForm ConForm = new ConvertForm();
            ConForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm AForm = new AboutForm();
            AForm.ShowDialog();
        }
    }
}
