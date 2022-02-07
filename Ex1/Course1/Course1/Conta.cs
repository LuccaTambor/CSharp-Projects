using System;
using System.Collections.Generic;
using System.Text;

namespace Course1
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public String Titular { get; private set; }
        public double Saldo { get; private set; }


        public Conta(int numero, String nome)
        {
            Numero = numero;
            Titular = nome;
        }
        
        public Conta(int numero, String nome, double deposito) : this (numero, nome)
        {
            Deposito(deposito);
        }

        public void Deposito (double valor)
        {
            Saldo += valor;
        }

        public void Saque (double valor)
        {
            Saldo -= (5 + valor);
        }

        public override String ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo;
        }



    }
}
