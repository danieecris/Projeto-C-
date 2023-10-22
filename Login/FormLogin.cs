using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace programacao.visual.aula.login.calculadora.Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbVerSenha_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbVerSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true ;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "admin";



            if (txtUsuario.Text == usuario && txtSenha.Text == senha)
            {
                var formulario = new FormPrincipal();
                formulario.Show();
                MessageBox.Show("Sala acessada");

            }
            else
            {

                MessageBox.Show("Login ou senha incorretos");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza de que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        }
    }
