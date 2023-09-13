using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IdanWeiss
{
    internal abstract class Animal
    {
        protected string name;
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
       //
        protected int age;
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
       //
        protected bool isApexPredator;
        public bool getIsApex()
        {
            return isApexPredator;
        }
        public void setIsApex(bool isApex)
        {
            this.isApexPredator = isApex;
        }
       //
        protected double caloriesPerMeal;
        public double getCaloriesPerMeal()
        {
            return caloriesPerMeal;
        }
        public void setCaloriesPerMeal(double caloriesPerMeal)
        {
            this.caloriesPerMeal = caloriesPerMeal;
        }

        public Animal(string name, int age, bool isApexPredator, double caloriesPerMeal)
        {
            this.name = name;
            this.age = age;
            this.isApexPredator = isApexPredator;
            this.caloriesPerMeal = caloriesPerMeal;
        }
        public override string ToString()
        {
            return $"name: {name} \nage: {age} \nisApexPredetor: {isApexPredator} \ncalories per meal: {caloriesPerMeal}";
        }

        public double Eat()
        {
            return 3 * caloriesPerMeal;
        }

        public abstract void Metabolise();
        public abstract void Age();
        public abstract void Repreduce();

    }
}
