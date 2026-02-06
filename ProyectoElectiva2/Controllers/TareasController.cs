using Microsoft.AspNetCore.Mvc;
using ProyectoElectiva2.Interface;
using ProyectoElectiva2.Models;

namespace ProyectoElectiva2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TareasController : ControllerBase
    {
        private readonly ITaskServices _taskServices;

        public TareasController(ITaskServices taskServices)
        {
            _taskServices = taskServices;
        }

        // POST api/tareas
        [HttpPost]
        public IActionResult CrearTarea([FromBody] TaskModel model)
        {
            if (model == null)
                return BadRequest();

            if (string.IsNullOrEmpty(model.Title))
                return BadRequest("El título es obligatorio");

            _taskServices.CrearTarea(model);
            return Ok("Tarea creada exitosamente.");
        }

        // GET api/tareas
        [HttpGet]
        public IActionResult ObtenerTareas()
        {
            var tareas = _taskServices.ObtenerTareas();
            return Ok(tareas);
        }

        // PUT api/tareas/{id}/completar
        [HttpPut("{id}/completar")]
        public IActionResult CompletarTarea(int id)
        {
            _taskServices.CompletarTarea(id);
            return Ok("Tarea Actualizada.");
        }

        // DELETE api/tareas/{id}
        [HttpDelete("{id}")]
        public IActionResult ElimiarTarea(int id)
        {
            _taskServices.ElimiarTarea(id);
            return Ok("Tarea Eliminada.");
        }

        [HttpPut("{id}")]
        public IActionResult ModificarTarea(int id, [FromBody] TaskModel model)
        {
            if (model == null)
                return BadRequest();

            var existing = _taskServices.TraerTarea(id);
            if (existing == null)
                return NotFound();

            // Only update title and description per requirement
            var updated = new TaskModel
            {
                Id = id,
                Title = model.Title ?? existing.Title,
                Description = model.Description ?? existing.Description,
                IsCompleted = existing.IsCompleted
            };

            _taskServices.ModificarTarea(updated);
            return Ok("Tarea Editada.");
        }

        private class CrearTareaRequest
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }
    }
}
