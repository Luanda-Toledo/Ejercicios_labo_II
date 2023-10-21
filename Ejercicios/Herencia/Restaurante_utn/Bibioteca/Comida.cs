using Bibioteca;
using System.Text;

namespace Bibioteca
{
    public enum Eingredientes { ADHERESO, QUESO = 10, CEBOLLA = 8, LECHUGA = 7, TOMATE = 9, JAMON = 12, HUEVO = 13, PANCETA = 15 };

    public abstract class Comida
    {
        // Atributos
        private string nombre;
        protected List<Eingredientes> ingredientes;

        // Constructores
        protected Comida(string nombre):this(nombre, new List<Eingredientes>())
        {
            
        }

        protected Comida(string nombre, List<Eingredientes> ingredientes) 
        {
            this.nombre = nombre;
            this.ingredientes = ingredientes;
        }

        // Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public double Costo
        {
            get
            {
                return CalcularCosto();
            }
        }

        public string Descripcion 
        {
            get
            {
                return this.MostrarDatos();
            }
        }

        public static object EIngredientes { get; set; }

        // Sobrecargas de operadores
        public static bool operator ==(Comida c, Eingredientes ingredientes)
        {
            return c.ingredientes.Contains(ingredientes);
        }

        public static bool operator !=(Comida c, Eingredientes ingredientes)
        {
            return !(c == ingredientes);
        }

        public static string operator +(Comida c, Eingredientes ingredientes)
        {
            return c.AgregarIngredientes(ingredientes);
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Comida && ((Comida)obj).nombre == this.nombre;
        }

        // Metodos
        protected abstract string AgregarIngredientes(Eingredientes ingredientes);

        protected abstract double CalcularCosto();

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Costo: {Costo}");

            if (ingredientes.Count > 0)
            {
                sb.AppendLine("Ingredientes:");
                foreach (Eingredientes ingrediente in ingredientes)
                {
                    sb.AppendLine($" - {ingrediente}");
                }
            }

            return sb.ToString();
        }

    }
}