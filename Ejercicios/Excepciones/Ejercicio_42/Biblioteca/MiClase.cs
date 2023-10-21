using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una clase llamada MiClase con métodos y constructores.
    /// </summary>
    public class MiClase
    {

        /// <summary>
        /// Inicializa una nueva instancia de la clase MiClase.
        /// Llama al método estático y maneja excepciones lanzadas por él.
        /// </summary>
        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Excepción UnaExcepcion", ex);
            }
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase MiClase utilizando otra instancia de MiClase.
        /// Lanza una excepción MiExcepcion y la maneja, relanzándola como UnaExcepcion.
        /// </summary>
        /// <param name="otra">Otra instancia de MiClase utilizada en la construcción de esta instancia.</param>
        public MiClase(MiClase otra)
        {
            try
            {
                throw new MiExcepcion("Excepción MiExcepcion en otro constructor", otra);
            }
            catch (MiExcepcion ex)
            {
                throw new UnaExcepcion("Excepción UnaExcepcion en constructor con otra excepción", ex);
            }
        }

        /// <summary>
        /// Método estático que lanza una excepción DivideByZeroException.
        /// </summary>
        public static void MetodoEstatico()
        {
            int divisor = 0;
            int resultado = 10 / divisor; // Lanza DivideByZeroException
        }
        /*
         * DivideByZeroException es una excepción que se lanza cuando intentas dividir un número por cero. 
         * La división por cero no está definida en matemáticas y genera un error en tiempo de ejecución en la mayoría de los lenguajes de programación. 
         * La excepción DivideByZeroException se utiliza para indicar que se ha producido un intento de división por cero en un programa 
         * y generalmente se captura y maneja para evitar que el programa se bloquee o se cierre de manera inesperada.
         */
    }
}
