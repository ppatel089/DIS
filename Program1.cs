using System;

namespace Iteration_Statements
{
	class Program1
	{
		static void Main(string[] args)
		{
			// Ask the user for input
			Console.Write("How many years experience do you have in professional programming? ");
			/*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
			try
			{
				// This variable will gather data from user input
				string input = Console.ReadLine();
				// This variable will be used to perform the various iterative statements and is parsed as an integer
				int exp = int.Parse(input);
				
				// If the value of user input is between 1 and 100, execute a For Loop
				if ((exp > 0) && (exp <= 100))
				{
					Console.WriteLine("You have " +  exp.ToString() + "years of experience.");
					Console.WriteLine("The For Loop will iterate " + exp.ToString() + " times.");
					// Here is the For Loop
					for (int i = 0; i < exp; i++)
					{
						Console.WriteLine("You have " + (i+1).ToString() + "years of experience.");
					}
					Console.WriteLine("Press any key to exit the program ...");
					// Pause the program and await the user to press a key to end the program
					Console.ReadKey(true);
				}
				
			} // End of try
			catch
			{
				Console.WriteLine("Please enter an integer value and try running the program again ...");
				Console.WriteLine("Press any key to exit the program ...");
				Console.ReadKey(true);
			} // End of catch
		} // End of Main
	} // End of class
} // End of namespace