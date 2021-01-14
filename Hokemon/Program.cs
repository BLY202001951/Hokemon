using System;

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
        }
    }
}
