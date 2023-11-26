using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werehouse
{
    internal class Magazyn
    {
        public List<Product> Products { get; set; }
        public Adress Adress { get; set; }

        public Magazyn(List<Product> products, Adress adress)
        {
            Products = products;
            Adress = adress;
        }

        /*public override string ToString()
        {
            return $"Producent: \n";
        }*/
    }
}
