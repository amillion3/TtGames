using System;

namespace TtGames.BaseType
{
    abstract class BaseType
    {
        // protected allows derived classes access to these fields
        protected readonly string _name;
        protected readonly bool _hat;
        protected readonly string _sex;
        protected readonly int _height;

        public BaseType(string name, bool hat, string sex, int height)
        {
            _name = name;
            _hat = hat;
            _sex = sex;
            _height = height;
        }

        public void Jump()
        {
            Console.WriteLine(_name + " Jumps!");
        }

        public void Attack()
        {
            Console.WriteLine(_name + " Attacks!");
        }

        public void Run()
        {
            Console.WriteLine(_name + " Runs!");
        }

        // must be overridden in derived class
        public virtual void SpecialPower(string power)
        {
            Console.WriteLine("");
        }
    }
}
