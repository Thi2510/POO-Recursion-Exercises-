using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    internal class Program
    {
        public static int SomaIntervalos(int m,int n)
        {
            int resp;
            if (m==n)
            {
                return m;
            }
           
            else
            {
                resp = m+ SomaIntervalos(m+1 , n);
               
            }
            return resp;
        }
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Digite os numeros");
            int primeiro=int.Parse(Console.ReadLine());
            int segundo=int.Parse(Console.ReadLine());
            result=SomaIntervalos(primeiro, segundo);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
