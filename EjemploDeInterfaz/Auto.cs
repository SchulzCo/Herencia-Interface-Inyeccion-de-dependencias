namespace Herencia_Interface_Inyeccion_de_dependencias.EjemploDeInterfaz
{
    public class Auto : IVehiculo
    {
        public string Acelerar()
        {
            return "El auto Acelero"; 
        }

        public string Frenar()
        {
            return "El auto Freno";

            //throw new NotImplementedException(); 
        }
    }
}
