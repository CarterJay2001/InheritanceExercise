using System;
namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {
        }
        public Animal(string name, int age, string noise)
        {
            Name = name;
            Age = age;
            Noise = noise;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Noise { get; set; }

        public string MakeNoise()
        {
            return $"{Name} says {Noise}!";
        }
    }
}
