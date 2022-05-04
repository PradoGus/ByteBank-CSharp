using ByteBank.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Contas
{
    public class Conta
    {

        public Cliente Cliente  { get; set; }
        public int Agencia { get; set; }
        public int Codigo { get; set; }
        public double Saldo { get; private set; }

        public Conta (int agencia, int codigo)
        {
            Codigo = codigo;
            Agencia = agencia;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (valor > this.Saldo)
            {
                Console.WriteLine("Sem saldo!");
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }
        }
        public void Transferir(Conta conta, double valor)
        {
            if (conta == this)
            {
                Console.WriteLine("Operação inválida! Informe uma conta diferente.");
            }
            else
            {
                if (Sacar(valor))
                {
                    conta.Depositar(valor);
                    Console.WriteLine("Transferência realizada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Transferência não realizada!");
                }
                
            }
            
        }
    }
}
