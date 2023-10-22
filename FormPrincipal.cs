using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace programacao.visual.aula.login.calculadora
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int subtrair = (int)(nmPrimeiroValor.Value - nmSegundoValor.Value);

            txtResultado.Text = subtrair.ToString();



        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int multiplicacao = (int)(nmPrimeiroValor.Value * nmSegundoValor.Value);

            txtResultado.Text = multiplicacao.ToString();


        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int soma = (int)(nmPrimeiroValor.Value + nmSegundoValor.Value);

            txtResultado.Text = soma.ToString();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double dividir = (double)(nmPrimeiroValor.Value / nmSegundoValor.Value);

            txtResultado.Text = dividir.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza de que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); // Cancela o fechamento do formulário
            }
        }
    }
}
