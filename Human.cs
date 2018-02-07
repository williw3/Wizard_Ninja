using System;
using System.Collections.Generic;

namespace wizard_ninja
{
    public class Human
    {
        public string name;

    //The { get; set; } format creates accessor methods for the field specified
    //This is done to allow flexibility
    public int health { get; set; }
    public int strength { get; set; }
    public int intelligence { get; set; }
    public int dexterity { get; set; }

    public Human(string person)
    {
        name = person;
        strength = 3;
        intelligence = 3;
        dexterity = 3;
        health = 100;
    }
    
    public Human(string person, int str, int intel, int dex, int hp)
    {
        name = person;
        strength = str;
        intelligence = intel;
        dexterity = dex;
        health = hp;
    }

    
    public void attack(object obj)
    {
        Human enemy = obj as Human;
        if(enemy == null)
        {
            Console.WriteLine("Failed Attack");
        }
        else
        {
            enemy.health -= strength * 5;
        }
    }
    public void getinfo()
    {
        Console.WriteLine($"Name: {name}, Strength: {strength}, Intelligence: {intelligence}, Dexterity: {dexterity}, Health: {health}");
    }
    }
    
    public class Wizard : Human
    {
        public Wizard(string person) : base(person)
        {
            intelligence = 25;
            health = 50;
            Console.WriteLine("New Wizard created named {0}", name);
        }
        public void heal()
        { 
            health += intelligence * 10;
        }
        public void fireball(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                Random rand = new Random();
                int damage = rand.Next(20, 51);
                enemy.health -= damage;
            }
        }
    }
    public class Ninja : Human
    {
        public Ninja(string person) : base(person)
        {
            dexterity = 175;
            Console.WriteLine("New Ninja created named {0}", name);
        }
        public void steal(object obj)
        {
            base.attack(obj);
            health += 10;
            
        }
        public void get_away()
        {
            health -= 15;
        }
    }
    public class Samurai : Human
    {

        public Samurai(string person) : base(person)
        {
            health = 200;
            Console.WriteLine("New Samurai created named {0}", name);
        }

        public void death_blow(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else if (enemy.health > 50){
                base.attack(obj);
            }
            else{
                enemy.health = 0;
            }
        }
        public void meditate()
        {
            health = 200;
            Console.WriteLine("Samurai {0} restored to full health {1}", name, health);
        }

    }
}