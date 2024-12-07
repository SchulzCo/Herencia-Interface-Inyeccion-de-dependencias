namespace Herencia_Interface_Inyeccion_de_dependencias.EjemploDeInterfaz
{
    public class Moto : IVehiculo
    {
        public string Acelerar()
        {
           return  "La moto Acelero"; 
        }

        public string Frenar()
        {
            return "La moto Freno";
        }
    }
}
