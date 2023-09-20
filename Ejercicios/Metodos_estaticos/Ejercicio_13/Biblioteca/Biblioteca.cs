namespace Biblioteca
{
    public class Conversiones
    {
        public static string DecimalBinario(int numero)
        {
            if (numero == 0)
            {
                return "0"; // Tratamiento especial para el caso de 0.
            }

            string binario = ""; // Aquí almacenaremos la representación binaria.

            while (numero > 0)
            {
                int residuo = numero % 2; // Obtenemos el residuo de la división por 2.
                binario = residuo + binario; // Agregamos el residuo a la izquierda de la cadena binaria.
                numero /= 2; // Dividimos el número por 2 para continuar con el siguiente dígito binario.
            }

            return binario;
        }

        public static int BinarioDecimal(string binario)
        {
            int decimalResult = 0;
            int longitud = binario.Length;

            for (int i = 0; i < longitud; i++)
            {
                int digito = int.Parse(binario[i].ToString()); // Convertimos el dígito a entero.
                int exponente = longitud - i - 1; // Calculamos el exponente correspondiente.

                // Sumamos el dígito binario multiplicado por 2 elevado al exponente.
                decimalResult += digito * (int)Math.Pow(2, exponente);
            }

            return decimalResult;
        }
    }
}