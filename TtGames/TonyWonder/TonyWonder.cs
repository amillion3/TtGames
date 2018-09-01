using System;

namespace TtGames.TonyWonder
{
    class TonyWonder : BaseType.BaseType
    {
        public TonyWonder() : base("Tony Wonder", false, "Male", 67) 
        { }
        
        public override void SpecialPower(string power)
        {
            Console.WriteLine(power);
            Console.ReadLine();
        }
    }
}
