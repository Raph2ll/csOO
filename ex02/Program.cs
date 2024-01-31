namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");

            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();

            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");

            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();

            Console.Write("Salário: ");
            f2.salario = int.Parse(Console.ReadLine());


            Console.WriteLine($"Salário médio = {(f1.salario + f2.salario) / 2}");
        }
    }

    class Funcionario
    {
        public string nome;
        public double salario;

    }

}