//Se declara el namespace System
using System;

//Se declara el namespace jerarquiaDeMemoria
namespace jerarquiaDeMemoria
{
    //Se declara la clase hija Registro
    public class Registro : Memoria
    {
        //Se declara la propiedad nueva SoloLectura (ReadOnly)
        public bool ReadOnly { get; set; }
        //Se hace el constructor de la clase hija Registro
        public Registro(string nombre, int capacidad, double tiempoAcceso, bool readOnly)
        : base(nombre, capacidad, tiempoAcceso)
        {
            ReadOnly = readOnly;
        }
        //Escribir un dato
        public override void Escribir(string dato)
        {
            if (ReadOnly)
            {
                RegistrarOperacion($"El {Nombre} está en modo Solo Lectura. No se puede guardar '{dato}'.");
            }
            else
            {
                // Sobrescribe el dato anterior
                Dato = dato;
                RegistrarOperacion($"Dato '{dato}' guardado en {Nombre}.");
            }
        }
        //Lectura de un dato
        public override void Leer()
        {
            RegistrarOperacion($"El contenido actual de {Nombre} es '{Dato}' (Tiempo acceso: {TiempoAcceso} ns).");
        }
        //Polimorfismo en ToString
        public override string ToString()
        {
            string modo = ReadOnly ? "Solo Lectura" : "Lectura/Escritura";
            return $"{Nombre} (Capacidad: {Capacidad} bits, Tiempo acceso: {TiempoAcceso} ns, Modo: {modo})";
        }

    }

}