using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hokemon
    {
        // Members of a Class include Attributes, Properties and Methods

        // Attributes

        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;

        // Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        // Methods

        public Hokemon() // Constructor method runs first when instantiated
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);
        }

        public void provide_name()
        {
            Console.WriteLine("\nEnter name for your Hokemon: ");
            name = Console.ReadLine();
        }

        public void get_details()
        {
            Console.WriteLine("\n**********\nName: {0}\nHealth: {1}/{2}\nAttack value: {3}\nSpeed value: {4}\nDefense value: {5}", name, Health, max_health, attack, speed, defense);
        }

        public int random_int_generator(int min_value, int max_value) // These are parameters
        {
            Random rnd = new Random(); // Creating a new object, this is an instance of random class
            int randomValue;
            randomValue = rnd.Next(min_value, max_value); // Using the next method from the random class found in rnd object
            return randomValue;
        }
    }
}
