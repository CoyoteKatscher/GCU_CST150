Brian Potter
04/10/2022
CST-150 Activity 10

Activity 10 Rubric Requirements

#1: Utilize a variety of debugging techniques to locate and correct errors
Using breakpoints, Step Into and Step Over techniques I was able to locate and fix three errors.
Error #1: containsElement method. returning a value of false in the if/else statement was causing the for loop to terminate premmaturely.
Error #2: union method. Method was returning "rhs" which was the value of Set B that was passed into the method. Changing the returning
value to "this" was returning the correct union value.
Error #3: union method. Using "this" was referencing Set A which was passed into the method due to the Set A object making the method call.
Since "this" was being modified to hold the union value it was modifying the intitial values in Set A. Creating a whole new union method
corrected Errors #2 and #3.
