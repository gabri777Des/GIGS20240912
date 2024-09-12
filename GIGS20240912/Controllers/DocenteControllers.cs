using Microsoft.AspNetCore.Mvc;
using GIGS20240912.Models;

namespace GIGS20240912.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteControllers : ControllerBase
    {
       // Declaración de una lista estática de objetos
       // "Docente" para almacenar docentes.
       static List<Docente> docentes = new List<Docente>();

        // Definición de un método HTTP GET
        // que vuelve una colección de docentes
        [HttpGet]
        public IEnumerable<Docente> Get()
        {
          return docentes;
        }

        // Definición de un método HTTP GET
        // que recibe un ID como parámetro y devuelve un docente específico.
        [HttpGet("{id}")]
        public Docente Get(int id)
        {
            var docente = docentes.FirstOrDefault(d => d.Id == id);
            return docente;
        }

        // Definición de un método HTTP POST
        // para agregar un nuevo docente a la lista.
        [HttpPost]
        public IActionResult Post([FromBody] Docente docente)
        {
            docentes.Add(docente);
            return Ok();
        }
    }
}
