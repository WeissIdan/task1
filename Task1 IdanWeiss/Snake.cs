using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IdanWeiss
{
    internal class Snake : Reptile
    {
        protected bool isVenumous;
        public bool getIsBenumous()
        {
            return isVenumous;
        }
        public void setIsVenomous(bool isVenomous)
        {
            this.isVenumous = isVenomous;
        }
        //
        public Snake(string name, int age, bool isApexPredator, double caloriesPerMeal, double tailLen,bool isVenumous)
        : base(name, age, isApexPredator, caloriesPerMeal, tailLen)
        {
            this.isVenumous = isVenumous;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nis venomous: {isVenumous}";
        }
        public string Dance()
        {
            return "dancing snake...";
        }
    }
}
