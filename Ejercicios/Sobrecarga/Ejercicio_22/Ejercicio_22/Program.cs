using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numeroBinario = (NumeroBinario)"1111";
            NumeroDecimal numeroDecimal = (NumeroDecimal)8;

            Console.WriteLine($"El numero binario es: {numeroBinario.Numero}, sumado con el decimal da un total de {numeroDecimal + numeroBinario}");
            Console.WriteLine($"El numero decimal es: {numeroDecimal.Numero}, sumado con el binario da un total de {numeroBinario + numeroDecimal}");

            Console.WriteLine($"El numero binario es: {numeroBinario.Numero}, restado con el decimal da un total de {numeroDecimal - numeroBinario}");
            Console.WriteLine($"El numero decimal es: {numeroDecimal.Numero}, restado con el decimal da un total de {numeroBinario - numeroDecimal}");
        }
    }
}