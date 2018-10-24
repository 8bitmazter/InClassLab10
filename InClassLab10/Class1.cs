using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab10
{
    class Circle //Circle class, circumference & area
    {
        private double area, radius;
        public const double PI = Math.PI;

        public double Radius //constructor 
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Circle(double radius)
        {
            this.radius = radius; //initializing the variable
        }
        public string FormatNumber(double x)
        {
            return $"{x,0:N2}";
        }
        public double CalculateCircumference()
        {
            double circumference = PI * (radius * 2); //calculate circumference equation
            return circumference;
        }
        //Allow for user input on number of decimal places
        public string CaclculateFormattedCircumference()
        {
            double formatted = Math.Round(CalculateCircumference(), 2); //using math round to format the circumference 
            return formatted.ToString(); //every object has a  .ToString  change
        }
        public double CalculateArea()
        {
            double area = PI * (radius * radius); //calculate area
            return area;
        }
        public string CalculateFormattedArea()
        {
            double formattedArea = Math.Round(CalculateArea(), 2); //using math round to format the area
            return formattedArea.ToString();
        }
    }
}
