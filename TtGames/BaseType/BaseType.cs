using System;

namespace TtGames.BaseType
{
    abstract class BaseType
    {
        private readonly string _name;
        private readonly bool _hat;
        private readonly string _sex;
        private readonly int _height;

        public BaseType(string name, bool hat, string sex, int height)
        {
            _name = name;
            _hat = hat;
            _sex = sex;
            _height = height;
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        // must be overridden in derived class
        public virtual void SpecialPower(string power)
        {
            throw new NotImplementedException();
        }
    }
}
