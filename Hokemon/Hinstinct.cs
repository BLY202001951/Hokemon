using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hinstinct: Hokemon
    {
        private string team = "Hinstinct";

        public void about()
        {
            Console.WriteLine("I am {0}, part of team {1}!", Name, team);
        }
    }
}
