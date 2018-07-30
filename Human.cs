using System;
using System.Collections.Generic;

namespace Human_Application
{
    public class Human
    {
        public int strength;
        public int dexterity;
        public int intelligence;
        public int health;
        public string name;

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

        public void Attack(ref Human_Application.Human obj)
        {
            if(obj.GetType() == typeof(Human))
            {
                int damage = strength*5;
                obj.health-=damage;
            }
        }
    }
}
