using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    internal class Cliente
    {
        string nome;
        string CPF;
        public ContaCorrente conta;
        public Cliente(string nome,string CPF)
        {
            this.nome = nome;
            this.CPF = CPF;
        }
    }
}
