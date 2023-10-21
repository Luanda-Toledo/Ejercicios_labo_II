namespace Biblioteca
{
    public class Sobreescritos
    {
        /// <summary>
        /// Sobrescribe el método ToString para proporcionar una representación de cadena personalizada del objeto.
        /// </summary>
        /// <returns>
        /// Una cadena que describe el objeto actual. En este caso, siempre retorna "¡Este es mi método ToString sobrescrito!".
        /// </returns>
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        /// <summary>
        /// Sobrescribe el método Equals para comparar si el objeto actual es del mismo tipo que el objeto proporcionado.
        /// </summary>
        /// <param name="obj">El objeto con el que se va a comparar.</param>
        /// <returns>
        /// <c>true</c> si el objeto actual y el objeto proporcionado son del mismo tipo (instancias de la clase Sobrescrito); 
        /// <c>false</c> en caso contrario.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is Sobreescritos)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrescribe el método GetHashCode para proporcionar un valor de código hash constante.
        /// </summary>
        /// <returns>
        /// Un valor de código hash constante, en este caso, siempre retorna 1142510187.
        /// </returns>
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}