namespace Biblioteca
{
    public class Libro
    {
        // Lista que almacena las páginas del libro.
        private List<string> paginas = new List<string>();

        /// <summary>
        /// Permite acceder a una página específica del libro mediante un índice.
        /// </summary>
        /// <param name="indice">El índice de la página que se desea acceder.</param>
        /// <returns>El contenido de la página en el índice especificado o una cadena vacía si el índice está fuera de rango.</returns>
        public string this[int indice]
        {
            get
            {
                if (indice >= 0 && indice < paginas.Count)
                {
                    return paginas[indice];
                }
                else
                {
                    return "";
                }
            }
            set
            {
                // Si el índice es mayor que el número actual de páginas, se agregarán páginas adicionales al libro.
                // .Count se utiliza para obtener el número de elementos en una lista
                if (indice >= paginas.Count)
                {
                    // Agregar nuevas páginas vacías si es necesario
                    while (paginas.Count <= indice)
                    {
                        paginas.Add("");
                    }
                }
                // Asigna el contenido proporcionado a la página en el índice especificado.
                paginas[indice] = value;
            }
        }
    }
}