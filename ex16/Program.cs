using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"./sales.csv";
            string targetPath = @"./summary.csv";

            try
            {
                bool targetFileExists = File.Exists(targetPath);

                using (StreamReader reader = new StreamReader(sourcePath))
                using (StreamWriter writer = new StreamWriter(targetPath, !targetFileExists))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        // Dividir a string usando vírgulas como delimitadores
                        string[] partes = line.Split(',');

                        writer.WriteLine($"{partes[0]}, {double.parse(double.Parse(partes[1]) * double.Parse(partes[2])) }");
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
