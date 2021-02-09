using System;

namespace HumanProject.Models
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        
        // add a public "getter" property to access health
        public int Health {
            get {
                return health; 
            }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name) {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string name, int strength, int intel, int dex, int hp) {
            Name = name;
            Strength = strength;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        // Build Attack method
        public int Attack(Human target) {
        // Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. 
        // The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). 
        // This method should return the remaining health of the target object.
            int damage = target.Strength * 5;
            Console.WriteLine(target.Health);
            target.health -= damage;
            Console.WriteLine(target.Health);
            return target.Health;
        }
    }
}