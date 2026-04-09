//Se declara el namespace System
using System;

//Se declara el namespace jerarquiaDeMemoria
namespace jerarquiaDeMemoria
{
    //Se declara la clase abstracta Memoria
    public abstract class Memoria
    {
        //Se declaran las propiedades de Memoria
        public string Nombre { get; set; } //Puede ser Registro, Cache, MemoriaPrincipal o MemoriaSecundaria
        public int Capacidad { get; set; } // en bit o MB
        public double TiempoAcceso { get; set; } // en ns
        // Cada memoria guarda un solo dato
        protected string Dato { get; set; }


        //Se hace el constructor con parametros de las propiedades de la clase Memoria
        public Memoria(string nombre, int capacidad, double tiempoAcceso)
        {
            Nombre = nombre;
            Capacidad = capacidad;
            TiempoAcceso = tiempoAcceso;
            Dato = "0x0";
        }

        //Se define el Metodo Leer() y Escribir(), estos van a variar segun el tipo de memoria
        public abstract void Escribir(string dato);
        public abstract void Leer();
        //Metodo para expresar las caracteristicas de cada memoria
        public override string ToString()
        {
            return $"{Nombre} (Capacidad: {Capacidad} MB, Tiempo acceso: {TiempoAcceso} ns)";
        }

        // Método protegido para escribir en el historial
        protected void RegistrarOperacion(string mensaje)
        {
            Console.WriteLine(mensaje);
            Logger.Anotar(mensaje);
        }
    }
}
