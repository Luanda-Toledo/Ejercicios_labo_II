namespace Biblioteca
{
    public class Jugador
    {
        // Atributos
        private int dni;

        // Constructor
        public Jugador(int dni, string nombre)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            TotalGoles = 0;
            PartidosJugados = 0;
        }

        // Getters y setters
        public int Dni
        {
            get {
                    return dni; 
                }

            set {
                    dni = value;
                }
        }

        /*
         * Estas propiedades proporcionan un control sobre el acceso y la modificación de los datos de un jugador desde fuera de la clase.
         */
        public string Nombre 
        {
            get;

            set;
        }

        public int TotalGoles 
        { 
            get;
            private set; 
        }
        public int PartidosJugados 
        { 
            get; 
            private set; 
        }

        // Propiedad de solo lectura para calcular el promedio de goles
        public float PromedioDeGoles
        {
            get 
            {
                /*
                 * Calcula el promedio de goles de un jugador tomando en cuenta si ha jugado partidos o no. 
                 * Si ha jugado al menos un partido, se calcula el promedio de goles. 
                 * Si no ha jugado ningún partido, se devuelve 0 como el promedio de goles.
                 */
                return PartidosJugados == 0 ? 0 : (float)TotalGoles / PartidosJugados; 
            }
        }

        // Métodos
        public void RegistrarGol()
        {
            TotalGoles++;
            PartidosJugados++;
        }

        public string MostrarDatos()
        {
            return $"DNI: {Dni}, Nombre: {Nombre}, Goles: {TotalGoles}, Partidos Jugados: {PartidosJugados}, Promedio de Goles: {PromedioDeGoles}";
        }

        // Sobrecarga de comparadores
        /*
         * La función ReferenceEquals(jugador1, null) se utiliza para verificar si la referencia al objeto jugador1 es nula.
         */
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            if (ReferenceEquals(jugador1, null) && ReferenceEquals(jugador2, null))
                return true;

            if (ReferenceEquals(jugador1, null) || ReferenceEquals(jugador2, null))
                return false;

            return jugador1.Dni.Equals(jugador2.Dni);
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }

}