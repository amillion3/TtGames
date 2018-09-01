using System;

namespace TtGames.TobiasFunke
{
    class TobiasFunke : BaseType.BaseType
    {
        public TobiasFunke() : base("Tobias Funke", false, "Male", 68)
        { }

        public override void SpecialPower(string power)
        {
            Console.WriteLine(power);
            Console.ReadLine();
        }
    }
}
