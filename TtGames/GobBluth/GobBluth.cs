using System;

namespace TtGames.GobBluth
{
    class GobBluth : BaseType.BaseType
    {
        public GobBluth() : base("Gob Bluth", false, "Male", 74)
        { }

        public override void SpecialPower(string power)
        {
            // _name is from BaseType and accessible because of `protected`
            Console.WriteLine(_name + " has the special power of " + power);
            Console.ReadLine();
        }
    }

}
