namespace Calculadora_sem_ajuda
{
    public partial class Calculadora : Form
    {

        enum
        Operacoes
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        double primeiroNumero = 0;
        string operacao = "";
        double resultado = 0;
        
        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCalculos.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCalculos.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCalculos.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCalculos.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCalculos.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCalculos.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCalculos.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCalculos.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCalculos.Text += "9";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtCalculos.Text);
            operacao = "/";

            txtCalculos.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCalculos.Text += "0";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtCalculos.Text.Contains(","))
            {
                txtCalculos.Text += ",";
                return;
            }

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtCalculos.Text = "";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtCalculos.Text);
            operacao = "+";

            txtCalculos.Text = "";

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtCalculos.Text);
            operacao = "X";

            txtCalculos.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtCalculos.Text);
            operacao = "-";

            txtCalculos.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double segundoNumero;
            if (double.TryParse(txtCalculos.Text, out segundoNumero))
            {
                switch (operacao)
                {
                    case "+":
                        resultado = primeiroNumero + segundoNumero;
                        break;
                    case "-":
                        resultado = primeiroNumero - segundoNumero;
                        break;
                    case "X":
                        resultado = primeiroNumero * segundoNumero;
                        break;
                    case "/":
                        resultado = primeiroNumero / segundoNumero;
                        break;

                }
            }
             txtCalculos.Text = resultado.ToString();
        }
    }
}
