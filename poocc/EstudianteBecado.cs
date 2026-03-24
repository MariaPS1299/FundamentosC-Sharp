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
    public class EstudianteBecado : Estudiante
    {
        //Definición y encapsulamiento de la propiedad TipoBeca
        public string TipoBeca { get; set; }

        // Constructor con parámetros
        public EstudianteBecado(string nombre, int edad, string cedula, string carrera, string tipoBeca)
            : base(nombre, edad, cedula, carrera)
        {
            this.TipoBeca = tipoBeca;
        }
        // Polimorfismo: redefinimos MostrarInfo
        public override void MostrarInfo()
        {
            Console.WriteLine($"Estudiante: {this.GetNombre()}, Edad: {Edad}, Carrera: {GetCarrera()}, Cedula: {Cedula}, Beca: {TipoBeca}");
        }
        // Override: redefinimos otra vez
        public override decimal CalcularPago() 
        { 
            decimal pagoBase = base.CalcularPago();
            return pagoBase * 0.5m; // paga la mitad por la beca
        }
    }
}