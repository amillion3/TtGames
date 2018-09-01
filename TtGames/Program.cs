using System;

namespace TtGames
{
    class Program
    {
        static void Main(string[] args)
        {
            var TonyWonderAKABenStiller = new TonyWonder.TonyWonder();
            var TobiasFunkeAKADavidCross = new TobiasFunke.TobiasFunke();
            var GeorgeMichaelAKAMichaelCera = new GeorgeMichael.GeorgeMichael();
            var GobBluthAKAWillArnett = new GobBluth.GobBluth();

            Console.WriteLine("What is Tony Wonder's special power?");
            var powerTonyWonder = Console.ReadLine();
            TonyWonderAKABenStiller.SpecialPower(powerTonyWonder);
        }
    }
}
