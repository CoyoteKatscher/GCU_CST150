/* Brian Potter
   CST-150
   03/27/2022
   The textbook and instruction for this assignment was severly lacking. I had to use the following sources to complete the assignment:
   Convert to lowercase: C#: Tolower() method. GeeksforGeeks. (2019, January 31). Retrieved March 27, 2022, from https://www.geeksforgeeks.org/c-sharp-tolower-method/ 
   Determine length of string: C#: String properties. GeeksforGeeks. (2019, January 23). Retrieved March 27, 2022, from https://www.geeksforgeeks.org/c-sharp-string-properties/ 
   Determine number of vowels in a word: C# count vowels. Stack Overflow. (1961, June 1). Retrieved March 27, 2022, from https://stackoverflow.com/questions/18109890/c-sharp-count-vowels 
   The rest of the code is my own work
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity5
{
    public partial class Activity5 : Form
    {
        public Activity5()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = null;
            StreamWriter outputFile;
            bool fileOpened = false;
            string fileInputData; //input stream
            string lowerCaseValue; //input stream converted to lower case
            string highestWordValue = "a"; 
            string lowestWordValue = "z"; 
            string longestWord = ""; 
            int numOfVowels = 0;
            int mostVowelsCount = 0;
            string mostVowels = "";


            if (openFileDialogBox.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialogBox.FileName);
                fileOpened = true;
            }
            else
                MessageBox.Show("Open File Request Cancelled");

            try
            {
                while (fileOpened && inputFile.EndOfStream == false)
                {
                    fileInputData = inputFile.ReadLine();
                    // Convert to lower case
                    lowerCaseValue = fileInputData.ToLower();
                                       
                    // Find first word alphabetically
                    if (String.Compare(lowestWordValue, lowerCaseValue) > 0)
                        lowestWordValue = lowerCaseValue;
                    
                    // Find last word alphabetically
                    if (String.Compare(highestWordValue, lowerCaseValue) < 0)
                        highestWordValue = lowerCaseValue;
                    
                    // Find longest word                  
                    if (lowerCaseValue.Length > longestWord.Length)
                        longestWord = lowerCaseValue;

                    // Find most vowels
                    // For loop to check each character of the word
                    for (int i = 0;i < lowerCaseValue.Length; i++)
                    {
                        // Check to see if character in position i is a vowel. If True, increment total vowel count
                        if (lowerCaseValue[i] == 'a' || lowerCaseValue[i] == 'e' || lowerCaseValue[i] == 'i' || lowerCaseValue[i] == 'u')
                            numOfVowels++;
                    }

                    // Compare currently stored value of mostVowels to current, If true make current word and vowel count the new mostVowels values
                    if (numOfVowels > mostVowelsCount)
                    {
                        mostVowelsCount = numOfVowels;
                        mostVowels = lowerCaseValue;
                    }
                    // Reset numOfVowels counter for next word
                    numOfVowels = 0;
                }
                // File successfully opened -
                // close input file, display results & write results to output file
                if (fileOpened)
                {
                    inputFile.Close();
                    firstWordTextBox.Text = lowestWordValue;
                    lastWordTextBox.Text = highestWordValue;
                    longestWordTextBox.Text = longestWord;
                    mostVowelsTextBox.Text = mostVowels;

                    outputFile = File.CreateText("Test_Data_Output.txt");
                    outputFile.WriteLine("First Word Alphabetically: " + lowestWordValue);
                    outputFile.WriteLine("Last Word Alphabetically: " + highestWordValue);
                    outputFile.WriteLine("Longest Word: " + longestWord);
                    outputFile.WriteLine("Word With Most Vowels: " + mostVowels);
                    outputFile.Close();
                    
                }
                // No file opened -
                // display all results as an empty string
                else
                {
                    firstWordTextBox.Text = "";
                    lastWordTextBox.Text = "";
                    longestWordTextBox.Text = "";
                    mostVowelsTextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
