﻿using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Hokemon hokeObject01 = new Hokemon();

            Console.WriteLine("\nHokemon name is: {0}", hokeObject01.Name);

            hokeObject01.get_details();

            Hokemon hokeObject02 = new Hokemon();

            Console.WriteLine("\nHokemon name is: {0}", hokeObject02.Name);

            hokeObject02.get_details();

            // Using the about method
            hokeObject01.about();

            Battle_Arena firstArena = new Battle_Arena(); // Instantiated Battle_Arena

            firstArena.ChallengeMe(hokeObject01);
            firstArena.ChallengeAccepted(hokeObject02);
            firstArena.Battle(hokeObject01, hokeObject02);
        }
    }
}
