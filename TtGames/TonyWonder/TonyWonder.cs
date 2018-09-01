using System;

namespace TtGames.TonyWonder
{
    class TonyWonder : BaseType.BaseType
    {
        public TonyWonder() : base("Tony Wonder", false, "Male", 67) 
        { }

        public override void SpecialPower(string power)
        {
            // _name is from BaseType and accessible because of `protected`
            Console.WriteLine(_name + " has the special power of " + power);
            Console.ReadLine();
            
        }
    }
}
