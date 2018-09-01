using System;

namespace TtGames.GobBluth
{
    class GobBluth : BaseType.BaseType
    {
        public GobBluth() : base("Gob Bluth", false, "Male", 74)
        { }

        public override void SpecialPower(string power)
        {
            base.SpecialPower("Magic");
        }
    }

}
