using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_1
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento1= new Estacionamento("Estacionamento 1",20);
            estacionamento1.Estacionar("HKT0098");
            estacionamento1.Estacionar("OLP4290");
            estacionamento1.Estacionar("HJB0495");
            estacionamento1.Estacionar("OWB3904");
            estacionamento1.ExibirOcupacao();
            estacionamento1.BuscarNumVaga("HKT0098");
            estacionamento1.Retirar("HKT0098");
            estacionamento1.ExibirOcupacao();
            estacionamento1.Estacionar("HTP5619");
            estacionamento1.Estacionar("BOL4861");
            estacionamento1.Estacionar("HGT9436");
            estacionamento1.ExibirOcupacao();
            Console.WriteLine(estacionamento1.NumVagasLivres);
            Console.ReadLine();
        }
    }
}
