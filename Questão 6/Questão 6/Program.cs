using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_6
{
    internal class Program
    {
        public static void Binario(int numdecimal)
        {
            if (numdecimal == 1 || numdecimal == 0)
            {
                Console.Write(numdecimal);
            }
            else
            {
                Binario(numdecimal / 2);
                Console.Write(numdecimal % 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero decimal");
           int numerodec= int.Parse(Console.ReadLine());
            Binario(numerodec);
            Console.ReadLine();
        }
    }
}
