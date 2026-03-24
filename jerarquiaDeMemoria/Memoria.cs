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
        public int Capacidad { get; set; } // en MB
        public int TiempoAcceso { get; set; } // en ns

        //Se hace el constructor con parametros de las propiedades de la clase Memoria
        public Memoria(string nombre, int capacidad, int tiempoAcceso)
        {
            Nombre = nombre;
            Capacidad = capacidad;
            TiempoAcceso = tiempoAcceso;
        }

        //Se define el Metodo AccederDato() y GuardarDato(), estos van a variar segun el tipo de memoria
        public abstract void GuardarDato(string dato);
        public abstract void AccederDato(string dato);

    }
}
