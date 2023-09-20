using Billetes;
namespace Ejercicio_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";

            // Crea un objeto Euro llamado "billeteEuro" y le asigna un valor de 1 euro.
            Euro billeteEuro = 1;

            // Convierte el objeto "billeteEuro" de Euro a Peso utilizando una conversión explícita.
            Peso billetePeso = (Peso)billeteEuro;

            // Crea un objeto Dolar llamado "billeteDolar" y le asigna un valor de 100 dólares.
            Dolar billeteDolar = 100;

            // Imprime la cantidad de pesos en el objeto "billetePeso".
            Console.WriteLine(billetePeso.GetCantidad);

            // Convierte el objeto "billeteDolar" de Dolar a Peso utilizando una conversión explícita.
            billetePeso = (Peso)billeteDolar;

            Console.WriteLine("Cantidad de dolares convertidos a pesos: {0}", billetePeso.GetCantidad);
            Console.ReadKey();
        }
    }
}