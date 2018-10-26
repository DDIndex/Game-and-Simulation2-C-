using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string play = "";
            while (!exit)
            {
                int guessCount = 0;
                Random rand = new Random();
                int randNum = rand.Next(1, 16);
                Console.WriteLine("Guess my number between 1 - 15!" + randNum);
                int inputNum = 0;


                while (randNum != inputNum && guessCount < 3)
                {
                    inputNum = Convert.ToInt32(Console.ReadLine());

                    if (inputNum > 15 || inputNum < 1)
                    {
                        Console.WriteLine("Out of the guess range\n try again!");
                    }
                    else if (inputNum != randNum)
                    {
                        Console.Write("Sorry not right!");
                        if (inputNum > randNum)
                        {
                            Console.WriteLine("too high");
                        }
                        else
                        {
                            Console.WriteLine("too low");
                        }
                        guessCount++;

                    }


                }
                if (guessCount < 3 && randNum == inputNum)
                {
                    Console.WriteLine("You're Right !!!");
                }
                else
                {
                    Console.WriteLine("The correct answer is " + randNum);
                }
                Console.WriteLine("press X to exit the game , any other keys to play again");
                play = Console.ReadLine();
                if (play == "X"||play == "x")
                {
                    exit = true;
                }
                else
                {
                    exit = false;
                }
            }
            Console.ReadKey();
        }
    }
}
