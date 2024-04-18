using System;
using System.Data.SqlClient;

namespace LoginDB.DAL
{
    public class Conexao
    {
        SqlConnection conn = new SqlConnection();

        public Conexao() //estabelece conexao com o banco
        {
            conn.ConnectionString = @"Data Source=RAZANI\SQLEXPRESS;Initial Catalog=Registros;Integrated Security=True;Connect Timeout=30;";//string de conexao
        }

        public SqlConnection Conectar()
        {
            if (conn.State==System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void Desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}

