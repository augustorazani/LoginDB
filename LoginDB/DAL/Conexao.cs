using System;
using System.Data.SqlClient;

namespace LoginDB.DAL
{
    internal class Conexao
    {
        private SqlConnection conn;

        public Conexao() //estabelece conexao com o banco
        {
            conn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");//string de conexao
            conn.Open();
        }

        public void InserirDados(string idLogin, string nome, string senha)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO autenticacao(IdLogin, Nome, Senha) VALUES(@IdLogin, @Nome, @Senha)", conn);
            cmd.Parameters.AddWithValue("@IdLogin", idLogin);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Senha", senha);
            cmd.ExecuteNonQuery();
        }
    }
}
