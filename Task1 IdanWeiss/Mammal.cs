using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IdanWeiss
{
    internal class Mammal: Animal
    {
        protected double caloriesInMilk;
        public double getCaloriesInMilk()
        {
            return caloriesInMilk;
        }
        public void setCaloriesInMilk(double caloriesInMilk)
        {
            this.caloriesInMilk = caloriesInMilk;
        }
        //
        protected int pregnencyLength;
        public int getPregnencyLength()
        {
            return pregnencyLength;
        }
        public void setPregnencyLength(int pregnencyLength)
        {
            this.pregnencyLength = pregnencyLength;
        }
        //

        public Mammal(string name, int age, bool isApexPredator, double caloriesPerMeal,double caloriesInMilk, int pregnencyLength) 
            : base(name, age, isApexPredator,caloriesPerMeal)
        {
            this.caloriesInMilk = caloriesInMilk;
            this.pregnencyLength = pregnencyLength;
        }
        public override string ToString()
        {

            return base.ToString() + $"\ncalories in milk: {caloriesInMilk} \nprecnency length: {pregnencyLength}";
        }
        public new double Eat()
        {
            return base.Eat() + caloriesInMilk;
        }
        public override void Metabolise()
        {
            Console.WriteLine("metabolising");
        }

        public override void Age()
        {
            this.age++;
        }

        public override void Repreduce()
        {
            Console.WriteLine("thing");
        }
    }
}
