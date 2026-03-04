using System;
using poo2;

namespace poo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Comento ya que acabo de instanciar la clase en Persona
            // //Creacion de la instancia mediante el constructor
            // Persona persona1 = new Persona();
            // Console.WriteLine(persona1.GetNombre());

            // persona1.SetNombre("Maria");
            // persona1.Edad = 23;
            // Console.WriteLine("Modificando atributo Nombre...");
            // Console.WriteLine(persona1.GetNombre());
            // Console.WriteLine($"La Persona1 se llama {persona1.GetNombre()}, y tiene {persona1.Edad} anios");

            // Persona persona2 = new Persona();
            // persona2.SetNombre("Jose");
            // persona2.Edad = 30;

            // Console.WriteLine($"La Persona2 se llama {persona2.GetNombre()}, y tiene {persona2.Edad} anios");

            // Persona persona3 = new Persona("Ana", 21);
            // Console.WriteLine($"La Persona3 se llama {persona3.GetNombre()}, y tiene {persona3.Edad} anios");

            Estudiante estudiante1 = new Estudiante("Ingenieria Informatica");
            estudiante1.SetNombre("Jeffry");
            estudiante1.Edad = 35;
            estudiante1.MostrarInfo();
        }
    }
}