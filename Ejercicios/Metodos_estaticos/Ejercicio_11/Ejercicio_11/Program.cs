namespace Ejercicio_11
{
    /*
     * 11.- Realizar una clase llamada Validacion que posea un metodo estatico llamado validar, que posea la sig firma:
        boolValidar(int valor, int min, int max):
        a) valor: dato a validar
        b) min y max : rango en el cual debera estar la variable valor.
        Pedir al usuario que ingrese 10 numeros enteros. Validar con el metodo desarrollado anteriormente que esten dentro del rango -100 y 100.
        Terminado el ingreso mostrar el valor minimo, el valor maximo, y el promedio.
        Nota: utilizar variables escalares, no vectores.
     */
    internal class Validacion
    {
        /*
        Una variable escalar es una variable que almacena un solo valor a la vez, de un tipo de dato simple. 
        Ej:
        Enteros: int miNumero = 42;
        Flotante: double miDecimal = 3.1416;
        Caracteres: char miCaracter = 'A';
        Booleanos: bool esVerdadero = true;
        */
        /*
        Este código define una clase Validacion con un método estático Validar que verifica si un número está dentro del rango especificado. 
        Luego, en el método Main, se solicita al usuario que ingrese 10 números enteros, se valida cada número con el método Validar y
        se realiza un seguimiento del valor mínimo, el valor máximo y la suma de los números ingresados. 
        Finalmente, se calcula el promedio y se muestran todos los resultados.
        */

        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";
            int min = -100;
            int max = 100;
            int suma = 0;
            int valorMinimo = int.MaxValue;
            int valorMaximo = int.MinValue;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un número: ");

                // intentar convertirla en un número entero (int), y luego verificar si la conversión fue exitosa
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (Validar(numero, min, max))
                    {
                        suma += numero;
                        if (numero < valorMinimo)
                            valorMinimo = numero;
                        if (numero > valorMaximo)
                            valorMaximo = numero;
                    }
                    else
                    {
                        Console.WriteLine($"El número {numero} está fuera del rango permitido.");
                        i--; // Para que el usuario ingrese otro número válido.
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número entero.");
                    i--; // Para que el usuario ingrese otro número válido.
                }
            }

            double promedio = (double)suma / 10;

            Console.WriteLine($"El valor mínimo es: {valorMinimo}");
            Console.WriteLine($"El valor máximo es: {valorMaximo}");
            Console.WriteLine($"El promedio es: {promedio}");
        }
    }
}
    