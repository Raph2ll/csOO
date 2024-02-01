using System.Globalization;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();

            Console.WriteLine("Entre a largura e altura do retângulo:");

            r1.width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            r1.height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Area = {r1.Area().ToString("F2", CultureInfo.InvariantCulture):2F}");
            Console.WriteLine($"Perímetro = {r1.Perimeter().ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
    class Rectangle
    {
        public double width;
        public double height;

        public double Area()
        {
            double ret = width * height;
            return ret;
        }
        public double Perimeter()
        {
            double ret = 2 * (width + height);
            return ret;
        }
        public double Diagonal(){
            double ret = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            return ret;
        }

    }
}