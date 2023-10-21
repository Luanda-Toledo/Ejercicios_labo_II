using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        // Atributos
        public short cantidadMaechas;
        public int pesoCarga;

        // Propiedades
        public short CantidadMarchas { get; set; }
        public int PesoCarga { get; set; }

        // Constructor
        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, color) // Llama al constructor de la clase base (VehiculoTerrestre)
        {
            CantidadMarchas = cantidadMarchas;
            PesoCarga = pesoCarga;
        }
    }
}
