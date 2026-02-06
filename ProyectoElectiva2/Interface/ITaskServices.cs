using ProyectoElectiva2.Models;

namespace ProyectoElectiva2.Interface
{
    public interface ITaskServices
    {
        void CrearTarea(TaskModel task);
        void CompletarTarea(int taskId);

        TaskModel TraerTarea(int taskId);

        void ModificarTarea(TaskModel task);

        void ElimiarTarea(int taskId);
        List<TaskModel> ObtenerTareas();

    }
}
