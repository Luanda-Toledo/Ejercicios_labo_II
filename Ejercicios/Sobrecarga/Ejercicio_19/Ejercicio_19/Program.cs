using Biblioteca;

namespace Ejercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear dos objetos Sumador
            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador(5);

            // Probar los métodos Sumar
            long resultadoSumaLong = sumador1.Sumar(10, 20);
            string resultadoConcatenacion = sumador2.Sumar("Hola, ", "mundo");

            Console.WriteLine("Resultado de la suma de long: " + resultadoSumaLong);
            Console.WriteLine("Resultado de la concatenación de cadenas: " + resultadoConcatenacion);

            // Probar la conversión explícita
            int cantidadSumas1 = (int)sumador1;
            int cantidadSumas2 = (int)sumador2;

            Console.WriteLine("Cantidad de sumas en sumador1: " + cantidadSumas1);
            Console.WriteLine("Cantidad de sumas en sumador2: " + cantidadSumas2);

            // Probar la sobrecarga del operador +
            long sumaDeCantidadSumas = sumador1 + sumador2;
            Console.WriteLine("Suma de cantidadSumas: " + sumaDeCantidadSumas);

            // Probar la sobrecarga del operador |
            bool sonIguales = sumador1 | sumador2;
            Console.WriteLine("¿Los sumadores tienen igual cantidadSumas?: " + sonIguales);
        }
    }
}
