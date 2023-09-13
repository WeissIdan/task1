using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IdanWeiss
{
    internal class Python:Snake
    {
        protected string color;
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        //
        public Python(string name, int age, bool isApexPredator, double caloriesPerMeal, double tailLen, bool isVenumous,string color)
            :base(name, age, isApexPredator:true, caloriesPerMeal, tailLen, isVenumous)
        {
            this.color = color;
        }
        public override string ToString()
        {
            return base.ToString() + $"\ncolor: {color}";
        }
    }
}
