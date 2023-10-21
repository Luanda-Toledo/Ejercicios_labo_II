using Biblioteca;

namespace Ejercicio_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(5, "Equipo A"); // Crear un equipo con capacidad para 5 jugadores y un nombre

            Jugador jugador1 = new Jugador(12345, "Lionel Messi");
            Jugador jugador2 = new Jugador(67890, "Cristiano Ronaldo");
            Jugador jugador3 = new Jugador(54321, "Neymar Jr.");
            Jugador jugador4 = new Jugador(67890, "Cristiano Ronaldo"); // Duplicado, no se debe agregar
            Jugador jugador5 = new Jugador(13579, "Kylian Mbappé");

            jugador1.RegistrarGol();
            jugador1.RegistrarGol();
            jugador2.RegistrarGol();
            jugador2.RegistrarGol();
            jugador3.RegistrarGol();
            jugador4.RegistrarGol();
            jugador5.RegistrarGol();

            equipo.AgregarJugador(jugador1);
            equipo.AgregarJugador(jugador2);
            equipo.AgregarJugador(jugador3);
            equipo.AgregarJugador(jugador4);
            equipo.AgregarJugador(jugador5);

            equipo.MostrarJugadores();
        }
    }
}