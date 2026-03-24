using System;

//Se declara el namespace jerarquiaDeMemoria
namespace jerarquiaDeMemoria
{
    //Se declara la clase hija MemoriaPrincipal
    public class MemoriaPrincipal : Memoria
    {
        public MemoriaPrincipal(int capacidad, int tiempoAcceso)
            : base("Memoria Principal", capacidad, tiempoAcceso) { }

        public override void GuardarDato(string dato)
        {
            Console.WriteLine("Guardando datos en la memoria principal.");//Se ampliará el  método en la entrega final
        }

        public override void AccederDato(string dato)
        {
            Console.WriteLine("Accediendo datos desde la memoria principal.");//Se ampliará el  método en la entrega final
        }
    }
}