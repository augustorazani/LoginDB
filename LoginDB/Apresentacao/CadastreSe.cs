using LoginDB.DAL;
using LoginDB.Modelo;
using System;
using System.Windows.Forms;

namespace LoginDB.Apresentacao
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //if (txtSenha.Text.Equals(txtConfSenha.Text) && txtLogin.Text != "" && txtSenha.Text != "")
            //{
            //    if (txtLogin.Text.Length < 4)
            //    {
            //        MessageBox.Show("O usuário deve conter 4 caracteres ou mais.");
            //    }
            //    else if (txtSenha.Text.Length < 4)
            //    {
            //        MessageBox.Show("A senha deve conter 4 caracteres ou mais.");
            //    }
                Controllers controller = new Controllers();
                String mensagem = controller.Cadastrar(txtLogin.Text, txtSenha.Text, txtConfSenha.Text); //envia os dados que o usuario digita através do metodo Cadastrar
                //if (LoginDaoComandos.VerificaLogin.tem == true)
                //{

                //}
                if (controller.tem)//mensagem de sucesso
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else //mensagem de erro
                {
                    MessageBox.Show(controller.mensagem);
                }
                CadastreSe cad = new CadastreSe();
                cad.Close();
                Login login = new Login();
                login.Show();   
        }

            private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBoxSenha.Checked)
                {
                    txtSenha.PasswordChar = '\0';
                    txtConfSenha.PasswordChar = '\0';
                }
                else
                {
                    txtSenha.PasswordChar = '•'; // Caractere de bullet (•)
                    txtConfSenha.PasswordChar = '•';
                }
            }

            private void btnVoltar_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

