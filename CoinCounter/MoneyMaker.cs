using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.Write("Enter an amount: ");
            string amount = Console.ReadLine();
            double amountDouble = Convert.ToDouble(amount);
            Console.WriteLine($"{amount} cents is equal to... ");

            int guldValue = 10;
            int silverValue = 5;

            double devide = amountDouble / guldValue;
            double goldCoins = Math.Floor(devide);
            double remainder = amountDouble % goldCoins;

            double devideSilver = remainder / silverValue;
            double silverCoins = Math.Floor(devideSilver);
            remainder = remainder % silverValue;

            Console.WriteLine($"You need " + goldCoins + " gold coins");
            Console.WriteLine($"You need " + silverCoins + " silver coins");
            Console.WriteLine($"You need " + remainder + " bronze coins");
           


        }
    }
}
