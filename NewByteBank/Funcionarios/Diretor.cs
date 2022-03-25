using NewByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(string cpf) : base(5000, cpf)
        {

        }


        /* Na classe filha que irá sobrescrever um método da classe mãe é necessário indicar que isso irá ocorrer
       e deixar claro que esse não é um método novo e sim um método sobrescrito. E por isso utilizamos a palavra 'override'*/

        /* Caso queira chamar um método da classe mãe(classe base) devemos utilizar a palavra 'base'*/

        /* Obs: 'base.GetBonificacao()' não é a implementação feita na classe do diretor
         * e sim a implementação da classe mãe, uma vez que utilizamos a palavra reservada 'base' */
        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }
        
        public override void AumentarSalario()
        {
            //this.Salario += this.Salario * 1.1
            this.Salario *= 1.15;
        }

    }
}
