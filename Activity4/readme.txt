Brian Potter
03/19/2022
CST-150 Activity 4

Activity 4 Rubric Requirements

#1: Create logical expressions using relational and logical operators.
I used if/else statements to compare the user input value of seconds to determine proper message box display. 
If converted value (input value / 60) greater than or equal to 60 (1 minute) but less than 3600 (60 minutes/1 hour) would display the converted value in minutes.
Else/If converted value (input value / 60) greater than or equal to 3600 (1 hours) but less than 86400 (24 hours/1 day) would display the converted value in hours.
Else/If converted value (input value / 60) greater than or equal to 86400 (1 day) would display the converted value in days.
Else input value is less than 60 therefore no conversion is necessary and the number of seconds is displayed.

#2: Write Selection Structures and Nested Selection Structures.
I used two sets of if/else selection structures.
First if/else was used for error checking. Using TryParse() I first tested to make sure the user inputed a valid integer value. If the value was valid then the second set of if/else selection structures were executed. If the value was invalid then the else portion of the first selection structure will display an error message to the user.

Second if/else was a nested selection structure stepping through the if/else statements that are explained in question #1 above.

#3: Use TryParse methods to prevent data conversion exceptions.
After the user clicks the convert button, the program reads the user's input and then executes int.TryParse() within an if/else statement. 
int.TryParse(userInputTextBox.Text, out seconds) is the command executed. If TryParse is successful in converting the user input from userInputTextBox into an integer value the value gets stored as an integer in the variable seconds. If TryParse is unsuccessful then the exception is thrown and due to the try-catch process the user is displayed an error message instead of the program breaking.

#4: Use the .NET environment to develop a simple graphical user interface using built-in tools.
I used the form designer to prompt the user for input which is then stored in userInputTextBox. 
There are three buttons for the user to click:
Convert - When clicked the code is executed to take the input value and display the results in a message box based on the if and if/else statements from question #2
Clear - When clicked the code is executed to clear the value entered by the user in userInputTextBox and display an empty string value instead making it appear the value in the box was cleared.
Exit - When clicked the code is executed to close the application.

