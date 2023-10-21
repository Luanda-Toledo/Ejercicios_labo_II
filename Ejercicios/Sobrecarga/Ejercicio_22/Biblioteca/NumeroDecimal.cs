using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NumeroDecimal
    {
        // Generamos atributos y constructores
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double Numero
        {
            get 
            { 
                return this.numero; 
            }
        }

        // Metodos de conversion (del ejercicio 13, reemplazamos el tipo de variables de ingreso del metoso)
        public string DecimalBinario(double numero)
        {
            string valorBinario = string.Empty;
            int resultadoDivision = (int)numero;
            int restoDeLaDivision;

            // Generamos variables para verificar si el resultado es igual a 0 y otra para verificar el resto.
            do
            {
                restoDeLaDivision = resultadoDivision % 2;
                resultadoDivision /= 2;
                //Para dejar la ultima division en la primer posicion
                valorBinario = restoDeLaDivision.ToString() + valorBinario;
            } while (resultadoDivision > 0);

            return valorBinario;
        }

        // Generamos las sobrecargas
        public static explicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);   
        }

        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)numeroDecimal.DecimalBinario(numeroDecimal.Numero);
        }

        // Generamos las sobrecargas de comparadores, operadores de suma y resta

        public static bool operator ==(NumeroDecimal d, NumeroBinario b) 
        {
            return d.Numero == ((NumeroDecimal)b).Numero;   
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(d == b);
        }

        public static double operator +(NumeroDecimal d, double b)
        {
            return d.Numero + ((NumeroDecimal)b).Numero;
        }

        public static double operator -(NumeroDecimal d, double b) 
        {
            return d.Numero - ((NumeroDecimal)b).Numero;
        }

    }
}