//Declaracion del namespace requeridos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declaracion del namspace del proyecto
//poocc = programacion orientada a objetos con colecciones
namespace poocc
{
    public class Estudiante : Persona
    {
        //Definición y encapsulamiento de la propiedad carrera
        private string Carrera { get; set; }
        //Constructor de la clase Estudiante
        public Estudiante(string nombre, int edad, string cedula, string carrera) : base(nombre, edad, cedula)
        {
            this.Carrera = carrera;
        }
        //Metodos publicos para modificar y obtener la carrera (lo ocupamos porque carrera es private)
        public void SetCarrera(string nuevoNombre)
        {
            this.Carrera = nuevoNombre;
        }
        public string GetCarrera() 
        {
            return this.Carrera;
        }
            
        //Metodo MostrarInfo
        public override void MostrarInfo()
        {
            Console.WriteLine($"Estudiante: {GetNombre()}, Edad: {Edad}, Carrera: {Carrera}, Cedula: {Cedula}");
        }

        // Override: redefinimos el metodo de calcularPago
        public override decimal CalcularPago() 
        { 
            if (Carrera == "Medicina") 
                return 2000; 
            if (Carrera == "Ingeniería") 
                return 1500; 
            return 1200; 
        }
    }
}