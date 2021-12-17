using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            // receba um numero positivo
            // exibe todos os numeros pares entere  0 e o numero digitado

            int final;

            int inicio = 0;

            Console.Write("digite um numero: \t");

            final = Convert.ToInt32(Console.ReadLine());

            while (inicio < final)
            {
                if (inicio % 2 == 0)
                {
                    Console.Write($"{inicio} ");
                }

                inicio = inicio + 2;
            }
        }
    }
}
