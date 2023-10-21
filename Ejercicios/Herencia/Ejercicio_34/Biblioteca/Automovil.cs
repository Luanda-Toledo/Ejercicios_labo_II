using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        // Atributos especificos del automovil
        public short cantidadMarchas;
        public int cantidadPasajeros;

        // Propiedades para acceder a los atributos
        public short CantidadMarchas { get; set; }
        public int CantidadPasajeros { get; set; }

        // Constructor
        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color) // Llama al constructor de la clase base (VehiculoTerrestre)
        {
            CantidadMarchas = cantidadMarchas;
            CantidadPasajeros = cantidadPasajeros;
        }
    }
}
