using System;
using System.ComponentModel;

//el namespace es para encapsular todo dentro de una misma estructura
namespace bucles
{
    internal class Bucles
    {
        static void Main(string [] args)
        {
            //for
            for(int i = 1; i <= 50; i++)
            {
                if(i == 25)
                {
                    break;
                }
                
                if (i % 5 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //foreach
            List<string> nombres = new List<string>() {"Ana", "Luis", "María", "Pedro"};

            foreach (string nombre in nombres)
            {
                if(nombre == "Ana")
                {
                    continue;
                }
                Console.WriteLine("Hola, " + nombre);
            }

            //while
            int numeroP;
            while(true)
            {
                Console.WriteLine("Ingrese un número positivo:");
                numeroP = int.Parse(Console.ReadLine());
                if(numeroP <= 0 | numeroP > 100)
                {
                    break;
                }
            }

            //dowhile
            //Nota importante: Voy a mostrar los números pares o 
            //impares hasta el 10, para no alargar la salida.
            int seleccion;
            do
            {
                Console.WriteLine("Selecciona una opcion del 1 al 3");
                Console.WriteLine("1. Mostrar números pares");
                Console.WriteLine("2. Mostrar números impares");
                Console.WriteLine("3. Salir");

                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("Números pares del 1 al 10:");
                        for (int i = 1; i <= 10; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Números impares del 1 al 10:");
                        for (int i = 1; i <= 10; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine();

            } while (seleccion != 3);
        }
    }
}