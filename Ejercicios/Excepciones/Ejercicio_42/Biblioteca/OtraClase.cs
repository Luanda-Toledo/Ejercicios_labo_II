using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class OtraClase
    {
        /// <summary>
        /// Este método de instancia crea una instancia de la clase MiClase y maneja excepciones lanzadas por ella.
        /// En caso de capturar una UnaExcepcion, la relanza como una MiExcepcion.
        /// </summary>
        public void MetodoDeInstancia()
        {
            try
            {
                MiClase instanciaMiClase = new MiClase();
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Excepción MiException en OtraClase", ex);
            }
        }
    }
}
