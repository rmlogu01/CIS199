//Grading ID: 7973
//Program 1
//Due Date: 2/14/17
//CIS199-75
//A program that allows a user to enter the square feet of the wall
//to be painted, the cost of the paint, and the number of coats of
//paint. The program calculates the total square feet to be painted,
//gallons of paint needed, hours of labor, and all of the costs involved

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }
        const double GALLON_PAINT = 330;//sets the ammount a gallon of paint can paint
        const double HOURS_LABOR = 6;//sets how long it takes to paint a gallon of paint
        const double COST_LABOR = 10.50;//sets the cost of an hour of labor

        //actions done when the calculate cost button is clicked
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double squareFeetInput;//creates a variable for the square feet input
            double numCoatsInput; ;//creates a variable for the number of coats of paint input
            double pricePaintInput;//creates a variable for the price of paint input
            double numSqrFeet;//variable used for calculating total square feet painted
            double numGallonsPaint;//variable used for calculating gallons of paint needed
            double numHoursLabor;//variable used for calculating hours of labor needed
            double numCostPaint;//variable used for calculating the cost of paint needed
            double numCostLabor;//variable used for calculating the cost of labor needed
            double numTotalCost;//variable used for calculating the total cost of the project

            squareFeetInput = double.Parse(sqrFeetTB.Text);//turns the square feet input into a number
            numCoatsInput = double.Parse(numCoatsTB.Text);//turns the number of coats input into a number
            pricePaintInput = double.Parse(paintPriceTB.Text);//turns the price of paint input into a number

            numSqrFeet = squareFeetInput * numCoatsInput;//Calculates the total square feet by multiplying the number of coats by the inputed square feet
            sqrFeetCalc.Text = numSqrFeet.ToString("");//Turns the calculated number into a text string
            numGallonsPaint = numSqrFeet / GALLON_PAINT;//Calculates the number of gallons of paint by dividing the total square feet of the wall by the
                                                        //square feet of wall per gallon constant
            numGallonsPaint = Math.Ceiling(numGallonsPaint);//makes sure that the number of gallons is rounded up to fit the needs of the project
            numGallonCalc.Text = numGallonsPaint.ToString("");//Turns the calculated number into a text string
            numHoursLabor = (numSqrFeet / GALLON_PAINT) * HOURS_LABOR;//Calculates the number of hours of labor needed by dividing the total square feet of wall
                                                                      //by the hours of labor constant
            hoursLaborCalc.Text = numHoursLabor.ToString("n1");//Turns the calculated number into a text string rounded to one decimal
            numCostPaint = numGallonsPaint * pricePaintInput;//Calculates the cost of paint by multiplying the number of gallons of paint by the inputed
                                                             //cost of paint per gallon
            costPaintCalc.Text = numCostPaint.ToString("c");//Turns the calculated number into a text string as a monetary amount
            numCostLabor = numHoursLabor * COST_LABOR;//Calculates the cost of labor by multiplying number of hours of labor by the constant for labor price
            costLaborCalc.Text = numCostLabor.ToString("c");//Turns the calculated number into a text string as a monetary amount
            numTotalCost = numCostPaint + numCostLabor;//Adds the cost of paint with the cost of labor
            totalCostCalc.Text = numTotalCost.ToString("c");//Turns the calculated number into a text string as a monetary amount

        }
    }
}
