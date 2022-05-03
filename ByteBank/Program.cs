using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();


            Console.ReadKey();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Diretor pedro = new Diretor("524.458.645-48");
            pedro.Nome = "Pedro";

            Designer roberta = new Designer("524.458.645-48");
            pedro.Nome = "Roberta";

            GerenteDeConta gustavo = new GerenteDeConta("524.458.645-48");
            pedro.Nome = "Gustavo";

            Auxiliar camila = new Auxiliar("524.458.645-48");
            pedro.Nome = "Camila";

            gerenciador.Registrar(camila);
            gerenciador.Registrar(gustavo);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(pedro);

            Console.WriteLine("Total de bonificação: " + gerenciador.GetTotalBonificacao());
        }
    }
}
