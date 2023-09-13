using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IdanWeiss
{
    internal class Hipo : Mammal
    {
        protected double fatPercantage;
        public double getFat()
        {
            return fatPercantage;
        }
        public void setFatPercentage(double fatPercentage)
        {
            this.fatPercantage = fatPercentage;
        }
        //
        public Hipo(string name, int age, bool isApexPredator, double caloriesPerMeal, double caloriesInMilk, int pregnencyLength, double fatPercantage)
        : base(name, age, isApexPredator, caloriesPerMeal, caloriesInMilk, pregnencyLength)
        {
            this.fatPercantage = fatPercantage;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nfat%: {fatPercantage}";
        }
    }
}
