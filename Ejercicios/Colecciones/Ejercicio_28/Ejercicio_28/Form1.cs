using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Este diccionario mantendr� el conteo de palabras
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
             * Split: dividir una cadena (string) en varias subcadenas (strings m�s peque�os) en funci�n de un separador especificado.
             * 
             * StringSplitOptions  es una enumeraci�n en C# que se utiliza junto con el m�todo Split para especificar c�mo manejar
             * las cadenas vac�as (o "tokens" vac�os) resultantes de la divisi�n de una cadena en partes m�s peque�as.
             * 
             * RemoveEmptyEntries: Este valor indica que se deben eliminar las cadenas vac�as resultantes de la divisi�n,
             * y no se incluir�n en el arreglo resultante. Si hay tokens vac�os entre los separadores, se omitir�n.
             */
            string[] palabras = texto.Split(new char[] { ' ', ',', '.', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Actualizar el diccionario de conteo de palabras
            foreach (string palabra in palabras)
            {
                /*
                 * ToLower() convierte a min�sculas. Para que las palabras en may�sculas y min�sculas se consideren iguales en el conteo.
                 * Trim() para eliminar cualquier espacio en blanco adicional alrededor de las palabras
                 */
                string palabraNormalizada = palabra.ToLower().Trim();
                /*
                 * Se verifica si la palabra normalizada ya existe como clave en el diccionario.
                 * ContainsKey es un m�todo que se utiliza en colecciones de tipo diccionario para verificar si una clave espec�fica existe en el diccionario. 
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
            string mensaje = "TOP 3 Palabras M�s Frecuentes:\n";
            foreach (var item in topPalabras)
            {
                mensaje += $"{item.Key}: {item.Value} veces\n";
            }

            // Mostrar el mensaje en un MessageBox
            MessageBox.Show(mensaje, "Resultados"); 
        }
    }
}