﻿using System;
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
            HumanInfo(steve);

            ////Creating a new Human object named Phil
            Human phil = new Human("Phil", 5, 5, 5, 120);
            HumanInfo(phil);
            Console.WriteLine("\nSteve is attacking Phil...");
            
            ///Having Steve attack Phil. We need to pass the object as a reference or we can't edit it's attributes on the other side
            steve.Attack(ref phil);
            HumanInfo(steve);
            HumanInfo(phil);

            ////Creating a Wizard object named Dilbert
            Wizard dilbert = new Wizard("Dilbert");
            WizardInfo(dilbert);

            ////Healing our wizard, Dilbert
            dilbert.Heal();
            WizardInfo(dilbert);

            ////Casting Fireball on Steve
            HumanInfo(steve);
            object BoxedData = steve;
            dilbert.Fireball(ref BoxedData);
            HumanInfo(steve);
        }

        static void WizardInfo(Wizard obj)
        {
            Console.WriteLine("\nNAME: "+obj.name);
            Console.WriteLine("STRENGTH: "+obj.strength);
            Console.WriteLine("INTELLIGENCE: "+obj.intelligence);
            Console.WriteLine("DEXTERITY: "+obj.dexterity);
            Console.WriteLine("HEALTH: "+obj.health);
        }

        static void HumanInfo(Human obj)
        {
            Console.WriteLine("\nNAME: "+obj.name);
            Console.WriteLine("STRENGTH: "+obj.strength);
            Console.WriteLine("INTELLIGENCE: "+obj.intelligence);
            Console.WriteLine("DEXTERITY: "+obj.dexterity);
            Console.WriteLine("HEALTH: "+obj.health);
        }
    }
}
