using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            Tested = true;
            Age = 0;
            Color = "Green";
            LegCount = 3;

        }


        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }
    }
}
