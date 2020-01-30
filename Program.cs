/*
Author: Nick Zaccaro
Date: 1/28/2020
Description: Program that demonstrates the use of iteration statements by asking the user
             for an integer and responding with the number of times entered.
 */
using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displays to user to enter an integer value
            Console.WriteLine("Please enter an integer value between 1 and 100: ");

            //try and catch statement to catch any incorrect data values for user input
            try
            {
                //Reads user input and converts it to a string
                string input = Console.ReadLine();

                //converts user input to an integer
                int value = int.Parse(input);

                //creates integer variable for while loop statement
                int count = 1;
                
                //check if value is between parameters
                if ((value >= 1) && (value <= 100))
                {
                    while (count <= value)
                    {
                        //Displays entered user value and current integer value in loop
                        Console.WriteLine("You have entered " + value.ToString() + ". " + "This is the current integer value in the loop: " + count.ToString());

                        //increase loop count
                        count++;
                    }
                }

                else
                {
                    Console.WriteLine("You have entered an integer not within the parameters:(");
                    Console.WriteLine("Please enter an integer between 1 and 100");
                    Console.WriteLine("To try again, exit the program by pressing any key!");
                }
            }
            catch
            {
                /* Displays the user with an error message stating that the user entered an incorrect 
                 * data type, to enter an integer, and to exit the program and try again
                */
                Console.WriteLine("You have entered an incorrect data type :(");
                Console.WriteLine("Please enter an integer between 1 and 100");
                Console.WriteLine("To try again, exit the program by pressing any key!");
                
                //Reads for the user to press any key
                Console.ReadKey(true);
            }
        }
    }
}
