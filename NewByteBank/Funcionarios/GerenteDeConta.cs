using NewByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {

        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

    }
}
