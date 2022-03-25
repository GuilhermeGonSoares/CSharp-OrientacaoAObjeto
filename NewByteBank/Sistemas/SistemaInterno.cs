using NewByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel usuario, string senha)
        {
            bool usuarioAutenticado = usuario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine($"Bem-vindo ao sistema {usuario.Nome}!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }

    }
}
