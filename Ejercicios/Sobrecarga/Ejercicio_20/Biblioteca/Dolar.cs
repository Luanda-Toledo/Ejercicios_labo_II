using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        // Generamos atributos
        //
        //

        private double cantidad; // Almacena la cantidad de dolares
        // Almacena la cotización del dólar en relación a otra moneda (por ejemplo, el euro).
        private static double cotizRespectoDolar;

        // Generamos constructores

        /// <summary>
        /// Constructor estático de la clase Dolar que se ejecuta una sola vez durante la inicialización de la clase.
        /// Su propósito es establecer la cotización por defecto del dólar a 1 unidad de la misma moneda (generalmente el dólar a sí mismo).
        /// </summary>
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        /// <summary>
        /// Constructor de la clase Dolar que inicializa la cantidad de dólares.
        /// </summary>
        /// <param name="cantidad">La cantidad de dólares a representar.</param>
        public Dolar (double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Constructor de la clase Dolar que inicializa la cantidad de dólares y la cotización del dólar en relación a otra moneda.
        /// </summary>
        /// <param name="cantidad">La cantidad de dólares a representar.</param>
        /// <param name="cotizacion">La cotización del dólar en relación a otra moneda.</param>
        public Dolar(double cantidad, double cotizacion)
            :this(cantidad)
        {
           Dolar.cotizRespectoDolar = cotizacion;
        }

        // Reemplazamos los metodos GET por propiedades

        /// <summary>
        /// Propiedad que obtiene la cantidad de dólares representada por un objeto Dolar.
        /// </summary>
        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        /// <summary>
        /// Propiedad estática que obtiene la cotización actual del dólar en relación a otra moneda.
        /// </summary>
        public static double GetCotizacion
        {
            get
            {
                return Dolar.cotizRespectoDolar;
            }
        }

        /// <summary>
        /// Sobrecarga del operador de conversión implícita que permite crear un objeto Dolar a partir de un valor double automáticamente.
        /// </summary>
        /// <param name="d">El valor double que se convertirá en un objeto Dolar.</param>
        /// <returns>Un objeto Dolar con la cantidad especificada.</returns>
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        // Sobrecargas explicitas para euro y pesos
        /// <summary>
        /// Método de conversión explícita que permite convertir un objeto Dolar en un objeto Euro.
        /// Calcula la cantidad equivalente en euros multiplicando la cantidad de dólares por la cotización actual del euro en relación al dólar.
        /// </summary>
        /// <param name="d">El objeto Dolar que se desea convertir en Euro.</param>
        /// <returns>Un objeto Euro con la cantidad equivalente en euros.</returns>
        public static explicit operator Euro(Dolar d) 
        {
            return new Euro((d.cantidad * Euro.GetCotizacion));
        }

        /// <summary>
        /// Método de conversión explícita que permite convertir un objeto Dolar en un objeto Peso.
        /// Calcula la cantidad equivalente en pesos multiplicando la cantidad de dólares por la cotización actual del peso en relación al dólar.
        /// </summary>
        /// <param name="d">El objeto Dolar que se desea convertir en Peso.</param>
        /// <returns>Un objeto Peso con la cantidad equivalente en pesos.</returns>
        public static explicit operator Peso(Dolar d)
        {
            return new Peso((d.cantidad * Peso.GetCotizacion));
        }

        // Generamos los comparadores y operadores aritmeticos
        // Sobrecarga del operador de igualdad (==) para comparar dos objetos Dolar.
        /// <summary>
        /// Compara si dos objetos Dolar son iguales en cuanto a su cantidad de dólares.
        /// </summary>
        /// <param name="d1">El primer objeto Dolar a comparar.</param>
        /// <param name="d2">El segundo objeto Dolar a comparar.</param>
        /// <returns>True si los objetos Dolar tienen la misma cantidad de dólares, de lo contrario, False.</returns>
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad == d2.GetCantidad);
        }

        // Sobrecarga del operador de desigualdad (!=) para comparar dos objetos Dolar.
        /// <summary>
        /// Compara si dos objetos Dolar no son iguales en cuanto a su cantidad de dólares.
        /// </summary>
        /// <param name="d1">El primer objeto Dolar a comparar.</param>
        /// <param name="d2">El segundo objeto Dolar a comparar.</param>
        /// <returns>True si los objetos Dolar tienen diferentes cantidades de dólares, de lo contrario, False.</returns>
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2); // Reutilizamos la comparación anterior
        }

        // Sobrecarga del operador de igualdad (==) para comparar un objeto Dolar y un objeto Euro.
        /// <summary>
        /// Compara si un objeto Dolar y un objeto Euro son iguales en cuanto a su cantidad convertida a dólares.
        /// </summary>
        /// <param name="d">El objeto Dolar a comparar.</param>
        /// <param name="e">El objeto Euro a comparar.</param>
        /// <returns>True si los objetos tienen la misma cantidad en dólares, de lo contrario, False.</returns>
        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.GetCantidad == (Dolar)e.GetCantidad);
        }

        // Sobrecarga del operador de desigualdad (!=) para comparar un objeto Dolar y un objeto Euro.
        /// <summary>
        /// Compara si un objeto Dolar y un objeto Euro no son iguales en cuanto a su cantidad convertida a dólares.
        /// </summary>
        /// <param name="d">El objeto Dolar a comparar.</param>
        /// <param name="e">El objeto Euro a comparar.</param>
        /// <returns>True si los objetos tienen diferentes cantidades en dólares, de lo contrario, False.</returns>
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        // Sobrecarga del operador de igualdad (==) para comparar un objeto Dolar y un objeto Peso.
        /// <summary>
        /// Compara si un objeto Dolar y un objeto Peso son iguales en cuanto a su cantidad convertida a dólares.
        /// </summary>
        /// <param name="d">El objeto Dolar a comparar.</param>
        /// <param name="p">El objeto Peso a comparar.</param>
        /// <returns>True si los objetos tienen la misma cantidad en dólares, de lo contrario, False.</returns>
        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.GetCantidad == ((Dolar)p).GetCantidad);
        }

        // Sobrecarga del operador de desigualdad (!=) para comparar un objeto Dolar y un objeto Peso.
        /// <summary>
        /// Compara si un objeto Dolar y un objeto Peso no son iguales en cuanto a su cantidad convertida a dólares.
        /// </summary>
        /// <param name="d">El objeto Dolar a comparar.</param>
        /// <param name="p">El objeto Peso a comparar.</param>
        /// <returns>True si los objetos tienen diferentes cantidades en dólares, de lo contrario, False.</returns>
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        // Sobrecarga del operador de resta (-) para restar un objeto Euro de un objeto Dolar.
        /// <summary>
        /// Resta la cantidad en euros convertida a dólares de un objeto Euro de un objeto Dolar.
        /// </summary>
        /// <param name="d">El objeto Dolar al que se le resta un objeto Euro.</param>
        /// <param name="e">El objeto Euro que se resta.</param>
        /// <returns>Un objeto Dolar con la cantidad restante en dólares.</returns>
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad - ((Dolar)e).GetCantidad));
        }

        // Sobrecarga del operador de resta (-) para restar un objeto Peso de un objeto Dolar.
        /// <summary>
        /// Resta la cantidad en pesos convertida a dólares de un objeto Peso de un objeto Dolar.
        /// </summary>
        /// <param name="d">El objeto Dolar al que se le resta un objeto Peso.</param>
        /// <param name="p">El objeto Peso que se resta.</param>
        /// <returns>Un objeto Dolar con la cantidad restante en dólares.</returns>
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar((d.GetCantidad - ((Dolar)p).GetCantidad));
        }

        // Sobrecarga del operador de suma (+) para sumar un objeto Euro a un objeto Dolar.
        /// <summary>
        /// Suma la cantidad en euros convertida a dólares de un objeto Euro a un objeto Dolar.
        /// </summary>
        /// <param name="d">El objeto Dolar al que se le suma un objeto Euro.</param>
        /// <param name="e">El objeto Euro que se suma.</param>
        /// <returns>Un objeto Dolar con la cantidad resultante en dólares.</returns>
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad + ((Dolar)e).GetCantidad));
        }

        // Sobrecarga del operador de suma (+) para sumar un objeto Peso a un objeto Dolar.
        /// <summary>
        /// Suma la cantidad en pesos convertida a dólares de un objeto Peso a un objeto Dolar.
        /// </summary>
        /// <param name="d">El objeto Dolar al que se le suma un objeto Peso.</param>
        /// <param name="p">El objeto Peso que se suma.</param>
        /// <returns>Un objeto Dolar con la cantidad resultante en dólares.</returns>
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar((d.GetCantidad + ((Dolar)p).GetCantidad));
        }

    }
}