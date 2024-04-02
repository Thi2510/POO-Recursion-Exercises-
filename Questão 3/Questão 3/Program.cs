using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    internal class CaixaEletronico
    {
        static void Main(string[] args)
        {
            Agencia agencia = new Agencia("Agencia B", 789, 5);
            ContaCorrente conta = new ContaCorrente(1234, 4, agencia);
            conta.Depositar(150.0);
            Cliente cliente = new Cliente("Ademar da Silva", "123231518-12)");
            cliente.conta = conta;
            Console.WriteLine("Saldo inicial: " + cliente.conta.ConsultarSaldo());
            cliente.conta.Sacar(140.0);
            cliente.conta.ConsultarSaldo();
            cliente.conta.Sacar(200.0);
            cliente.conta.ConsultarSaldo();
            conta.Depositar(25.45);
            cliente.conta.ConsultarSaldo();
            Console.ReadKey();

         }
    }
}
