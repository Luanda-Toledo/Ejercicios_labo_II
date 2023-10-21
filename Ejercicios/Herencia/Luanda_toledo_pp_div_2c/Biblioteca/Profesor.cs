using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Profesor : Persona
    {
        // Atributos
        private string email;
        private EMateria materiaAsignada;

        // Constructores
        public Profesor(int dni) : base(dni)
        {

        }
        public Profesor(int dni, string email) : this(dni)
        {
            this.email = email;
        }

        public Profesor(int dni, string email, EMateria materiaAsignada) : this(dni,email)
        {
            this.materiaAsignada = materiaAsignada;
        }

        /// <summary>
        /// Muestra los datos del profesor, incluyendo nombre, apellido, DNI, email y materia asignada.
        /// </summary>
        public void MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Email: {email}");
            sb.AppendLine($"Materia Asignada: {Enum.GetName(typeof(EMateria), materiaAsignada)}");

            Console.WriteLine(sb.ToString());
        }

        /// <summary>
        /// Propiedad que devuelve la información completa del profesor, incluyendo su nombre, apellido, DNI, email y materia asignada.
        /// </summary>
        public override string Informacion
        {
            get
            {
                // La materia asignada se obtiene utilizando Enum.GetName para obtener el nombre de la materia a partir de su valor numérico.
                string? materiaNombre = Enum.GetName(typeof(EMateria), materiaAsignada);
                return $"Profesor - {Nombre} {Apellido}, DNI: {dni}, Email: {email}, Materia Asignada: {materiaNombre}";
            }
        }

        /// <summary>
        /// Sobrescribe el método ToString para proporcionar una representación de cadena personalizada de la instancia de Profesor.
        /// </summary>
        /// <returns>
        /// Una cadena que representa la instancia de Profesor en el formato "Profesor - [Nombre de la Materia Asignada]".
        /// </returns>
        public override string ToString()
        {
            string? materiaNombre = Enum.GetName(typeof(EMateria), materiaAsignada);
            return $"Profesor - {materiaNombre}";
        }

        /// <summary>
        /// Evalúa a un alumno haciendo que rinda un examen de la materia asignada al profesor.
        /// </summary>
        /// <param name="alumno">El alumno que se evaluará.</param>
        public void Evaluar(Alumno alumno)
        {
            string mensaje = string.Empty;
            // Verificar si el alumno está inscrito en la misma materia que el profesor
            if (alumno.materiasAsignadas == this.materiaAsignada)
            {
                // El alumno está inscrito en la materia, hacer que rinda el examen
                bool exitoExamen = alumno.RendirExamen(this.materiaAsignada);

                if (exitoExamen)
                {
                    mensaje = $"El alumno {alumno.Nombre} {alumno.Apellido} ha rendido el examen de {Enum.GetName(typeof(EMateria), this.materiaAsignada)} con éxito.";
                }
                else
                {
                    mensaje = $"El alumno {alumno.Nombre} {alumno.Apellido} ya ha rendido el examen de {Enum.GetName(typeof(EMateria), this.materiaAsignada)}.";
                }
            }
            else
            {
                mensaje = $"El alumno {alumno.Nombre} {alumno.Apellido} no está inscrito en la misma materia que el profesor.";
            }
        }
    }
}
