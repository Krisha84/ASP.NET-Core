using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Furniture
    {
        public string Material;
        public double Price;

        public Furniture(string material, double price)
        {
            this.Material = material;
            this.Price = price;
        }
    }

    public class Table : Furniture
    {
        public double Height;
        public double Surface_Area;

        public Table(string material, double price, double height, double surfaceArea) : base(material, price)
        {
            this.Height = height;
            this.Surface_Area = surfaceArea;
        }
    }
}
