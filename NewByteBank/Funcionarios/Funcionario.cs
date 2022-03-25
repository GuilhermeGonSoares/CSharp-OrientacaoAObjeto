using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            this.Salario = salario;
            this.CPF = cpf;
            TotalDeFuncionarios++;
        }

        /* Como funcionário é uma classe abstrata provavelmente quero que seus métodos sempre seja sobrescritos 
         * pelas classes que vão herdar Funcionário e para que isso ocorra eu devo utilizar a palavra reservada 'abstract' */


        public abstract void AumentarSalario();



        /*
         Deve permitir que aja uma sobrescrita do método GetBonificacao e para isso dizemos
        que o método é virtual para que seja possível uma classe filha realizar a sobrescrita desse método */
        /* Observação: O método continua existindo na classe Funcionário, ele só permite que seja sobrescrito  */
        public abstract double GetBonificacao();

        //OBSERVAÇÃO: Métodos abstratos só podem existir em classes que foram definidas como abstratas

        /* Virtual x Abstract:
            Virtual: PERMITE QUE A CLASSE HERDEIRA SOBRESCREVA O MÉTODO, CONTUDO AINDA EXISTE A IMPLEMENTAÇÃO 
         DO MÉTODO NA CLASSE MÃE PARA POSTERIOR UTILIZAÇÃO
            Abstract: OBRIGA A CLASSE HERDEIRA A SOBRESCREVER O MÉTODO(MELHOR DIZENDO, A IMPLEMENTAR O MÉTODO) E 
        A IMPLEMETAÇÃO NÃO EXISTE NA CLASSE MÃE
         */
        

    }
}
