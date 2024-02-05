using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rooms = 10;
            Student[] vect = new Student[rooms];

            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine());

            for (int index = 0; index < N; index++)
            {
                Console.WriteLine($"Aluguel #{index}:");

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Student(name, email);
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int index = 0; index < rooms; index++)
            {
                if (vect[index] != null)
                {
                    Console.WriteLine($"{index}: {vect[index].ToString()}");
                }
            }
        }
    }
}