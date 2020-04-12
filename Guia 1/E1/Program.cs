using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite la cantidad de numeros");
            n = Int32.Parse(Console.ReadLine());
            int[] vector= new int[n];
            int suma = 0;
            double prome = 0;
            int menor = 10000000;
            int aux;



            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Numero {0}" ,(i+1));
                vector[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1 ; j < n; j++)
                {
                    if(vector[i]< vector[j])
                    {
                        aux=vector[i];
                        vector[i]=vector[j];
                        vector[j]=aux;
                    }
                    
                }
                
            }

            for (int i = 0; i < n; i++)
            {
                suma += vector[i];

                if ( vector[i] < menor )
                {
                    menor = vector[i];
                }
            }

            prome= suma/n;
            Console.WriteLine("La suma :" + suma);
            Console.WriteLine("El promedio es :" + prome);
            Console.WriteLine("El menor elemento es :" + menor);

            Console.WriteLine("Datos Ordenados de Mayor a Menor :");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vector[i]);
            }
        
        }
    }
}
