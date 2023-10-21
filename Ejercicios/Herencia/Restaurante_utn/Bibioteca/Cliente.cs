using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibioteca
{
    public class Cliente
    {
        // Atributos
        private int dni;
        private List<Comida> comidas;

        // Constructores
        private Cliente(int dni)
        {
            this.dni = dni;
            comidas = new List<Comida>();
        }

        // Propiedad
        private double TotalAPagar
        {
            get
            {
                double total = 0;
                foreach (var comida in comidas)
                {
                    total += comida.Costo;
                }
                return total;
            }
        }

        // Sobrecarga de operadores
        public static bool operator ==(Cliente cliente, Comida comida)
        {
            foreach (var c in cliente.comidas)
            {
                if (c.Nombre == comida.Nombre)
                {
                    // Se encontró una coincidencia por nombre
                    return true; 
                }
            }

            return false; 
        }

        public static bool operator !=(Cliente cliente, Comida comida)
        {
            return !(cliente == comida);
        }

        public static Cliente operator +(Cliente cliente, Comida comida)
        {
            cliente.comidas.Add(comida);
            return cliente;
        }

        /// <summary>
        /// Convierte un número entero (dni) en una instancia de la clase Cliente.
        /// </summary>
        /// <param name="dni">El número entero que se utilizará como DNI del cliente.</param>
        /// <returns>Una nueva instancia de la clase Cliente con el DNI proporcionado.</returns>
        public static implicit operator Cliente(int dni)
        {
            return new Cliente(dni);
        }

        /// <summary>
        /// Crea y devuelve una instancia de la clase Cliente con el DNI especificado.
        /// </summary>
        /// <param name="dni">El número entero que se utilizará como DNI del cliente.</param>
        /// <returns>Una nueva instancia de la clase Cliente con el DNI proporcionado.</returns>
        public static Cliente GetCliente(int dni)
        {
            return new Cliente(dni);
        }

        /// <summary>
        /// Busca una comida en el menú del cliente y retorna la primera coincidencia por nombre.
        /// </summary>
        /// <param name="comida">La comida que se desea buscar en el menú del cliente.</param>
        /// <returns>
        /// La primera comida encontrada que coincida por nombre con la comida proporcionada.
        /// Si no se encuentra ninguna coincidencia, se retorna null.
        /// </returns>
        public Comida BuscarComida(Comida comida)
        {
            foreach (var item in comidas)
            {
                if (item == comida)
                {
                    return item; 
                }
            }

            return null; 
        }

        public string ImprimirTicket(Cliente cliente)
        {
            StringBuilder ticket = new StringBuilder();

            // Agregar los datos del cliente (dni)
            ticket.AppendLine("Cliente DNI: " + cliente.dni);

            // Agregar el menú del cliente (descripción de comidas)
            ticket.AppendLine("Menú del Cliente:");
            foreach (var comida in cliente.comidas)
            {
                ticket.AppendLine("- " + comida.Descripcion);
            }

            // Calcular y agregar el total a pagar
            double totalAPagar = cliente.TotalAPagar;
            ticket.AppendLine("Total a Pagar: " + totalAPagar.ToString("C2"));

            return ticket.ToString();
        }
    }
}
