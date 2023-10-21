namespace Biblioteca
{
    public class VehiculoTerrestre
    {
        //Atributos
        public short cantdadRuedas;
        public short cantidadPuertas;

        // Propidades
        public short CantidadRuedas { get; set; }
        public short CantidadPuertas { get; set; }
        public Colores Color { get; set; }

        // Constructor
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            CantidadRuedas = cantidadRuedas;
            CantidadPuertas = cantidadPuertas;
            Color = color;
        }
    }
}