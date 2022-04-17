// Brian Potter
// CST-150
// 04/16/2022
// Primary souce used is assigned textbook
// Additional source for converting contents of file into a string:
// Read text file [C#]. C# Examples. (n.d.). Retrieved April 16, 2022, from https://www.csharp-examples.net/read-text-file/ 
// The code is of my own work

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Activity_12
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter outputFile;
            string fileContents;
            int count = 0;
            
            // Create text file to be processed by program
            outputFile = File.CreateText("Activity12.txt");
            outputFile.WriteLine("Don't be late, teatime will not wait!");
            outputFile.Close();
                        
            try
            {
                // Read entire contents of text file into a string variable
                fileContents = File.ReadAllText("Activity12.txt");

                // Search the contents of the string letter by letter 
                for (int i = 0; i < fileContents.Length; i++)
                {
                    // First check - if punctuation is found check the letter prior to the punctuation
                    if (char.IsPunctuation(fileContents[i]))
                        if (fileContents[i - 1] == 'e' ||
                            fileContents[i - 1] == 'E' ||
                            fileContents[i - 1] == 't' ||
                            fileContents[i - 1] == 'T')
                                 count++;
                    
                    // Second check - if whitespace is found check the letter prior to the whitespace
                    // if the letter prior is a letter then check to see if it matches the criteria for counter increment
                    if (char.IsWhiteSpace(fileContents[i]))
                    {
                        if (char.IsLetter(fileContents[i - 1]))
                            if (fileContents[i - 1] == 'e' ||
                                fileContents[i - 1] == 'E' ||
                                fileContents[i - 1] == 't' ||
                                fileContents[i - 1] == 'T')
                                     count++;
                    }
                }
                // Display final result of number of words located matching criteria
                Console.WriteLine("There are " + count + " words that end in t or e");
                Console.ReadKey(); // Wait for any key before closing program
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}