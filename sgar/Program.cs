using System;
using System.Collections.Generic;

namespace sgar
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Colección de animales
            List<Animal> animales = new List<Animal>();

            // Se crean tres animales concretos
            animales.Add(new Perro("Cachorro", 6));
            animales.Add(new Gato("Ana", 2));
            animales.Add(new Ave("Nieve", 1));

            // Recorrer la lista y llamar a EmitirSonido()
            foreach (Animal animal in animales)
            {
                animal.EmitirSonido();
            }
        }
    }
}