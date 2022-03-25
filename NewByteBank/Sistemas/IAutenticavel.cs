using NewByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewByteBank.Sistemas
{
    public interface IAutenticavel 
    {
        string Nome { get; set; }
        bool Autenticar(string senha);

        /* Interface cria um contrato com quem implementa Autenticavel. Esse contrato consiste na obrigação
         * de implementar os métodos que estão sinalizados na interface*/
        
    }
}
