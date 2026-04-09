//Se declara los namespaces requeridos
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.IO;

//Se declara el namespace jerarquiaDeMemoria
namespace jerarquiaDeMemoria
{
    //Se declara la clase Program
    class Program
    {
        //Se declara el metodo Main
        static void Main(string[] args)
        {
            try
            {
                //Se solicitan correo y contraseña del usuario
                Console.WriteLine("--- Inicio de Sesión, Jerarquía de Memoria MiniApp ---");
                Console.Write("Ingrese su correo: ");
                string correo = Console.ReadLine();
                Console.Write("Ingrese su contraseña: ");
                string contrasena = LeerContrasena();

                // Se valida que el no correo y contraseña no estén vacíos
                if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrasena))
                {
                    //Se lanza la excepcion
                    throw new ArgumentException("El correo y la contraseña no pueden estar vacíos.");
                }

                // Se valida que se haya utilizado un formato de correo
                try
                {
                    var direccion = new MailAddress(correo);
                }
                catch (FormatException)
                {
                    //Si no cumple con el formato de MailAddress (usuario@dominio.com), se detiene el programa
                    throw new ArgumentException("El correo ingresado no tiene un formato válido.");
                }

                Console.WriteLine("Validación exitosa. Puede continuar.");

                // Método para leer contraseña sin mostrarla explícitamente
                static string LeerContrasena()
                {
                    string contrasena = "";
                    //Captura cada pulsacion del teclado
                    ConsoleKeyInfo tecla;

                    do
                    {
                        tecla = Console.ReadKey(true); // true = no muestra la tecla en pantalla

                        if (tecla.Key != ConsoleKey.Backspace && tecla.Key != ConsoleKey.Enter)
                        {
                            contrasena += tecla.KeyChar;
                            Console.Write("*"); // muestra un asterisco en lugar del carácter real
                        }
                        else if (tecla.Key == ConsoleKey.Backspace && contrasena.Length > 0)
                        {
                            contrasena = contrasena.Substring(0, contrasena.Length - 1);
                            Console.Write("\b \b"); // borra el último asterisco
                        }
                    } while (tecla.Key != ConsoleKey.Enter);

                    Console.WriteLine(); // salto de línea al terminar
                    return contrasena;
                }

                //Si pasa la validación anterior, continúa el programa
                //Se genera una lista de memorias disponibles
                List<Memoria> memorias = new List<Memoria>();

                //Se definen 2 registros, memoria cacheL3, principal y secundaria
                Registro registroPC = new Registro("Program Counter", 32, 0.8, true); // capacidad 32 bits, acceso 0.8 ns, ReadOnly
                Registro acumulador = new Registro("Acumulador", 32, 0.8, false); // capacidad 32 bits, acceso 0.8 ns, Read/Write
                CacheL3 cacheL3 = new CacheL3("Cache L3", 2, 2.5); // 2 MB, 2.5 ns
                MemoriaPrincipal ram = new MemoriaPrincipal("Memoria Principal (RAM)", 16, 100); // 16 GB, 100 ns
                MemoriaSecundaria disco = new MemoriaSecundaria("Disco Duro", 512, 10000000); // 512 GB, 10 ms

                //Se agregan a la lista memoria
                memorias.Add(disco);
                memorias.Add(ram);
                memorias.Add(cacheL3);
                memorias.Add(acumulador);
                memorias.Add(registroPC);

