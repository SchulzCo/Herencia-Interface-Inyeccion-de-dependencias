using Herencia_Interface_Inyeccion_de_dependencias.EjemploDeInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Herencia_Interface_Inyeccion_de_dependencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploInterfazController : ControllerBase
    {
        [HttpGet]
        public string EjemploDeInterfaz() { 
        
            Moto moto = new Moto();
            return moto.Frenar();

            // Auto auto = new Auto();
           // return auto.Frenar();


        }
    }
}
