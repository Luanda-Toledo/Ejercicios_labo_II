using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        // Generamos sus atributos
        private double cantidad; 
        private static double cotizRespectoDolar;

        // Generamos constructores

        /// <summary>
        /// Constructor estático de la clase Euro que se ejecuta una sola vez durante la inicialización de la clase.
        /// Su propósito es establecer la cotización por defecto del Euro.
        /// </summary>
        static Euro()
        {
            Euro.cotizRespectoDolar = 1/1.18;
        }

        /// <summary>
        /// Constructor de la clase Euro que inicializa la cantidad de euros.
        /// </summary>
        /// <param name="cantidad">La cantidad de euros a representar.</param>
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Constructor de la clase Euro que inicializa la cantidad de euros y la cotización del dólar en relación a otra moneda.
        /// </summary>
        /// <param name="cantidad">La cantidad de euros a representar.</param>
        /// <param name="cotizacion">La cotización del euro en relación a otra moneda.</param>
        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        // Reemplazamos los metodos GET por propiedades

        /// <summary>
        /// Propiedad que obtiene la cantidad de euros representada por un objeto Euro.
        /// </summary>
        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        /// <summary>
        /// Propiedad estática que obtiene la cotización actual del Euro en relación a otra moneda.
        /// </summary>
        public static double GetCotizacion
        {
            get
            {
                return Euro.cotizRespectoDolar;
            }
        }

        /// <summary>
        /// Sobrecarga del operador de conversión implícita que permite crear un objeto Euro a partir de un valor double automáticamente.
        /// </summary>
        /// <param name="d">El valor double que se convertirá en un objeto Euro.</param>
        /// <returns>Un objeto Euro con la cantidad especificada.</returns>
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        // Sobrecargas explicitas para Peso y Dolar
        // Método de conversión explícita de Euro a Peso
        /// <summary>
        /// Convierte un objeto Euro en un objeto Peso de forma explícita.
        /// Calcula la cantidad equivalente en pesos multiplicando la cantidad de euros por la cotización actual del euro en relación al dólar.
        /// </summary>
        /// <param name="e">El objeto Euro que se desea convertir en Peso.</param>
        /// <returns>Un objeto Peso que representa la cantidad equivalente en pesos.</returns>
        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e); // De esta manera reutilizamos las conversiones explicitas.
        }

        // Método de conversión explícita de Euro a Dolar
        /// <summary>
        /// Convierte un objeto Euro en un objeto Dolar de forma explícita.
        /// Calcula la cantidad equivalente en dólares dividiendo la cantidad de euros por la cotización actual del euro en relación al dólar.
        /// </summary>
        /// <param name="e">El objeto Euro que se desea convertir en Dolar.</param>
        /// <returns>Un objeto Dolar que representa la cantidad equivalente en dólares.</returns>
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar((e.cantidad / Euro.GetCotizacion));
        }

        // Generamos los comparadores y operadores aritmeticos
        // Sobrecarga del operador de igualdad (==) para comparar dos objetos Euro.
        /// <summary>
        /// Compara si dos objetos Euro son iguales en cuanto a su cantidad de euros.
        /// </summary>
        /// <param name="e1">El primer objeto Euro a comparar.</param>
        /// <param name="e2">El segundo objeto Euro a comparar.</param>
        /// <returns>True si los objetos Euro tienen la misma cantidad de euros, de lo contrario, False.</returns>
        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.GetCantidad == e2.GetCantidad);
        }

        // Sobrecarga del operador de desigualdad (!=) para comparar dos objetos Euro.
        /// <summary>
        /// Compara si dos objetos Euro no son iguales en cuanto a su cantidad de euros.
        /// </summary>
        /// <param name="e1">El primer objeto Euro a comparar.</param>
        /// <param name="e2">El segundo objeto Euro a comparar.</param>
        /// <returns>True si los objetos Euro tienen diferentes cantidades de euros, de lo contrario, False.</returns>
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2); // Reutilizamos la comparación anterior
        }

        // Sobrecarga del operador de igualdad (==) para comparar un objeto Euro y un objeto Dolar.
        /// <summary>
        /// Compara si un objeto Euro y un objeto Dolar son iguales en cuanto a su cantidad convertida a euros.
        /// </summary>
        /// <param name="e">El objeto Euro a comparar.</param>
        /// <param name="d">El objeto Dolar a comparar.</param>
        /// <returns>True si los objetos tienen la misma cantidad en euros, de lo contrario, False.</returns>
        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.GetCantidad == (Euro)d.GetCantidad);
        }

        // Sobrecarga del operador de desigualdad (!=) para comparar un objeto Euro y un objeto Dolar.
        /// <summary>
        /// Compara si un objeto Euro y un objeto Dolar no son iguales en cuanto a su cantidad convertida a euros.
        /// </summary>
        /// <param name="e">El objeto Euro a comparar.</param>
        /// <param name="d">El objeto Dolar a comparar.</param>
        /// <returns>True si los objetos tienen diferentes cantidades en euros, de lo contrario, False.</returns>
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        // Sobrecarga del operador de igualdad (==) para comparar un objeto Euro y un objeto Peso.
        /// <summary>
        /// Compara si un objeto Euro y un objeto Peso son iguales en cuanto a su cantidad convertida a euros.
        /// </summary>
        /// <param name="e">El objeto Euro a comparar.</param>
        /// <param name="p">El objeto Peso a comparar.</param>
        /// <returns>True si los objetos tienen la misma cantidad en euros, de lo contrario, False.</returns>
        public static bool operator ==(Euro e, Peso p)
        {
            return (e.GetCantidad == ((Euro)p).GetCantidad);
        }

        // Sobrecarga del operador de desigualdad (!=) para comparar un objeto Euro y un objeto Peso.
        /// <summary>
        /// Compara si un objeto Euro y un objeto Peso no son iguales en cuanto a su cantidad convertida a euros.
        /// </summary>
        /// <param name="e">El objeto Euro a comparar.</param>
        /// <param name="p">El objeto Peso a comparar.</param>
        /// <returns>True si los objetos tienen diferentes cantidades en euros, de lo contrario, False.</returns>
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro((e.GetCantidad + ((Euro)p).GetCantidad));
        }// Sobrecarga del operador de resta (-) para restar un objeto Dolar de un objeto Euro.
        /// <summary>
        /// Resta la cantidad en dólares convertida a euros de un objeto Dolar de un objeto Euro.
        /// </summary>
        /// <param name="e">El objeto Euro al que se le resta un objeto Dolar.</param>
        /// <param name="d">El objeto Dolar que se resta.</param>
        /// <returns>Un objeto Euro con la cantidad restante en euros.</returns>
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro((e.GetCantidad - ((Euro)d).GetCantidad));
        }

        // Sobrecarga del operador de resta (-) para restar un objeto Peso de un objeto Euro.
        /// <summary>
        /// Resta la cantidad en pesos convertida a euros de un objeto Peso de un objeto Euro.
        /// </summary>
        /// <param name="e">El objeto Euro al que se le resta un objeto Peso.</param>
        /// <param name="p">El objeto Peso que se resta.</param>
        /// <returns>Un objeto Euro con la cantidad restante en euros.</returns>
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro((e.GetCantidad - ((Euro)p).GetCantidad));
        }

        // Sobrecarga del operador de suma (+) para sumar un objeto Dolar a un objeto Euro.
        /// <summary>
        /// Suma la cantidad en dólares convertida a euros de un objeto Dolar a un objeto Euro.
        /// </summary>
        /// <param name="e">El objeto Euro al que se le suma un objeto Dolar.</param>
        /// <param name="d">El objeto Dolar que se suma.</param>
        /// <returns>Un objeto Euro con la cantidad resultante en euros.</returns>
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro((e.GetCantidad + ((Euro)d).GetCantidad));
        }

        // Sobrecarga del operador de suma (+) para sumar un objeto Peso a un objeto Euro.
        /// <summary>
        /// Suma la cantidad en pesos convertida a euros de un objeto Peso a un objeto Euro.
        /// </summary>
        /// <param name="e">El objeto Euro al que se le suma un objeto Peso.</param>
        /// <param name="p">El objeto Peso que se suma.</param>
        /// <returns>Un objeto Euro con la cantidad resultante en euros.</returns>
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro((e.GetCantidad + ((Euro)p).GetCantidad));
        }
    }
}
