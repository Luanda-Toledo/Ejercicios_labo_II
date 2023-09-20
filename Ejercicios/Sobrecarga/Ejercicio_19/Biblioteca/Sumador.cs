namespace Biblioteca
{
    public class Sumador
    {
        // Declaramos su atributo
        private int cantidadSumas;

        // A - Constructores
        /// <summary>
        /// Constructor que inicializa la instancia de Sumador con un valor inicial.
        /// </summary>
        /// <param name="valorInicial">El valor inicial para cantidadSumas.</param>
        public Sumador(int valorInicial)
        {
            cantidadSumas = valorInicial;
        }

        /// <summary>
        /// Constructor que inicializa la instancia de Sumador con cantidadSumas en 0.
        /// </summary>
        public Sumador()
        {
            cantidadSumas = 0;
        }

        // B - METODOS
        /// <summary>
        /// Método que incrementa cantidadSumas en 1 y realiza la suma de dos valores long.
        /// </summary>
        /// <param name="a">El primer valor long.</param>
        /// <param name="b">El segundo valor long.</param>
        /// <returns>La suma de los dos valores long.</returns>
        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }

        /// <summary>
        /// Método que incrementa cantidadSumas en 1 y concatena dos cadenas de texto.
        /// </summary>
        /// <param name="cadena1">La primera cadena de texto.</param>
        /// <param name="cadena2">La segunda cadena de texto.</param>
        /// <returns>La concatenación de las dos cadenas de texto.</returns>
        public string Sumar(string cadena1, string cadena2)
        {
            cantidadSumas++;
            return cadena1 + cadena2;
        }

        /// <summary>
        /// Conversión explícita que retorna la cantidad de sumas realizadas.
        /// </summary>
        /// <param name="sumador">La instancia de Sumador.</param>
        /// <returns>La cantidad de sumas realizadas.</returns>
        public static explicit operator int(Sumador sumador) // C
        {
            return sumador.cantidadSumas;
        }

        /// <summary>
        /// Sobrecarga del operador + para sumar cantidadSumas de dos Sumadores y retornar un long.
        /// </summary>
        /// <param name="sumador1">El primer Sumador.</param>
        /// <param name="sumador2">El segundo Sumador.</param>
        /// <returns>La suma de cantidadSumas de ambos Sumadores.</returns>
        public static long operator +(Sumador sumador1, Sumador sumador2) // D
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }

        /// <summary>
        /// Sobrecarga del operador | para verificar si dos Sumadores tienen igual cantidadSumas.
        /// </summary>
        /// <param name="sumador1">El primer Sumador.</param>
        /// <param name="sumador2">El segundo Sumador.</param>
        /// <returns>True si ambos Sumadores tienen igual cantidadSumas, False en caso contrario.</returns>
        public static bool operator |(Sumador sumador1, Sumador sumador2) // E
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas;
        }
    }
}