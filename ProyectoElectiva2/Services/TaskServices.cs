using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoElectiva2.Interface;
using ProyectoElectiva2.Models;

namespace ProyectoElectiva2.Services
{
    public class TaskServices : ITaskServices
    {
        private static readonly List<TaskModel> _tasks = new();
        private static int _nextId = 1;

        public void CompletarTarea(int taskId)
        {
            var tarea = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (tarea == null)
            {
                Console.WriteLine($"Tarea con Id {taskId} no encontrada.");
                return;
            }

            if (tarea.IsCompleted)
            {
                Console.WriteLine("La tarea ya está completada.");
                return;
            }

            tarea.IsCompleted = true;
        }

        public void CrearTarea(TaskModel task)
        {
            if (task == null) throw new ArgumentNullException(nameof(task));

            task.Id = _nextId++;
            task.Title = task.Title ?? string.Empty;
            task.Description = task.Description ?? string.Empty;
            task.IsCompleted = task.IsCompleted;

            _tasks.Add(task);
        }

        public void ElimiarTarea(int taskId)
        {
            var tarea = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (tarea == null)
            {
                Console.WriteLine($"Tarea con Id {taskId} no encontrada.");
                return;
            }

            _tasks.Remove(tarea);
        }

        public List<TaskModel> ObtenerTareas()
        {
            return _tasks.Select(t => new TaskModel
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                IsCompleted = t.IsCompleted
            }).ToList();
        }

        public TaskModel TraerTarea(int taskId)
        {
            return _tasks.FirstOrDefault(t => t.Id == taskId);
        }

        public void ModificarTarea(TaskModel task)
        {
            if (task == null) throw new ArgumentNullException(nameof(task));

            var existing = _tasks.FirstOrDefault(t => t.Id == task.Id);
            if (existing == null)
            {
                Console.WriteLine($"Tarea con Id {task.Id} no encontrada.");
                return;
            }

            existing.Title = task.Title ?? existing.Title;
            existing.Description = task.Description ?? existing.Description;
            existing.IsCompleted = task.IsCompleted;
        }
    }
}
