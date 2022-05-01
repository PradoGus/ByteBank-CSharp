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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario pedro = new Funcionario();
            pedro.Nome = "Pedro";
            pedro.CPF = "524.458.645-48";
            pedro.Salario = 2000;

            Diretor leticia = new Diretor();
            leticia.Nome = "Letícia";
            leticia.CPF = "562.487.465-89";
            leticia.Salario = 4000;

            pedro.GetBonificacao();
            leticia.GetBonificacao();

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(leticia);
            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadKey();
        }
    }
}
