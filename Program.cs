using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Fighter
{
    struct Info
    {
        public string Name;
        public int Health;
        public int Attack;
        public int Defence;
        public int Speed;

        public Info(string name,int health,int attack,int defence,int speed)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defence = defence;
            Speed = speed;

        }

    }
    
    enum Warrior
    {
        Warrior,
        Cleric,
        Paladin,
        UnicornKnight,
        Knight,
        Mage
    }
    class Program
    {
        static void Main(string[] args)
        {

            bool loop = true;
            string like;
            while (loop == true)
            {
                Info user;
                int sum = 0;
                Console.WriteLine("Your name?");
                user.Name = Console.ReadLine();
                Console.WriteLine("Your health? (1-17)");
                user.Health = Convert.ToInt32(Console.ReadLine());
                if (user.Health >= 1 && user.Health <= 17)
                {
                    sum += user.Health;
                }
                else
                {
                    Console.WriteLine("InputNotInRange: automatically set to 1");
                    sum += 1;
                }
                Console.WriteLine("Your attack? (1-17)");
                user.Attack = Convert.ToInt32(Console.ReadLine());
                if (user.Attack >= 1 && user.Attack <= 17)
                {
                    sum += user.Attack;
                }
                else
                {
                    Console.WriteLine("InputNotInRange: automatically set to 1");
                    sum += 1;
                }
                Console.WriteLine("Your defence? (1-17)");
                user.Defence = Convert.ToInt32(Console.ReadLine());
                if (user.Defence >= 1 && user.Defence <= 17)
                {
                    sum += user.Defence;
                }
                else
                {
                    Console.WriteLine("InputNotInRange: automatically set to 1");
                    sum += 1;
                }
                Console.WriteLine("Your speed? (1-17)");
                user.Speed = Convert.ToInt32(Console.ReadLine());
                if (user.Speed >= 1 && user.Speed <= 17)
                {
                    sum += user.Speed;
                }
                else
                {
                    Console.WriteLine("InputNotInRange: automatically set to 1");
                    sum += 1;
                }

                if (sum == 25)
                {
                    Console.WriteLine($"Please confirm Your info :  \nName: {user.Name} \nHealth Level: {user.Health} \nStength Level: {user.Attack}\nSpeed Level: {user.Speed}\nDefence Level: {user.Defence}");
                    Console.WriteLine("\nDo you like your stats? yes or no");
                }
                else
                {
                    Console.WriteLine("Sorry, you must have in total of 20 point. You have " + sum + " points right now.");
                    Console.WriteLine("Press any key to try again");
                }
                like = Console.ReadLine();
                if (like == "yes")
                {
                    loop = false;
                }

                int choice;
                Warrior userType;
                Console.WriteLine("Your Warrior type?(1.Warrior 2.Cleric 3.Paladin 4.Unicorn Knight 5.Knight 6.Mage)");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 1 && choice <= 6)
                {
                    userType = (Warrior)choice;
                    if(choice ==1)
                    {
                        user.Attack =+2;
                        user.Defence =-1;
                    }
                    else if (choice == 2)
                    {
                        user.Health =+ 1;
                        user.Defence =+ 1;
                    }
                    else if (choice == 3)
                    {
                        user.Defence = +2;
                        user.Attack = -1;
                    }
                    else if (choice == 4)
                    {
                        user.Health = -2;
                        user.Speed = +5;
                    }
                    else if (choice == 5)
                    {
                        user.Attack = +1;
                        user.Defence = +1;
                        user.Speed = -1;
                    }
                    else if (choice == 6)
                    {
                        user.Defence = -3;
                        user.Attack = +3;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, your input is not in the range");
                }
               

            }
        } 
    }
}
