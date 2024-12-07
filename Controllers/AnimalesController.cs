using Microsoft.AspNetCore.Mvc;
using Herencia_Interface_Inyeccion_de_dependencias.EjemploDeHerencia;

namespace Herencia_Interface_Inyeccion_de_dependencias.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalesController : ControllerBase
    {
        [HttpGet("perro")]
        public IActionResult GetPerro()
        {
            Perro miPerro = new Perro
            {
                Nombre = "Milo",
                Edad = 3
            };
            var result = new
            {
                Comer = miPerro.Comer(),
                Dormir = miPerro.Dormir(),
                Ladrar = miPerro.Ladrar()
            };
            return Ok(result);
        }

        [HttpGet("gato")]
        public IActionResult GetGato()
        {
            Gato miGato = new Gato
            {
                Nombre = "Cleo",
                Edad = 2
            };
            var result = new
            {
                Comer = miGato.Comer(),
                Dormir = miGato.Dormir(),
                Maullar = miGato.Maullar()
            };
            return Ok(result);
        }
    }
}
