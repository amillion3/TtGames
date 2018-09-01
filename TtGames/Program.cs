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

            TonyWonderAKABenStiller.SpecialPower("Magic000");
        }
    }
}
