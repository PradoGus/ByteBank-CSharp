using ByteBank.Clientes;
using ByteBank.Excecoes;
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
        public int Agencia { get; }
        public int Codigo { get; }
        public double Saldo { get; private set; }

        public Conta (int agencia, int codigo)
        {
           ChecaAgenciaCodigo(agencia, codigo); 
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito de R$" + valor + " efetuado com sucesso!");
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
        public void ChecaAgenciaCodigo(int agencia, int codigo)
        {
            if ((agencia <= 0) || (codigo <= 0))
            {
                throw new AgenciaZeradaException("Agência ou código não podem ser zerados!");
            }
        }
    }
}
