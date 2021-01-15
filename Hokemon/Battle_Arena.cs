using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Battle_Arena
    {
        public Battle_Arena() // Constructor method funs first
        {
            Console.WriteLine("\nWelcome to the battle arena!");
        }

        public void ChallengeMe(Hokemon hokeChallenger)
        {
            Console.WriteLine("\n{0} says: 'I want to battle!'", hokeChallenger.Name);
        }
    }
}
