namespace Geometria
{
    // ----------- A -------------
    /// <summary>
    /// Clase que representa un punto en un plano cartesiano con coordenadas (x, y).
    /// </summary>
    public class Punto
    {
        // Atributos privados de solo lectura para las coordenadas x e y.
        private readonly int x;
        private readonly int y;

        /// <summary>
        /// Constructor de la clase Punto que inicializa las coordenadas (x, y) del punto.
        /// </summary>
        /// <param name="x">Coordenada x del punto.</param>
        /// <param name="y">Coordenada y del punto.</param>
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Método para obtener la coordenada x del punto.
        /// </summary>
        /// <returns>La coordenada x del punto.</returns>
        public int GetX()
        {
            return x;
        }

        /// <summary>
        /// Método para obtener la coordenada y del punto.
        /// </summary>
        /// <returns>La coordenada y del punto.</returns>
        public int GetY()
        {
            return y;
        }
    }

    // ----------------- B - C - D - E ------------------
    /// <summary>
    /// Clase que representa un rectángulo en un plano cartesiano con dos vértices diagonales.
    /// </summary>
    public class Rectangulo
    {
        // Atributos para los vértices del rectángulo.
        private Punto vertice1;
        private Punto vertice3;

        // Atributos privados para almacenar el área y el perímetro calculados.
        private double area;
        private double perimetro;

        /// <summary>
        /// Constructor de la clase Rectangulo que construye el rectángulo a partir de los vértices 1 y 3.
        /// </summary>
        /// <param name="v1">Vértice 1 del rectángulo como objeto Punto.</param>
        /// <param name="v3">Vértice 3 del rectángulo como objeto Punto.</param>
        public Rectangulo(Punto v1, Punto v3)
        {
            vertice1 = v1;
            vertice3 = v3;

            // Asegurar que la base del rectángulo sea horizontal.
            if (vertice1.GetY() != vertice3.GetY())
            {
                // Calcular la distancia entre los vértices 1 y 3 en valor absoluto.
                int distanciaY = Math.Abs(vertice1.GetY() - vertice3.GetY());

                // Intercambiar los vértices si la base no es horizontal.
                if (vertice1.GetY() > vertice3.GetY())
                {
                    vertice1 = new Punto(vertice1.GetX(), vertice1.GetY() - distanciaY);
                    vertice3 = new Punto(vertice3.GetX(), vertice3.GetY() + distanciaY);
                }
                else
                {
                    vertice1 = new Punto(vertice1.GetX(), vertice1.GetY() + distanciaY);
                    vertice3 = new Punto(vertice3.GetX(), vertice3.GetY() - distanciaY);
                }
            }
        }

        /// <summary>
        /// Propiedad para acceder al vértice 1 del rectángulo.
        /// </summary>
        public Punto Vertice1
        {
            get 
            { 
                return vertice1; 
            }
            set 
            { 
                vertice1 = value; 
            }
        }

        /// <summary>
        /// Propiedad para acceder al vértice 3 del rectángulo.
        /// </summary>
        public Punto Vertice3
        {
            get 
            { 
                return vertice3; 
            }
            set 
            { 
                vertice3 = value; 
            }
        }

        /// <summary>
        /// Propiedad para obtener el área del rectángulo.
        /// </summary>
        public double Area
        {
            get
            {
                if (area == 0)
                {
                    // Calcular el área solo si aún no se ha calculado.
                    double baseRectangulo = Math.Abs(vertice1.GetX() - vertice3.GetX());
                    double alturaRectangulo = Math.Abs(vertice1.GetY() - vertice3.GetY());
                    area = baseRectangulo * alturaRectangulo;
                }
                return area;
            }
        }

        /// <summary>
        /// Propiedad para obtener el perímetro del rectángulo.
        /// </summary>
        public double Perimetro
        {
            get
            {
                if (perimetro == 0)
                {
                    // Calcular el perímetro solo si aún no se ha calculado.
                    double baseRectangulo = Math.Abs(vertice1.GetX() - vertice3.GetX());
                    double alturaRectangulo = Math.Abs(vertice1.GetY() - vertice3.GetY());
                    perimetro = 2 * (baseRectangulo + alturaRectangulo);
                }
                return perimetro;
            }
        }
    }
}