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
            // HumanInfo(steve);

            ////Creating a new Human object named Phil
            Human phil = new Human("Phil", 5, 5, 5, 120);
            // HumanInfo(phil);

            ///Having Steve attack Phil. We need to pass the object as a reference or we can't edit it's attributes on the other side
            Console.WriteLine("\nSteve is attacking Phil...");
            object AttackBoxedObject = phil;
            steve.Attack(ref AttackBoxedObject);
            // HumanInfo(steve);
            // HumanInfo(phil);

            ////Creating a Wizard object named Dilbert
            Wizard dilbert = new Wizard("Dilbert");
            // WizardInfo(dilbert);

            ////Healing our wizard, Dilbert
            dilbert.Heal();
            // WizardInfo(dilbert);

            ////Casting Fireball on Steve
            // HumanInfo(steve);
            object BoxedData = steve;
            dilbert.Fireball(ref BoxedData);
            // HumanInfo(steve);

            ////Creating a new Ninja object named Drake
            Ninja drake = new Ninja("Drake");

            ////Steal from Phil
            // HumanInfo(phil);
            // NinjaInfo(drake);
            object BoxedData2 = phil;
            drake.Steal(ref BoxedData2);
            // HumanInfo(phil);
            // NinjaInfo(drake);

            ////Have drake get away
            // NinjaInfo(drake);
            drake.GetAway();
            // NinjaInfo(drake);

            ////Create a new samurai named Ted
            Samurai ted = new Samurai("Ted");

            ////Have Ted deathblow and fail, then weaken and deathblow Drake
            object DeathblowBoxedObject = drake;
            ted.DeathBlow(DeathblowBoxedObject);
            ted.Attack(ref DeathblowBoxedObject);
            ted.Attack(ref DeathblowBoxedObject);
            ted.Attack(ref DeathblowBoxedObject);
            ted.DeathBlow(DeathblowBoxedObject);

            ////Damaging then healing Ted via meditation
            // SamuraiInfo(ted);
            object BoxedObject3 = ted;
            phil.Attack(ref BoxedObject3);
            // SamuraiInfo(ted);
            ted.Meditate();
            // SamuraiInfo(ted);
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

        static void NinjaInfo(Ninja obj)
        {
            Console.WriteLine("\nNAME: "+obj.name);
            Console.WriteLine("STRENGTH: "+obj.strength);
            Console.WriteLine("INTELLIGENCE: "+obj.intelligence);
            Console.WriteLine("DEXTERITY: "+obj.dexterity);
            Console.WriteLine("HEALTH: "+obj.health);
        }

        static void SamuraiInfo(Samurai obj)
        {
            Console.WriteLine("\nNAME: "+obj.name);
            Console.WriteLine("STRENGTH: "+obj.strength);
            Console.WriteLine("INTELLIGENCE: "+obj.intelligence);
            Console.WriteLine("DEXTERITY: "+obj.dexterity);
            Console.WriteLine("HEALTH: "+obj.health);
        }
    }
}
