using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasConPrioridad
{
    internal class Opciones
    {
        private List<Tarea> tareas;

        public Opciones()
        {
            tareas = new List<Tarea>();
        }

        public void AñadirTarea(string titulo, int prioridad)
        {
            Tarea nuevaTarea = new Tarea(titulo, prioridad);
            tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea añadida correctamente.");
        }

        public void VerTareas()
        {
            int count = 1;
            if (tareas.Count == 0)
            {
                Console.WriteLine("\nNo hay tareas disponibles.");
                return;
            }

            foreach (var tarea in tareas)
            {
                Console.WriteLine($"\nTítulo: {tarea.tittle} \nId: {count} \nPrioridad: {tarea.priority} {(tarea.priority == 1 ? " --- Tarea Critica" : "")} \nCompletada: {(tarea.completed ? "Completada" : "Pendiente")}\n");
                count++;
            }
        }
        private void VerTareas(List<Tarea> listaTareas)
        {
            int count = 1;
            if (listaTareas.Count == 0)
            {
                Console.WriteLine("\nNo hay tareas disponibles.");
                return;
            }

            foreach (var tarea in listaTareas)
            {
                Console.WriteLine($"\nTítulo: {tarea.tittle} \nId: {count} \nPrioridad: {tarea.priority} {(tarea.priority == 1 ? " --- Tarea Critica" : "")} \nCompletada: {(tarea.completed ? "Completada" : "Pendiente")}\n");
            }
        }

        public void CompletarTarea(int index)
        {
            index--;
            if (index < 0 || index >= tareas.Count)
            {
                Console.WriteLine("Índice de tarea no válido.");
                return;
            }

            tareas[index].completed = true;
            Console.WriteLine("Tarea marcada como completada.");
        }

        public void CompletarTarea(string tittle) {
            Tarea tarea = tareas.Find(t => t.tittle == tittle);
            if (tarea != null)
            {
                tarea.completed = true;
                Console.WriteLine($"\nTarea '{tittle}' marcada como completada correctamente.");
            }
            else
            {
                Console.WriteLine($"\nNo se encontró ninguna tarea con el título '{tittle}'.");
            }
        }

        public void VerTareasOrdenadasPorPrioridad()
        {
            var tareasOrdenadas = tareas.OrderBy(t => t.priority).ToList();
            VerTareas(tareasOrdenadas);
        }

        public void EliminarTarea(int index)
        {
            index--;
            if (index < 0 || index >= tareas.Count)
            {
                Console.WriteLine("Índice de tarea no válido.");
                return;
            }

            tareas.RemoveAt(index);
            Console.WriteLine("Tarea eliminada correctamente.");
        }

        public void Resumen()
        {
            int totalTareas = tareas.Count;
            int completadas = tareas.Count(t => t.completed);
            int pendientes = totalTareas - completadas;
            int total = completadas + pendientes;

            if (total == 0) {
                Console.WriteLine("No hay tareas para mostrar el resumen.");
                return;
            }

            Console.WriteLine($"Total de Tareas: {totalTareas}");
            Console.WriteLine($"Completadas: {completadas}");
            Console.WriteLine($"Pendientes: {pendientes}");
            Console.WriteLine($"Porcentaje de avance: {(float)completadas / total * 100}%");
        }
    }
}
