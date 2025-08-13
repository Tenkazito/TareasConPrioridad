# TareasConPrioridad

Caso
Un equipo de estudio necesita organizar sus tareas. Quieren un mini‐sistema que permita registrar, listar, completar y priorizar tareas durante una sesión.

Requerimiento del sistema
A. Estructura de datos de una Tarea con: 
  Título (texto), prioridad (entero 1–5; 1 = alta), estado (texto: “pendiente”/“completada”).
B. Mantener una lista de tareas en memoria.
C. Menú en bucle hasta que el usuario elija salir:
  1. Añadir tarea (validar prioridad 1–5).
  2. Listar todas (orden natural de inserción).
  3. Marcar como completada (por título o índice; validar existencia).
  4. Listar ordenadas por prioridad ascendente.
  5. Eliminar por índice (validar rango).
  6. Resumen: total, pendientes, completadas; porcentaje de avance.
  7. Salir.

D. 	Validaciones mínimas: títulos no vacíos; prioridad dentro de rango; índices válidos.
E.  Regla sencilla extra: si al agregar una tarea con prioridad 1, mostrar “Tarea crítica”.
