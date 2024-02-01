using System.Globalization;

namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            Console.Write("Nome: ");
            s1.name = Console.ReadLine();

            s1.schoolCardA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s1.schoolCardB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s1.schoolCardC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Nota Final: {s1.SchoolGradle().ToString("F2", CultureInfo.InvariantCulture):2F}");

            if (s1.SchoolGradle() > 60.00)
            {
                Console.WriteLine("APROVADO"); 
            } else 
            {
                Console.WriteLine($"Faltaram {(60.00 - s1.SchoolGradle() ).ToString("F2", CultureInfo.InvariantCulture):2F}");
            }
            
        }
    }
    class Student
    {
        public string name;
        public double schoolCardA;
        public double schoolCardB;
        public double schoolCardC;

        public double SchoolGradle()
        {
            double ret = schoolCardA + schoolCardB + schoolCardC;
            return ret;
        }
    }
}
