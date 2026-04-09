using System;

//Se declara el namespace jerarquiaDeMemoria
namespace jerarquiaDeMemoria
{
    //Se declara la clase hija MemoriaPrincipal
    public class MemoriaPrincipal : Memoria
    {
        public MemoriaPrincipal(string nombre, int capacidad, double tiempoAcceso)
            : base(nombre, capacidad, tiempoAcceso) { }

        public override void Escribir(string dato)
        {
            Dato = dato;
            RegistrarOperacion($"Dato '{dato}' guardado en {Nombre} (RAM).");
        }

        public override void Leer()
        {
            RegistrarOperacion($"El contenido actual de {Nombre} es '{Dato}' (Tiempo acceso: {TiempoAcceso} ns).");
        }
        //Polimorfismo en ToString
        public override string ToString()
        {
            return $"{Nombre} (Capacidad: {Capacidad} GB, Tiempo acceso: {TiempoAcceso} ns, Volátil)";
        }
    }
}