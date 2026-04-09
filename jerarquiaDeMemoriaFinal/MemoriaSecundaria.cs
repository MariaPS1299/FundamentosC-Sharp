using System;

//Se declara el namespace jerarquiaDeMemoria
namespace jerarquiaDeMemoria
{
    //Se declara la clase hija MemoriaSecundaria
    public class MemoriaSecundaria : Memoria
    {
        public MemoriaSecundaria(string nombre, int capacidad, double tiempoAcceso)
            : base(nombre, capacidad, tiempoAcceso) { }

        public override void Escribir(string dato)
        {
            Dato = dato;
            RegistrarOperacion($"Dato '{dato}' escrito en {Nombre} (persistente, acceso más lento).");
        }

        public override void Leer()
        {
            RegistrarOperacion($"Leyendo desde {Nombre}: '{Dato}' (Tiempo acceso: {TiempoAcceso} ns, persistente).");
        }
        //Polimorfismo en ToString
        public override string ToString()
        {
            return $"{Nombre} (Capacidad: {Capacidad} GB, Tiempo acceso: {TiempoAcceso} ns, Persistente)";
        }
    }
   
}