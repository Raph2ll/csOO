namespace ex01
{
    class Pessoa
    {
        public string nome;
        public int idade;

        public Pessoa(string nome = "", int idade = 0)
        {
            this.nome = nome;
            this.idade = idade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");

            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();

            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");

            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();

            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine($"{p1.nome} é mais velho que {p2.nome}");

            }
            else
            {
                Console.WriteLine($"{p2.nome} é mais velho que {p1.nome}");
            }
        }
    }
}