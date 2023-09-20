namespace Ejercicio_08
{
    /*
     * 8.- Por teclado se ingresa el valor hora, el nombre, la antiguedad(en años) y la cantidad de horas trabajadas en el mes de N empleados de una fabrica.
       Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
       hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de esas operaciones restarle el 13% enconcepto de descuentos.
     */
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el valor hora: ");
            double valorHora = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre: ");
            string nombreDelTrabajador = Console.ReadLine();

            Console.Write("Ingrese la antiguedad en años: ");
            int antiguedadLaboral = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de horas trabajadas en el mes: ");
            double cantidadDeHorasTrabajadas = double.Parse(Console.ReadLine());

            double sueldo = CalcularSueldo(valorHora, cantidadDeHorasTrabajadas, antiguedadLaboral);

            Console.Write($"\nEl sueldo a cobrar de {nombreDelTrabajador} es: {sueldo}.");
        }

        static double CalcularSueldo(double valorHora, double horasTrabajadas, int antiguedad)
        {
            double sueldoBasico = valorHora * horasTrabajadas;
            int valorAdicionalPorAntiguedad = 150;
            int adicionalPorAntiguedad = antiguedad * valorAdicionalPorAntiguedad;
            double sueldoMasAntiguedad = sueldoBasico + adicionalPorAntiguedad;
            int valorEnPorcentajeDelDescuento = 13;
            double descuentosSalariales = valorEnPorcentajeDelDescuento * sueldoMasAntiguedad / 100;
            double sueldoACobrar = sueldoMasAntiguedad - descuentosSalariales;

            return sueldoACobrar;
        }
    }
}