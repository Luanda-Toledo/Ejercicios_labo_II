using Geometria;

namespace PruebaGeometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un punto.
            Punto punto1 = new Punto(2, 3);

            // Crear un rectángulo utilizando los vértices 1 y 3.
            Rectangulo rectangulo1 = new Rectangulo(punto1, new Punto(5, 6));

            // Probar el método que muestra todos los datos del rectángulo.
            MostrarDatosRectangulo(rectangulo1);
        }

        /// <summary>
        /// Método de clase que muestra todos los datos de un rectángulo, incluyendo vértices,
        /// área y perímetro.
        /// </summary>
        /// <param name="rectangulo">El rectángulo que se desea mostrar.</param>

        static void MostrarDatosRectangulo(Rectangulo rectangulo)
        {
            Console.WriteLine("Datos del rectángulo:");
            Console.WriteLine("Vértice 1: (" + rectangulo.Vertice1.GetX() + ", " + rectangulo.Vertice1.GetY() + ")");
            Console.WriteLine("Vértice 3: (" + rectangulo.Vertice3.GetX() + ", " + rectangulo.Vertice3.GetY() + ")");
            Console.WriteLine("Área: " + rectangulo.Area);
            Console.WriteLine("Perímetro: " + rectangulo.Perimetro);
        }
    }
}