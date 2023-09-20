using System;

namespace Ejercicio_02
{
    class Program
    {
        /*
         Ingresar un numero y mostrar: El cuadrado y el cubo del mismo.
         Se debe validar que el numero sea mayor que cero, caso contrario, mostrar el mensaje: 
         "ERROR.¡Reingresar numero!".
         Utilizar metodo POW de la clase Math.
         */
        static void Main()
        {
            /*
             * Utilizamos double.TryParse para intentar convertir convertir la cadena en un numero double.
             * Si la conversion es exitosa y el numero es mayor que 0, calculemos el cuadrado y el cubo.
            */
            Console.Title = "Ejercicio 02";

            Console.Write("Ingrese un numero: ");
            string cadenaIngresada = Console.ReadLine();

            // Intentar convertir la cadena a un numero double 
            // La variable para ser una cadena a u numero.
            if (double.TryParse(cadenaIngresada, out double numeroIngresado)) 
            { 
                if (numeroIngresado > 0)
                {
                    double resultadoCuadrado = Math.Pow(numeroIngresado, 2);
                    double resultadoCubo = Math.Pow(numeroIngresado, 3);

                    Console.WriteLine($"El cuadrado de {numeroIngresado} es: {resultadoCuadrado}. \nEl cubo de {numeroIngresado} es {resultadoCubo}.");
                }
                else
                {
                    Console.WriteLine("ERROR.¡Reingresar numero!");
                }
            }
            else
            {
                Console.WriteLine("ERROR.¡Reingresar numero!");
            }
        }
    }
}