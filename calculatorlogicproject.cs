using System;

public class program
{
	public static void Main()
	{
		Console.WriteLine("Choose your math, Press A, S, D, or M");
		string selection = Console.ReadLine();
		if(selection == "a")
		{
			Console.WriteLine("You have chosen addition, Pick a number");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Pick a second number");
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(number1+number2);
		}
		else if (selection == "s")
		{
			Console.WriteLine("You have chosen subtraction, Pick a number");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Pick a second number");
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(number1-number2);
		}
		else if (selection == "m")
		{
			Console.WriteLine("You have chosen multiplication, Pick a number");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Pick a second number");
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(number1*number2);
		}
		else if (selection == "d")
		{
			Console.WriteLine("You have chosen division, Pick a number");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Pick a second number");
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(number1/number2);
		}
		else
		{
			Console.WriteLine("You have chosen the wrong key.");
		}
	}
}