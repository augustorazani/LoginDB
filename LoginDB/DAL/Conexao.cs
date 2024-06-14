using System;
using System.Data.SqlClient;
using Dapper;

namespace LoginDB.DAL
{
    public class Conexao
    {
        public static SqlConnection conn;

        public static readonly string Connection = StringConexao();
        public static string StringConexao()
        {
            var conn = @"Data Source=AXYS-NOTE-04\SQLEXPRESS;Initial Catalog=Registros;Integrated Security=True;Connect Timeout=30";
            return conn;
        }
        public static String Conectar()
        {
            try
            {
                conn = new SqlConnection(Connection);
                conn.Open();
                return "Conexão criada";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro conexão: " + ex.Message);
                return "Não conectado";
            }
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