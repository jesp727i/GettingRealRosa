using System;

namespace GettingRealRosa
{
    internal class Garn
    {
        public string Name;
        public string Farve;
        public string Type;
        public int Amount;
        public float Price;

        internal void AddAmount(int amount)
        {
            Amount += amount;
        }

        internal void SubAmount(int amount)
        {
            Amount -= amount;
        }
    }

}