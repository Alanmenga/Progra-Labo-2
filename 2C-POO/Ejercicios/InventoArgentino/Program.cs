using E4_Boligrafo;

namespace InventoArgentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boliRojo = new Boligrafo(100, ConsoleColor.Red);
            Boligrafo boliAzul = new Boligrafo(50, ConsoleColor.Blue);

            Console.WriteLine("Boligrafo de color {0} con {1} de tinta", boliAzul.GetColor(), boliAzul.GetTinta());
            Console.WriteLine("Boligrafo de color {0} con {1} de tinta", boliRojo.GetColor(), boliRojo.GetTinta());

        }
    }
}