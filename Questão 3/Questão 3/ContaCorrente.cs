using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    internal class ContaCorrente
    {
        private int numero;
        private int digito;
        private Agencia agencia;
        double saldo;

        public ContaCorrente(int numero, int digito, Agencia agencia)
        {
            this.numero = numero;
            this.digito = digito;
            this. digito = digito;
            this. agencia = agencia;
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public int Digito
        {
            get { return digito; }
            set { digito = value; }
        }

        public Agencia Agencia
        {
            get { return agencia; }
            set { agencia = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }



        public void Depositar(double valordeposito)
        {
            saldo = saldo+ valordeposito;
            Console.WriteLine("Seu novo saldo agora é " + saldo);
        }
        public void Sacar(double valorsaque)
        {
            if (saldo >= valorsaque)
            {
                saldo = saldo - valorsaque;
            }
            else 
            {
                Console.WriteLine("Seu saldo é insuficiente"); 
            }
        }

        public string ConsultarSaldo()
        {
            return $"Conta: {numero}-{digito}, Agência: {Numero}-{Digito}, Saldo: R${saldo:F2}";
        }


    }
}
