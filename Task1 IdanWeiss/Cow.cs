using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IdanWeiss
{
    internal class Cow : Mammal
    {
        public int whelpingNUmber;
        public int getWhelpingNumber()
        {
            return whelpingNUmber;
        }
        public void set(int whelpingNUmber)
        {
            this.whelpingNUmber = whelpingNUmber;
        }
        //
        public Cow(string name, int age, bool isApexPredator, double caloriesPerMeal, double caloriesInMilk, int pregnencyLength,int whelpingNUmber)
        :base(name, age, isApexPredator, caloriesPerMeal, caloriesInMilk, pregnencyLength)
        {
            this.whelpingNUmber = whelpingNUmber;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nwhelping count: {whelpingNUmber}";
        }
        public new double Eat()
        {
            return base.Eat() * 0.25;
        }
    }
}
