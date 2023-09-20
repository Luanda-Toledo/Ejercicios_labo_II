namespace Biblioteca
{
    public class CalcularOperacionesMatematicas
    {
        public static double Calcular(double primerNumero, double segundoNumero, char operacionMatematica)
        {
            double resultado = 0;

            switch (operacionMatematica)
            {
                case '/':
                    if (!ValidarDivision(segundoNumero))
                    {
                        Console.WriteLine("¡ERROR! No se puede dividir por cero.");
                    }
                    else
                    {
                        resultado = primerNumero / segundoNumero;
                    }
                    break;

                case '*':
                    resultado = primerNumero * segundoNumero;
                    break;

                case '+':
                    resultado = primerNumero + segundoNumero;
                    break;

                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;

                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }

            return resultado;
        }

        private static bool ValidarDivision(double segundoNumero)
        {
            return segundoNumero != 0;
        }
    }
}