//Se declara el namespace System
using System;

//Se declara el namespace jerarquiaDeMemoria
namespace jerarquiaDeMemoria
{
    //Se declara la clase hija Cache
    public class CacheL3 : Memoria
    {
        public CacheL3(string nombre, int capacidad, double tiempoAcceso)
            : base(nombre, capacidad, tiempoAcceso) { }

        public override void Escribir(string dato)
        {
            Dato = dato;
            RegistrarOperacion($"Dato '{dato}' guardado en {Nombre} (política: write-back).");

        }

        public override void Leer()
        {
           RegistrarOperacion($"El contenido actual de {Nombre} es '{Dato}' (Tiempo acceso: {TiempoAcceso} ns).");
        }
        //Polimorfismo en ToString
        public override string ToString()
        {
            return $"{Nombre} (Capacidad: {Capacidad} MB, Tiempo acceso: {TiempoAcceso} ns)";
        }
    }
}
  