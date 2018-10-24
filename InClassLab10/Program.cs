using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0; //using for the counter
            bool repeat = true;  //using to loop the code
            while (repeat == true)
            {
                Console.WriteLine("Please enter the radius of a circle!");
                double UserInput = double.Parse(Console.ReadLine());
                Circle myCicle = new Circle(UserInput); //called circle class and named this string "myCircle"

                Console.WriteLine($"Circumference: {myCicle.CalculateCircumference()}"); //used the $ to replace the {0} placement holder
                Console.WriteLine($"Circumference Formatted! {myCicle.CaclculateFormattedCircumference()}"); //see Circle Class for steps

                Console.WriteLine($"Area: {myCicle.CalculateArea()}");
                Console.WriteLine($"Area formatted! {myCicle.CalculateFormattedArea()}"); //see circle Class for steps
                c++;
                Console.ReadLine();
                while (true) //used bool for breaking out of the continue loop
                {
                    Console.WriteLine("Would you like to continue? (Y/N)");
                    string again = Console.ReadLine().ToLower();
                    if (again == "y")
                    {
                        repeat = true;
                        break;
                    }
                    if (again == "n")
                    {
                        repeat = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose Y/N"); //using incase user does not use y or n
                        continue;
                    }
                }
                Console.WriteLine($"You ran this program { c }");

            }
        }
    }
}