                //Se genera el menu
                int opcion;
                do
                {
                    Console.WriteLine("\n--- Simulador de Jerarquía de Memoria ---");
                    Console.WriteLine("1. Escribir dato en Registro");
                    Console.WriteLine("2. Leer dato en Registro");
                    Console.WriteLine("3. Escribir dato en Cache");
                    Console.WriteLine("4. Leer dato en Cache");
                    Console.WriteLine("5. Escribir dato en MemoriaPrincipal");
                    Console.WriteLine("6. Leer dato en MemoriaPrincipal");
                    Console.WriteLine("7. Escribir dato en MemoriaSecundaria");
                    Console.WriteLine("8. Leer dato en MemoriaSecundaria");
                    Console.WriteLine("9. Ver todas las memorias disponibles por tiempo de acceso");
                    Console.WriteLine("0. Salir");
                    Console.Write("Seleccione una opción: ");

                    //Manejo de excepciones al escoger la opcion del menu
                    try
                    {
                        opcion = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Debe ingresar un número válido.");
                        opcion = -1; // valor inválido para continuar el ciclo
                    }

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Seleccione el registro:");
                            for (int i = 0; i < memorias.Count; i++)
                            {
                                if (memorias[i] is Registro)
                                    Console.WriteLine($"{i + 1}. {memorias[i].Nombre}");
                            }

                            if (int.TryParse(Console.ReadLine(), out int regGuardar) &&
                                regGuardar >= 1 && regGuardar <= memorias.Count)
                            {
                                Console.Write("Ingrese dato a guardar: ");
                                string dato = Console.ReadLine();
                                memorias[regGuardar - 1].Escribir(dato);
                            }
                            else
                            {
                                Console.WriteLine("Selección inválida.");
                            }
                            break;
                        case 2:
                        Console.WriteLine("Seleccione el registro:");
                        for (int i = 0; i < memorias.Count; i++)
                        {
                            if (memorias[i] is Registro)
                                Console.WriteLine($"{i + 1}. {memorias[i].Nombre}");
                        }

                        if (int.TryParse(Console.ReadLine(), out int regAcceder) &&
                            regAcceder >= 1 && regAcceder <= memorias.Count)
                        {
                            memorias[regAcceder - 1].Leer();
                        }
                        else
                        {
                            Console.WriteLine("Selección inválida.");
                        }
                            break;
                        case 3: // Guardar dato en Cache L3
                            Console.Write("Ingrese dato a guardar en Cache L3: ");
                            string datoCache = Console.ReadLine();
                            cacheL3.Escribir(datoCache);
                            break;
                        case 4: // Acceder dato en Cache L3
                            cacheL3.Leer();
                            break;

                        case 5: // Guardar dato en Memoria Principal
                            Console.Write("Ingrese dato a guardar en Memoria Principal: ");
                            string datoRam = Console.ReadLine();
                            foreach (var mem in memorias)
                            {
                                if (mem is MemoriaPrincipal)
                                    mem.Escribir(datoRam);
                            }
                            break;

                        case 6: // Acceder dato en Memoria Principal
                            foreach (var mem in memorias)
                            {
                                if (mem is MemoriaPrincipal)
                                    mem.Leer();
                            }
                            break;
                        
                        case 7: // Guardar dato en Memoria Secundaria
                            Console.Write("Ingrese dato a guardar en Memoria Secundaria: ");
                            string datoDisco = Console.ReadLine();
                            foreach (var mem in memorias)
                            {
                                if (mem is MemoriaSecundaria)
                                    mem.Escribir(datoDisco);
                            }
                            break;

                        case 8: // Acceder dato en Memoria Secundaria
                            foreach (var mem in memorias)
                            {
                                if (mem is MemoriaSecundaria)
                                    mem.Leer();
                            }
                            break;
                        case 9:
                            Console.WriteLine("Memorias disponibles en el simulador:");
                            var ordenadas = memorias.OrderBy(m => m.TiempoAcceso);
                            Console.WriteLine("Desordenadas:");
                            foreach (var mem in memorias)
                                Console.WriteLine($"- {mem}"); // aquí se usa ToString automáticamente
                            Console.WriteLine("Ordenadas por LINQ:");
                            foreach (var mem in ordenadas)
                                Console.WriteLine($"- {mem}"); // aquí se usa ToString automáticamente
                        break;
                    }

                } while (opcion != 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Error de acceso: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("El programa ha finalizado.");
            }
        }
    }
}

//Clase para guardar el archivo con el historial de acciones que se hacen en las memorias
public static class Logger
{
    private static string ruta = "historial_memoria.txt";
    //Metodo Anotar para agregar los datos de la memoria en un archivo de texto
    public static void Anotar(string mensaje)
    {
        //StreamWriter es una clase de System.IO que da flujo de salida a un archivo
        // El "true" indica que se agrega al final del archivo (append)
        using (StreamWriter sw = new StreamWriter(ruta, true))
        {
            sw.WriteLine($"{DateTime.Now}: {mensaje}");
        }
    }
}