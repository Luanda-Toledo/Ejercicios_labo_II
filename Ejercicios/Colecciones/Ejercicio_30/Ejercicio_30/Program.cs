using Biblioteca;

namespace Ejercicio_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear autos de Fórmula 1
            AutoF1 auto1 = new AutoF1(1, "Ferrari");
            AutoF1 auto2 = new AutoF1(2, "Mercedes");
            AutoF1 auto3 = new AutoF1(3, "Red Bull");
            AutoF1 auto4 = new AutoF1(1, "Ferrari"); // Mismo número y escudería que auto1

            // Mostrar información de los autos
            Console.WriteLine("Información de los autos:");
            MostrarInformacionAuto(auto1);
            MostrarInformacionAuto(auto2);
            MostrarInformacionAuto(auto3);
            MostrarInformacionAuto(auto4);

            // Verificar si dos autos son iguales
            bool sonIguales = auto1 == auto2;
            Console.WriteLine($"¿auto1 y auto2 son iguales?: {sonIguales}");

            sonIguales = auto1 == auto4;
            Console.WriteLine($"¿auto1 y auto4 son iguales?: {sonIguales}");

            // Crear una competencia
            Competencia competencia = new Competencia(3, 10);

            // Agregar autos a la competencia
            AgregarAutoACompetencia(competencia, auto1);
            AgregarAutoACompetencia(competencia, auto2);
            AgregarAutoACompetencia(competencia, auto3);
            AgregarAutoACompetencia(competencia, auto4); // No debería agregarse porque es igual a auto1

            // Mostrar información de los autos en la competencia
            Console.WriteLine("\nInformación de los autos en la competencia:");
            competencia.MostrarCompetidores();

            // Cambiar el estado de competencia de algunos autos
            CambiarEstadoCompetencia(auto1, true);
            CambiarEstadoCompetencia(auto2, true);

            // Mostrar información de los autos en la competencia después de cambiar el estado
            Console.WriteLine("\nInformación de los autos en la competencia después de cambiar el estado:");
            competencia.MostrarCompetidores();
        }

        static void MostrarInformacionAuto(AutoF1 auto)
        {
            Console.WriteLine(auto.MostrarDatos());
        }

        static void AgregarAutoACompetencia(Competencia competencia, AutoF1 auto)
        {
            if (competencia + auto)
            {
                Console.WriteLine($"{auto.Escuderia} - Auto{auto.Numero} agregado a la competencia.");
            }
            else
            {
                Console.WriteLine($"{auto.Escuderia} - Auto{auto.Numero} no se agregó a la competencia debido a duplicación o límite.");
            }
        }

        static void CambiarEstadoCompetencia(AutoF1 auto, bool enCompetencia)
        {
            auto.EnCompetencia = enCompetencia;
        }
    }
}