namespace Herencia_Interface_Inyeccion_de_dependencias.EjemploDeHerencia
{
    public class Perro : Animal
    {
        public string Ladrar()
        {
            return $"{Nombre} está ladrando.";
        }
    }
}
