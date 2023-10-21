using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una excepción personalizada llamada MiExcepcion.
    /// Esta clase hereda de la clase base Exception del espacio de nombres System.
    /// </summary>
    public class MiExcepcion : Exception
    {
        // Inicializa una nueva instancia de la clase MiExcepcion con un mensaje predeterminado.
        public MiExcepcion() : base("Excepción MiExcepcion")
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase MiExcepcion con un mensaje personalizado.
        /// </summary>
        /// <param name="message">Mensaje de la excepción personalizado.</param>
        public MiExcepcion(string message, MiClase otra) : base(message)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase MiExcepcion con un mensaje personalizado y una excepción interna.
        /// </summary>
        /// <param name="message">Mensaje de la excepción personalizado.</param>
        /// <param name="innerException">Excepción interna que desencadenó esta excepción.</param>
        public MiExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
