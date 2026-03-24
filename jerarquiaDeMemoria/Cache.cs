//Se declara el namespace System
using System;

//Se declara el namespace jerarquiaDeMemoria
namespace jerarquiaDeMemoria
{
    //Se declara la clase hija Cache
    public class Cache : Memoria
    {
        public Cache(int capacidad, int tiempoAcceso)
            : base("Cache", capacidad, tiempoAcceso) { }

        public override void GuardarDato(string dato)
        {
            Console.WriteLine("Guardando datos como lo hace la caché.");//Se ampliará el  método en la entrega final
        }

        public override void AccederDato(string dato)
        {
            Console.WriteLine("Accediendo datos desde la caché.");//Se ampliará el  método en la entrega final
        }
    }
}
  