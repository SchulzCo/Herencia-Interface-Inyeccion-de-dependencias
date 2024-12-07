using Microsoft.AspNetCore.Server.IIS.Core;
using System.Reflection.Metadata.Ecma335;

namespace Herencia_Interface_Inyeccion_de_dependencias.EjempoDeHerencia
{
    public class Vehiculo
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public Vehiculo() {
        
        
        }


        public string Acelerar() {

            return "El vehiculo Acelero";
        }


        public string Frenar()
        {

            return "El vehiculo Freno";
        }


    }
}
