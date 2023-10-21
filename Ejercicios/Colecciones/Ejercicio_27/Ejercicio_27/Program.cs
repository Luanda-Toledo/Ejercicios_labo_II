namespace Ejercicio_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una colección de tipo Pila para los números aleatorios.
            Stack<int> pilaNumeros = new Stack<int>();

            // Crear una colección de tipo Cola para los números aleatorios.
            Queue<int> colaNumeros = new Queue<int>();

            // Crear una colección de tipo Lista para los números aleatorios.
            List<int> listaNumeros = new List<int>();

            // Crear un objeto Random para generar números aleatorios.
            Random rand = new Random();

            // Llenar las colecciones con números aleatorios (positivos y negativos distintos de cero).
            for (int i = 0; i < 20; i++)
            {
                int numeroAleatorio = 0;
                do
                {
                    numeroAleatorio = rand.Next(-100, 101); // Genera números entre -100 y 100.

                    /*
                     * Contains: Es un método que se utiliza para verificar si un elemento específico está contenido en una colección. 
                     * En este caso, estamos usando Contains para verificar si numeroAleatorio se encuentra en pilaNumeros
                     */
                } while (numeroAleatorio == 0 || pilaNumeros.Contains(numeroAleatorio)); // Verificar que no sea cero ni se repita.

                // Agregar el número aleatorio a la Pila.
                pilaNumeros.Push(numeroAleatorio);

                // Agregar el número aleatorio a la Cola.
                colaNumeros.Enqueue(numeroAleatorio);

                // Agregar el número aleatorio a la Lista.
                listaNumeros.Add(numeroAleatorio);
            }

            // Mostrar los números tal como fueron ingresados.
            Console.WriteLine("Números tal como fueron ingresados:");
            MostrarColeccion(listaNumeros);

            // Ordenar y mostrar los números positivos en forma decreciente.
            /*
             * Where(num => num > 0) filtra los números positivos.

               OrderBy(num => num) ordena los números positivos en orden ascendente.

               Reverse() invierte el orden, convirtiendo la ordenación ascendente en descendente.

               ToList() convierte el resultado en una lista.
             */
            var positivosOrdenados = listaNumeros.Where(num => num > 0).OrderBy(num => num).Reverse().ToList();
            Console.WriteLine("\nPositivos ordenados en forma decreciente:");
            MostrarColeccion(positivosOrdenados);

            // Ordenar y mostrar los números negativos en forma creciente.
            /*
             * Where(num => num < 0) filtra los números negativos.

               OrderBy(num => num) ordena los números negativos en orden ascendente.

               ToList() convierte el resultado en una lista.
             */
            var negativosOrdenados = listaNumeros.Where(num => num < 0).OrderBy(num => num).ToList();
            Console.WriteLine("\nNegativos ordenados en forma creciente:");
            MostrarColeccion(negativosOrdenados);


        }

        // Método para mostrar una colección en la consola.

        /*
         *  IEnumerable<T> es una interfaz que representa una secuencia de elementos de tipo T, en este caso, int. 
         *  Esta interfaz se utiliza comúnmente para trabajar con colecciones.
         */
        static void MostrarColeccion(IEnumerable<int> coleccion)
        {
            foreach (int numero in coleccion)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }
    }
}