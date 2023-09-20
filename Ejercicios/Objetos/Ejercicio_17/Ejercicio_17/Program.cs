using Biblioteca;

namespace Ejercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Guardamos el color original de la consola, para poder restaurarlo al final del programa.
            ConsoleColor colorOriginalDeLaConsola = Console.ForegroundColor; 
            // Guardamos el resultado de la accion de pintar.
            string dibujo;

            //E - G - H

            // Creamos boligrafos con sus valores iniciales
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine("Bolígrafo Azul:");
            // Cambiamos el color de la fuente de la consola a Azul
            Console.ForegroundColor = boligrafoAzul.GetColor();
            // Pintamos diez asteriscos
            boligrafoAzul.Pintar(10, out dibujo);
            Console.WriteLine(dibujo);
            // Imprimimos el valor actual de tinta que le queda al boligrafo azul en consola
            Console.WriteLine($"El nivel de tinta del boligrafo azul es de {boligrafoAzul.GetTinta()}");
            Console.ForegroundColor = colorOriginalDeLaConsola;

            Console.WriteLine("\nBolígrafo Rojo:");
            Console.ForegroundColor = boligrafoRojo.GetColor();
            boligrafoRojo.Pintar(15, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"El nivel de tinta del bolígrafo rojo es de {boligrafoRojo.GetTinta()}");


            // Restauramos el color original de la fuente en la consola
            Console.ForegroundColor = colorOriginalDeLaConsola;
            Console.ReadKey();

        }
    }
}