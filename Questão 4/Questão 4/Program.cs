using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_4
{
    internal class Program
    {
        public static int Recursao(int a, int n)
        {
            int resp;
            if(n== 0)
            {
                resp = 1;
            }
            else
            {
                resp = a * Recursao(a, n - 1);
                return resp;
            }
            return resp;
        }
        static void Main(string[] args)
        {
            int expoente, numero;
            Console.WriteLine("Digite o número e seu expoente");
            numero= int.Parse(Console.ReadLine());
            expoente=int.Parse(Console.ReadLine());
            Recursao(numero, expoente);
            Console.ReadLine();
        }
    }
}
