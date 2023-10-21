using Bibioteca;
namespace Testeo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente c = 12345678;
            Comida h = new Hamburguesa("Doble cuarto de libra", true);
            Console.WriteLine(h + Comida.EIngredientes.PANCETA);
            Console.WriteLine(h + Comida.EIngredientes.ADHERESO);
            Console.WriteLine(h + Comida.EIngredientes.TOMATE);
            Console.WriteLine(h + Comida.EIngredientes.PANCETA);
            Console.WriteLine("hamburguesa");
            Console.WriteLine(h.Descripcion);
            Comida g = new Guarnicion();
            Console.WriteLine(g + Comida.EIngredientes.LECHUGA);
            Console.WriteLine(g + Comida.EIngredientes.QUESO);
            Console.WriteLine("Guarnicion");
            Console.WriteLine(g.Descripcion);

            c += h;
            c += g;
            Console.WriteLine("Cliente");
            Console.WriteLine(Cliente.ImprimirTicket(c));
        }
    }
}