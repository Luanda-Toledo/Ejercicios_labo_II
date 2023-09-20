using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        // Generamos sus atributos
        private double cantidad;
        private static double cotizRespectoDolar;

        // Generamos constructores

        /// <summary>
        /// Constructor estático de la clase Peso que se ejecuta una sola vez durante la inicialización de la clase.
        /// Su propósito es establecer la cotización por defecto del Peso.
        /// </summary>
        static Peso()
        {
            Peso.cotizRespectoDolar = 180;
        }

        /// <summary>
        /// Constructor de la clase Peso que inicializa la cantidad de pesos.
        /// </summary>
        /// <param name="cantidad">La cantidad de pesos a representar.</param>
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Constructor de la clase Peso que inicializa la cantidad de pesos y la cotización del peso en relación a otra moneda.
        /// </summary>
        /// <param name="cantidad">La cantidad de pesos a representar.</param>
        /// <param name="cotizacion">La cotización del peso en relación a otra moneda.</param>
        public Peso(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
        }

        // Reemplazamos los metodos GET por propiedades

        /// <summary>
        /// Propiedad que obtiene la cantidad de pesos representada por un objeto Peso.
        /// </summary>
        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        /// <summary>
        /// Propiedad estática que obtiene la cotización actual del peso en relación a otra moneda.
        /// </summary>
        public static double GetCotizacion
        {
            get
            {
                return Peso.cotizRespectoDolar;
            }
        }

        /// <summary>
        /// Sobrecarga del operador de conversión implícita que permite crear un objeto Peso a partir de un valor double automáticamente.
        /// </summary>
        /// <param name="d">El valor double que se convertirá en un objeto Peso.</param>
        /// <returns>Un objeto Peso con la cantidad especificada.</returns>
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        // Sobrecargas explicitas para euro y Dolar
        // Método de conversión explícita de Peso a Dolar
        /// <summary>
        /// Convierte un objeto Peso en un objeto Dolar de forma explícita.
        /// Calcula la cantidad equivalente en dólares dividiendo la cantidad de pesos por la cotización actual del peso en relación al dólar.
        /// </summary>
        /// <param name="p">El objeto Peso que se desea convertir en Dolar.</param>
        /// <returns>Un objeto Dolar que representa la cantidad equivalente en dólares.</returns>
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar((p.GetCantidad / Peso.GetCotizacion));
        }

        // Método de conversión explícita de Peso a Euro
        /// <summary>
        /// Convierte un objeto Peso en un objeto Euro de forma explícita.
        /// Realiza una conversión intermedia convirtiendo el objeto Peso en Dolar y luego de Dolar a Euro, utilizando las sobrecargas de métodos.
        /// </summary>
        /// <param name="p">El objeto Peso que se desea convertir en Euro.</param>
        /// <returns>Un objeto Euro que representa la cantidad equivalente en euros.</returns>
        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p); // De esta manera utilizamos la sobrecarga de métodos para realizar la conversión.
        }

        // Generamos los comparadores y operadores aritmeticos
        // Sobrecarga del operador de igualdad (==) para comparar dos objetos Peso.
        /// <summary>
        /// Compara si dos objetos Peso son iguales en cuanto a su cantidad de pesos.
        /// </summary>
        /// <param name="p1">El primer objeto Peso a comparar.</param>
        /// <param name="p2">El segundo objeto Peso a comparar.</param>
        /// <returns>True si los objetos Peso tienen la misma cantidad de pesos, de lo contrario, False.</returns>
        public static bool operator ==(Peso p1, Peso p2)
        {
            return (p1.GetCantidad == p2.GetCantidad);
        }

        // Sobrecarga del operador de desigualdad (!=) para comparar dos objetos Peso.
        /// <summary>
        /// Compara si dos objetos Peso no son iguales en cuanto a su cantidad de pesos.
        /// </summary>
        /// <param name="p1">El primer objeto Peso a comparar.</param>
        /// <param name="p2">El segundo objeto Peso a comparar.</param>
        /// <returns>True si los objetos Peso tienen diferentes cantidades de pesos, de lo contrario, False.</returns>
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2); // Reutilizamos la comparación anterior
        }

        // Sobrecarga del operador de igualdad (==) para comparar un objeto Peso y un objeto Euro.
        /// <summary>
        /// Compara si un objeto Peso y un objeto Euro son iguales en cuanto a su cantidad convertida a pesos.
        /// </summary>
        /// <param name="p">El objeto Peso a comparar.</param>
        /// <param name="e">El objeto Euro a comparar.</param>
        /// <returns>True si los objetos tienen la misma cantidad en pesos, de lo contrario, False.</returns>
        public static bool operator ==(Peso p, Euro e)
        {
            return (p.GetCantidad == (Peso)e.GetCantidad);
        }

        // Sobrecarga del operador de desigualdad (!=) para comparar un objeto Peso y un objeto Euro.
        /// <summary>
        /// Compara si un objeto Peso y un objeto Euro no son iguales en cuanto a su cantidad convertida a pesos.
        /// </summary>
        /// <param name="p">El objeto Peso a comparar.</param>
        /// <param name="e">El objeto Euro a comparar.</param>
        /// <returns>True si los objetos tienen diferentes cantidades en pesos, de lo contrario, False.</returns>
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        // Sobrecarga del operador de igualdad (==) para comparar un objeto Peso y un objeto Dolar.
        /// <summary>
        /// Compara si un objeto Peso y un objeto Dolar son iguales en cuanto a su cantidad convertida a pesos.
        /// </summary>
        /// <param name="p">El objeto Peso a comparar.</param>
        /// <param name="d">El objeto Dolar a comparar.</param>
        /// <returns>True si los objetos tienen la misma cantidad en pesos, de lo contrario, False.</returns>
        public static bool operator ==(Peso p, Dolar d)
        {
            return (p.GetCantidad == ((Peso)d).GetCantidad);
        }

        // Sobrecarga del operador de desigualdad (!=) para comparar un objeto Peso y un objeto Dolar.
        /// <summary>
        /// Compara si un objeto Peso y un objeto Dolar no son iguales en cuanto a su cantidad convertida a pesos.
        /// </summary>
        /// <param name="p">El objeto Peso a comparar.</param>
        /// <param name="d">El objeto Dolar a comparar.</param>
        /// <returns>True si los objetos tienen diferentes cantidades en pesos, de lo contrario, False.</returns>
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        // Sobrecarga del operador de resta (-) para restar un objeto Euro de un objeto Peso.
        /// <summary>
        /// Resta la cantidad en euros convertida a pesos de un objeto Euro de un objeto Peso.
        /// </summary>
        /// <param name="p">El objeto Peso al que se le resta un objeto Euro.</param>
        /// <param name="e">El objeto Euro que se resta.</param>
        /// <returns>Un objeto Peso con la cantidad restante en pesos.</returns>
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso((p.GetCantidad - ((Peso)e).GetCantidad));
        }

        // Sobrecarga del operador de resta (-) para restar un objeto Dolar de un objeto Peso.
        /// <summary>
        /// Resta la cantidad en dólares convertida a pesos de un objeto Dolar de un objeto Peso.
        /// </summary>
        /// <param name="p">El objeto Peso al que se le resta un objeto Dolar.</param>
        /// <param name="d">El objeto Dolar que se resta.</param>
        /// <returns>Un objeto Peso con la cantidad restante en pesos.</returns>
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso((p.GetCantidad - ((Peso)d).GetCantidad));
        }

        // Sobrecarga del operador de suma (+) para sumar un objeto Euro a un objeto Peso.
        /// <summary>
        /// Suma la cantidad en euros convertida a pesos de un objeto Euro a un objeto Peso.
        /// </summary>
        /// <param name="p">El objeto Peso al que se le suma un objeto Euro.</param>
        /// <param name="e">El objeto Euro que se suma.</param>
        /// <returns>Un objeto Peso con la cantidad resultante en pesos.</returns>
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso((p.GetCantidad + ((Peso)e).GetCantidad));
        }

        // Sobrecarga del operador de suma (+) para sumar un objeto Dolar a un objeto Peso.
        /// <summary>
        /// Suma la cantidad en dólares convertida a pesos de un objeto Dolar a un objeto Peso.
        /// </summary>
        /// <param name="p">El objeto Peso al que se le suma un objeto Dolar.</param>
        /// <param name="d">El objeto Dolar que se suma.</param>
        /// <returns>Un objeto Peso con la cantidad resultante en pesos.</returns>
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso((p.GetCantidad + ((Peso)d).GetCantidad));
        }
    }
}
