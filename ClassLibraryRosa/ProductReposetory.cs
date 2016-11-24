using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRosa
{
    public class ProductReposetory
    {
        public List<IProducts> ProductList;
        public ProductReposetory()
        {
            ProductList = new List<IProducts>();
        }

        public void AddProduct(IProducts product)
        {
            ProductList.Add(product);
        }

        public void DeleteProduct(int Id)
        {
            IProducts product = ProductList[Id];
            ProductList.Remove(product);
        }

        
        
    }
}
