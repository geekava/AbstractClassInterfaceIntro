using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterfaceIntro
{
    public class Animal : Creature
    {
        public override void DisplayHabitat()
        {
            Console.WriteLine("America");
        }
    }
}
