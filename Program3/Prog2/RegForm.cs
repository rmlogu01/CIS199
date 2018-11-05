// CIS 199-75
// Due: 4/13/2017
// By: C7973
// Program 3

// This application calculates the earliest registration date
// and time for an undergraduate student given their class standing
// and last name.
// Decisions based on UofL Fall/Summer 2017 Priority Registration Schedule

// This porgram is a modified version of program 2. 
// The decision logic of the program is changed to use sequential search
// loops makeing the program more effecient.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Program3 : Form
    {
        public Program3()
        {
            InitializeComponent();
        }
            //Precondition:Last name label has input, a level radio button 
            //has been clicked, and the find registration time button is clicked
            //Postcondition:The registration date and time are outputed
            private void findRegTimeBtn_Click(object sender, EventArgs e)
            {
                const string DAY1 = "March 29";  // 1st day of registration
                const string DAY2 = "March 30";  // 2nd day of registration
                const string DAY3 = "March 31";  // 3rd day of registration
                const string DAY4 = "April 3";   // 4th day of registration
                const string DAY5 = "April 4";   // 5th day of registration
                const string DAY6 = "April 5";   // 6th day of registration

                const string TIME1 = "8:30 AM";  // 1st time block
                const string TIME2 = "10:00 AM"; // 2nd time block
                const string TIME3 = "11:30 AM"; // 3rd time block
                const string TIME4 = "2:00 PM";  // 4th time block
                const string TIME5 = "4:00 PM";  // 5th time block

                string lastNameStr;       // Entered last name
                char lastNameLetterCh;    // First letter of last name, as char
                string dateStr = "Error"; // Holds date of registration
                string timeStr = "Error"; // Holds time of registration
                bool isUpperClass;        // Upperclass or not?

                lastNameStr = lastNameTxt.Text;
                if (lastNameStr.Length > 0) // Empty string?
                {
                    lastNameLetterCh = lastNameStr[0];   // First char of last name
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        isUpperClass = (seniorRBtn.Checked || juniorRBtn.Checked);

                        // Juniors and Seniors share same schedule but different days
                        if (isUpperClass)
                        {
                            if (seniorRBtn.Checked)
                                dateStr = DAY1;
                            else // Must be juniors
                                dateStr = DAY2;

                            //Checks if the grade level then does a sequential search loop to find the correct time
                            char[] inputCharacters = { 'A', 'E', 'J', 'P', 'T' };
                            string[] enrollmentTimes = { TIME3, TIME4, TIME5, TIME1, TIME2 };
                            bool found = false;

                            int index = inputCharacters.Length - 1; // Start from end
                                                                    // since lower limits
                            while (index >= 0 && !found)
                            {
                                if (lastNameLetterCh >= inputCharacters[index])
                                    found = true;
                                else
                                    --index;
                            }

                            if (found)
                                timeStr = enrollmentTimes[index];


                        }
                        // Sophomores and Freshmen
                        else // Must be soph/fresh
                        {
                            if (sophomoreRBtn.Checked)
                            {
                                // C-O on one day
                                if ((lastNameLetterCh >= 'C') && // >= C and
                                    (lastNameLetterCh <= 'O'))   // <= O
                                    dateStr = DAY4;
                                else // All other letters on previous day
                                    dateStr = DAY3;
                            }
                            else // must be freshman
                            {
                                // C-O on one day
                                if ((lastNameLetterCh >= 'C') && // >= C and
                                    (lastNameLetterCh <= 'O'))   // <= O
                                    dateStr = DAY6;
                                else // All other letters on previous day
                                    dateStr = DAY5;
                            }
                            //Checks if the grade level then does a sequential search loop to find the correct time
                            char[] inputCharacters = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W' };
                            string[] enrollmentTimes = { TIME5, TIME1, TIME2, TIME3, TIME4, TIME5, TIME1, TIME2, TIME3, TIME4 };
                            bool found = false;

                            int index = inputCharacters.Length - 1; // Start from end
                                                                    // since lower limits
                            while (index >= 0 && !found)
                            {
                                if (lastNameLetterCh >= inputCharacters[index])
                                    found = true;
                                else
                                    --index;
                            }

                            if (found)
                                timeStr = enrollmentTimes[index];

                        }

                        // Output results
                        dateTimeLbl.Text = dateStr + " at " + timeStr;
                    }
                    else // First char not a letter
                        MessageBox.Show("Make sure last name starts with a letter");
                }
                else // Empty textbox
                    MessageBox.Show("Enter a last name!");
            }
        }
    }
