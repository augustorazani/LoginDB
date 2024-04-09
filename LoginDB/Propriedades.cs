using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDB
{
    internal class Propriedades
    {
        public int IdLogin { get; private set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Propriedades(int idLogin, string nome, string senha)
        {
            IdLogin = idLogin;
            Nome = nome;
            Senha = senha;
        }
        public Propriedades()
        {
        }


    }
}
