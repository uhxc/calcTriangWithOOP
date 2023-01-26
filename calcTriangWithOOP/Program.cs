using System.Globalization;

namespace calcTriangWithOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x= new Triangulo();
            y= new Triangulo();

            Console.WriteLine("entre com os dados do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2;
            double xArea = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            Console.WriteLine($"A area de x é: {xArea:F4}");

            Console.WriteLine("entre com os dados do triangulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (y.A + y.B + y.C) / 2;
            double yArea = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"A area de y é: {yArea:F4}");
            if (xArea >= yArea) Console.WriteLine("o maior é x");
            else Console.WriteLine("o maior é Y");

        }
    }
}