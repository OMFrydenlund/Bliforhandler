using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Bliforhandler
{
    public class Car
    {
        public Car(string model, int year, string regNumber, int kilometer, int price)
        {
            Model = model;
            Year = year;
            RegNumber = regNumber;
            Kilometer = kilometer;
            Price = price;
            IsBought = false;
        }
        public string Model { get; set; }
        public int Year { get; set; }
        public string RegNumber { get; set; }
        public int Kilometer { get; set; }
        public int Price { get; set; }
        public bool IsBought { get; set; }
    }
}
