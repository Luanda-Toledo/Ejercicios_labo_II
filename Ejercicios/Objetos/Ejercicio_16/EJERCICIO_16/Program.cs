using Entidades;
using System.Runtime.CompilerServices;
using static Entidades.Entidades;

namespace ej16
{
    internal class program
    {
        /*
         * public Alumno(byte nota1, byte nota2, string apellido, int legajo, string nombre)
         */
        static void Main(string[] args)
        {
            // Utiliza el constructor para crear instancias de Alumno
            Alumno alum1 = new Alumno(7, 9, "Gómez", 101, "Juan");
            Alumno alum2 = new Alumno(4, 10, "Pozo", 100, "Mariano");
            Alumno alum3 = new Alumno(2, 5, "Smith", 102, "Alice");

            alum1.Estudiar(7, 9);
            alum2.Estudiar(4, 10);
            alum3.Estudiar(2, 5);

            alum1.CalcularFinal();
            alum2.CalcularFinal();
            alum3.CalcularFinal();

            Console.WriteLine(alum1.Mostrar());
            Console.WriteLine(alum2.Mostrar());
            Console.WriteLine(alum3.Mostrar());


        }
    }
}