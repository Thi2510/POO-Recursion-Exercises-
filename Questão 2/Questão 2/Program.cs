using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CartaoValeTransporte cartao1 = new CartaoValeTransporte(337540, 100.0);
            CartaoValeTransporte cartao2 = new CartaoValeTransporte(553066, 50.0);
            cartao2.PagarPassagem(5.50);
            Console.WriteLine(cartao2.Saldo);
            cartao1.Recarregar(25.0);
            Console.WriteLine(cartao1.Saldo);
            cartao2.Bloquear();
            cartao2.Recarregar(35.0);
            Console.WriteLine(cartao2.Saldo);
            Console.ReadKey();
        }
    }
}
