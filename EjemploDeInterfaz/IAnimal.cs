namespace Herencia_Interface_Inyeccion_de_dependencias.EjemploDeInterfaz
{
    public interface IAnimal
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        string Comer(); string Dormir();
    }
}
