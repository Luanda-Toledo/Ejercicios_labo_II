using Biblioteca;

namespace Ejercicio_14
{
    /*14.- Realizar una clase llamada CalculoDeArea que posea 3 metodos de clase (estaticos) que realicen el calculo del area que corresponda:
    a) double CalcularCuadrado(double)
    b) double CalcularTriangulo(double, double)
    c) double CalcularCirculo(double)
    El ingreso de los datos como la visualizacion se deberan realizar desde el metodo Main().
    */
    class CalculoDeArea
    {
        /*
         Primero solicitamos al usuario que elija la figura que desea calcular, luego según la opción ingresada, 
         solicitamos los datos necesarios (lado, base, altura o radio) y calculamos el área utilizando los métodos estáticos correspondientes. 
         Finalmente, mostramos el área calculada en la consola. Si el usuario ingresa datos no válidos, se muestra un mensaje de error y el programa termina.
        */
        static void Main()
        {
            Console.Title = "Ejercicio 14";
            // Solicitamos al usuario que elija la figura para calcular el área.
            Console.WriteLine("Seleccione la figura para calcular el área:");
            Console.WriteLine("a) Cuadrado");
            Console.WriteLine("b) Triángulo");
            Console.WriteLine("c) Círculo");
            char opcion = Console.ReadKey().KeyChar;

            double area = 0;

            switch (opcion)
            {
                case 'a':
                    Console.Write("\nIngrese el lado del cuadrado: ");
                    if (double.TryParse(Console.ReadLine(), out double ladoCuadrado))
                    {
                        area = Calculos.CalcularCuadrado(ladoCuadrado);
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Ingrese un número válido para el lado del cuadrado.");
                        return;
                    }
                    break;

                case 'b':
                    Console.Write("\nIngrese la base del triángulo: ");
                    if (double.TryParse(Console.ReadLine(), out double baseTriangulo))
                    {
                        Console.Write("Ingrese la altura del triángulo: ");
                        if (double.TryParse(Console.ReadLine(), out double alturaTriangulo))
                        {
                            area = Calculos.CalcularTriangulo(baseTriangulo, alturaTriangulo);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Ingrese un número válido para la altura del triángulo.");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Ingrese un número válido para la base del triángulo.");
                        return;
                    }
                    break;

                case 'c':
                    Console.Write("\nIngrese el radio del círculo: ");
                    if (double.TryParse(Console.ReadLine(), out double radioCirculo))
                    {
                        area = Calculos.CalcularCirculo(radioCirculo);
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Ingrese un número válido para el radio del círculo.");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Opción inválida. Seleccione 'a', 'b' o 'c' para calcular el área de la figura correspondiente.");
                    return;
            }

            Console.WriteLine($"El área de la figura es: {area}");
        }
    }
}