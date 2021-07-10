using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterfaceIntro
{
    public class Plane : IFlyable
    {
        public string Name { get; set; }

        public Plane() { }

        public Plane(string name)
        {
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
        }

        public void PrintLocation()
        {
            Console.WriteLine("Plane is flying...");
        }
    }
}
