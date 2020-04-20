using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Gatito misi = new Gatito("misi",true,40);

            int minu;
            int menu = 0;



            while ( menu != 6)
            {
                Console.Clear();
                Console.WriteLine("--------");
                Console.WriteLine("| Menu:|");
                Console.WriteLine("--------\n");
                Console.WriteLine("|Ver el nombre del gatito|1");
                Console.WriteLine("|Saber si esta vacuando  |2");
                Console.WriteLine("|Hacer jugar al gatito   |3");
                Console.WriteLine("|Darle de comer al gatito|4");
                Console.WriteLine("|Saber si esta saludable |5");
                Console.WriteLine("|Salir del programa      |6");
                Console.Write("Elija la opcion desea hacer: ");
                menu = Int32.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("El nombre el gatito es: " + misi.Nombres());
                        break;
                    case 2:
                        Console.WriteLine("El gato esta vacunado?" + misi.estaVacunado());
                        break;
                    case 3:
                        Console.WriteLine("Ingrese cuantos minutos jugo el gatito");
                        minu = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El gatito es jugando y su enegia es ahora: " + misi.Jugar(minu));
                        break;
                    case 4:
                        Console.WriteLine("El gatito esta comiendo, la energia del gatito es ahora: " + misi.Comer());
                        break;
                    case 5:
                        Console.WriteLine("El gatito esta saludable?" + misi.estaSaludable());
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa");
                        break;                     
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
                Console.ReadKey();
            }    
        }
    }
}
