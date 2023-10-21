namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int totalGoles;
        private int partidosJugados;
        private float promedioGoles;

        private Jugador()
        {
            dni = 0;
            nombre = "";
            totalGoles = 0;
            partidosJugados = 0;
            promedioGoles = 0;  
        }

        /// <summary>
        /// Constructor público para crear un objeto Jugador con DNI y nombre.
        /// </summary>
        /// <param name="DNI">El número de DNI del jugador.</param>
        /// <param name="nombre">El nombre del jugador.</param>
        public Jugador(int DNI, string nombre)
        {
            this.dni = DNI;
            this.nombre = nombre;
            totalGoles = 0;
            partidosJugados = 0;
            promedioGoles = 0;
        }

        /// <summary>
        /// Registra un gol y aumenta la cantidad de partidos jugados.
        /// </summary>
        public void RegistrarGol()
        {
            totalGoles++;
            partidosJugados++;
        }

        /// <summary>
        /// Calcula y devuelve el promedio de goles por partido del jugador.
        /// </summary>
        /// <returns>El promedio de goles por partido.</returns>
        public float GetPromedioGoles()
        {
            if (partidosJugados == 0)
                return 0;
            promedioGoles = (float)totalGoles / partidosJugados;
            return promedioGoles;
        }

        /// <summary>
        /// Retorna una cadena de texto con los datos y estadísticas del jugador.
        /// </summary>
        /// <returns>Los datos del jugador en formato de cadena.</returns>
        public string MostrarDatos()
        {
            return $"DNI: {dni}, Nombre: {nombre}, Goles: {totalGoles}, Partidos Jugados: {partidosJugados}, Promedio de Goles: {promedioGoles}";
        }

        /*
         * Equals(object obj): Este método se utiliza para determinar si dos objetos de tipo Jugador son iguales o no.
         * Primero, se verifica si obj es realmente un objeto de tipo Jugador usando obj is Jugador.
           Si obj es un Jugador, se realiza un casting de obj a un objeto de tipo Jugador llamado jugador.
           Luego, se compara el DNI del jugador actual (representado por this.DNI) con el DNI del jugador jugador que se pasó como parámetro.
           Si los DNI son iguales, el método devuelve true, lo que indica que los jugadores son iguales. En caso contrario, devuelve false.
         */
        public override bool Equals(object obj)
        {
            if (obj is Jugador)
            {
                Jugador jugador = (Jugador)obj;
                return dni.Equals(jugador.dni);
            }
            return false;
        }
    }
}