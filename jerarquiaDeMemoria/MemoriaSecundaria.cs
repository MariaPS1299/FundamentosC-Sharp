using System;

//Se declara el namespace jerarquiaDeMemoria
namespace jerarquiaDeMemoria
{
    //Se declara la clase hija MemoriaSecundaria
    public class MemoriaSecundaria : Memoria
    {
        public MemoriaSecundaria(int capacidad, int tiempoAcceso)
            : base("Memoria Secundaria", capacidad, tiempoAcceso) { }

        public override void GuardarDato(string dato)
        {
            Console.WriteLine("Guardando datos en la memoria secundaria (Disco).");//Se ampliará el  método en la entrega final
        }

        public override void AccederDato(string dato)
        {
            Console.WriteLine("Accediendo datos desde la memoria secundaria (Disco).");//Se ampliará el  método en la entrega final
        }
    }
   
}