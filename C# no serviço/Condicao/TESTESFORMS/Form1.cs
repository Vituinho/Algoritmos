using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTESFORMS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string operador = ""; // Cria a variavel do Operador
        double valor1 = 0; // Cria a variavel do primeiro valor
        bool novoNumero = false; // cria o novo numero que é true or false, e fala que se numero = 1 novo numero = false

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                textBox1.Text = "1";
                novoNumero = false;
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (novoNumero) // indica se o usuário está tentando digitar um novo numero, depois de escolher a operação.
            {
                textBox1.Text = "2"; // a caixa de texto é substituida por 2
                novoNumero = false; // a variavel é alterada pra false, indicando que o número atual começou a ser digitado
            }
            else
            {
                textBox1.Text += "2"; // o numero vai ser adicionado a conta, exemplo a conta era 23 agora vai ser 232.
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                textBox1.Text = "3";
                novoNumero = false;
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                textBox1.Text = "4";
                novoNumero = false;
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                textBox1.Text = "5";
                novoNumero = false;
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                textBox1.Text = "6";
                novoNumero = false;
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                textBox1.Text = "7";
                novoNumero = false;
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                textBox1.Text = "8";
                novoNumero = false;
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                textBox1.Text = "9";
                novoNumero = false;
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                textBox1.Text = "0";
                novoNumero = false;
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text); // transforma o numero selecionado, que é uma string em um double.
            operador = "+"; // muda o operador para +
            novoNumero = true; // fala que o proximo numero vai ser do segundo numero.
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operador = "-";
            novoNumero = true;
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operador = "*";
            novoNumero = true;
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operador = "/";
            novoNumero = true;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; // muda o texto pra vazio
            valor1 = 0; // muda o valor 1 pra vazio
            operador = ""; // muda o operador pra vazio
            novoNumero = false; // fala que não tem um novo numero, então é o numero 1 agora.
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            double valor2 = double.Parse(textBox1.Text); // Pega o segundo número
            double resultado = 0;

            switch (operador)
            {
                case "+": // caso operador for igual a + resultado vai receber valor1 + valor2;
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    else
                        MessageBox.Show("Não é possível dividir por zero.");
                    break;
                default:
                    MessageBox.Show("Operação inválida.");
                    break;
            }

            textBox1.Text = resultado.ToString(); // muda o resultado de double para string. porque double não aparece no textbox
            novoNumero = true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
