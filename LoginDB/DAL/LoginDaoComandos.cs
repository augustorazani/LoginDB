using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginDB.DAL
{
    public class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = ""; //se retornar vazia = tudo ok, sem erros
        private SqlCommand cmd = new SqlCommand();
        private Conexao conn = new Conexao();
        private SqlDataReader dr;

        #region Métodos
        public bool VerificaLogin(String nome, String senha) //existe login no banco v ou f
        {
            //comandos sql para checar no DB
            cmd.CommandText = "select * from autenticacao where nome = @nome and senha = @senha";
            cmd.Parameters.AddWithValue("@nome", nome); //login do parametro do metodo, ira substituir o @login do comando sql
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conn.Conectar();
                dr = cmd.ExecuteReader(); //utilizado para trazer infos do DB, por isso não é utilizado o ExecuteNonQuery
                                          //dr recebera todas as infos buscadas
                if (dr.HasRows)
                {
                    tem = true; //se encontrar linhas no DB, retornara True
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
                        cmd.Connection = conn.Conectar();
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
        }


        #endregion
    }
}