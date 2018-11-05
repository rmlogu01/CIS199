// CIS 199-75
// Due: 4/25/2017
// By: C7973
// Program 4
//Allows the user to input values for a package then returns a cost to send the package.
//Also allows the user to change the destination and origin zip to louisville
// and allows the user to see the details of the package

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class Program4 : Form
    {
        //List to hold new packages
        private List<GroundPackage> packageList = new List<GroundPackage>();

        //Precondtion: None
        //Postcondition: Form is loaded
        public Program4()
        {
            InitializeComponent();
        }
        private const int LOUISVILLE_ZIP = 40292;// constant for the louisville zip code
        //Precondtion: None
        //Postcondtion: All inputs are validated
        //              If all values are valid, return true
        //              else false 
        private bool ValidatePackageData(out int originZip, out int destZip, out double length, out double width, out double height,
            out double weight)
        {
            bool isValid = false; //holds the validation, starts as false
            //Set a value of all the outs
            originZip = 0;
            destZip = 0;
            length = 0;
            width = 0;
            height = 0;
            weight = 0;

            if(int.TryParse(originTB.Text, out originZip) && originZip >= 0)
            {
                if (int.TryParse(destTB.Text, out destZip) && destZip >= 0)
                {
                    if (double.TryParse(lengthTB.Text, out length) && length > 0)
                    {
                        if (double.TryParse(widthTB.Text, out width) && width > 0)
                        {
                            if (double.TryParse(heightTB.Text, out height) && height > 0)
                            {
                                if (double.TryParse(weightTB.Text, out weight) && weight > 0)
                                {
                                    isValid = true; //sets the validation to true
                                }
                                else
                                {
                                    MessageBox.Show("Input valid length");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Input valid height");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Input valid width");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input valid length");
                    }
                }
                else
                {
                    MessageBox.Show("Input valid destination zip");
                }
            }
            else
            {
                MessageBox.Show("Input valid origin zip");
            }
            return isValid;
        }
        //Precondition: add button is clicked
        //Postcondtion: A package is added to the package list and a price is outputed in the listbox
        private void addButton_Click(object sender, EventArgs e)
        {
            int packageOrigin;// origin zip
            int packageDest;// destination zip
            double packageLength; //length
            double packageWidth;//width
            double packageHeight;//height
            double packageWeight;//weight
            GroundPackage newPackage; //holds the inputed values of the package

            if (ValidatePackageData(out packageOrigin, out packageDest, out packageLength, out packageWidth, out packageHeight,
                out packageWeight))
            {
                newPackage = new GroundPackage(packageOrigin, packageDest, packageLength, packageWidth, packageHeight, packageWeight);
                // creates a new package
                packageList.Add(newPackage);
                // adds the package to the list
                outputListBox.Items.Add(newPackage.CalcCost().ToString("c"));
                //outputs the package cost in the listbox

                //clears all of the text boxes
                originTB.Clear();
                destTB.Clear();
                lengthTB.Clear();
                widthTB.Clear();
                heightTB.Clear();
                weightTB.Clear();

            }
        }
        //Precondition: details button is clicked and a package is selected
        //Postcondtion: Messagebox shows all of the selected package values
        private void detailsButton_Click(object sender, EventArgs e)
        {
            int index;//holds the selected package 

            index = outputListBox.SelectedIndex;// sets index to the selected package

            if (index >= 0)
            {
                MessageBox.Show(packageList[index].ToString()); //Uses the ToString method to return a formated value list
                outputListBox.SelectedIndex = -1;// returns the selected package to nothing
            }
            else
            {
                MessageBox.Show("Select a package");
            }
        }
        //Precondtion: send to UofL button is clicked
        //Postcondtion: The destination zip is changed to 40292
        private void toULButton_Click(object sender, EventArgs e)
        {
            int index;//holds the selected package 

            index = outputListBox.SelectedIndex;// sets index to the selected package

            if (index >= 0)
            {
                packageList[index].DestinationZip = LOUISVILLE_ZIP; //Sets the destination zip to 40292
                outputListBox.Items[index] = packageList[index].CalcCost().ToString("c"); //displays the new cost in the listbox
                outputListBox.SelectedIndex = -1;// returns the selected package to nothing
                MessageBox.Show("The Destination ZIP has been changed");
            }
            else
            {
                MessageBox.Show("Select a package");
            }

        }
        //Precondtion: send from UofL button is clicked
        //Postcondtion: The origin zip is changed to 40292
        private void fromULButton_Click(object sender, EventArgs e)
        {
            int index;//holds the selected package

            index = outputListBox.SelectedIndex;// sets index to the selected package

            if (index >= 0)
            {
                packageList[index].OriginZip = LOUISVILLE_ZIP;//Sets the origin zip to 40292
                outputListBox.Items[index] = packageList[index].CalcCost().ToString("c");
                outputListBox.SelectedIndex = -1;
                MessageBox.Show("The Origin ZIP has been changed");
            }
            else
            {
                MessageBox.Show("Select a package");
            }
        }
    }
}
