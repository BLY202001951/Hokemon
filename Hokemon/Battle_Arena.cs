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

        public void ChallengeAccepted(Hokemon hokeAccepter)
        {
            Console.WriteLine("\n{0} says: 'I accept your challenge!'", hokeAccepter.Name);
        }

        public void Battle(Hokemon Attacker, Hokemon Defender)
        {
            int attackValue;
            int defenceValue;
            int round = 0;

            while (Attacker.Health >= 0 && Defender.Health >= 0)
            {
                round += 1; // This is the same as round = round + 1
                Console.WriteLine("\n\nROUND {0}\n\n", round);

                attackValue = Attacker.attackCalculator();
                defenceValue = Defender.defenceCalculator();

                Console.WriteLine("{0}: Attacks with value {1}", Attacker.Name, attackValue);

                Console.WriteLine("\n{0}: Generates a defence...", Defender.Name);
                Console.WriteLine("\n{0}: Defends with value {1}", Defender.Name, defenceValue);
                Console.WriteLine("\n{0}: Health is {1}", Defender.Name, Defender.Health);

                Console.WriteLine("\nCalculation: (Health {0} + Defence {1}) - Attack {2}", Defender.Health, defenceValue, attackValue);
                Defender.Health = (Defender.Health + defenceValue) - attackValue;

                Console.WriteLine("\n{0}: Health changed to {1}", Defender.Name, Defender.Health);

            }
        }
    }
}
