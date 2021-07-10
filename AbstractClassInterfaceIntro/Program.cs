using System;

namespace AbstractClassInterfaceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Creature person = new Person();
            Creature bird = new Bird();
            Creature animal = new Animal();

            CreaturePrinter.PrintHabitat(person);
            CreaturePrinter.PrintHabitat(bird);
            CreaturePrinter.PrintHabitat(animal);

            Plane plane = new Plane();
            FlyingObjectDisplayer.Display(plane);

            FlyingObjectDisplayer.Display((Bird)bird);

            if (animal is Bird)
            {
                Console.WriteLine("You have bird..");
            }
            else
            {
                Console.WriteLine("You have a creature....");
            }

            Bird birdCasted = animal as Bird;
            if (birdCasted != null)
            {
                Console.WriteLine("Bird is here with as operator....");
            }
            else
            {
                Console.WriteLine("As operator returned null....");
            }

            Person jack = new Person("pass1", "Jack", "White");
            Person jack1 = new Person("pass1", "Jack", "White");

            if (jack.Equals(jack1))
            {
                Console.WriteLine("jack and jack1 are the same...");
            }
            else
            {
                Console.WriteLine("You are worng!!!! jack and jack1 are different...");
            }

        }
    }
}
