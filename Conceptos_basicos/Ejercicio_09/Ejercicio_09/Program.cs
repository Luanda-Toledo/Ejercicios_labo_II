namespace Ejercicio_09
{
    /*
     * 9.- Escribir un programa que escriba por pantalla una piramide como la siguiente:

    *
    ***
    *****
    *******
    *********

    Nota: El usuario indicara cual sera la altura de la piramide ingresando un numero entero positivo. Para el ejemplo anterior
    la altura ingresada fue de 5. 
    Utilizar estructuras repetitivas y selectivas.
     */

    internal class Program
    {
        /*
        Este programa solicita al usuario la altura deseada de la pirámide y luego utiliza un bucle for para imprimir la pirámide
        en función de la altura ingresada. Asegura que el número ingresado sea un número entero positivo válido antes de continuar. 
        Luego, utiliza un bucles for anidado para los asteriscos necesarios para cada fila de la pirámide. 
        */
        static void Main()
        {
            Console.Title = "Ejercicio 09";
            Console.Write("Ingrese la altura de la pirámide (un número entero positivo): ");
            int altura;
     
            // Validar que se ingrese un número válido
            while (!int.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.WriteLine("Ingrese un número entero positivo válido: ");
            }

            for (int i = 1; i <= altura; i++)
            {
                // Imprimir asteriscos
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                // Cambiar de línea después de imprimir la fila
                Console.WriteLine();
            }
        }
    }
}