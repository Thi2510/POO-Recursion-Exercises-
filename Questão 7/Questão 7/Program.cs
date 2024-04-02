using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_7
{
    internal class Program
    {
        public static int MDC(int x, int y)
        {
            if (x > y)
            {
                return MDC(x - y, y);
            }
            else if (x == y)
            {
                return x;
            }
            else
            {
                return x;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            int x= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int y= int.Parse(Console.ReadLine());
            Console.WriteLine("O MDC desses dois números é " + MDC(x, y));
            Console.ReadLine();
        }
    }
}
