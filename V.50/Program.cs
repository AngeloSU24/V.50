using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace V._50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            Player p1 = new Player();
            {
                p1.name = "Frize";
                p1.health = 20;
                p1.damage = Rand.Next(5, 11);
                p1.heal = 5;
            }
            Player p2 = new Player();
            {
                p2.name = "Nuggit";
                p2.health = 30;
                p2.damage = Rand.Next(3, 8);
                p2.heal = Rand.Next(4, 9);
            }
            Enemy e1 = new Enemy();
            {
                e1.name = "Ani Joan";
                e1.health = 50;
                e1.damage = Rand.Next(5, 8);
            }
            Console.WriteLine("On a sunny day Frize and Nuggit are having a walk, when out of nowhere" +
                " Ani Joan goes and jumps them:");
            p1.PrintStatus();
            p2.PrintStatus();
            e1.enemyStatus();
            Console.WriteLine("Frize thinking she is the MC takes the initiative, what should she do?");
            Console.WriteLine("(1) SLime Ani Joan");
            Console.WriteLine("(2) Heal Herself");
            Console.WriteLine("(3) Talk");
            int answer = int.Parse(Console.ReadLine());
            //while ()
            {

            }
            if (answer == 1)
            {
                e1.TakeDamage(p1.damage);
            }
            else if (answer == 2)
            {
                p1.HealSelf(p1.heal);
            }
            p1.PrintStatus();
            e1.enemyStatus();
        }
        
        class Enemy
        {
            public string name;
            public int health;
            public int damage;
            public int TakeDamage(int damage)
            {
                health = health - damage;
                return health;
            }
            public void enemyStatus()
            {
                Console.WriteLine($"{name} has {health} HP");


            }
        }
        class Player
        {
            public string name;
            public int health;
            public int damage;
            public int heal;
            public int TakeDamage(int damage)
            {
                health = health - damage;
                return health;
            }
            public int HealSelf(int HP)
            {
                health = health + HP;
                return health;
            }
            public void PrintStatus()
            {
                Console.WriteLine($"{name} has {health} HP");


            }
        }
    }
}
