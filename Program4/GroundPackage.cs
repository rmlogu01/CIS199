//GroundPackage class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class GroundPackage
    {
        private const int LOUISVILLE_ZIP = 40202; //Named constant for the Louisville Zip
        private const int BEVERLY_HILLS_ZIP = 90210; //Named constant for the Beverly Hills Zip
        private const double DEFAULT_SIZE = 1.0; //Named constant for the default size for the size properties
        private const int ZIP_SIMPLIFIER = 10000; //Needed to simplify the zip codes 
        private const double SIZE_MULTIPLIER = 0.2; //Helps determine the cost based off the size properties
        private const double DISTANCE_MULTIPLIER = 0.5; //Helps determine the costr based off the zip properties

        //Backing fields
        private int _originZip; //The origin zip property (0<=Zip>=99999)
        private int _destZip; //The destination zip property (0<=Zip>=99999)
        private double _length; //The length property (>0)
        private double _width; //The width property (>0)
        private double _height;//The height property (>0)
        private double _weight;//The weight property (>0)

        //Constructor
        //Precondition: All of the inputs are valid
        //Postcondition:A package has been constructed with specific properties
        public GroundPackage(int origin, int dest, double theLength, double theWidth, double theHeight, double theWeight)
        {
            OriginZip = origin;
            DestinationZip = dest;
            Length = theLength;
            Width = theWidth;
            Height = theHeight;
            Weight = theWeight;
        }

        //origin zip property
        public int OriginZip
        {
            //Precondition: None
            //Postcondition: origin zip is returned
            get
            {
                return _originZip;
            }
            //Precondtion: The origin zip is >0 or <=99999
            //Postcondition: origin zip is either changed to the new value or is set to Louisville's zip code
            set
            {
                if (value>=0 || value<=99999)
                {
                    _originZip = value;
                }
                else//if invalid
                {
                    _originZip = LOUISVILLE_ZIP;
                }
            }
        }
        //destination property
        public int DestinationZip
        {
            //Precondition: None
            //Postcondition: destination zip is returned
            get
            {
                return _destZip;
            }
            //Precondition: value >=0 or value <=99999
            //Postcondition: destination is set to value or to 90210
            set
            {
                if (value >= 0 || value <= 99999)
                {
                    _destZip = value;
                }
                else
                {
                    _destZip = BEVERLY_HILLS_ZIP;//if invalid
                }
            }
        }
        //length property
        public double Length
        {
            //Precondition: None
            //Postcondition: Length is returned
            get
            {
                return _length;
            }
            //Precondtion: value is >0
            //Postcondition: length is set to value or default size
            set
            {
                if(value >0)
                {
                    _length = value;
                }
                else
                {
                    _length = DEFAULT_SIZE;// if invalid
                }
            }
        }
        //width property
        public double Width
        {
            //Precondition: None
            //Postcondition: Width is returned
            get
            {
                return _width;
            }
            //Precondtion: value is >0
            //Postcondition: width is set to value or default size
            set
            {
                if(value >0)
                {
                    _width = value;
                }
                else
                {
                    _width = DEFAULT_SIZE; //if invalid
                }
            }
        }
        //height property
        public double Height
        {
            //Precondition: None
            //Postcondition: Height is returned
            get
            {
                return _height;
            }
            //Precondtion: value is >0
            //Postcondition: height is set to value or default size
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = DEFAULT_SIZE;//if invalid
                }
            }
        }
        //weight propery
        public double Weight
        {
            //Precondition: None
            //Postcondition: Weight is returned
            get
            {
                return _weight;
            }
            //Precondtion: value is >0
            //Postcondition: weight is set to value or default size
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    _weight = DEFAULT_SIZE;//if invalid
                }
            }
        }
        //zone distance property
        public int ZoneDistance
        {
            //Precondition: OriginZip and DestinationZip have values
            //Postcondition: A value for calculating the cost based off of zip code is returned
            get
            {
                return Math.Abs((OriginZip / ZIP_SIMPLIFIER) - (DestinationZip / ZIP_SIMPLIFIER));//divides both zip codes by 10000
                                                                                                //then takes the absoulte value
            }
        }
        //Calculates the cost method
        //Precondition: All properties have valid input
        //Postcondition: The cost of the package is returned
        public double CalcCost()
        {
            double Cost = SIZE_MULTIPLIER * (Length + Width + Height) + DISTANCE_MULTIPLIER * (ZoneDistance + 1) * Weight;
            //Equation for finding the cost of shipping a package
            return Cost;
        }
        //ToString Method
        //Precondition: All the value calculated are valid and all properties have values
        //Postcondition: A messagebox is displayed with all of the values formatted
        public override string ToString()
        {
            return "Origin ZIP: " + OriginZip.ToString("D5") + Environment.NewLine + "Destination ZIP: " + DestinationZip.ToString("D5") + Environment.NewLine
                + "Length: " + Length + Environment.NewLine + "Width: " + Width + Environment.NewLine + "Height: " + Height +
                Environment.NewLine + "Weight: " + Weight;
        }
    }
}
