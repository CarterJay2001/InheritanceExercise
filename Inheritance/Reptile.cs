using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }
        public Reptile(bool ispoison, string scalecolor, int tailcount)
        {
            IsPoison = ispoison;
            ScaleColor = scalecolor;
            TailCount = tailcount;
        }

        public bool IsPoison { get; set; }
        public string ScaleColor { get; set; }
        public int TailCount { get; set; }

        public string CanIPet()
        {
            return IsPoison ? $"NO! Don't touch {Name}" : "Yea sure give him a pet.";
        }
    }
}
