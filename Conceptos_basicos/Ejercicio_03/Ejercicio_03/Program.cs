using System;
namespace Ejercicio_03
{
    internal class Program
    {
        // 3.- Mostrar por pantalla todoslos numeros primos que haya hasta el numero que ingrese el usuario por consola.
        // Nota: utilizar estructuras repetitivas, selectivas y la funcion modulo (%). 

        /*
         * Leemos la entrada del usuario como una cadena y la converitmos a un numero double.
         * Verificamos si el numero ingresado es mayor o igual a 2, ya que los num primos comienzan desde 2.
         * Utilizamos un bucle for para iterar desde 2 hasta el numero ingresado, y llamamos a la funcion EsPrimo para 
         * verificar si cada numero es ese rango primo.
         * La funcion EsPrimo verifica si un numero es primo usando un bucle for y el operador % (modulo) para comprobar si es divisible
         * por algun numero menor que el.
         * Si no es divisible por ningun numero menor, es primo.
        */
        static void Main()
        {

            Console.Title = "Ejercicio 03";
            Console.Write("Ingrese un numero: ");
            string cadenaIngresada = Console.ReadLine();
            
            if (double.TryParse(cadenaIngresada, out double numeroIngresado))
            {
                if (numeroIngresado >= 2)
                {
                    Console.WriteLine($"Numeros primos hasta {numeroIngresado}: ");
                    for (double i = 2; i <= numeroIngresado; i++)
                    {
                        if (EsPrimo(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El numero ingresado debe ser mayor o igual a 2");
                }
            } 
            else
            {
                Console.WriteLine("Error. ¡Reingrese un numero valido!");
            }
        }

        // Metodo para verificar si el numero es primo
        static bool EsPrimo(double numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (double i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}