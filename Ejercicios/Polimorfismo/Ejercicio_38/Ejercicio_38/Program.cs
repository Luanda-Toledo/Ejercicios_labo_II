using Biblioteca;

namespace Ejercicio_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº38 Guía 2023";

            // Crea una instancia de la clase Sobrescrito
            Sobreescritos sobrecarga = new Sobreescritos();
            // Llama al método ToString sobrescrito y muestra el resultado
            Console.WriteLine(sobrecarga.ToString());
            // Crea una cadena para comparar con el método Equals de la instancia
            string objeto = "¡Este es mi método ToString sobrescrito!";


            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.ReadKey();
        }
    }
}