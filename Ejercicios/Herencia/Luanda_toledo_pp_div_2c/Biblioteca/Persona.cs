using System.Net;
using System.Text;

namespace Biblioteca
{
    public abstract class Persona
    {
        // Atributos
        private string? apellido;
        protected int dni;
        private string? nombre;

        // Constructor
        protected Persona(int dni)
        {
            this.dni = dni;
        }

        // Propiedades
        public string? Apellido
        {
            get 
            { 
                return apellido; 
            }
            set 
            { 
                this.apellido = value;
            }
        }
        public string? Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public abstract string Informacion
        {
            get;
        }

        /*
         * Se usa Equals en los casos int y en los casos en los que se compara si dos objetos estan guardados en 
         * la misma direccion de memoria.
         */
        public override bool Equals(object? obj)
        {
            if (obj is null) // Comprobar si el objeto es nulo
            {
                return false;
            }

            if (obj is Persona otraPersona) // Comprobar si el objeto es una Persona
            {
                // Comparar los números de DNI para determinar si son iguales
                return dni == otraPersona.dni;
            }

            return false; // Si el objeto no es una Persona, considerarlo diferente
        }

        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }

        // Sobrecarga de operadores 
        public static bool operator !=(Persona personaA, Persona personaB)
        {
            return !(personaA == personaB);
        }

        public static bool operator ==(Persona personaA, Persona personaB)
        {
            return personaA.dni == personaB.dni;
        }
        protected string MostrarDatos()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"DNI: {dni}");
            builder.AppendLine($"Apellido: {Apellido}");
            builder.AppendLine($"Nombre: {Nombre}");
            return builder.ToString();
        }
    }
}