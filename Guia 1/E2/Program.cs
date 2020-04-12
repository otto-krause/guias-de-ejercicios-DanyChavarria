using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int num2 = 0;
            int suma = 0;
            int cont = 0;
            int menu = 0;
            Console.WriteLine("Ingrese el valor del numero 1 :");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 2 :");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Elija la operacion que desea hacer\nMultiplicacion[1]\nDivision[2]");
            menu = Int32.Parse(Console.ReadLine());

            if (menu == 1)
            {

                for (int i = 0; i < num2; i++)
                {
                    suma+= num;
                    
                }
                Console.WriteLine("El resultado de la Multiplicaion Sucesiva es :" + suma);
            }
            else
            {
                while(num >= num2)
                {
                    cont+=1;
                    num-= num2;
                }
                Console.WriteLine("El resultado de la Division Sucesiva es :" + cont);
                Console.WriteLine("El resto de la Division es :" +num);
            }   
        }
    }
}
