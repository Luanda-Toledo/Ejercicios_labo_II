using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibioteca
{
    public class Hamburguesa : Comida
    {
        // Atributos
        private static double costoBase;
        private bool esDoble;

        // Constructores
        static Hamburguesa() 
        {
            Hamburguesa.costoBase = 1500;
        }

        public Hamburguesa(string nombre):base(nombre)
        {
        }

        public Hamburguesa(string nombre, bool esDoble):this(nombre)
        {
            this.esDoble = esDoble;
        }

        // Metodos

        /// <summary>
        /// Agrega un ingrediente a la hamburguesa si no está ya presente en la lista de ingredientes.
        /// </summary>
        /// <param name="ingrediente">El ingrediente que se intenta agregar.</param>
        /// <returns>
        /// Un mensaje que indica si el ingrediente se agregó con éxito a la hamburguesa o si no pudo agregarse.
        /// </returns>
        protected override string AgregarIngredientes(Eingredientes ingrediente)
        {
            if (!ingredientes.Contains(ingrediente))
            {
                ingredientes.Add(ingrediente);
                return $"Se agrega {ingrediente} a su hamburguesa";
            }
            else
            {
                return $"No se pudo agregar {ingrediente} a su hamburguesa";
            }
        }

        /// <summary>
        /// Devuelve una representación de cadena que indica si la hamburguesa es de tipo "Doble" o "Simple".
        /// </summary>
        /// <returns>
        /// "Doble" si la hamburguesa es de tipo doble (esDoble es true), o "Simple" si es de tipo simple (esDoble es false).
        /// </returns>
        public override string ToString()
        {
            return esDoble ? "Doble" : "Simple";
        }

        /// <summary>
        /// Obtiene una representación de cadena que muestra los datos de la hamburguesa, incluyendo el tipo (simple o doble).
        /// </summary>
        /// <returns>Una cadena que contiene los datos de la hamburguesa y su tipo.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ToString());
            return sb.ToString(); 
        }

        /// <summary>
        /// Calcula el costo total de la hamburguesa, considerando su tipo (simple o doble) y los ingredientes agregados.
        /// </summary>
        /// <returns>El costo total de la hamburguesa.</returns>
        protected override double CalcularCosto()
        {
            double costo = costoBase;

            // Si la hamburguesa es doble, agregar $500 al costo
            if (esDoble)
            {
                costo += 500;
            }

            // Recorrer la lista de ingredientes e incrementar sus valores 
            foreach (Eingredientes ingrediente in ingredientes)
            {
                switch (ingrediente)
                {
                    case Eingredientes.LECHUGA:
                        costo += costo * 0.07; 
                        break;
                    case Eingredientes.CEBOLLA:
                        costo += costo * 0.08; 
                        break;
                    case Eingredientes.TOMATE:
                        costo += costo * 0.09; 
                        break;
                    case Eingredientes.QUESO:
                        costo += costo * 0.10; 
                        break;
                    case Eingredientes.JAMON:
                        costo += costo * 0.12; 
                        break;
                    case Eingredientes.HUEVO:
                        costo += costo * 0.13; 
                        break;
                    case Eingredientes.PANCETA:
                        costo += costo * 0.15; 
                        break;
                }
            }

            return costo;
        }

    }
}
