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
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }
        private double Perimetr()
        {
            return InputForm.a + InputForm.b + InputForm.c;
        }
        private double Square()
        {
            double p = Perimetr() / 2;
            return Math.Sqrt(p * (p - InputForm.a) * (p - InputForm.b) * (p - InputForm.c));
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            if((InputForm.a >= InputForm.b + InputForm.c) || (InputForm.b >= InputForm.a + InputForm.c) || (InputForm.c >= InputForm.b + InputForm.a))
            {
                label1.Text = "Такого треугольника не существует!";
            }
            else
            {
                if (InputForm.calcP)
                    label1.Text += String.Format("P = {0}\n", Perimetr());
                if (InputForm.calcS)
                    label1.Text += String.Format("S = {0}", Math.Round(Square(), 2));
            }
        }
    }
}
