namespace Biblioteca
{
    public class AutoF1
    {
        // Atributos
        private short numero;
        private string escuderia;
        private bool enCompetencia;
        private short cantidadCombustible;
        private short vueltasRestantes;

        // Constructor
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
        }

        // Getters y setters
        public short Numero
        {
            get {
                return numero; 
                }

            set {
                numero = value; 
                }
        }

        public string Escuderia
        {
            get {
                return escuderia; 
                }

            set {
                escuderia = value; 
                }
        }

        public bool EnCompetencia
        {
            get {
                return enCompetencia; 
                }

            set {
                enCompetencia = value; 
                }
        }

        public short CantidadCombustible
        {
            get {                
                return cantidadCombustible; 
                }

            set {
                cantidadCombustible = value; 
                }
        }

        public short VueltasRestantes
        {
            get {
                return vueltasRestantes; 
                }

            set {
                vueltasRestantes = value; 
                }
        }

        // Sobrecarga de operadores de comparacion
        public static bool operator ==(AutoF1 f1, AutoF1 f2)
        {
            return f1.numero == f2.numero && f1.escuderia == f2.escuderia;
        }

        public static bool operator !=(AutoF1 f1, AutoF1 f2)
        {
            return !(f1 == f2);
        }

        public string MostrarDatos()
        {
            // La variable estadoCompetencia se inicializa como "En Competencia" si enCompetencia es verdadero,
            // de lo contrario, se inicializa como "Fuera de Competencia".
            string estadoCompetencia = enCompetencia ? "En Competencia" : "Fuera de Competencia";

            // Se construye una cadena de texto utilizando interpolación de cadenas.
            return $"Número: {numero}, Escudería: {escuderia}, Estado: {estadoCompetencia}, Combustible: {cantidadCombustible}, Vueltas Restantes: {vueltasRestantes}";
        }
    }
}