using NewByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }


    }
}
