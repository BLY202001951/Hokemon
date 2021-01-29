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

            // Declaring members
            Hinstinct[] ChallengerArray = new Hinstinct[3];

            Random rnd = new Random();
            bool repeatGame = true;
            string result;

            // Creating player Hokemon
            Halor playerHokemon01 = new Halor(); // Instantiation from Halor class

            // NPC Hokemon
            for (int i = 0; i < ChallengerArray.Length; i++)
            {
                ChallengerArray[i] = new Hinstinct(); // Instatiating challenger Hokemon
            }
        }
    }
}
