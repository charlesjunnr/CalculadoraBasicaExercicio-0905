using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace CalculadoraBasicaExercicio_0905
{
    public partial class Calculadora : Form
    {
        public bool primeiroNumero = true;

        Operacao operacao;

        string operacaoSelecionada = "";

        List<string> numerosDigitados = new List<string>();

        List<string> numerosDigitados2 = new List<string>();

        private string ApresentarNumerosDigitados()
        {
            string numerosTela;

            return $"{numerosTela = String.Join("", numerosDigitados)} {operacaoSelecionada} {numerosTela = String.Join("", numerosDigitados2)}";

        }

        public Calculadora()
        {
            InitializeComponent();
        }

        private void ValidarPrimeiroNumero(string numeroDigitado)
        {
            if (primeiroNumero == true)
            {
                numerosDigitados.Add(numeroDigitado);
            }
            else
            {
                numerosDigitados2.Add(numeroDigitado);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtValor.Text = 1.ToString();

            string numeroDigitado = txtValor.Text;

            ValidarPrimeiroNumero(numeroDigitado);

            txtValor.Text = ApresentarNumerosDigitados();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtValor.Text = 4.ToString();

            string numeroDigitado = txtValor.Text;

            ValidarPrimeiroNumero(numeroDigitado);

            txtValor.Text = ApresentarNumerosDigitados();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = "÷";

            operacao = Numero.Dividir;

            primeiroNumero = false;

            txtValor.Text = ApresentarNumerosDigitados();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = "x";

            operacao = Numero.Multiplicar;

            primeiroNumero = false;

            txtValor.Text = ApresentarNumerosDigitados();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtValor.Text = 0.ToString();

            string numeroDigitado = txtValor.Text;

            ValidarPrimeiroNumero(numeroDigitado);

            txtValor.Text = ApresentarNumerosDigitados();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = "+";

            operacao = Numero.Somar;

            primeiroNumero = false;

            txtValor.Text = ApresentarNumerosDigitados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtValor.Text = 2.ToString();

            string numeroDigitado = txtValor.Text;

            ValidarPrimeiroNumero(numeroDigitado);

            txtValor.Text = ApresentarNumerosDigitados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtValor.Text = 3.ToString();

            string numeroDigitado = txtValor.Text;

            ValidarPrimeiroNumero(numeroDigitado);

            txtValor.Text = ApresentarNumerosDigitados();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtValor.Text = 5.ToString();

            string numeroDigitado = txtValor.Text;

            ValidarPrimeiroNumero(numeroDigitado);

            txtValor.Text = ApresentarNumerosDigitados();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtValor.Text = 6.ToString();

            string numeroDigitado = txtValor.Text;

            ValidarPrimeiroNumero(numeroDigitado);

            txtValor.Text = ApresentarNumerosDigitados();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtValor.Text = 7.ToString();

            string numeroDigitado = txtValor.Text;

            ValidarPrimeiroNumero(numeroDigitado);

            txtValor.Text = ApresentarNumerosDigitados();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtValor.Text = 8.ToString();

            string numeroDigitado = txtValor.Text;

            ValidarPrimeiroNumero(numeroDigitado);

            txtValor.Text = ApresentarNumerosDigitados();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtValor.Text = 9.ToString();

            string numeroDigitado = txtValor.Text;

            ValidarPrimeiroNumero(numeroDigitado);

            txtValor.Text = ApresentarNumerosDigitados();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtValor.Text = ",";

            string numeroDigitado = txtValor.Text;

            ValidarPrimeiroNumero(numeroDigitado);

            txtValor.Text = ApresentarNumerosDigitados();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string numeroSemConversao = String.Join("", numerosDigitados);

            decimal valor1 = decimal.Parse(numeroSemConversao);

            string numeroSemConversao2 = String.Join("", numerosDigitados2);

            decimal valor2 = decimal.Parse(numeroSemConversao2);

            if (valor2 == 0 && operacao == Numero.Dividir)
            {
                MessageBox.Show("Não é possível dividir por zero!");
                ResetarValores();
            }
            else
            {
                txtValor.Text = Calcular(valor1, valor2, operacao).ToString();
            }
        }
        public static decimal Calcular(decimal x, decimal y, Operacao operacao)
        {
            return operacao(x, y);
        }
        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = "-";

            operacao = Numero.Subtrair;

            primeiroNumero = false;

            txtValor.Text = ApresentarNumerosDigitados();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ResetarValores();
        }

        private void ResetarValores()
        {
            txtValor.Clear();
            numerosDigitados.Clear();
            numerosDigitados2.Clear();
            primeiroNumero = true;
            operacaoSelecionada = "";
        }
    }
}