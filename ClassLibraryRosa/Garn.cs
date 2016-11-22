using System;

namespace ClassLibraryRosa
{
    public class Garn : IProducts
    {
        public string Name;
        public string Color;
        public string Type;
        public int Amount;
        public double Price;
        public int Id;

        public Garn()
        {

        }

        public Garn(int id, string type, string name, int amount, double price, string color)
        {
            Name = name;
            Color = color;
            Type = type;
            Amount = amount;
            Price = price;
            Id = id;
        }

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