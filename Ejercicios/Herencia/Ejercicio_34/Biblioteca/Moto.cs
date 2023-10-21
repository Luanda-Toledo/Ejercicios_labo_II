using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {
        // Atributo
        public short cilindrada;

        // Propiedad
        public short Cilindrada { get; set; }

        // Constructor
        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color) // Llama al constructor de la clase base (VehiculoTerrestre)
        {
            Cilindrada = cilindrada;
        }
    }
}
