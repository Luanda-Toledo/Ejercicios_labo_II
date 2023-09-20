using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Entidades
    {
        // Declaramos atributos de la clase Alumno
        public class Alumno
        {
            private byte nota1; 
            private byte nota2;
            private float notaFinal;
            private string apellido;
            private int legajo;
            private string nombre;
            private static Random random;

            static Alumno()
            {
                Alumno.random = new Random();
            }

            //constructor (inicializacion de atributos)
            public Alumno(byte nota1, byte nota2, string apellido, int legajo, string nombre)
            {
                this.nota1 = nota1;     
                this.nota2 = nota2;
                this.apellido = apellido;
                this.legajo = legajo;
                this.nombre = nombre;
            }

            /// <summary>
            /// Calcula la nota final del alumno y la asigna según ciertos criterios de aprobación.
            /// (Valida que este aprobado y actualiza segun corresponda)
            /// </summary>
            /// <remarks>
            /// La nota final se calcula de la siguiente manera:
            /// - Si ambas notas (nota1 y nota2) son iguales o mayores a 4, se genera una nota final aleatoria entre 4 y 10 (inclusive).
            /// - Si alguna de las notas es menor que 4, el alumno se considera desaprobado y la nota final se establece en -1.
            /// </remarks>
            public void CalcularFinal() 
            {
                if (this.nota1 >= 4 && this.nota2 >= 4)
                {
                    this.notaFinal = Alumno.random.Next(4, 11);
                }
                else
                {
                    this.notaFinal = -1;
                }
            }

            /// <summary>
            /// Actualiza las notas del alumno después de estudiar, asegurando que estén dentro del rango válido (0-10).
            /// </summary>
            /// <param name="nota1">La nueva nota del primer examen.</param>
            /// <param name="nota2">La nueva nota del segundo examen.</param>
            /// <remarks>
            /// Este método permite que el alumno actualice sus notas después de estudiar. Las notas deben estar en el rango de 0 a 10 para ser válidas.
            /// Si se proporciona una nota fuera de este rango, no se realizarán cambios en la nota correspondiente.
            /// </remarks>
            public void Estudiar(byte nota1, byte nota2)
            {
                if (nota1 > 0 && nota1 < 11)
                {
                    this.nota1 = nota1;
                }

                if (nota2 > 0 && nota2 < 11)
                {
                    this.nota2 = nota2;
                }
            }

            /// <summary>
            /// Obtiene una representación en forma de cadena de los datos del alumno.
            /// </summary>
            /// <returns>
            /// Una cadena que contiene los datos del alumno, incluyendo nombre, apellido, legajo, notas y nota final (si está aprobado).
            /// </returns>
            /// <remarks>
            /// Este método construye una cadena multilinea utilizando la clase StringBuilder para mostrar los datos del alumno de manera organizada.
            /// Si el alumno está desaprobado, se mostrará un mensaje indicando esto en lugar de la nota final.
            /// </remarks>
            public string Mostrar()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Datos del Alumno:"); // con str builder construimos una cadena multilinea(sb)
                sb.AppendLine("Nombre: " + nombre);
                sb.AppendLine("Apellido: " + apellido);
                sb.AppendLine("Legajo: " + legajo);
                sb.AppendLine("Nota 1: " + nota1);
                sb.AppendLine("Nota 2: " + nota2);

                if (notaFinal != -1)
                {
                    sb.AppendLine("Nota Final: " + notaFinal);
                }
                else
                {
                    sb.AppendLine("Alumno desaprobado");
                }

                return sb.ToString(); //se usa para convertir el contenido de string builder(sb) en una cadena
            }

        }
    }
}