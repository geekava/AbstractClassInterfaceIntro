using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterfaceIntro
{
    class Bird : Creature, IFlyable
    {
        public override void DisplayHabitat()
        {
            Console.WriteLine("Africa");
        }

        public void PrintLocation()
        {
            Console.WriteLine("Bird is flying....");
        }
    }
}
