using Biblioteca;

namespace Ejercicio_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un equipo con capacidad para 5 jugadores y un nombre
            Equipo equipo = new Equipo(5, "Equipo A");

            // Crear jugadores
            Jugador jugador1 = new Jugador(12345, "Lionel Messi");
            Jugador jugador2 = new Jugador(67890, "Cristiano Ronaldo");
            Jugador jugador3 = new Jugador(54321, "Neymar Jr.");
            Jugador jugador4 = new Jugador(67890, "Cristiano Ronaldo"); // Duplicado, no se debe agregar
            Jugador jugador5 = new Jugador(13579, "Kylian Mbappé");

            // Registrar goles para algunos jugadores
            jugador1.RegistrarGol();
            jugador1.RegistrarGol();
            jugador2.RegistrarGol();
            jugador2.RegistrarGol();
            jugador3.RegistrarGol();
            jugador4.RegistrarGol();
            jugador5.RegistrarGol();

            // Agregar jugadores al equipo
            equipo.AgregarJugador(jugador1);
            equipo.AgregarJugador(jugador2);
            equipo.AgregarJugador(jugador3);
            equipo.AgregarJugador(jugador4); // No se debe agregar debido a duplicado
            equipo.AgregarJugador(jugador5);

            // Mostrar jugadores del equipo
            equipo.MostrarJugadores();

            // Comprobar la igualdad de jugadores
            Console.WriteLine("\nComprobar igualdad de jugadores:");
            Console.WriteLine($"¿jugador1 es igual a jugador2? {(jugador1 != null && jugador2 != null && jugador1 == jugador2)}");
            Console.WriteLine($"¿jugador1 es igual a jugador4? {(jugador2 != null && jugador4 != null && jugador2 == jugador4)}");

            // Cambiar el nombre de un jugador
            jugador1.Nombre = "Leo Messi";

            // Mostrar jugadores actualizados
            Console.WriteLine("\nJugadores del equipo después de cambiar el nombre:");
            equipo.MostrarJugadores();
        }
    }
}