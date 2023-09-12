using System;
using Biblioteca;

namespace Ejercicio_13
{
    /*
    13.- Desarrollar una clase llamada Conversor, que posea dos metodos de clase (estaticos):
    string DecimalBinario(int). Convierte un numero entero a binario.
    int BinarioDecimal(string). Convierte un numero binario a entero.
    Nota: No utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.
    
    En la función DecimalBinario, convertimos un número decimal a binario utilizando un bucle while que divide
    el número por 2 en cada iteración, tomando el residuo y concatenándolo a la izquierda de la cadena binaria.

    En la función BinarioDecimal, convertimos una cadena binaria en un número decimal utilizando un bucle for para iterar
    a través de los dígitos binarios y calcular su valor decimal correspondiente, teniendo en cuenta la posición del dígito 
    y su exponente en la representación binaria.
    */
    class Conversor
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Title = "Conversor";
                Console.WriteLine("Seleccione la operación que desea realizar:");
                Console.WriteLine("1. Decimal a Binario");
                Console.WriteLine("2. Binario a Decimal");
                Console.WriteLine("3. Salir");
                Console.Write("Ingrese el número de la operación que desea realizar: ");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el número decimal que desea convertir a binario: ");
                        if (int.TryParse(Console.ReadLine(), out int decimalIngresado))
                        {
                            string binario = Conversiones.DecimalBinario(decimalIngresado);
                            Console.WriteLine($"El número binario equivalente es: {binario}");
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingrese un número decimal válido.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese el número binario que desea convertir a decimal: ");
                        string binarioIngresado = Console.ReadLine();
                        int decimalResult = Conversiones.BinarioDecimal(binarioIngresado);
                        Console.WriteLine($"El número decimal equivalente es: {decimalResult}");
                        break;

                    case 3:
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }
}