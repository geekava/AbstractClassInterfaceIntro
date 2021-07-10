using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterfaceIntro
{
    public class FlyingObjectDisplayer
    {
        public static void Display(IFlyable flyable)
        {
            flyable.PrintLocation();
        }
    }
}
