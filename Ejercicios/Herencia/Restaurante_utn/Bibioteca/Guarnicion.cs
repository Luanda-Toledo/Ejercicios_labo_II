using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibioteca
{
    public enum ETipo {PAPAS_FRITAS = 1000, ENSALADA_RUSA = 750, ENSALADA_MIXTA = 500};

    public class Guarnicion : Comida
    {
        // Atributos
        private ETipo tipo;

        // Constructores
        public Guarnicion():this(ETipo.PAPAS_FRITAS)
        {
            
        }

        public Guarnicion(ETipo tipoGuarnicion):base(tipoGuarnicion.ToString())
        {
            this.tipo = tipoGuarnicion;
        }

        // Sobrecarga de comparadores
        public static bool operator ==(Guarnicion guarnicion, Eingredientes ingrediente)
        {
            if (ingrediente == Eingredientes.PANCETA || ingrediente == Eingredientes.ADHERESO || ingrediente == Eingredientes.QUESO)
            {
                // Comprobar si el tipo de guarnición coincide con el ingrediente
                return guarnicion.tipo == (ETipo)ingrediente;
            }

            return false;
        }

        public static bool operator !=(Guarnicion guarnicion, Eingredientes ingrediente)
        {
            return !(guarnicion == ingrediente);
        }

        // Metodos

        /// <summary>
        /// Devuelve una representación de cadena que describe la guarnición.
        /// </summary>
        /// <returns>
        /// Una cadena que indica el tipo de guarnición.
        /// </returns>
        public override string ToString()
        {
            return $"Guarnición de tipo {this.tipo}";
        }

        /// <summary>
        /// Agrega un ingrediente a la guarnición si cumple con ciertas condiciones.
        /// </summary>
        /// <param name="ingrediente">El ingrediente a agregar.</param>
        /// <returns>
        /// Un mensaje indicando si se agregó o no el ingrediente a la guarnición.
        /// </returns>
        public string AgregarIngrediente(Eingredientes ingrediente)
        {
            if (ingredientes.Contains(ingrediente))
            {
                return $"No se pudo agregar {ingrediente} a su guarnición";
            }
            else 
            {
                ingredientes.Add(ingrediente);
                return $"Se agregó {ingrediente} a su guarnición";
            }
        }


        /// <summary>
        /// Calcula el costo total de la guarnición, considerando el tipo de guarnición y los ingredientes adicionales.
        /// </summary>
        /// <returns>
        /// El costo total de la guarnición, incluyendo el costo base y los costos adicionales de los ingredientes.
        /// </returns>
        public double CalcularCosto()
        {

            // Calcular el costo base según el tipo de guarnición
            /*
            double costoBase = 0;
            switch (tipo)
            {
                case ETipo.PAPAS_FRITAS:
                    costoBase = 1000;
                    break;
                case ETipo.ENSALADA_RUSA:
                    costoBase = 750;
                    break;
                case ETipo.ENSALADA_MIXTA:
                    costoBase = 500;
                    break;
            }
            */
            double costoBase = (int)this.tipo;


            // Calcular el costo adicional por ingredientes permitidos
            foreach (var ingrediente in ingredientes)
            {
                /*switch (ingrediente)
                {
                    case Eingredientes.ADHERESO: // +0%
                        break;
                    case Eingredientes.QUESO: // +10%
                        costoBase += costoBase * 0.10m;
                        break;
                    case Eingredientes.PANCETA: //+15%
                        costoBase += costoBase * 0.15m;
                        break;
                }
                */
                costoBase += costoBase * (int)this.tipo / 100;
            }

            return costoBase;
        }

        public static explicit operator Guarnicion(ETipo tipo)
        {
            // Crear una nueva instancia de Guarnicion utilizando el valor de tipo
            return new Guarnicion(tipo);
        }

        /// <summary>
        /// Obtiene una representación de cadena que muestra los datos de la guarnición.
        /// </summary>
        /// <returns>
        /// Una cadena que contiene información sobre el tipo de guarnición y otros datos adicionales si es necesario.
        /// </returns>
        public string MostrarDatos()
        {
            return $"Nombre: {this.ToString()}\n"; 
        }
    }
}
