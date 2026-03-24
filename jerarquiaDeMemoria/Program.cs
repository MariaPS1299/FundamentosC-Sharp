//Se declara el namespace System
using System;

namespace jerarquiaDeMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Colección de memorias
            List<Memoria> memorias = new List<Memoria>();

            // Por ahora solo agregamos Registro como ejemplo
            Registro registro = new Registro(3, 1); // capacidad 3, acceso 1 ns
            memorias.Add(registro);

            int opcion;
            do
            {
                Console.WriteLine("\n--- Simulador de Jerarquía de Memoria ---");
                // Console.WriteLine("1. Guardar dato en Registro");
                // Console.WriteLine("2. Acceder dato en Registro");
                // Console.WriteLine("3. Guardar dato en Cache");
                // Console.WriteLine("4. Acceder dato en Cache");
                // Console.WriteLine("5. Guardar dato en MemoriaPrincipal");
                // Console.WriteLine("6. Acceder dato en MemoriaPrincipal");
                // Console.WriteLine("7. Guardar dato en MemoriaSecundaria");
                // Console.WriteLine("8. Acceder dato en MemoriaSecundaria");
                Console.WriteLine("9. Ver todas las memorias disponibles");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Console.Write("Ingrese dato: ");
                        // string dato = Console.ReadLine();
                        // registro.GuardarDato(dato);
                        break;

                    case 2:
                        // Console.Write("Ingrese dato: ");
                        // string buscar = Console.ReadLine();
                        // Console.WriteLine(registro.AccederDato(buscar));
                        break;

                    case 9:
                        Console.WriteLine("Memorias disponibles en el simulador:");
                        foreach (var mem in memorias)
                            Console.WriteLine($"- {mem.Nombre} (Capacidad: {mem.Capacidad}, Tiempo acceso: {mem.TiempoAcceso} ns)");
                        break;
                }

            } while (opcion != 0);
        }
    }
}
