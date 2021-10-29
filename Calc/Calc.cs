using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calc : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Calc()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void btsoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
            textBox.Text = "";
            operacao = "SOMA";
            lab.Text = "+";
        }

        private void btresult_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                textBox.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUBTRAÇÃO")
            {
                textBox.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICAÇÃO")
            {
                textBox.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISÃO")
            {
                if (valor2 == 0)
                {
                textBox.Text = "ERRO!!!";
                }
                else{
                textBox.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btsub_Click_1(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
            textBox.Text = "";
            operacao = "SUBTRAÇÃO";
            lab.Text = "-";
        }

        private void btmult_Click_1(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
            textBox.Text = "";
            operacao = "MULTIPLICAÇÃO";
            lab.Text = "x";
        }

        private void btdiv_Click_1(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
            textBox.Text = "";
            operacao = "DIVISÃO";
            lab.Text = "÷";
        }

        private void btce_Click_1(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void btc_Click_1(object sender, EventArgs e)
        {
            textBox.Text = "";
            valor1 = 0;
            valor2 = 0;
            lab.Text = "";
        }

        private void btponto_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
