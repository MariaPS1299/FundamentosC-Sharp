using System;

namespace poo2
{
    public class Estudiante : Persona
    {
        private string Carrera;
        //Constructor de la clase
        public Estudiante(string carrera) : base()
        {
            this.Carrera = carrera;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine($"Estudiante: {this.GetNombre()}, Edad: {this.Edad}, Carrera: {this.Carrera}");
        }
    }
}