using System;

namespace poo2
{
    public abstract class Persona
    {
        private string Nombre;
        //Encapsulamiento con propiedades
        public int Edad { get; set; }
        //Constructor sin parametros
        public Persona()
        {
            this.Nombre = "Juan";
        }
        //Otra forma de hacer el constructor, con parametros
        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
        public void SetNombre(string nuevoNombre)
        {
            this.Nombre = nuevoNombre;
        }

        public string GetNombre()
        {
            return this.Nombre;
        }
        //Metodo abstracto
        public abstract void MostrarInfo();

    }
}