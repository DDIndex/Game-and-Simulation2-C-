using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_chara
{
    
    enum Race
    {
        Human = 1,
        Orc,
        Elf,
        Dwarf,
        Gnome,
        Hobbit,
        Alien

    }
    enum Class
    {
        Mage = 1,
        Barbarian,
        Druid,
        Sharpshooter,
        Paladin
    }
    enum Stat : uint
    {
        Health,
        Strength,
        Speed,
        Defence
    }
    class Program
    {
        
        static void Main(string[] args)
        {

            int choice;
            bool loop = true;
            while (loop == true)
            {
                Race userRace = 0;
                Class userClass = 0;
                Console.WriteLine("Your name?");
                string userName = Console.ReadLine();
                Console.WriteLine("Your Race?");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 1 && choice <= 7)
                {
                    userRace = (Race)choice;
                }
                else
                {
                    Console.WriteLine("Sorry, your input is not in the range");
                }
                Console.WriteLine("Your Class?");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 1 && choice <= 5)
                {
                    userClass = (Class)choice;
                }
                else
                {
                    Console.WriteLine("Sorry, your input is not in the range");
                }
                Console.WriteLine("Please confirm Your info :  Name: " + userName +" Race: "+ userRace +"Class: "+ userClass);
                Console.WriteLine("Do you like your setup? yes or no");
                string like = Console.ReadLine();
                if (like == "yes")
                {
                    loop = false;
                }
            }

            Stat userHealth = Stat.Health;
            Stat userStrength = Stat.Strength;
            Stat userSpeed = Stat.Speed;
            Stat userDefence = Stat.Defence;
            Console.WriteLine("Now choose you character base stat (in total of 25 point). ");
            Console.WriteLine("What is your Heath stat? (1-10)");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 1 && choice <= 22)
            {
               
            }
            else
            {
                Console.WriteLine("Sorry, your input is not in the range");
            }
            Console.WriteLine("What is your Strength stat? (1-10)");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 1 && choice <= 22)
            {
                userStrength = (Stat)choice;
            }
            else
            {
                Console.WriteLine("Sorry, your input is not in the range");
            }
            Console.WriteLine("What is your Speed stat? (1-10)");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 1 && choice <= 22)
            {
                userSpeed = (Stat)choice;
            }
            else
            {
                Console.WriteLine("Sorry, your input is not in the range");
            }
            Console.WriteLine("What is your Defence stat? (1-10)");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 1 && choice <= 22)
            {
                userDefence = (Stat)choice;
            }
            else
            {
                Console.WriteLine("Sorry, your input is not in the range");
            }
            
            Console.ReadKey();

        }
    }
}
