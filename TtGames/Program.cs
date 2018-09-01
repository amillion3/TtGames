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

            TonyWonderAKABenStiller.Jump();
            TonyWonderAKABenStiller.SpecialPower(powerTonyWonder);
            TobiasFunkeAKADavidCross.Attack();
            TobiasFunkeAKADavidCross.SpecialPower(powerTobiasFunke);
            GeorgeMichaelAKAMichaelCera.Run();
            GeorgeMichaelAKAMichaelCera.SpecialPower(powerGeorgeMichael);
            GobBluthAKAWillArnett.Jump();
            GobBluthAKAWillArnett.Attack();
            GobBluthAKAWillArnett.Run();
            GobBluthAKAWillArnett.SpecialPower(powerGobBluth);
        }
    }
}
