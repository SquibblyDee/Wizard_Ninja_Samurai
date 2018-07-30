using System;
using System.Collections.Generic;

namespace Human_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHuman Exercise:");
            ////Creating a new Human object named Steve
            Human steve = new Human("Steve");
            Console.WriteLine("\nNAME: "+steve.name);
            Console.WriteLine("STRENGTH: "+steve.strength);
            Console.WriteLine("INTELLIGENCE: "+steve.intelligence);
            Console.WriteLine("DEXTERITY: "+steve.dexterity);
            Console.WriteLine("HEALTH: "+steve.health);

            ////Creating a new Human object named Phil
            Human phil = new Human("Phil", 5, 5, 5, 120);
            Console.WriteLine("\nNAME: "+phil.name);
            Console.WriteLine("STRENGTH: "+phil.strength);
            Console.WriteLine("INTELLIGENCE: "+phil.intelligence);
            Console.WriteLine("DEXTERITY: "+phil.dexterity);
            Console.WriteLine("HEALTH: "+phil.health);
            Console.WriteLine("\nSteve is attacking Phil...");
            
            ///Having Steve attack Phil. We need to pass the object as a reference or we can't edit it's attributes on the other side
            steve.Attack(ref phil);
            Console.WriteLine("\nNAME: "+phil.name);
            Console.WriteLine("HEALTH: "+phil.health);
            Console.WriteLine("\nNAME: "+steve.name);
            Console.WriteLine("HEALTH: "+steve.health);
        }
    }
}
