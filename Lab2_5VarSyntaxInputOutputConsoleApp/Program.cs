﻿using System;
using System.Runtime.InteropServices;

namespace Lab2_5VarSyntaxInputOutputConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Lab 2_5

            // 1. Write a C# program to print on screen the output of adding, subtracting, 
            //  multiplying and dividing of two numbers which will be entered by the user.
            int intFirstNumber = 0;
            int intSecondNumber = 0;
            int intResult = 0;
            int intThirdNumber = 0;
            double dblResult = 0;

            Console.WriteLine("Enter your first number: ");
            intFirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            intSecondNumber = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter your third number: ");
            intThirdNumber = Convert.ToInt32(Console.ReadLine());

            //Adding
            intResult = intFirstNumber + intSecondNumber;
            Console.WriteLine($"{intFirstNumber} plus {intSecondNumber} is {intResult}");

            //Subtracting
            intResult = intFirstNumber - intSecondNumber;
            Console.WriteLine($"{intFirstNumber} minus {intSecondNumber} is {intResult}");

            //Multiplying
            intResult = intFirstNumber * intSecondNumber;
            Console.WriteLine($"{intFirstNumber} multiplied by {intSecondNumber} is {intResult}");

            //Dividing
            dblResult = intFirstNumber / Convert.ToDouble(intSecondNumber);
            Console.WriteLine($"{intFirstNumber} divided by {intSecondNumber} is {dblResult}");

            // 2. Write a C# program to print Hello and your name (which you will type in on the Console) in a separate line.
            string personsName = string.Empty;
            Console.WriteLine("Please enter your name: ");
            personsName = Console.ReadLine();
            Console.WriteLine($"Hello, {personsName}");

            // 3. Write a C# program to print the output of multiplication of three numbers which will be entered by the user.
            
            //multiplying
            intResult = intFirstNumber * intSecondNumber * intThirdNumber;
            Console.WriteLine($"{intFirstNumber} multiplied by {intSecondNumber} multiplied by {intThirdNumber} is {intResult}");

            // 4. Write a C# program that takes an age (for example 20) as input and prints something like "You look younger than 20 (the age the user entered)".
            int intAge = 0;
            Console.WriteLine("Please enter your age: ");
            intAge = int.Parse(Console.ReadLine());
            //or
            //intAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You look younger than {intAge}.");

        }
    }
}
