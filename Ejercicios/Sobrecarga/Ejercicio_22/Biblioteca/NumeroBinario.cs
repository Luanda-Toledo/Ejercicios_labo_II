using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NumeroBinario
    {
        private string numero;

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }
            
        public string Numero
        {
            get 
            { 
                return this.numero;
            }
        }

        public double BinarioDecimal(string valorRecibido)
        {
            //El valor a retornar
            //Lo inicializamos en cero dado que si la cadena recibida no corresponde a un binario, retornamos cero.
            double resultado = 0;
            //Guardamos la longitud de la cadena para saber hasta donde tenemos que ir calculando.
            int cantidadCaracteres = valorRecibido.Length;

            foreach(char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if(caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;
        }

         // Generamos las sobrecargas
         public static explicit operator NumeroBinario (string numero) 
         {
            return new NumeroBinario(numero);
         }

         public static explicit operator NumeroDecimal(NumeroBinario b)
         {
            return (NumeroDecimal)b.BinarioDecimal(b.Numero);
         }

         // Generamos las sobrecargas de comparadores, operadores de suma y resta
         public static bool operator == (NumeroBinario b, NumeroDecimal d)
         {
            return b.Numero == ((NumeroBinario)d).Numero;   
         }

         public static bool operator != (NumeroBinario b, NumeroDecimal d)
         {
            return !(b == d);
         } 

         public static string operator +(NumeroBinario b, NumeroDecimal d)
         {
            // Usamos el metodo decimal a binario para convertir la suma de los dos numeros en decimal 
            return d.DecimalBinario(((NumeroDecimal)b).Numero + d.Numero); 
         }

         public static string operator -(NumeroBinario b, NumeroDecimal d)
         {
            return d.DecimalBinario(((NumeroDecimal)b).Numero - d.Numero);
         }
    }
}
