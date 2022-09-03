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

            int goldCoin = 10;
            int silverCoin = 5;

            double devide = amountDouble / goldCoin;
            double roundDown = Math.Floor(devide);
            double goldCoins = Convert.ToDouble(roundDown);
            double moduloOne = amountDouble % (goldCoin * goldCoins);


            double devideS = moduloOne / silverCoin;
            double roundDownS = Math.Floor(devideS);
            double silverCoins = roundDownS;
            double moduloTwo = moduloOne % (silverCoin * silverCoins);
            Console.WriteLine(moduloTwo);
            Console.WriteLine(moduloOne);
            Console.WriteLine(silverCoin);
            Console.WriteLine(silverCoins);

            Console.WriteLine($"You need " + goldCoins + " gold coins");
            Console.WriteLine($"You need " + silverCoins + " silver coins");
            Console.WriteLine($"You need " + moduloTwo + " bronze coins");



        }
    }
}
