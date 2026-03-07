using System;

//sgar significa Sistema de Gestion de Animales en un Refugio
namespace sgar
{
    //Clase heredada Gato
    public class Gato : Animal
    {
        public Gato(string nombre, int edad) : base(nombre, edad)
        {
        }
        public override void EmitirSonido()
        {
            Console.WriteLine("El gato hace ¡Miau!");
        }
    }
}