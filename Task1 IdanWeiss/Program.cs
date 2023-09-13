using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IdanWeiss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal[] mammals = new Mammal[]{
                new Mammal("yeapy", 12, true, 17.7, 90, 92),
                new Cow("clopy", 7, false, 32, 90, 92, 2),
                new Cow("shlopy", 53, false, 79, 90, 91, 3),
                new Mammal("sneapy", 1, true, 80, 90, 92),
                new Hipo("creapy", 1127582, true, 2593407498, 90, 92, 800)
            };
            Reptile[] reptiles = new Reptile[]{
                new Reptile("repti", 13 ,false, 90, 78),
                new Python("c++", 40, true, 0, 6, true, "blue"),
                new Snake("snake snake", 2, true, 80, 90, false),
                new Crocodile("croc", 100, true, 900, 500, true),
                new Python("c", 51, true, 0, 68, true, "blue")
            };

            Animal[] animals = new Animal[]{
                //new Animal("animalMan", 16, true, 300),
                new Hawk("hawkeye", 37, 400, 700, 50, 200),
                new Bird("birb", 5, false, 80, 60, 13.6),
                new Hipo("yeapyeap", 90, false, 1500, 300, 15, 67.8),
                new Crocodile("croocroo", 51, true, 3000, 60,false),
                new Snake("sniffsniff", 15, true, 2000, 70, true),
                new Mammal("animammal", 16, true, 400, 70, 9),
                new Reptile("reportile", 6, false, 70, 40)
            };

            Console.WriteLine("mammals:");
            foreach(Mammal m in mammals)
            {
                Console.WriteLine("\n" + m.GetType().ToString().Remove(0,16) +":");
                Console.WriteLine(m);
            }
            Console.WriteLine("\n\nreptiles:");
            foreach(Reptile m in reptiles)
            {
                Console.WriteLine("\n" + m.GetType().ToString().Remove(0, 16) + ":");
                Console.WriteLine(m);
            }
            Console.WriteLine("\n\nanimals:");
            foreach(Animal m in animals)
            {
                Console.WriteLine("\n" + m.GetType().ToString().Remove(0, 16) + ":");
                Console.WriteLine(m);
            }


            Console.WriteLine("");
        }
        public static double howMuchEat(Animal[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].Eat();
            }
            return sum;
        }

        public static double howManyMammals(Animal[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Mammal)
                    sum++;
            }
            return sum;
        }

        public static void danceSnakeDance(Animal[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Snake)
                {
                    Console.WriteLine(((Snake)arr[i]).Dance());
                }
                else if (arr[i] is Bird)
                {
                    Console.WriteLine(((Bird)arr[i]).Dance());
                }
            }
        }
        public static string fatetstHipoInTheWest(Animal[] arr)
        {
            string HipoName = "no hipo found";
            double fatHipo = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Hipo)
                {
                    if (((Hipo)arr[i]).getFat() > fatHipo)
                    {
                        HipoName = arr[i].getName();
                    }
                }
            }
            return HipoName;
        }



    }
}
