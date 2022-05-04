using ByteBank.Clientes;
using ByteBank.Contas;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            Cliente gustavo = new Cliente();
            Cliente ricardo = new Cliente();
            Conta contaGustavo = new Conta(072, 35368);
            Conta contaRicardo = new Conta(072, 3288);
            contaGustavo.Cliente = gustavo;
            contaRicardo.Cliente = ricardo;

            Console.WriteLine("Saldo do Gustavo: " + contaGustavo.Saldo);
            contaGustavo.Depositar(100);
            Console.WriteLine("Saldo do Gustavo: " + contaGustavo.Saldo);
            Console.WriteLine("Saldo do Ricardo: " + contaRicardo.Saldo);
            contaGustavo.Transferir(contaRicardo, 100);
            Console.WriteLine("Saldo do Ricardo: " + contaRicardo.Saldo);
            Console.WriteLine("Saldo do Gustavo: " + contaGustavo.Saldo);



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
