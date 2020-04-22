using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo nuevo = new Triangulo(2,3,5);
            int ladoA = 0;
            int ladoB = 0;
            int ladoC = 0;
            int menu = 0;


            Console.Write("Ingrese cuanto mide el lado A: ");
            ladoA = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese cuanto mide el lado B: ");
            ladoB = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese cuanto mide el lado C: ");
            ladoC = Int32.Parse(Console.ReadLine());
            while (menu != 5)
            {
                Console.Clear();
                Console.WriteLine( " -------- " );
                Console.WriteLine( " | Menú: | " );
                Console.WriteLine( " --------" );
                Console.WriteLine( " |Saber si el triangulo es Escaleno  | 1 " );
                Console.WriteLine( " |Saber si el triangulo es Isosceles | 2 " );
                Console.WriteLine( " |Saber si el triangulo es Equilatero| 3 " );
                Console.WriteLine( " |Saber si el triangulo es Rectangulo| 4");
                Console.WriteLine( " |Salir del programa | 5 \n" );
                Console.Write( "  Elija la opción desea hacer: " );
                menu  =  Int32.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Su triangulo es escaleno- " + nuevo.EsEscaleno (ladoA,ladoB,ladoC));
                        break;
                    case 2:
                        Console.WriteLine("Su triangulo  es Isoscelos- " + nuevo.EsIsosceles (ladoA,ladoB,ladoC));
                        break;
                    case 3:
                        Console.WriteLine("Su triangulo es Equilatero- " + nuevo.EsEquilatero(ladoA,ladoB,ladoC));
                        break;
                    case 4:
                        Console.WriteLine("Su triangulo es Rectangulo-" + nuevo.EsTrianguloRectangulo(ladoA,ladoB,ladoC));
                        break;    
                    case 5:
                        Console.WriteLine("Saliendo del programa ");
                        break;
                    default:
                        Console.WriteLine(" Ingrese un opcion valida");
                        break;
                }
                Console.ReadKey();
            }   
        }
    }
}
