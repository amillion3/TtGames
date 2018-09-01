using System;

namespace TtGames.GeorgeMichael
{
    class GeorgeMichael : BaseType.BaseType
    {
        public GeorgeMichael() : base("George Michael Bluth", false, "Male", 69)
        { }

        public override void SpecialPower(string power)
        {
            base.SpecialPower("Charm");
        }
    }
}
