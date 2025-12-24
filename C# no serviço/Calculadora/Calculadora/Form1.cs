using System.Media;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer = new SoundPlayer();

        private void btnTocar_Click(object sender, EventArgs e)
        {
            try
            {
                string caminhoAudio = @"C:\Users\victor.moraes\Documents\C# no serviço\Calculadora\Calculadora\bin\Debug\net8.0-windows\rapdovituinho.wav";

                _soundPlayer = new SoundPlayer(caminhoAudio);
                _soundPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tocar o áudio: " + ex.Message);
            }
        }

        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + decimal.Parse(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - decimal.Parse(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * decimal.Parse(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / decimal.Parse(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Resultado.ToString();
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
