namespace Ejercicio_10
{
    /*
     * 10.- Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla una piramide como la siguiente:
 
        *
       ***
      *****
     *******
    *********

    Nota: utilizar estructuras repetitivas y selectivas.

     */
    internal class Program
    {
        /*
        Este programa es similar al anterior, pero en este caso, utiliza dos bucles for anidados para imprimir espacios en blanco antes de los asteriscos en cada fila. 
        La cantidad de espacios en blanco en cada fila se calcula para que los asteriscos estén centrados. El usuario debe ingresar la altura deseada de la pirámide, 
        y el programa imprimirá la pirámide con esa altura.
        */

        static void Main()
        {
            Console.Title = "Ejercicio 10";
            Console.Write("Ingrese la altura de la pirámide (un número entero positivo): ");
            int altura;

            // Validar que se ingrese un número válido
            while (!int.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.WriteLine("Ingrese un número entero positivo válido: ");
            }

            for (int i = 1; i <= altura; i++)
            {
                // Imprimir espacios en blanco para alinear los asteriscos al centro
                for (int j = 1; j <= altura - i; j++)
                {
                    Console.Write(" ");
                }

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