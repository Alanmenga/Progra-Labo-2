namespace Validador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros = 10;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int suma = 0;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine($"Ingrese el numero {i + 1}: ");
                int numero;

                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Entrada invalida. Ingrese un numero valido.");
                }

                while (!Validador.Validar(numero, -100, 100))
                {
                    Console.WriteLine("Entrada invalida. Ingrese un numero valido.");
                    Console.WriteLine("El numero debe estar en el rango de -100 a 100.");
                    Console.WriteLine($"Ingrese el numero {i + 1} nuevamente: ");
                    numero = int.Parse(Console.ReadLine());
                }


                int.TryParse(Console.ReadLine(), out numero);

                minimo = Math.Min(minimo, numero);
                maximo = Math.Max(maximo, numero);
                suma += numero;
            }

            double promedio = (double)suma / cantidadNumeros;

            Console.WriteLine($"Valor minimo: {minimo}");
            Console.WriteLine($"Valor maximo: {maximo}");
            Console.WriteLine($"Promedio : {promedio}");
        }
    }
}