namespace Herencia_Interface_Inyeccion_de_dependencias.EjemploDeInterfaz
{
    public class Base
    {
        public string Acelerar(IVehiculo vehiculo) {
            return vehiculo.Acelerar();
        }

    }
}
