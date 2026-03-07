using System;

//sgar significa Sistema de Gestion de Animales en un Refugio
namespace sgar
{
    //Clase publica abstracta Animal
    public abstract class Animal
    {
        //Encapsulamiento de las propiedades Nombre y Edad
        private string Nombre { get; set;}
        private int Edad { get; set;}
        
        //Constructor con parametros
        public Animal(string nombre, int edad)
        {
            if (edad <= 0)
            {
                throw new ArgumentException($"La edad de {nombre} debe ser mayor que 0");

            }
            else
            {
                Console.WriteLine($"La edad de {nombre} es válida y es {edad} anios");
            }
            this.Nombre = nombre;
            this.Edad = edad;
        }
        //Metodo abstracto para emitir sonido
        public abstract void EmitirSonido();
    }
}