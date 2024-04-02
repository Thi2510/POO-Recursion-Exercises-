using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    internal class CartaoValeTransporte
    {
        int numero;
        double saldo;
        bool bloqueado;

        public CartaoValeTransporte(int numero,double saldo)
        {
            this.numero = numero;
            this.saldo = saldo;
            bloqueado = false;
        }
        public void Recarregar(double credito)
        {
            if(bloqueado!=true)
            {
                if(credito > 0)
                {
                    saldo = saldo + credito;
                }
            }
        }
        public double Saldo
        {
        get { return saldo; }
        }
        public void PagarPassagem(double tarifa)
        {
            if(bloqueado=!true)
            {
                if (saldo >= tarifa)
                {
                    saldo=saldo-tarifa;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }
        }
        public void Bloquear()
        {
            bloqueado=true;
            Console.WriteLine("Cartão bloqueado");
        }
    }
}
