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

namespace calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textresult.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textresult.Text += "1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textresult.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textresult.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textresult.Text += "4";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textresult.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textresult.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textresult.Text += "7";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textresult.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textresult.Text += "9";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if(textresult.Text != "")
            {
            valor1 = decimal.Parse(textresult.Text, CultureInfo.InvariantCulture);
            textresult.Text = "";
            operacao = "SOMA";
            labeloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Erro: Informe um número antes de efetuar uma operação.");
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textresult.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA")
            {
                textresult.Text = Convert.ToString(valor1 + valor2);
            }
            else if(operacao == "SUBTRACAO")
            {
                textresult.Text = Convert.ToString(valor1 - valor2);
            }
            else if(operacao == "MULTIPLICACAO")
            {
                textresult.Text = Convert.ToString(valor1 * valor2);
            }
            else if(operacao == "DIVISAO")
            {
                textresult.Text = Convert.ToString(valor1 / valor2);
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textresult.Text != "")
            { 
                valor1 = decimal.Parse(textresult.Text, CultureInfo.InvariantCulture);
                textresult.Text = "";
                operacao = "SUBTRACAO";
                labeloperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Erro: Informe um número antes de efetuar uma operação.");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textresult.Text != "")
            {
                valor1 = decimal.Parse(textresult.Text, CultureInfo.InvariantCulture);
                textresult.Text = "";
                operacao = "MULTIPLICACAO";
                labeloperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Erro: Informe um número antes de efetuar uma operação.");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textresult.Text != "")
            {
                valor1 = decimal.Parse(textresult.Text, CultureInfo.InvariantCulture);
                textresult.Text = "";
                operacao = "DIVISAO";
                labeloperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Erro: Informe um número antes de efetuar uma operação.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textresult.Text = "";
            labeloperacao.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textresult.Text = "";
            valor1 = 0;
            valor2 = 0;
            labeloperacao.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textresult.Text.Length > 0)
            {

                textresult.Text = textresult.Text.Remove(textresult.Text.Length - 1);
            }
            else if(textresult.Text == "")
            {
                textresult.Text = "0"; 
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textresult.Text.Contains("-"))
            {
                textresult.Text = textresult.Text.Remove(0, 1);
            }
            else
            {
                textresult.Text = "-" + textresult.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textresult.Text += ".";
        }
    }
}
