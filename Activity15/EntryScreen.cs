// Brian Potter
// CST-150
// 04/23/2022
// Primary souce used for project understanding is assigned textbook
// Astrological Sign Chart source for determineSign method:
// Welcome to Astrology.com. Tarot, Zodiac, Astrology &amp; Horoscopes | Astrology.com. (n.d.). Retrieved April 23, 2022, from https://www.astrology.com/us/home.aspx 
// The code is of my own work

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15
{
    public partial class EntryScreen : Form
    {
        public EntryScreen()
        {
            InitializeComponent();
        }

        private void luckyButton_Click(object sender, EventArgs e)
        {
            string birthMonth = " ";
            int birthMonthInt;
            int sign;
            LuckyNumber luckyNumberResult = new LuckyNumber();
            int luckyNumberCalc;

            // Get birth month string value from main form and
            // convert to integer value for lucky number calculation
            birthMonth = monthListBox.SelectedItem.ToString();
            birthMonthInt = determineMonth(birthMonth);

            // Get the numeric string value from the birth day and favorite number pick lists
            // Convert from string to int using TryParse for lucky number calculation
            int.TryParse(dayListBox.SelectedItem.ToString(), out int birthDay);
            int.TryParse(numPickListBox.SelectedItem.ToString(), out int numPick);  

            // Get the numberic value assigned to the astrological sign
            // Method will display the sign name in the Entry Screen form
            sign = determineSign(birthMonthInt, birthDay);

            // Get the lucky number based on user input
            luckyNumberCalc = determineLuckyNum(birthMonthInt, birthDay, numPick, sign);

            // Send the lucky number to the Lucky Number form to be displayed to the user
            luckyNumberResult.generatedLuckyNumber.Text = luckyNumberCalc.ToString();
            luckyNumberResult.ShowDialog();
        }

        private int determineMonth (string month)
        {
            // Convert month name to numeric value for lucky number calculations
            switch (month)
            {
                case "January":
                    return 1;
                case "February":
                    return 2;
                case "March":
                    return 3;
                case "April":
                    return 4;
                case "May":
                    return 5;
                case "June":
                    return 6;
                case "July":
                    return 7;
                case "August":
                    return 8;
                case "September":
                    return 9;
                case "October":
                    return 10;
                case "November":
                    return 11;
                default:
                    return 12;            
            }            
        }

        private int determineSign (int month, int day)
        {
            // Based on astological chart -
            // Determine astrological sign name and display in the main form
            // Assign a numeric value to each astrological sign for lucky number calculation
            switch (month)
            {
                case 1: 
                    if (day >= 20)
                    {
                        // Dec 22 - Jan 19
                        signResultLabel.Text = "Aquarius";
                        return 2;
                    }
                    else
                    {
                        // Jan 20 - Feb 18
                        signResultLabel.Text = "Capricorn";
                        return 1;
                    }

                case 2:
                    if (day >= 19)
                    {
                        // Feb 19 - Mar 20
                        signResultLabel.Text = "Pisces";
                        return 3;
                    }
                    else
                    {
                        // Jan 20 - Feb 18
                        signResultLabel.Text = "Aquarius";
                        return 2;
                    }
                    
                case 3:
                    if (day >= 21)
                    {
                        // Mar 21 - Apr 19
                        signResultLabel.Text = "Aries";
                        return 4;
                    }
                    else
                    {
                        // Feb 19 - Mar 20
                        signResultLabel.Text = "Pisces";
                        return 3;
                    }
                    
                case 4:
                    if (day >= 20)
                    {
                        // Apr 20 - May 20
                        signResultLabel.Text = "Taurus";
                        return 5;
                    }
                    else
                    {
                        // Mar 21 - Apr 19
                        signResultLabel.Text = "Aries";
                        return 4;
                    }

                case 5:
                    if (day >= 21)
                    {
                        // May 21 - Jun 20
                        signResultLabel.Text = "Gemini";
                        return 6;
                    }
                    else
                    {
                        // Apr 20 - May 20
                        signResultLabel.Text = "Taurus";
                        return 5;
                    }
                    
                case 6:
                    if (day >= 21)
                    {
                        // Jun 21 - Jul 22
                        signResultLabel.Text = "Cancer";
                        return 7;
                    }
                    else
                    {
                        // May 21 - Jun 20
                        signResultLabel.Text = "Gemini";
                        return 6;
                    }

                case 7:
                    if (day >= 23)
                    {
                        // Jul 23 - Aug 22
                        signResultLabel.Text = "Leo";
                        return 8;
                    }
                    else
                    {
                        // Jun 21 - Jul 22
                        signResultLabel.Text = "Cancer";
                        return 7;
                    }

                case 8:
                    if (day >= 23)
                    {
                        // Aug 23 - Sep 22
                        signResultLabel.Text = "Virgo";
                        return 9;
                    }
                    else
                    {
                        // Jul 23 - Aug 22
                        signResultLabel.Text = "Leo";
                        return 8;
                    }

                case 9:
                    if (day >= 23)
                    {
                        // Sep 23 - Oct 22
                        signResultLabel.Text = "Libra";
                        return 10;
                    }
                    else
                    {
                        // Aug 23 - Sep 22
                        signResultLabel.Text = "Virgo";
                        return 9;
                    }

                case 10:
                    if (day >= 23)
                    {
                        // Oct 23 - Nov 21
                        signResultLabel.Text = "Scorpio";
                        return 11;
                    }
                    else
                    {
                        // Sep 23 - Oct 22
                        signResultLabel.Text = "Libra";
                        return 10;
                    }

                default: // Nov 22 - Dec 21
                    signResultLabel.Text = "Sagittarius";
                    return 12;
            }            
        }

        private int determineLuckyNum(int month, int day, int num, int sign)
        {
            // Made up a math equation to determine a lucky number result
            // Added random number generator to add to the entertainment value

            Random rand = new Random();
            
            return (((month + day) * rand.Next(50)) / ((sign * num) % rand.Next(100)));            
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
