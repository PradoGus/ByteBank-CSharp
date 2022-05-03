using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    internal class SistemaInterno
    {

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            if (funcionario.Autenticar(senha))
            {
                Console.WriteLine("Bem vindo!");
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
