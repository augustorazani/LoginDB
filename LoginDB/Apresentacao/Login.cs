using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using LoginDB.Apresentacao;
using LoginDB.Modelo;

namespace LoginDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            Text.ToString();
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '•'; // Caractere de bullet (•)
            }
        }

        private void lkLbCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastreSe cad = new CadastreSe(); //instancia o formulario de cadastro
            cad.Show(); //apresenta o form na tela
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtSenha.Text = "";
            txtUser.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Controllers controllers = new Controllers();
            controllers.Acessar(txtUser.Text, txtSenha.Text); //envia os dados que o usuario digita através do metodo Acessar
            if (controllers.mensagem.Equals(""))
            {
                if (controllers.tem)
                {
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bv = new BemVindo();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controllers.mensagem); //caso haja mensagem com erro, irá exibir na tela
            }
        }
    }
}
