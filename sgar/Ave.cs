using System;

//sgar significa Sistema de Gestion de Animales en un Refugio
namespace sgar
{
    //Clase heredada Ave
    public class Ave : Animal
    {
        public Ave(string nombre, int edad) : base(nombre, edad)
        {
        }
        public override void EmitirSonido()
        {
            Console.WriteLine("El pato hace ¡Cuac!");
        }
    }
}