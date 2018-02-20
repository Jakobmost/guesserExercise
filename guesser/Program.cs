using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        /*
         * Write a console application that keeps on asking the user to enter a string to guess a
           certain name. At any trial, if the user’s guess is wrong the system should print out a
           message like, “Sorry, wrong guess, please enter a new one:”, and a congratulation
           message if it is the correct name.
           There should be a maximum amount of tries; once the number of maximum guesses is reached, the
           program should inform the user that they have run out of trials and exit. To exit you can use the
           instruction: Environment.Exit(0);
         */
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 0;
        

        static void Main(string[] args)
        {
            /* TO DO: here is where you add your code! */
            Console.WriteLine("You have found a bomb.");
            Console.WriteLine("Defuse the bomb by guessing the right color of the wire you have to cut.");
            Console.WriteLine("You have 10 tries. Its a pretty strange bomb");
            Console.WriteLine();

            for (int i = 10; i > MaxTrials; i--)
            {
                
                string command = Console.ReadLine();
                switch (command)
                {
                    case "brown":
                    case "Brown":
                        Console.WriteLine("Jesus fucking christ you lucky bastard!");
                        Console.WriteLine("You managed to defuse the bomb!");
                        break;

                    default:
                        Console.WriteLine("No, no, no!!!! FUCK! Only " + (i-1) + " tries left!");
                        break;
                }

                if (i == 1)
                {
                    Console.WriteLine();


                    Console.WriteLine("Well. You know what happens.");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to see what happens after death.");
                }

            }
             Console.ReadLine();
        }
    }
}
