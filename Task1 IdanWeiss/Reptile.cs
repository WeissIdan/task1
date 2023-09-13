using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IdanWeiss
{
    internal class Reptile :Animal, IReptile
    {
        protected double tailLen;
        public double getTailLen()
        {
            return tailLen;
        }
        public void setTailLen(double tailLen)
        {
            this.tailLen = tailLen;
        }
        //
        public Reptile(string name, int age, bool isApexPredator, double caloriesPerMeal,double tailLen)
            :base(name, age, isApexPredator, caloriesPerMeal)
        {
            this.tailLen = tailLen;
        }
        public override string ToString()
        {
            return base.ToString() + $"\ntail length: {tailLen}";
        }
        
        public void Crawl()
        {
            Console.WriteLine("crawling reptile on the way");
        }

        public void Shield()
        {
            Console.WriteLine("shielding position, engaged");
        }

        public int BodyHeat()
        {
            Console.WriteLine("what is the body heat?");
            int heat = int.Parse(Console.ReadLine());
            return heat;
        }

        public override void Metabolise()
        {
            Console.WriteLine("metabolising but in lizard");
        }

        public override void Age()
        {
            this.age++;
        }

        public override void Repreduce()
        {
            Console.WriteLine("thing but in lizard");
        }
    }
}
