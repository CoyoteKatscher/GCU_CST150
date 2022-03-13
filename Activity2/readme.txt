Brian Potter
03/13/2022
CST-150 Activity 2

Activity 2 Rubric Requirements
#1: Write a program that gathers input data from a text box control.
Created a text box called weightEntryTextBox with a label of "Enter your weight on Earth"
weightEntryTextBox holds the entry from the user as a String

#2: Declare and Initialize Primitive Variables.
I determined the need of 2 double type variables: enteredWeight and marsWeight
I determined there is a need for a conversion constant double variable: MARS_WEIGHT_CONVERSION
Initilization of enteredWeight and marsWeight occurs when processing input and doing calculations
Two primitive type conversions needed to occur:
Input received from user is stored as a String value so the entered value of weightEntryTextBox needed to be parsed out into a double using double.Parse()for calculations.
Output to marsWeightTextBox is expecting a string value so the double value of marsWeight needed to be converted to a String using ToString() for proper display

#3: Formulate mathematical expressions to solve problems.
I used the parsed entered value (enteredWeight) and multiplied it with the value defined in the constant MARS_WEIGHT_CONVERSION to end up with the Earth to Mars weight calculated value (marsWeight)

#4: Use the .NET environment to develop a simple graphical user interface using built-in tools.
Form was created that has a text box for the user to enter their weight, and a text box that displays the users weight on Mars that is calculated when the user clicks the Convert button.
An Exit button was added to allow the user to exit out of the program. Clicking the Exit button calls the Close() function


