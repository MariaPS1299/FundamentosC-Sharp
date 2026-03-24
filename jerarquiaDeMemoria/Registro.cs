//Se declara el namespace System
using System;

//Se declara el namespace jerarquiaDeMemoria
namespace jerarquiaDeMemoria
{
    //Se declara la clase hija Registro
    public class Registro : Memoria
    {
        public Registro(int capacidad, int tiempoAcceso)
        : base("Registro", capacidad, tiempoAcceso)
        {
            
        }
        public override void GuardarDato(string dato)
        {
            Console.WriteLine("Guardando datos como lo hace un registro.");//Se ampliará el  método en la entrega final
        }

        public override void AccederDato(string dato)
        {
            Console.WriteLine("Accediendo datos desde los registros.");//Se ampliará el  método en la entrega final
        }
    }

}