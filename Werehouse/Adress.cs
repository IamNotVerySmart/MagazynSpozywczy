using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werehouse
{
    public class Adress
    {
        string Street { get; set; }
        int PostCode {  get; set; }
        string City { get; set; }
        int PosessionNumber { get; set; }
        int FlatNumber { get; set; }

        public Adress(string street, int postCode, string city, int posessionNumber, int flatNumber)
        {
            Street = street;
            PostCode = postCode;
            City = city;
            PosessionNumber = posessionNumber;
            FlatNumber = flatNumber;
        }

        public override string ToString()
        {
            return $"street: {Street}\npost code: {PostCode}\ncity: {City}\nposession number: {PosessionNumber}\nflat number: {FlatNumber}\n";
        }
    }
}
