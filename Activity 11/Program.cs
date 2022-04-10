// Brian Potter
// CST-150
// 04/10/2022
// Primary souce used to understand the concepts for completing the assignment:
// Doyle, B. (2011). In C♯ Programming: From problem analysis to program design, Course Technology, Cengage Learning. 
// The code is of my own work

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity_11
{
    class Dice
    {
        private int sidesOfDie;

        // Constructor. Sets the sides of the die 
        public Dice(int sides)
        {
            sidesOfDie = sides;
        }

        // rollDie: "Rolls" the die. Use random number between 1 and total number of sides of die. Return "die roll" value
        public int rollDie()
        {
            Random random = new Random();
            int roll;

            roll = random.Next(1,sidesOfDie);
            return roll;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Dice die1;
            Dice die2;
            int sides;
            int die1Roll;
            int die2Roll;
            int numOfRolls = 1;
            bool snakeEyes = false;

            // Use random number generator to set number of sides (between 4 and 20) the dice have
            sides = rand.Next(4, 20);

            // Create the die object and set the number of sides the die has. Both die have the same value for sides
            die1 = new Dice(sides);
            die2 = new Dice(sides);
                        
            // Roll the dice until Snake Eyes (Both die have a rolled value of 1)
            while (snakeEyes == false)
            {
                die1Roll = die1.rollDie();
                die2Roll = die2.rollDie();

                // Display result of roll
                Console.WriteLine("Roll # " + numOfRolls);
                Console.WriteLine("Die 1 Rolled: " + die1Roll);
                Console.WriteLine("Die 2 Rolled: " + die2Roll + "\n");

                // Check for snake eyes. If true terminate loop. If false increment number of rolls counter
                if (die1Roll == 1 && die2Roll == 1)
                    snakeEyes = true;
                else
                    numOfRolls++;
            }

            // Display final results
            Console.WriteLine("You rolled Snake Eyes!");
            Console.WriteLine("It took " + numOfRolls + " rolls to get snake eyes.");
            Console.WriteLine("There were " + sides + " sides to each die.");
        }
    }
}
