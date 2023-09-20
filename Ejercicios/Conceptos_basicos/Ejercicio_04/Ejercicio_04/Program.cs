using System;

namespace Ejercicio_04
{
    /*
     * 4.- Un nnumero perfecto es un entero positivo, que es igual a la suma de todos de enteros positivos (excluido el mismo)
     * que son divisores del numero.
     * El primer numero perfecto es el 6, ya que los divisores de 6 son: 1,2,3; y 1+2+3=6
     * Escribir una aplicacion que encuentre los primeros 4 numeros perfectos
     * Nota: Utilizar estructuras repetitivas y selectivas.
    */
    internal class Program
    {
        /*
         * Este programa busca y muestra los primeros 4 numeros perfectos utilizando un bucle while.
         * La funcion EsNumeroPerfecto verifica si un numero es perfecto sumando todos sus divisores.
         * Cuando se encuentra un numero perfecto, se muestra en consola y se incrementa el contador numerosPerfectosEncontrados.
         * El programa se detendra despues de enconttrar los primeros 4 numeros perfectos.
         */
        static void Main()
        {
            Console.Title = "Ejercicio  04";
            int numerosPerfectosEncontrados = 0;
            int numeroActual = 2; // Comenzamos con el numero 2

            while (numerosPerfectosEncontrados < 4)
            {
                if (EsNumeroPerfecto(numeroActual)) 
                {
                    Console.WriteLine($"Numero perfecto encontrado: {numeroActual}");
                    numerosPerfectosEncontrados++;
                }
                numeroActual++;
            }
        }

        // Metodo para verificar si un numero es perfecto.
        static bool EsNumeroPerfecto(int numero)
        {
            // Iniciamos con 1, por que todo numero es divisible por 1
            int sumaDivisores = 1;

            for (int i = 2; i * i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    sumaDivisores += i;
                    if (i != numero / i)
                    {
                        sumaDivisores += numero / i;
                    }
                }
            }

            return sumaDivisores == numero;
        }
    }
}