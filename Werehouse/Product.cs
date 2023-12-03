using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werehouse
{
    public class Product
    {
        public string ProducerName { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int ProductCode { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Product(string producerName, string productName, string category, int productCode, double price, string description)
        {
            ProducerName = producerName;
            ProductName = productName;
            Category = category;
            ProductCode = productCode;
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
            return $"Producent: {ProducerName},\nProdukt: {ProductName},\nKategoria: {Category}.\nKod produktu: {ProductCode},\nCena: {Price},\nOpis: {Description}\n";
        }
    }
}
