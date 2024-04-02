using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_1
{
    class Estacionamento
    {
        private string nome;
        private int numVagasLivres;
        private string[] vagas;

        public int NumVagasLivres
        {
            get
            {
                return numVagasLivres;
            }
        }
        public Estacionamento(string nome, int numTotalVagas)
        {
            this.nome = nome;
            numVagasLivres = numTotalVagas;
            vagas=new string[numTotalVagas];
        }
        public int Estacionar(string placa)
        {
            if (numVagasLivres == 0)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < vagas.Length; i++)
                {
                    if (vagas[i] == null)
                    {
                        vagas[i] = placa;
                        return i;
                    }
                }
                return -1;
            }
        }
        public int BuscarNumVaga(string placa)
        {
            if (vagas == null)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < vagas.Length; i++)
                {
                    if (vagas[i] == placa)
                    {
                        return i;
                    }

                }
                return -1;
            }
        }
        public void Retirar(string placa)
        {
            if (vagas == null)
            {
                Console.WriteLine("O estacionamento está vazio");
            }
            else
            {
                for (int i = 0; i < vagas.Length; i++)
                {
                    if (vagas[i] == placa)
                    {
                        vagas[i] = null;
                        Console.WriteLine("Retirado o carro " + placa);
                        break;
                    }
                }
            }
        }
        public void ExibirOcupacao()
        {
            if (vagas == null)
            {
                Console.WriteLine("O estacionamento está vazio");
            }
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == null)
                {
                    Console.WriteLine("Vaga " + i + " vazia");
                }
                else
                {
                    Console.WriteLine(vagas[i]);
                    Console.WriteLine(" Vaga número " + i);
                }
            }
        }
    }
}
