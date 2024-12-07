using Herencia_Interface_Inyeccion_de_dependencias.EjemploDeInterfaz;

namespace Herencia_Interface_Inyeccion_de_dependencias.EjemploDeInterfaz
{
    public class Perro : IPerro
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Comer()
        {
            return $"{Nombre} está comiendo.";
        }

        public string Dormir()
        {
            return $"{Nombre} está durmiendo.";
        }

        public string Ladrar()
        {
            return $"{Nombre} está ladrando.";
        }
    }
}