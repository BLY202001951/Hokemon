using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hinstinct : Hokemon
    {
        public Hinstinct()
        {
            Team = "Hinstinct";
        }

        public void about()
        {
            Console.WriteLine("\nI am {0}, part of team {1}!", Name, Team);
        }
    }
}
