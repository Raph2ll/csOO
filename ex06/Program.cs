using System.Globalization;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dólar? ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double willYouBuy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double ret = CurrencyConverter.AmountToBePaid(price, willYouBuy);
            Console.WriteLine($"Valor a ser pago em reais = {ret.ToString("F2", CultureInfo.InvariantCulture):2F}");
        }
    }
    class CurrencyConverter
    {
        public static double IOF = 0.06;

        public static double AmountToBePaid(double price, double willYouBuy)
        {
            double ret = price * willYouBuy * (1 + IOF);
            return ret;
        }
    }
}