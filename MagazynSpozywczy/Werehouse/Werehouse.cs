using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werehouse
{
    internal class Magazyn
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public Adress Adress { get; set; }

        public Magazyn(List<Product> products, Adress adress, string name)
        {
            Products = products;
            Adress = adress;
            Name = name;
        }

        public override string ToString()
        {
            return $"Nazwa: {Name}\n";
        }
    }
}
