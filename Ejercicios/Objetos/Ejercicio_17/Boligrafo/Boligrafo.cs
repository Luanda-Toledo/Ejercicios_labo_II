namespace Biblioteca
{
    public class Boligrafo
    {
        //-----Generamos los atributos
        public const short cantidadTintaMaxima = 100; // A
        private ConsoleColor color;
        private short tinta;

        //------Generamos el constructor 
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        //-----Generamos los metodos GET // B
        /// <summary>
        /// Obtiene el color asociado a este objeto.
        /// </summary>
        /// <returns>El valor ConsoleColor que representa el color.</returns>
        public ConsoleColor GetColor() 
        {
            return this.color;
        }

        /// <summary>
        /// Obtiene el nivel de tinta actual.
        /// </summary>
        /// <returns>Un valor corto (short) que representa el nivel de tinta.</returns>
        public short GetTinta() 
        {
            return this.tinta;
        }

        //Generamos el metodo privado SetTinta // C
        /// <summary>
        /// Establece el nivel de tinta del boligrafo a un valor específico.
        /// </summary>
        /// <param name="tinta">El valor corto (short) que se utilizará para establecer el nivel de tinta.</param>
        private void SetTinta(short tinta) 
        {
            if (tinta > 0) // recarga de tinta
            {
                if ((this.tinta + tinta) > cantidadTintaMaxima) 
                {
                    this.tinta = cantidadTintaMaxima;
                }
                else
                {
                    this.tinta += tinta;
                }
            }
            else if (tinta < 0) // gasto de tinta 
            {
                if (this.tinta > 0) 
                {
                    if (((this.tinta + tinta) < 0))
                    {
                        this.tinta = 0;
                    }
                    else
                    {
                        this.tinta += tinta; //Le sumamos un valor negativo (lo que descontara ese valor negativo del valor actual)
                    }
                }
            }
        }

        // D
        /// <summary>
        /// Recarga la tinta del objeto al nivel máximo permitido.
        /// </summary>
        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        // F
        /// <summary>
        /// Simula la acción de pintar utilizando una cantidad específica de tinta.
        /// </summary>
        /// <param name="gasto">La cantidad de tinta que se utilizará para pintar.</param>
        /// <param name="dibujo">Una cadena que almacenará el resultado del dibujo (una serie de asteriscos).</param>
        /// <returns>Devuelve true si la acción de pintar se completó con éxito, o false si no se pudo debido a la falta de tinta.</returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            string cadenaAux = string.Empty; // Su valor inicial es una cadena vacia
            bool returnAux = false;
            short cont = 0; // Ajusta el nivel de tinta en funcion del gasto de tinta real durante la pintura

            if (this.tinta == 0)
            {
                dibujo = "No se puede pintar ya que no posee tinta";
            }
            else
            {
                while (gasto > 0 && (this.tinta + cont) > 0) 
                {
                    cadenaAux += "*";
                    cont--;
                    gasto--;
                }
                dibujo = cadenaAux;
                returnAux = true;
                this.SetTinta(cont); // Seteamos el nivel de tinta segun el gasto que se realizo.
            }
            return returnAux;
        }
    }
}