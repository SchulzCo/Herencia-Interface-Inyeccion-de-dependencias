using Herencia_Interface_Inyeccion_de_dependencias.EjemploDeInterfaz;
using Microsoft.AspNetCore.Mvc;

namespace Herencia_Interface_Inyeccion_de_dependencias.Controllers
{
 
    public class IAnimalesController : Controller
    {

        private readonly IPerro _perro;
        private readonly IGato _gato;

        public IAnimalesController(IPerro perro, IGato gato)
        {
            _perro = perro;
            _gato = gato;
        }

        [HttpGet("perro")]
        public IActionResult GetPerro()
        {
            _perro.Nombre = "Milo";
            _perro.Edad = 3;
            var result = new
            {
                Comer = _perro.Comer(),
                Dormir = _perro.Dormir(),
                Ladrar = _perro.Ladrar()
            };
            return Ok(result);
        }

        [HttpGet("gato")]
        public IActionResult GetGato()
        {
            _gato.Nombre = "Cleo";
            _gato.Edad = 2;
            var result = new
            {
                Comer = _gato.Comer(),
                Dormir = _gato.Dormir(),
                Maullar = _gato.Maullar()
            };
            return Ok(result);
        }
    }
}
