using System;

namespace TtGames.GeorgeMichael
{
    class GeorgeMichael : BaseType.BaseType
    {
        public GeorgeMichael() : base("George Michael Bluth", false, "Male", 69)
        { }

        public override void SpecialPower(string power)
        {
            // _name is from BaseType and accessible because of `protected`
            Console.WriteLine(_name + " has the special power of " + power);
            Console.ReadLine();
        }
    }
}
