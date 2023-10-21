using System.Drawing;
using System;
using Biblioteca;

namespace Ejercicio_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación de instancias de Automovil, Moto y Camion
            Automovil automovil = new Automovil(4, 4, Colores.Azul, 5, 4);
            Moto moto = new Moto(2, 0, Colores.Rojo, 250);
            Camion camion = new Camion(8, 2, Colores.Gris, 6, 10000);

            Console.WriteLine("Automóvil:");
            Console.WriteLine($"Ruedas: {automovil.CantidadRuedas}");
            Console.WriteLine($"Puertas: {automovil.CantidadPuertas}");
            Console.WriteLine($"Color: {automovil.Color}");
            Console.WriteLine($"Marchas: {automovil.CantidadMarchas}");
            Console.WriteLine($"Pasajeros: {automovil.CantidadPasajeros}");

            Console.WriteLine("\nMoto:");
            Console.WriteLine($"Ruedas: {moto.CantidadRuedas}");
            Console.WriteLine($"Puertas: {moto.CantidadPuertas}");
            Console.WriteLine($"Color: {moto.Color}");
            Console.WriteLine($"Cilindrada: {moto.Cilindrada}");

            Console.WriteLine("\nCamión:");
            Console.WriteLine($"Ruedas: {camion.CantidadRuedas}");
            Console.WriteLine($"Puertas: {camion.CantidadPuertas}");
            Console.WriteLine($"Color: {camion.Color}");
            Console.WriteLine($"Marchas: {camion.CantidadMarchas}");
            Console.WriteLine($"Peso de Carga: {camion.PesoCarga}");
        }
    }
}