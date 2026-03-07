using System;

//sgar significa Sistema de Gestion de Animales en un Refugio
namespace sgar
{
    //Clase heredada Perro
    public class Perro : Animal
    {
        public Perro(string nombre, int edad) : base(nombre, edad)
        {
        }
        public override void EmitirSonido()
        {
            Console.WriteLine($"El perro hace ¡Guau!");
        }
    }
}