using Dapper;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace LoginDB.DAL
{
    public class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = ""; //se retornar vazia = tudo ok, sem erros
        private SqlCommand cmd = new SqlCommand();
        private Conexao conn = new Conexao();

        #region Métodos
        public bool VerificaLogin(string nome, string senha) // existe login no banco v ou f
        {
            try
            {
                var sql = @"SELECT * FROM autenticacao WHERE Nome = @Nome AND Senha = @Senha";
                var parametros = new
                {
                    Nome = nome,
                    Senha = senha
                };

                using (var conexao = new SqlConnection(Conexao.Connection))
                {
                    conexao.Open();
                    var result = conexao.Query(sql, parametros);

                    // Verifica se o resultado contém linhas
                    tem = result.Any();
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }
            return tem;
        }


        public String Cadastrar(String nome, String senha, String confSenha)
        {
            //comandos sql para cadastrar user
            tem = false;
            if (senha.Equals(confSenha) && nome != "" && senha != "")

                if (nome.Length < 4)
                {
                    MessageBox.Show("O usuário deve conter 4 caracteres ou mais.");
                }
                else if (senha.Length < 4)
                {
                    MessageBox.Show("A senha deve conter 4 caracteres ou mais.");
                }
                else
                {
                    cmd.CommandText = "insert into autenticacao values (@nome, @senha)";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    try
                    {
                        Conexao.Conectar();
                        cmd.ExecuteNonQuery();
                        conn.Desconectar();
                        this.mensagem = "Cadastrado com sucesso!";
                        tem = true;
                    }
                    catch (SqlException)
                    {
                        this.mensagem = "Erro com o Banco de Dados!";
                    }
                }
            else
            {
                this.mensagem = "Verifique os dados inseridos";
            }
            return mensagem;

            #endregion
        }
    }
}