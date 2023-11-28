using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werehouse
{
    public class Product
    {
        string ProducerName { get; set; }
        string ProductName { get; set; }
        string Category { get; set; }
        int ProductCode { get; set; }
        double Price { get; set; }
        string Description { get; set; }

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
