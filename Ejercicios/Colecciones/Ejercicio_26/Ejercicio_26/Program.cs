namespace Ejercicio_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un objeto Random para generar numeros aleatorios
            Random rand = new Random();

            // Declarar un vector para almacenar los numeros
            int[] numeros = new int[20];

            // Llenamos el vector con numeros enteros aleatorios (positivos y negativos distintos de cero)
            for (int i = 0; i < 20; i++) 
            {
                int numeroAleatorio = 0;
                do
                {
                    // Genera numeros enteros entre -100 y 100
                    numeroAleatorio = rand.Next(-100, 101);

                // Verificamos que no sea cero  ni que se repita
                } while (numeroAleatorio == 0 || Array.IndexOf(numeros, numeroAleatorio) != -1);

                numeros[i] = numeroAleatorio;
            }

            // Método para mostrar un vector en la consola.
            static void MostrarVector(int[] vector)
            {
                foreach (int numero in vector)
                {
                    Console.Write(numero + " ");
                }
                Console.WriteLine();
            }

            // -------- A) Mostrar el vector tal como fue ingresado -------------------------------
            Console.WriteLine("Vector tal como fue ingresado: ");
            MostrarVector(numeros);

            // --------- B) Mostrar los positivos ordenados en forma decreciente. -----------------
            // Filtrar y ordenar los positivos en forma decreciente.
            /*
             * Array.FindAll(numeros, num => num > 0);
             * Buscar y filtrar elementos en un arreglo.
             * El primer argumento (numeros) es el arreglo en el que deseas buscar y filtrar elementos.
             * El segundo argumento es una expresión lambda (num => num < 0) que define la condición que
             * deben cumplir los elementos del arreglo para ser incluidos en el nuevo arreglo resultante (negativos en este caso).
             * Esta expresión en el segundo parametro lambda actúa como un filtro que selecciona los números negativos del arreglo numeros.
             */
            int[] positivos = Array.FindAll(numeros, num => num > 0);
            Array.Sort(positivos); // Ordena
            Array.Reverse(positivos); // Invierte el orden

            // Mostrar los positivos ordenados en forma decreciente.
            Console.WriteLine("\nPositivos ordenados en forma decreciente:");
            MostrarVector(positivos);

            // --------- C) Mostrar los negativos ordenados en forma creciente. -------------------
            // Filtrar y ordenar los negativos en forma creciente.
            int[] negativos = Array.FindAll(numeros, num => num < 0); //buscar y filtrar en el arreglo numeros que satisfacen la condición de ser números negativos
            Array.Sort(negativos); // Ordena

            // Mostrar los negativos ordenados en forma creciente.
            Console.WriteLine("\nNegativos ordenados en forma creciente:");
            MostrarVector(negativos);

        }
    }
}