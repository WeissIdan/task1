using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IdanWeiss
{
    internal class Bird : Animal, IBird
    {
        protected int flightHeight;
        public int getFlightHeight()
        {
            return flightHeight;
        }
        public void setFlightHeight(int flightHeight)
        {
            this.flightHeight = flightHeight;
        }
        //
        protected double wingspan;
        public double getWingSpan()
        {
            return wingspan;
        }
        public void setWingSpan(double wingSpan)
        {
            this.wingspan = wingSpan;
        }
        //
        public Bird(string name, int age, bool isApexPredator, double caloriesPerMeal,int flightHeight, double wingspan)
        : base(name, age, isApexPredator, caloriesPerMeal)
        {
            this.flightHeight = flightHeight;
            this.wingspan = wingspan;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nflight height: {flightHeight} \nwingspan: {wingspan}";
        }

        public string Sing()
        {
            return "lalalalalalalalalalalalala";
        }
        public string Dance()
        {
            return "dancing bird";
        }

        public void Rise()
        {
            Console.WriteLine("rising up into the sky");
        }
        public void Land()
        {
            Console.WriteLine("landing");
        }
        public void Fly()
        {
            Console.WriteLine("flying! \\_/");
        }

        public override void Metabolise()
        {
            Console.WriteLine("metabolising in bird");
        }

        public override void Age()
        {
            this.age++;
        }

        public override void Repreduce()
        {
            Console.WriteLine("thing in bird");
        }
    }
}
