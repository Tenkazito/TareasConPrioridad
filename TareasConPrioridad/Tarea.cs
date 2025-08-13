using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasConPrioridad
{
    internal class Tarea
    {
        public string tittle { get; set; }
        public int priority { get; set; }
        public bool completed { get; set; }

        public Tarea(string tittle, int priority)
        {
            this.tittle = tittle;
            this.priority = priority;
            this.completed = false;
        }
    }
}
