using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.HasBeak = true;
            myBird.TalkBack = false;

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            var myReptile = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                CanGrowTail = true
            };


            var myAnimals = new Animal[] { myBird, myReptile };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Tested:{animal.Tested}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"Color:{animal.Color}");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine();
            }
        }
    }
}
