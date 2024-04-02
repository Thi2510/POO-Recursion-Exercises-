using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_8
{
    internal class Program
    {
        public static int Negativos(int[]vet,int N)
        {
            if (N == 0)
            {
                return 0;
            }
            int quant = Negativos(vet,N-1);
            if (vet[N-1] <0) 
            {
                quant++;
            }
            return quant;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do vetor");
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];
            for(int i = 0 ; i < N; i++)
            {
                Console.WriteLine("Digite o número " + i);
                vet[i] = int.Parse(Console.ReadLine());
            }
            Negativos(vet, N);
            int quant = Negativos(vet, N);
            Console.WriteLine("A quantidade de negativos é " + quant);
            Console.ReadLine();
        }
    }
}
