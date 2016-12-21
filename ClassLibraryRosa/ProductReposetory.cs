using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRosa
{
    public class ProductReposetory
    {
        public List<Garn> ProductList;
        public ProductReposetory()
        {
            ProductList = new List<Garn>();
        }

        public void AddProduct(Garn product)
        {
            ProductList.Add(product);
        }

        public void DeleteProduct(int Id)
        {
            Garn product = ProductList[Id];
            ProductList.Remove(product);
        }

        public void UpdateProduct(int vareNr, string type, string name, int amount, double price, string color)
        {
            ProductList[vareNr].Type = type;
            ProductList[vareNr].Name = name;
            ProductList[vareNr].Amount = amount;
            ProductList[vareNr].Price = price;
            ProductList[vareNr].Color = color;
        }
        
        
    }
}
