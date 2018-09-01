using System;

namespace TtGames.TobiasFunke
{
    class TobiasFunke : BaseType.BaseType
    {
        public TobiasFunke() : base("Tobias Funke", false, "Male", 68)
        { }

        public override void SpecialPower(string power)
        {
            // _name is from BaseType and accessible because of `protected`
            Console.WriteLine(_name + " has the special power of " + power);
            Console.ReadLine();
        }
    }
}
