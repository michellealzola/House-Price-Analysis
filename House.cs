using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Price_Analysis
{
    internal class House
    {
        public House(decimal price, int bedroom, int bathroom, double squareFeet)
        {
            Price = price;
            Bedroom = bedroom;
            Bathroom = bathroom;
            SquareFeet = squareFeet;
        }

        public decimal Price { get; set;}

        public int Bedroom { get; set;}

        public int Bathroom { get; set;}

        public double SquareFeet { get; set;}


    }
}
