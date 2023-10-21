using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        // Atributos
        private List<AutoF1> competidores;
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private static Random random = new Random();

        // Constructores
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadDeVueltas, short cantidadCompetidores)
            : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadDeVueltas;
        }

        // Sobrecarga de operadores de suma y resta
        public static bool operator +(Competencia competencia, AutoF1 competidor)
        {
            return competencia.AgregarCompetidor(competidor);
        }

        public static bool operator -(Competencia competencia, AutoF1 competidor)
        {
            return competencia.EliminarCompetidor(competidor);
        }

        // Sobrecarga de operadores de comparacion
        public static bool operator ==(Competencia competencia, AutoF1 competidor)
        {
            // Verificar si un objeto competidor(del tipo AutoF1) está contenido en la lista de competidores.
            return competencia.competidores.Contains(competidor);
        }

        public static bool operator !=(Competencia competencia, AutoF1 competidor)
        {
            return !(competencia == competidor);
        }

        /// <summary>
        /// Agrega un competidor (AutoF1) a la competencia si cumple con los requisitos establecidos.
        /// </summary>
        /// <param name="competidor">El competidor (AutoF1) que se desea agregar a la competencia.</param>
        /// <returns>
        ///   <c>true</c> si se agregó exitosamente el competidor a la competencia; 
        ///   <c>false</c> si no se pudo agregar debido a límite de competidores alcanzado o si el competidor ya está en la competencia.
        /// </returns>
        public bool AgregarCompetidor(AutoF1 competidor)
        {
            // Verifica si el número de competidores es menor que el límite y si el competidor no está duplicado.
            if (competidores.Count < cantidadCompetidores && !competidores.Contains(competidor))
            {
                // Configura el competidor para que esté en competencia.
                competidor.EnCompetencia = true;
                // Establece la cantidad de vueltas restantes igual a la cantidad de vueltas de la competencia.
                competidor.VueltasRestantes = cantidadVueltas;
                // Asigna una cantidad aleatoria de combustible entre 15 y 100 al competidor.
                competidor.CantidadCombustible = (short)random.Next(15, 101);

                competidores.Add(competidor);
                return true; 
            }
            return false; 
        }

        /// <summary>
        /// Elimina un competidor (AutoF1) de la competencia si está presente.
        /// </summary>
        /// <param name="competidor">El competidor (AutoF1) que se desea eliminar de la competencia.</param>
        /// <returns>
        ///   <c>true</c> si se eliminó exitosamente el competidor de la competencia; 
        ///   <c>false</c> si el competidor no estaba en la competencia y no se pudo eliminar.
        /// </returns>
        public bool EliminarCompetidor(AutoF1 competidor)
        {
            // Verifica si el competidor está presente en la lista de competidores.
            if (competidores.Contains(competidor))
            {
                competidores.Remove(competidor);
                // Configura el competidor para que no esté en competencia.
                competidor.EnCompetencia = false;

                return true;
            }
            return false; 
        }

        public string MostrarCompetidores()
        {
            string infoCompetencia = $"Cantidad de Vueltas: {cantidadVueltas}, Cantidad de Competidores: {cantidadCompetidores}";
            /*
             * string.Join() para unir todas las cadenas generadas en el paso anterior en una sola cadena de texto. 
             * El primer argumento "\n" indica que se debe utilizar un salto de línea como separador entre las cadenas.
             * 
             * Select(auto => auto.MostrarDatos()) aplica la función MostrarDatos() a cada elemento auto de la lista competidores. 
             * La función MostrarDatos() se llama para cada competidor, y el resultado es una secuencia de cadenas que representan
             * la información detallada de cada competidor.
             */
            string infoCompetidores = string.Join("\n", competidores.Select(auto => auto.MostrarDatos()));

            return $"{infoCompetencia}\n{infoCompetidores}";
        }
    }
}
