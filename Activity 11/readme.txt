Brian Potter
04/10/2022
CST-150 Activity 11

Activity 11 Rubric Requirements

#1: Implement a class.
Created the Dice class. 
Constructor sets the private variable that sets the sides of the die between 4 and 20 sides.
rollDie() method is used to simulate a die roll. Random number generated between 1 and number of sides on the die to determine value of roll.

#2: Instantiate class objects as part of a solution to a problem.
Within the main program I create 2 dice objects. A random number between 4 and 20 is generated to determine how many sides the dice have. 
The same number of sides is passed to the class constructor to create a two equal die.
rollDie() is called to roll each die.
A while loop is used to allow the program to continuously roll the dice until each die rolls a 1 in that roll (snake eyes). Once each die
rolls a 1 in a roll the loop terminates and displays the final values of how many rolls it took to reach snake eyes. Additionally the 
number of sides are displayed.
