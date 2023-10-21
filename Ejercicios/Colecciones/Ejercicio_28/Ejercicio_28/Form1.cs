using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Este diccionario mantendrá el conteo de palabras
        private Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el texto actual del RichTextBox
            string texto = richTextBox1.Text;

            // Dividir el texto en palabras
            /*
             * Split: dividir una cadena (string) en varias subcadenas (strings más pequeños) en función de un separador especificado.
             * 
             * StringSplitOptions  es una enumeración en C# que se utiliza junto con el método Split para especificar cómo manejar
             * las cadenas vacías (o "tokens" vacíos) resultantes de la división de una cadena en partes más pequeñas.
             * 
             * RemoveEmptyEntries: Este valor indica que se deben eliminar las cadenas vacías resultantes de la división,
             * y no se incluirán en el arreglo resultante. Si hay tokens vacíos entre los separadores, se omitirán.
             */
            string[] palabras = texto.Split(new char[] { ' ', ',', '.', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Actualizar el diccionario de conteo de palabras
            foreach (string palabra in palabras)
            {
                /*
                 * ToLower() convierte a minúsculas. Para que las palabras en mayúsculas y minúsculas se consideren iguales en el conteo.
                 * Trim() para eliminar cualquier espacio en blanco adicional alrededor de las palabras
                 */
                string palabraNormalizada = palabra.ToLower().Trim();
                /*
                 * Se verifica si la palabra normalizada ya existe como clave en el diccionario.
                 * ContainsKey es un método que se utiliza en colecciones de tipo diccionario para verificar si una clave específica existe en el diccionario. 
                 */
                if (contadorPalabras.ContainsKey(palabraNormalizada))
                {
                    contadorPalabras[palabraNormalizada]++;
                }
                else
                {
                    contadorPalabras[palabraNormalizada] = 1; // Inicializar contador en 1 para palabras nuevas
                }
            }

            // Ordenar el diccionario en orden descendente por cantidad de apariciones
            /*
             * OrderByDescending significa "ordenar en orden descendente", del valor asociado a cada clave (la cantidad de apariciones de cada palabra).
             * pair es una variable que representa cada par clave-valor en el diccionario, y pair.Value se refiere al valor de cada par 
             * (en este caso, la cantidad de apariciones).
             * 
             * Take(3) para seleccionar las primeras 3 entradas del diccionario.
             */
            var topPalabras = contadorPalabras.OrderByDescending(pair => pair.Value).Take(3);

            // Construir el mensaje para mostrar el TOP 3
            string mensaje = "TOP 3 Palabras Más Frecuentes:\n";
            foreach (var item in topPalabras)
            {
                mensaje += $"{item.Key}: {item.Value} veces\n";
            }

            // Mostrar el mensaje en un MessageBox
            MessageBox.Show(mensaje, "Resultados"); 
        }
    }
}