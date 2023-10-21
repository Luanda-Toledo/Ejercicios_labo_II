using Biblioteca;

namespace Ejercicio_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intenta ejecutar el código dentro de este bloque.
            try
            {
                // Intenta crear una instancia de OtraClase y llamar a su método MetodoDeInstancia.
                OtraClase instanciaOtraClase = new OtraClase();
                instanciaOtraClase.MetodoDeInstancia();
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine("Mensaje de MiException: " + ex.Message);

                // Obtiene la excepción interna (InnerException) y muestra sus mensajes si existen.
                Exception innerException = ex.InnerException;

                // Recorre todas las excepciones internas si las hay y muestra sus mensajes.
                while (innerException != null)
                {
                    Console.WriteLine("Mensaje de InnerException: " + innerException.Message);
                    innerException = innerException.InnerException;
                }
            }
        }
    }
}