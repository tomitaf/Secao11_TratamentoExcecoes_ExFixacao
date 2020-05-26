using System;
using Secao11_TratamentoExcecoes.Entities;
using Secao11_TratamentoExcecoes.Entities.Exceptions;

namespace Secao11_TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryCatchMethod();
            Secao11_ExFixacao1();
        }


        public static void Secao11_ExFixacao1()
        {
            try
            {
                Console.Write("Número do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                Console.Write("Data do Check In: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data do Check Out: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(numeroQuarto, checkIn, checkOut);

                Console.WriteLine(reserva);
                Console.WriteLine();

                Console.Write("Nova data Check In: ");
                DateTime newCheckIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Nova data Check Out: ");
                DateTime newCheckOut = DateTime.Parse(Console.ReadLine());
                reserva.UpdateDate(newCheckIn, newCheckOut);
                Console.WriteLine(reserva);
            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro inesperado");
            }
        }
        public static void TryCatchMethod()
        {
            try
            {
                Console.Write("Digite um número inteiro: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite outro número inteiro: ");
                int n2 = int.Parse(Console.ReadLine());
                // Aqui em nenhum momento é verificado se é uma divisão por zero, se o que foi digita é um caractera, etc.
                int result = n1 / n2;
                Console.WriteLine("n1/n2 = " + result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Erro: divisão por zero ");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro: os valores de entrada devem ser números inteiros ");
            }
        }
    }
}
