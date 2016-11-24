using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRosa
{
    public interface IProducts
    {
        List<object> GetProductInfo();
        void UpdateProduct(string type, string name, string color, int antal, double pris);
    }
}
