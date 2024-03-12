using System;
using System.Globalization;
using System.Collections.Generic;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            Console.WriteLine("How many students for course A? ");
            int numA = int.Parse(Console.ReadLine());
            for (int i = 0; i < numA; i++)
            {
                int student = int.Parse(Console.ReadLine());
                set.Add(student);
            }

            Console.WriteLine("How many students for course C? ");
            int numB = int.Parse(Console.ReadLine());
            for (int i = 0; i < numB; i++)
            {
                int student = int.Parse(Console.ReadLine());
                set.Add(student);
            }

            Console.WriteLine("How many students for course B? ");
            int numC = int.Parse(Console.ReadLine());
            for (int i = 0; i < numC; i++)
            {
                int student = int.Parse(Console.ReadLine());
                set.Add(student);
            }
            
            Console.WriteLine($"Total users: {set.Count}");
        }
    }
}