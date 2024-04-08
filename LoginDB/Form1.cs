using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO autenticacao(IdLogin, Nome, Senha) VALUES( , , ,)");


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
    }
}
