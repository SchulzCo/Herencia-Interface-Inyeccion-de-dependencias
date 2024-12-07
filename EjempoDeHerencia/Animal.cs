namespace Herencia_Interface_Inyeccion_de_dependencias.EjemploDeHerencia
{
    public class Animal
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
    }
}
