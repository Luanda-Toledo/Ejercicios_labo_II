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
        public string Nombre 
        {
            get;

            set;
        }

        public Equipo(short cantidadDeJugadores, string nombre)
        {
            jugadores = new List<Jugador>();
            this.cantidadDeJugadores = cantidadDeJugadores;
            Nombre = nombre;
        }

        public void AgregarJugador(Jugador jugador)
        {
            if (!jugadores.Contains(jugador) && jugadores.Count < cantidadDeJugadores)
            {
                jugadores.Add(jugador);
                Console.WriteLine($"El jugador {jugador.MostrarDatos()} ha sido agregado al equipo {Nombre}.");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar el jugador al equipo {Nombre}.");
            }
        }

        public void MostrarJugadores()
        {
            Console.WriteLine($"Jugadores del equipo {Nombre}:");
            foreach (Jugador jugador in jugadores)
            {
                Console.WriteLine(jugador.MostrarDatos());
            }
        }
    }
}
