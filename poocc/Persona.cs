//Declaracion del namespace requeridos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declaracion del namespace del proyecto
//poocc = programacion orientada a objetos con colecciones
namespace poocc
{
    //Declaracion de la clase abstracta Persona
    public abstract class Persona
    {
        //Definición y encapsulamiento de la propiedad nombre
        private string Nombre;
        //Definición y encapsulamiento de la propiedad edad
        public int Edad { get; set; }
        //Definición y encapsulamiento de la propiedad cedula (para buscar por cedula)
        public string Cedula { get; set; }
        //Constructor con parametros de la clase Persona
        public Persona(string nombre, int edad, string cedula)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Cedula = cedula;
        }

        //Metodos publicos para modificar y obtener el nombre (lo ocupamos porque nombre es private)
        public void SetNombre(string nuevoNombre)
        {
            this.Nombre = nuevoNombre;
        }
        public string GetNombre() 
        {
            return this.Nombre;
        }
        //Metodo MostrarInfo para que las clases hijas requieran utilizarlo
        public abstract void MostrarInfo();

        // Método virtual de calcular pago
        public virtual decimal CalcularPago() 
        { 
            return 1000; // tarifa general
        }

    }
}