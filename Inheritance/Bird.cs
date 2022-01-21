using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
        }
        public Bird(bool canfly, string beakcolor, int wingcount)
        {
            CanFly = canfly;
            BeakColor = beakcolor;
            WingCount = wingcount;
        }

        public bool CanFly { get; set; }
        public string BeakColor { get; set; }
        public int WingCount { get; set; }

        public void FlyAway()
        {
            Console.WriteLine(CanFly ? "Flap flap" : $"{Name} can't fly");
        }
    }
}
