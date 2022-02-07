using System;

namespace Course1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta cliente;

            Console.Write("Entre o número da Conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta:");
            String nome = Console.ReadLine();
            Console.Write("Haverá depósito Inicial?(s/n)");
            char op = char.Parse(Console.ReadLine());

            double deposito;

            if (op == 's' || op == 'S')
            {
                Console.Write("Entre o valor do depósito inicial");
                deposito = double.Parse(Console.ReadLine());
                cliente = new Conta(numero, nome, deposito);
            }
            else
            {
                cliente = new Conta(numero, nome);
            }

            Console.WriteLine("Dados da conta:\n"+ cliente);

            Console.Write("Entre um valor para depósito:");
            deposito = double.Parse(Console.ReadLine());
            cliente.Deposito(deposito);

            Console.WriteLine("Dados da conta atualizados:\n" + cliente);

            Console.Write("Entre um valor para Saque:");
            double saque = double.Parse(Console.ReadLine());
            cliente.Saque(saque);

            Console.WriteLine("Dados da conta atualizados:\n" + cliente);


        }
    }
}
