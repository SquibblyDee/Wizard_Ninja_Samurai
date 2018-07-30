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
            object AttackBoxedObject = phil;
            steve.Attack(ref AttackBoxedObject);
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

            ////Creating a new Ninja object named Drake
            Ninja drake = new Ninja("Drake");

            ////Steal from Phil
            HumanInfo(phil);
            NinjaInfo(drake);
            object BoxedData2 = phil;
            drake.Steal(ref BoxedData2);
            HumanInfo(phil);
            NinjaInfo(drake);

            ////Have drake get away
            NinjaInfo(drake);
            drake.GetAway();
            NinjaInfo(drake);

            ////Create a new samurai named Ted
            Human ted = new Samurai("Ted");
            Console.WriteLine("CREATED TED");
            SamuraiInfo(ted as Samurai);

            ////Have Ted deathblow and fail, then weaken and deathblow Drake
            object DeathblowBoxedObject = drake;
            (ted as Samurai).DeathBlow(DeathblowBoxedObject);
            ted.Attack(ref DeathblowBoxedObject);
            ted.Attack(ref DeathblowBoxedObject);
            ted.Attack(ref DeathblowBoxedObject);
            (ted as Samurai).DeathBlow(DeathblowBoxedObject);

            ////Damaging then healing Ted via meditation
            HumanInfo(ted);
            object BoxedObject3 = ted;
            phil.Attack(ref BoxedObject3);
            HumanInfo(ted);
            (ted as Samurai).Meditate();
            HumanInfo(ted);
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
            Console.WriteLine("\nNAME: "+(obj as Samurai).name);
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
