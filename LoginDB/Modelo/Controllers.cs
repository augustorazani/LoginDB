using LoginDB.DAL;
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
namespace LoginDB.Modelo
{
    public class Controllers
    {
        public bool tem;
        public String mensagem = "";
        public bool Acessar(String nome, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.VerificaLogin(nome, senha); //comunica com a classe LDC, passa os parâmetros no método e obtem resposta v ou f
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem; //variavel mensagem dessa classe recebe mensagem de erro da classe que comunica com o banco
            }
            return tem;
        }

        public String Cadastrar(String nome, String senha, String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.Cadastrar(nome, senha, confSenha); //para inserir, deve ser utilizada string
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
