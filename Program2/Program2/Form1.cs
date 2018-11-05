//Grading ID: C7973
//Lab 5
//Due Date: 4/9/17
//CIS199-75
//Allows the user to enter their last name and grade then tells them their registration time and date.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class program2 : Form
    {
        public program2()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)              //results from clicking the calculate button
        {
            string lastName = enterNameTB.Text;                                     //turns the input from the textbox into a string

            if ((enterNameTB.Text.Length > 0)&&(char.IsLetter(lastName,0)))         //checks if there is an input in the textbox and if the input is letters
            {
                char firstLetter = char.ToLower(lastName[0]);                       //turns the string into a char variable of just the first letter
                    if ((seniorRadioButton.Checked) || (juniorRadioButton.Checked)) //checks if the senior or junior button is clicked
                    {
                        if (seniorRadioButton.Checked)
                        {
                            resultsDateLabel.Text = "March 29";                     //sets the date label to March 29 if the senior button is clicked
                        }
                        else
                        {
                            resultsDateLabel.Text = "March 30";                     //sets the date label to March 30 if the  junior button is clicked
                        }
                        if (firstLetter <= 'd')                                     //if the value of first letter is less than d then it displatys 11:30
                        {
                            resultsTimeLabel.Text = "11:30";
                        }
                        else if (firstLetter <= 'i')                                //if the value of first letter is less than i then it displatys 2:00
                        {
                            resultsTimeLabel.Text = "2:00";
                        }
                        else if (firstLetter <= 'o')                                //if the value of first letter is less than 0 then it displatys 4:00
                        {
                            resultsTimeLabel.Text = "4:00";
                        }
                        else if (firstLetter <= 's')                                //if the value of first letter is less than s then it displatys 8:30
                        {
                            resultsTimeLabel.Text = "8:30";
                        }
                        else
                        {
                            resultsTimeLabel.Text = "10:00";                        //Any other value it displays 10:00
                        }
                    }
                    else
                    {
                        if (sophomoreRadioButton.Checked)                           //checks if the sophomore button is clicked
                        {
                            if (firstLetter <= 'b' || firstLetter > 'o')            //sets the date label to March 31 if the first letter is within the range
                            {
                                resultsDateLabel.Text = "March 31";
                            }
                            else
                            {
                                resultsDateLabel.Text = "April 3";                  //if the first letter is not in the range it sets the  date to April 3
                            }

                        }

                        else if (freshmanRadioButton.Checked)                       //checks if the freshman button is clicked
                        {
                            if (firstLetter <= 'b' || firstLetter > 'o')            //sets the date label to April 4 if the first letter is within the range
                            {
                                resultsDateLabel.Text = "April 4";
                            }
                            else
                            {
                                resultsDateLabel.Text = "April 5";                  //if the first letter is not in the range it sets the  date to April 5
                            }

                        }
                        if (firstLetter <= 'b')                                     //if the value of first letter is less than b then it displatys 4:00
                        {
                            resultsTimeLabel.Text = "4:00";
                        }
                        else if (firstLetter <= 'd')                                //if the value of first letter is less than d then it displatys 8:30
                        {
                            resultsTimeLabel.Text = "8:30";
                        }
                        else if (firstLetter <= 'f')                                //if the value of first letter is less than f then it displatys 10:00
                        {
                            resultsTimeLabel.Text = "10:00";
                        }
                        else if (firstLetter <= 'i')                                //if the value of first letter is less than i then it displatys 11:30
                        {
                            resultsTimeLabel.Text = "11:30";
                        }
                        else if (firstLetter <= 'l')                                //if the value of first letter is less than l then it displatys 2:00
                        {
                            resultsTimeLabel.Text = "2:00";
                        }
                        else if(firstLetter <= 'o')                                 //if the value of first letter is less than o then it displatys 4:00
                        {
                            resultsTimeLabel.Text = "4:00";
                        }
                        else if (firstLetter <= 'q')                                //if the value of first letter is less than q then it displatys 8:30
                        {
                            resultsTimeLabel.Text = "8:30";
                        }
                        else if (firstLetter <= 's')                                //if the value of first letter is less than s then it displatys 10:00
                        {
                            resultsTimeLabel.Text = "10:00";
                        }
                        else if (firstLetter <= 'v')                                //if the value of first letter is less than v then it displatys 11:30
                        {
                            resultsTimeLabel.Text = "11:30";
                        }
                        else
                        {
                            resultsTimeLabel.Text = "2:00";                         //if the value of first letter is above v then it displatys 2:00
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter your last name");                        //diplays a message if the first letter isn't a letter 
                }
            }
        }
    }