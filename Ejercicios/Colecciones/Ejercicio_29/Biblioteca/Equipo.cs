using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private List<Jugador> jugadores;
        private short cantidadDeJugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
            cantidadDeJugadores = 0;
            nombre = "";
        }

        public Equipo(short cantidadDeJugadores, string nombre)
        {
            jugadores = new List<Jugador>();
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public void AgregarJugador(Jugador jugador)
        {
            if (!jugadores.Contains(jugador) && jugadores.Count < cantidadDeJugadores)
            {
                jugadores.Add(jugador);
                Console.WriteLine($"El jugador {jugador.MostrarDatos()} ha sido agregado al equipo {nombre}.");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar el jugador al equipo {nombre}.");
            }
        }

        public void MostrarJugadores()
        {
            Console.WriteLine($"Jugadores del equipo {nombre}:");
            foreach (Jugador jugador in jugadores)
            {
                Console.WriteLine(jugador.MostrarDatos());
            }
        }
    }
}
