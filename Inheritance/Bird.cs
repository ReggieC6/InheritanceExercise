using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Tested = true;
            Age = 4;
            Color = "Red";
            LegCount = 2;
        }

        public string WingColor { get; set; }
        public bool CanFly { get; set; }
        public bool HasBeak { get; set; }
        public bool TalkBack { get; set; }
    }
}
