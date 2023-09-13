using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IdanWeiss
{
    internal class Park
    {
        protected Animal[] animals;
        public Park()
        {
            animals = new Animal[1000];
        }
        public void addAnimal(Animal an)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] == null)
                {
                    animals[i] = an;
                    i = animals.Length;
                }
            }
        }
        public string findNeededAnimals()
        {
            string animalList = "";
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] != null)
                {
                    if (animals[i].getAge() > 10 && animals[i].getIsApex())
                    {
                        animalList += animals[i].getName() + "\n";
                    }
                }
            }
            return animalList;
        }
        public int findAllApexReptileBirds()
        {
            int sum = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].getIsApex() && (animals[i] is Reptile || animals[i] is Bird))
                    sum++;
            }
            return sum;
        }

    }
}
