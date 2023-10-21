using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum EMateria
    {
        Programacion,
        Laboratorio
    }

    public class Alumno : Persona
    {
        // Atributos 
        private string legajo;
        private Dictionary<EMateria, List<int>> materiasAsignadas;

        // Constructor 
        private Alumno(int dni):base(dni)
        {
            materiasAsignadas = new Dictionary<EMateria, List<int>>();
        }

        // Sobrecarga del constructor
        public Alumno(int dni, string legajo):this(dni) 
        {
            this.legajo = legajo;
        }

        // Constructor estático para crear una instancia de Alumno a partir de un string
        public static implicit operator Alumno(string dni)
        {
            int dniParseado;
            if (int.TryParse(dni, out dniParseado))
            {
                // Crear una instancia de Alumno con el DNI proporcionado y legajo basado en el código hash
                Alumno alumno = new Alumno(dniParseado, $"L-{dniParseado.GetHashCode()}");
                return alumno;
            }
            else
            {
                throw new ArgumentException("El formato del DNI no es válido.");
            }
        }

        // Propiedades
        public override string Informacion
        {
            get
            {
                return $"Alumno - {Nombre} {Apellido}, DNI: {dni}, Legajo: {legajo}";
            }
        }

        // Propiedad indexadora
        public List<int> this[EMateria materia]
        {
            get
            {
                if (materiasAsignadas.ContainsKey(materia)) 
                {
                    return materiasAsignadas[materia];  
                }
                else
                {
                    return null;
                }
            }
        }

        // Sobrecarga de operadores 
        public static bool operator !=(Alumno alumno, EMateria materia)
        {
            return !(alumno.materiasAsignadas.ContainsKey(materia));
        }

        public static bool operator ==(Alumno alumno, EMateria materia)
        {
            return alumno.materiasAsignadas.ContainsKey(materia);
        }

        
        public static bool operator +(Alumno alumno, EMateria materia)
        {
            // Verificar si el alumno ya está inscrito en la materia
            if (!alumno.materiasAsignadas.ContainsKey(materia))
            {
                // El alumno no está inscrito, asignar la materia
                alumno.materiasAsignadas.Add(materia, new List<int>());
                return true;
            }
            return false;
        }

        /// <summary>
        /// Rinde un examen para una materia específica y asigna un resultado aleatorio a las calificaciones.
        /// </summary>
        /// <param name="materia">La materia para la que se rendirá el examen.</param>
        /// <returns>
        /// Retorna true si el examen se rinde con éxito y se asigna un resultado aleatorio a las calificaciones,
        /// o false si el alumno no está inscrito en la materia y no puede rendir el examen.
        /// </returns>
        public bool RendirExamen(EMateria materia)
        {
            if (materiasAsignadas.ContainsKey(materia))
            {
                // El alumno está inscrito en la materia, generar un número aleatorio entre 1 y 10
                Random random = new Random();
                int resultadoExamen = random.Next(1, 11);

                // Asignar el resultado del examen a la lista de calificaciones de la materia
                materiasAsignadas[materia].Add(resultadoExamen);

                return true; 
            }
            else
            {
                return false; 
            }
        }

        /// <summary>
        /// Muestra los datos de la persona, incluyendo nombre, apellido y DNI, 
        /// junto con el legajo del alumno y las materias a las cuales se encuentra inscrito.
        /// </summary>
        public void MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Legajo: {legajo}");

            sb.AppendLine("Materias inscritas:");
            foreach (var materia in materiasAsignadas.Keys)
            {
                sb.AppendLine($"- {materia}");
            }

            Console.WriteLine(sb.ToString());
        }

        /// <summary>
        /// Sobrescribe el método ToString para proporcionar una representación de cadena personalizada de la instancia de Alumno.
        /// </summary>
        /// <returns>
        /// Una cadena que representa la instancia de Alumno en el formato "Alumno - [Legajo]".
        /// </returns>
        public override string ToString()
        {
            return $"Alumno - {legajo}";
        }
    }
}
