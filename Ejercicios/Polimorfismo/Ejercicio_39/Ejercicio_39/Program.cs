using Biblioteca;

namespace Ejercicio_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº38 Guía 2023";

            // Crear una instancia de SobreSobrescrito
            SobreSobrescritos sobreSobrescrito = new SobreSobrescritos();

            // Probar la propiedad abstracta MiPropiedad
            Console.WriteLine("Valor de MiPropiedad: " + sobreSobrescrito.MiPropiedad);

            // Probar el método abstracto MiMetodo
            Console.WriteLine("Valor de MiMetodo: " + sobreSobrescrito.MiMetodo());

            Console.ReadKey();
        }
    }
}