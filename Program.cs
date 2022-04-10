// Brian Potter
// CST-150
// 04/10/2022
// Primary souce used to understand the concepts for completing the assignment:
// Doyle, B. (2011). Chapter 5 Making Decisions. In C♯ Programming: From problem analysis to program design,
// Course Technology, Cengage Learning. 
// The code is of my own work

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity_9
{
    class Measurements
    {
        // Method 1: Two integers are passed into the method and the sum of the two numbers are displayed
        public void DisplaySum(int value1, int value2)
        {
            Console.WriteLine("Sum of the values: " + (value1 + value2));
        }

        // Method 2: Five double values are passed into the method and the average is returned
        public double ReturnAverage(double value1, double value2, double value3, double value4, double value5)
        {
            return ((value1 + value2 + value3 + value4 + value5) / 5);            
        }

        // Method 3: Two integers are passed into the method and the sum of the two numbers are returned
        public int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        // Method 4: Three integers are passed into the method. The integers are added and then the program determines
        // if the sum is divisible by 3. If yes, method returns true. If no, method returns false.
        public bool DivByThree(int value1, int value2, int value3)
        {
            int totalValue;

            totalValue = value1 + value2 + value3;

            if ((totalValue % 3) == 0)
                return true;
            else
                return false;
        }

        // Method 5: Two strings are passed into the method. The lengths of the two strings are compared against each other
        // String with lowest length is displayed
        public void DisplaySmallerString (string str1, string str2)
        {
            // Compare str1 and str2. Display the string with fewer values
            if (str1.Length > str2.Length)
                Console.WriteLine(str2 + " is the smallest string");
            else
                Console.WriteLine(str1 + " is the smallest string");
        }

        // Method 6: An array of doubles are passed into the method. The method steps through the entire array and compares each
        // value of the array to the current largest number. If the value in the current index location is greater than prior values
        // it becomes the new largest value. Once all elements of the array are compared the method returns the largest value
        public double ReturnLargestValue (List<double> value)
        {
            double largestVal=0;

            for (int i = 0; i < value.Count; i++)
            {
                if (largestVal < value[i])
                    largestVal = value[i];
            }
            return largestVal;        
        }

        // Method 7: Nothing is passed to the method. The method creates a new array of integers and random class value.
        // The metod goes through a 50 count loop and for each iteration a new randon integer value that is < 500 is added to the array.
        // The entire array is returned
        public List<int> GenerateFiftyInts()
        {
            List<int> value = new List<int>();
            Random rand = new Random();
            
            for (int i=0; i < 50; i++)
            {
                value.Add(rand.Next(500));
            }

            return value;
        }

        // Method 8: Two boolean values are passed to the method. The values of the boolean values are compared. If the values are equal
        // the method returns true. If they are not equal the method returns false
        public bool CompareBooleans (bool value1, bool value2)
        {
            if (value1 == value2)
                return true;
            else
                return false;
        }

        // Method 9: An integer value and double value are passed to the method. The two values are multiplied together and the method
        // returns the product of the values.
        public double MultiplyValues (int value1, double value2)
        {
            return value1 * value2;
        }

        // Method 10: A two-dimensional array of integers is passed to the method. The method steps through each row and column of the array
        // and computes the sum of all values in the array. The method computes and returns the average of the values in the array
        public double AverageIntArray (int[,] value)
        {
            int sum = 0;
            
            for (int row = 0; row < value.GetLength(0); row++)
            {
                for (int col = 0; col < value.GetLength(1); col++)
                    sum += value[row, col];
            }

            return (sum / value.GetLength(0));
        }        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Measurements someAction = new Measurements();
            Random rand = new Random();

            // Variables to use for testing the different method calls
            double method2Result;
            int method3Result;
            bool method4Result;
            string method5Str1 = "This is a small string";
            string method5Str2 = "This is a string that is quite a bit longer";
            List<double> listVal = new List<double> ();
            double method6Result;
            List<int> method7Result = new List<int>();
            bool method8Bool1 = false;
            bool method8Bool2 = false;
            bool method8Result;
            double method9Result;
            int[,] method10ArrayValues = { { 1, 22 }, { 25, 89 }, { 192, 79 }, { 841, 9732 } };
            double method10Result;

            // Method 1 test
            Console.WriteLine("Method 1: Write a method that takes two integers and displays their sum.");
            someAction.DisplaySum(5, 18);
            Console.WriteLine();

            // Method 2 test
            Console.WriteLine("Method 2: Write a method that takes five doubles and returns their average.");
            method2Result = someAction.ReturnAverage(rand.NextDouble(), rand.NextDouble(), rand.NextDouble(), rand.NextDouble(), rand.NextDouble());
            Console.WriteLine("Method 2 result - average of five random doubles are: " + method2Result + "\n");

            // Method 3 test
            Console.WriteLine("Method 3: Write a method that returns the sum of two randomly generated integers.");
            method3Result = someAction.Sum(rand.Next(100), rand.Next(100));
            Console.WriteLine("Method 3 result - sum of two random integers is: " + method3Result + "\n");

            // Method 4 test
            Console.WriteLine("Method 4: Write a method that takes three integers and returns true if their sum is divisible by 3, false otherwise.");
            method4Result = someAction.DivByThree(rand.Next(200), rand.Next(200), rand.Next(200));
            Console.WriteLine("Method 4 result " + method4Result + "\n");

            // Method 5 test
            Console.WriteLine("Method 5: Write a method that takes two strings and displays the string that has fewer characters");
            someAction.DisplaySmallerString(method5Str1, method5Str2);
            Console.WriteLine();

            // Method 6 test
            Console.WriteLine("Method 6: Write a method that takes an array of doubles and returns the largest value in the array.");
            for (int i = 0; i < 20; i++)
            {
                listVal.Add(rand.NextDouble());
            }
            method6Result = someAction.ReturnLargestValue(listVal);
            Console.WriteLine("Method 6 result - largest value from 20 random values is " + method6Result + "\n");

            // Method 7 test
            Console.WriteLine("Method 7: Write a method that generates and returns an array of fifty integer values.");
            method7Result = someAction.GenerateFiftyInts();
            Console.WriteLine("Method 7 result:");
            for (int i = 0;i < method7Result.Count; i++)
            {
                Console.Write(method7Result[i] + " ");                
            }
            Console.WriteLine();

            // Method 8 test
            Console.WriteLine("Method 8: Write a method that takes two bool values and returns true if they have the same value, false otherwise.");
            method8Result = someAction.CompareBooleans(method8Bool1, method8Bool2);
            Console.WriteLine("Method 8 result: " + method8Result + "\n");

            // Method 9 test
            Console.WriteLine("Method 9: Write a method that takes an int and a double and returns their product");
            method9Result = someAction.MultiplyValues(rand.Next(500), rand.NextDouble());
            Console.WriteLine("Method 9 result: " + method9Result + "\n");

            // Method 10 test
            Console.WriteLine("Method 10: Write a method that takes a two-dimensional array of integers and returns the average of the entries.");
            method10Result = someAction.AverageIntArray(method10ArrayValues);
            Console.WriteLine("Method 10 result: " + method10Result + "\n");
        }
    }
}