namespace Ejercicio_05
{
    /*
     * 5.- Un centro numerico es un numero que separa una lista de numeros enteros (comenzando en 1) 
     * en dos grupos de numeros, cuyas sumas son iguales.
     * El primer centro numerico es el 6, el cual separa la lista (1 a 8) en los grupos: (1,2,3,4,5) y (7,8)
     * cuyas sumas son iguales a 15.
     * El segundo centro numerico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49)
     * cuyas sumas son iguales a 595.
     * Se pide elaborar una aplicacion que calcule los centros numericos entre 1 y el numero que el usuario ingrese por consola.
     * Nota: Utiliza estructuras repetitivas y selectivas.
     */
    internal class Program
    {
        static List<int> CalcularCentrosNumericos(int numero)
        {
            List<int> centrosNumericos = new List<int>();

            for (int i = 1; i <= numero; i++)
            {
                int sumaIzquierda = 0;
                int sumaDerecha = 0;

                for (int j = 1; j < i; j++)
                {
                    sumaIzquierda += j;
                }

                for (int k = i + 1; k <= numero; k++)
                {
                    sumaDerecha += k;
                }

                if (sumaIzquierda == sumaDerecha)
                {
                    centrosNumericos.Add(i);
                }
            }

            return centrosNumericos;
        }

        static void Main()
        {
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out int numeroUsuario) && numeroUsuario >= 1)
            {
                List<int> centros = CalcularCentrosNumericos(numeroUsuario);

                if (centros.Count > 0)
                {
                    Console.WriteLine($"Los centros numéricos entre 1 y {numeroUsuario} son: {string.Join(", ", centros)}");
                }
                else
                {
                    Console.WriteLine($"No se encontraron centros numéricos entre 1 y {numeroUsuario}.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido mayor o igual a 1.");
            }
        }
    }
}