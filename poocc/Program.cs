//Declaracion del namespace requeridos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declaracion del namespace del proyecto
//poocc = programacion orientada a objetos con colecciones
namespace poocc
{
    public class Program
    {
        // Colecciones accesibles
        static List<Persona> personas = new List<Persona>();
        static Queue<Persona> colaAtencion = new Queue<Persona>();
        static Stack<Persona> historialAtendidos = new Stack<Persona>();

        static void Main(string[] args)
        {
            bool salir = false;
            //Se imprime el menu mientras el usuario no salga
            while (!salir)
            {
                Console.WriteLine("\n --- MENÚ DEL ESTUDIANTE ---");
                Console.WriteLine("1. Agregar un estudiante");
                Console.WriteLine("2. Listar los estudiantes actuales");
                Console.WriteLine("3. Buscar estudiante por cédula");
                Console.WriteLine("4. Filtrar estudiante por edad (LINQ)");
                Console.WriteLine("5. Atender estudiante (Queue)");
                Console.WriteLine("6. Registrar estudiante atendido (Stack)");
                Console.WriteLine("7. Salir");
                Console.Write("Ingrese una opción: ");
                string opcion = Console.ReadLine();

                //Se ingresa al switch case para entrar en cada opcion del menu
                switch (opcion)
                {
                    case "1": AgregarEstudiante(); break;
                    case "2": ListarEstudiantes(); break;
                    case "3": BuscarPorCedula(); break;
                    case "4": FiltrarPorEdad(); break;
                    case "5": AtenderEstudiante(); break;
                    case "6": RegistrarAtendido(); break;
                    case "7": salir = true; break;
                    default: Console.WriteLine("Opción no válida. Intente de nuevo."); break;
                }
            }
        }

        // Metodo AgregarEstudiante()
        public static void AgregarEstudiante()
        {
            Console.Write("¿Es un estudiante becado? (s/n): ");
            string esBecado = Console.ReadLine().ToLower();
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la edad del estudiante: ");
            int edad = int.Parse(Console.ReadLine());
            //Se agrega la cedula para poder cumplir con el case 3 del menu
            Console.Write("Ingrese la cedula del estudiante (con 0s, no guiones ni espacios): ");
            string cedula = Console.ReadLine();
            Console.Write("Ingrese la carrera del estudiante: ");
            string carrera = Console.ReadLine();

            Persona nuevo;
            if (esBecado == "s")
            {
                Console.Write("Ingrese el tipo de beca: ");
                string tipoBeca = Console.ReadLine();
                nuevo = new EstudianteBecado(nombre, edad, cedula, carrera, tipoBeca);
            }
            else
            {
                nuevo = new Estudiante(nombre, edad, cedula, carrera);
            }
            //El estudiante se agrega a la lista de personas y a la de atendidas
            personas.Add(nuevo);
            colaAtencion.Enqueue(nuevo);
            Console.WriteLine("Estudiante agregado correctamente.");
        }

        // Metodo ListarEstudiantes() almacenados en la coleccion personas
        public static void ListarEstudiantes()
        {
            if (personas.Count == 0)
            {
                Console.WriteLine("No hay estudiantes registrados.");
                return;
            }
            else
            {
                Console.WriteLine("\n--- LISTA DE ESTUDIANTES ---");
                foreach (Persona p in personas)
                {
                    p.MostrarInfo(); // Se muestra la informacion del Estudiante, ya sea becado o no
                }
            }
        }
        //Metodo BuscarPorCedula(): se solicita la cedula y se busca si coincide con los registros
        public static void BuscarPorCedula()
        {
            Console.Write("Ingrese la cédula del estudiante: ");
            string cedulaBuscada = Console.ReadLine();

            Persona encontrado = personas.FirstOrDefault(p => p.Cedula == cedulaBuscada);

            if (encontrado != null)
            {
                Console.WriteLine("Estudiante encontrado:");
                encontrado.MostrarInfo();
            }
            else
            {
                Console.WriteLine("No se encontró ningún estudiante con esa cédula.");
            }
        }
        //Metodo FiltrarPorEdad(): se solicita la edad en la que se va a filtrar mediante LINQ
        public static void FiltrarPorEdad()
        {
            Console.Write("Ingrese la edad mínima para filtrar: ");
            int edadFiltro = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n--- ESTUDIANTES MAYORES DE {edadFiltro} AÑOS ---");

            var filtrados = personas.Where(p => p.Edad > edadFiltro);

            if (!filtrados.Any())
            {
                Console.WriteLine($"No hay estudiantes mayores de {edadFiltro} años.");
                return;
            }

            foreach (var estudiante in filtrados)
            {
                estudiante.MostrarInfo();
            }
        }
        //Metodo AtenderEstudiante(): se usa el primer estudiante en la cola, una vez atendido, se le hace push a historialAtendidos
        public static void AtenderEstudiante()
        {
            if (colaAtencion.Count == 0)
            {
                Console.WriteLine("No hay estudiantes en la cola de atención.");
                return;
            }

            // Quitamos al primer estudiante de la cola
            Persona atendido = colaAtencion.Dequeue();

            Console.WriteLine("\n--- ATENDIENDO ESTUDIANTE ---");
            atendido.MostrarInfo();

            historialAtendidos.Push(atendido);
            Console.WriteLine("El estudiante ha sido registrado en el historial de atendidos.");

        }
        //Metodo RegistrarAtendido(): Muestra el último elemento de historialAtendidos mediante Peek()
        public static void RegistrarAtendido()
        {
            if (historialAtendidos.Count == 0)
            {
                Console.WriteLine("No hay estudiantes registrados en el historial.");
                return;
            }

            Console.WriteLine("\n--- ÚLTIMO ESTUDIANTE ATENDIDO ---");
            Persona ultimo = historialAtendidos.Peek(); // consulta sin eliminar
            ultimo.MostrarInfo();
        }
    }
}
