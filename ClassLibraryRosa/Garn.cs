using System;

namespace ClassLibraryRosa
{
    public class Garn
    {
        public string Name;
        public string Farve;
        public string Type;
        public int Amount;
        public float Price;

        public void AddAmount(int amount)
        {
            Amount += amount;
        }

        public void SubAmount(int amount)
        {
            Amount -= amount;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }
    }

}