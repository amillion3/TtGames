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

            Console.WriteLine("What is Tobias Funke's special power?");
            var powerTobiasFunke = Console.ReadLine();

            Console.WriteLine("What is George Michael's special power?");
            var powerGeorgeMichael = Console.ReadLine();

            Console.WriteLine("What is Gob Bluth's special power?");
            var powerGobBluth = Console.ReadLine();

            TonyWonderAKABenStiller.SpecialPower(powerTonyWonder);
            TobiasFunkeAKADavidCross.SpecialPower(powerTobiasFunke);
            GeorgeMichaelAKAMichaelCera.SpecialPower(powerGeorgeMichael);
            GobBluthAKAWillArnett.SpecialPower(powerGobBluth);
        }
    }
}
