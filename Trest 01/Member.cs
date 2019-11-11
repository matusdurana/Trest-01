using System;
namespace Trest_01
{
    internal class Member
    {
        public Member(string name, string type, int health, int food, int sleep)
        {
            Name = name;
            Type = type;
            Health = health;
            Food = food;
            Sleep = sleep;
        }
        public string Name { get; }
        public string Type { get; }
        public int Health { get; set; }
        public int Food { get; set; }
        public int Sleep { get; set; }

        public void Update()
        {
            if (Health <= 0) return;
            Food -= 5;
            if (Food <= 0)
            {
                Health--;
                if (Health > 0)
                {
                    Console.WriteLine($"{Name} Je hladná");
                }
                else
                {
                    Console.WriteLine($"{Name} Umiera od hladu.");
                    Health = 0;
                }

                Food = 0;
            }
        }

        public void Eat(int amount)
        {
            Food += amount;
        }

        public void Update2()
        {
            if (Sleep <= 0) return;
            Sleep -= 5;
            if (Sleep <= 0)
            {
                Console.WriteLine($"{Name} Je unavená.");
            }
            else
            {
                Console.WriteLine($"{Name} Odpadáva od únavy.");
                Health = 0;
            }
            Sleep = 0;
        }

        public void Time_in_Bed(int amount)
        {
            Sleep += amount;
        }
    }
}
        