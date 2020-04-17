using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int cont = 0;

            Program.NumeroPar();
            Program.NumeroPrimo();
        }

        static void NumeroPar()
        {
            int num = 0;

            Console.Write("Ingrese un numero para saber si es par o no: ");
            num = Int32.Parse(Console.ReadLine());

            if ( num % 2 == 0)
            {
                Console.WriteLine("El numero que ingreso es par");
            }
            else
            {
                Console.WriteLine("El numero que ingreso no es par");
            }
        }

        static void NumeroPrimo()
        {
            int num = 0;
            int cont = 0;

            Console.Write("Ingrese un numero para saber si es primo o no: ");
            num = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if ( num % i == 0)
                {
                    
                    cont += 1;
                }
            }

            if (cont > 2)
            {
                Console.WriteLine("El numero que ingreso no es primo");
            }
            else
            {
                Console.WriteLine("El numero que ingreso es primo");
            }

        }
    }
}
