namespace Biblioteca
{
    /// <summary>
    /// Representa una excepción personalizada llamada UnaExcepcion.
    /// Esta clase hereda de la clase base Exception del espacio de nombres System.
    /// </summary>
    public class UnaExcepcion : Exception
    {
        // Inicializa una nueva instancia de la clase UnaExcepcion con un mensaje predeterminado.
        public UnaExcepcion() : base("Excepción UnaExcepcion")
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase UnaExcepcion con un mensaje personalizado.
        /// </summary>
        /// <param name="message">Mensaje de la excepción personalizado.</param>
        public UnaExcepcion(string message) : base(message)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase UnaExcepcion con un mensaje personalizado y una excepción interna.
        /// </summary>
        /// <param name="message">Mensaje de la excepción personalizado.</param>
        /// <param name="innerException">Excepción interna que desencadenó esta excepción.</param>
        public UnaExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}