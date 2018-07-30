using System;
using System.Collections.Generic;

namespace Human_Application
{


    public class Human
    {
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int intelligence { get; set; }
        public int health { get; set; }
        public string name { get; set; }

        ////Create a base Human class with five attributes: name, strength, intelligence, dexterity, and health.
        ////Give a default value of 3 for strength, intelligence, and dexterity. Health should have a default of 100.
        ////When an object is constructed from this class it should have the ability to pass a name
        public Human(string str)
        {
            strength = 3;
            dexterity = 3;
            intelligence = 3;
            health = 100;
            name = str;
        }

        ////Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
        public Human(string str="John", int stronk=3, int dex=3, int intel=3, int hlth=100)
        {
            strength = stronk;
            dexterity = dex;
            intelligence = intel;
            health = hlth;
            name = str;
        }

        ////Now add a new method called attack, which when invoked, should attack another Human object that is passed as a parameter.
        public void Attack(ref object obj)
        {

            if(obj.GetType() == typeof(Human))
            {
                Human target = obj as Human;
                int damage = strength*5;
                target.health-=damage;
            }
            if(obj.GetType() == typeof(Wizard))
            {
                Wizard target = obj as Wizard;
                int damage = strength*5;
                target.health-=damage;
            }
            if(obj.GetType() == typeof(Ninja))
            {
                Ninja target = obj as Ninja;
                int damage = strength*5;
                target.health-=damage;
            }
        }
    }

    ////Wizard should have a default health of 50 and intelligence of 25


    public class Wizard : Human
    {
        public new int health;
        public new int intelligence; 

        public Wizard(string str="John")
        {
            name = str;
            intelligence = 25;
            health = 50;
        }
        
        public void Heal()
        {
            int healAmount = intelligence*10;
            this.health+=healAmount;
            Console.WriteLine("Healed for {0}", healAmount);
        }

        public void Fireball(ref object obj)
        {
            if(obj.GetType() == typeof(Human))
            {
                Human target = obj as Human;
                Random rand = new Random();
                int damage = rand.Next(20,51);
                Console.WriteLine("Fireball hit for {0} damage.", damage);
                target.health-=damage;
            }
            if(obj.GetType() == typeof(Wizard))
            {
                Wizard target = obj as Wizard;
                Random rand = new Random();
                int damage = rand.Next(20,51);
                Console.WriteLine("Fireball hit for {0} damage.", damage);
                target.health-=damage;
            }
        }
    }


    public class Ninja : Human
    {
        public new int dexterity;

        public Ninja(string str="John")
        {
            dexterity=175;
            name=str;
        }

        public void Steal(ref object obj)
        {
            Attack(ref obj);
            health-=10;
            Console.WriteLine("Successfully stole some stuff.");
        }

        public void GetAway()
        {
            this.health-=15;
            Console.WriteLine("Successfully got away.");
        }


    }
}
