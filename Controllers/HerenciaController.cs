using Herencia_Interface_Inyeccion_de_dependencias.EjempoDeHerencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Herencia_Interface_Inyeccion_de_dependencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerenciaController : ControllerBase
    {
        [HttpGet]
        public string GetVehiculo()
        {
         
          Moto moto = new Moto();
            moto.TipoMoto = "cross";
            moto.Marca = "zanella";
            return moto.Acelerar(); 
        }
    }
}
