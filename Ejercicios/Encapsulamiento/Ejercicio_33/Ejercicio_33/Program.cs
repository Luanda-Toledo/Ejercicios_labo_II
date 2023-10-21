using Biblioteca;

namespace Ejercicio_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            libro[0] = "Esta es la primera página.";
            libro[1] = "Esta es la segunda página.";
            libro[3] = "Esta es la cuarta página.";

            Console.WriteLine("Contenido de las páginas:");
            Console.WriteLine($"Página 0: {libro[0]}");
            Console.WriteLine($"Página 1: {libro[1]}");
            Console.WriteLine($"Página 2: {libro[2]}"); // Esta página está en blanco
            Console.WriteLine($"Página 3: {libro[3]}");
        }
    }
}