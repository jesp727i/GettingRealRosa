﻿using System;
using System.Collections.Generic;

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
        public List<object> GetProductInfo()
        {
            List<object> l = new List<object>();
            l.Add(Type);
            l.Add(Name);
            l.Add(Color);
            
            l.Add(Amount);
            l.Add(Price);
            return l;
        }
        public void UpdateProduct(string type, string name, string color, int antal, double pris)
        {
            Name = name;
            Color = color;
            Type = type;
            Amount = antal;
            Price = pris;
        }
    }

}