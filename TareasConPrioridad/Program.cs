using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasConPrioridad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opciones opciones = new Opciones();
            bool loop = true;
            do {

                Console.WriteLine("--Menu--");
                Console.WriteLine("1. Añadir Tarea");
                Console.WriteLine("2. Ver Tareas");
                Console.WriteLine("3. Completar Tarea");
                Console.WriteLine("4. Ver tareas ordenadas por prioridad");
                Console.WriteLine("5. Eliminar Tarea");
                Console.WriteLine("6. Resumen");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                switch (int.Parse(Console.ReadLine())) {
                    
                    case 1:
                        Console.Write("\nIngrese el título de la tarea:");
                        string titulo = Console.ReadLine();
                        Console.Write("\nIngrese la prioridad de la tarea (1-5):");
                        int prioridad = int.Parse(Console.ReadLine());
                        if (titulo == "") {
                            Console.WriteLine("\nTítulo no puede estar vacío. Por favor, ingrese un título válido.");
                            break;
                        }
                        if (prioridad < 1 || prioridad > 5)
                        {
                            Console.WriteLine("\nPrioridad no válida, debe ser entre 1 y 5.");
                            break;
                        }
                        opciones.AñadirTarea(titulo, prioridad);
                        break;

                    case 2:
                        opciones.VerTareas();
                        break;

                    case 3:
                        Console.Write("\nBuscar por titulo (1) o por index (2)?: ");
                        int searchOption = int.Parse(Console.ReadLine());
                        if (searchOption == 1) {
                            Console.Write("\nIngrese el título de la tarea a completar:");
                            string tituloCompletar = Console.ReadLine();
                            opciones.CompletarTarea(tituloCompletar);
                        } else if (searchOption == 2) {
                            Console.Write("\nIngrese el índice de la tarea a completar:");
                            int index = int.Parse(Console.ReadLine());
                            opciones.CompletarTarea(index);
                        }else {
                            Console.WriteLine("Opcion invalida.");
                        }
                        break;

                    case 4:
                        opciones.VerTareasOrdenadasPorPrioridad();
                        break;

                    case 5:
                        Console.Write("\nIngrese el índice de la tarea a eliminar:");
                        int indexToDelete = int.Parse(Console.ReadLine());
                        opciones.EliminarTarea(indexToDelete);
                        break;

                    case 6:
                        opciones.Resumen();
                        break;

                    case 7:
                        loop = false;
                        Console.WriteLine("\nSaliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida, por favor intente de nuevo.");
                        break;
                };

                Console.WriteLine("\nContinuar? (Cualquier tecla)");
                Console.ReadKey();
                Console.Clear();

            } while (loop);
        }
    }
}
