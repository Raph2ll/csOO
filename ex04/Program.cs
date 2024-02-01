using System.Globalization;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            Console.Write("Nome: ");
            e1.name = Console.ReadLine();

            Console.Write("Salário: ");
            e1.grossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            e1.tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionario {e1.name}, R${e1.LiquidSalary().ToString("F2", CultureInfo.InvariantCulture):2F}");

            Console.WriteLine($"Digite a quantidade para aumentaro  salário: ");
            Console.Write("Aumentar o salário:");

            e1.IncreaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));


            Console.WriteLine($"Dados atualizados: {e1.name}, R${e1.LiquidSalary().ToString("F2", CultureInfo.InvariantCulture):2F}");
            

        }
    }
    class Employee 
    {
        public string name;
        public double grossSalary;
        public double tax;

        public double LiquidSalary()
        {
            double ret = grossSalary - tax;
            return ret;
        }
        public void IncreaseSalary(double percentage)
        {
            grossSalary =  grossSalary + (grossSalary * percentage / 100.0);
        }
    }
}