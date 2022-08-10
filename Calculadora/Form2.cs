using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            string num0 = "0";
            textScreen.AppendText(num0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = "1";
            textScreen.AppendText(num1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num2 = "2";
            textScreen.AppendText(num2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num3 = "3";
            textScreen.AppendText(num3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num4 = "4";
            textScreen.AppendText(num4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string num5 = "5";
            textScreen.AppendText(num5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string num6 = "6";
            textScreen.AppendText(num6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string num7 = "7";
            textScreen.AppendText(num7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string num8 = "8";
            textScreen.AppendText(num8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string num9 = "9";
            textScreen.AppendText(num9);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            string plus = "+";
            textScreen.AppendText(plus);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            string sub = "-";
            textScreen.AppendText(sub);
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            string mult = "*";
            textScreen.AppendText(mult);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            string div = "/";
            textScreen.AppendText(div);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            DataTable Calc = new DataTable();
            var result = Calc.Compute(textScreen.Text,"");
            textScreen.Text = result.ToString();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textScreen.Clear();
        }
    }
}
