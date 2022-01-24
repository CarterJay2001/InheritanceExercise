using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var Pengiun = new Bird(false, "yellow", 2)
            {
                Name = "Mumble",
                Age = 5,
                Noise = "Honk Honk"
            };
            Console.WriteLine($"Pengiun" +
                $"\nHis name is {Pengiun.Name}" +
                $"\nHe is {Pengiun.Age} years old" +
                $"\nHis beak is {Pengiun.BeakColor}" +
                $"\nHe has {Pengiun.WingCount} wings" +
                $"\nCan he fly? {Pengiun.FlyAway()}" +
                $"{Pengiun.MakeNoise()}\n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var Chameleon = new Reptile(false, "all the colors", 1)
            {
                Name = "Pascal",
                Age = 3,
                Noise = "huff puff"
            };
            Console.WriteLine($"Chameleon" +
                $"\nHis name is {Chameleon.Name}" +
                $"\nHe is {Chameleon.Age} years old" +
                $"\nHis scales are {Chameleon.ScaleColor}" +
                $"\nHe has {Chameleon.TailCount} wings" +
                $"\nCan you pet him? {Chameleon.CanIPet()}" +
                $"{Pengiun.MakeNoise()}");
        }
    }
}
