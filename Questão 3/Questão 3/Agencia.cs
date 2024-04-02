using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    internal class Agencia
    {
        private string nome;
        private int numero;
        private int digito;

        public Agencia(string nome, int numero, int digito)
        {
            this.nome = nome;
            this.numero = numero;
            this.digito = digito;
        }

        public int GetNumero()
        {
            return numero;
        }

        public int GetDigito()
        {
            return digito;
        }
    }
}
