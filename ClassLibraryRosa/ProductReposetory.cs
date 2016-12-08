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

        
        
    }
}
