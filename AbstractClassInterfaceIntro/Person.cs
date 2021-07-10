using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterfaceIntro
{
    class Person : Creature
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Passport { get; set; }


        public Person()
        {

        }

        public Person(string passport, string firstName, string lastName)
        {
            Passport = passport;
            FirstName = firstName;
            LastName = lastName;
        }

        public override void DisplayHabitat()
        {
            Console.WriteLine("Earth");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
