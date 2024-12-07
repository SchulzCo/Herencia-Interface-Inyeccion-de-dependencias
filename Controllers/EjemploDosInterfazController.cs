using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Herencia_Interface_Inyeccion_de_dependencias.EjemploDeInterfaz;

namespace Herencia_Interface_Inyeccion_de_dependencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploDosInterfazController : ControllerBase
    {
        [HttpGet]
        public string EjemploDeInterfazDos()
        {
            EjemploDeInterfaz.Base _base = new Base();


            Auto auto = new Auto();
           return _base.Acelerar(auto);
          

        }
    }
}
      

