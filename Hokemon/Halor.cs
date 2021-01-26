using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Halor: Hokemon // Inheriting from parent Hokemon class
    {
        public Halor()
        {
            Team = "Halor";
        }

        public void about() // Polymorphism from the Hokemon about method
        {
            Console.WriteLine("I am {0}, part of team {1}!", Name, team);
        }
    }
}
