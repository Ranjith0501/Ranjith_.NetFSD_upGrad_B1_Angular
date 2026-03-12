using System;

namespace C__Basic_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1: Divide two numbers
            Console.WriteLine("Exercise 1 - Division");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double quotient = num1 / num2;
            Console.WriteLine("Quotient = " + quotient);


            // Exercise 2: Kilometer to meters
            Console.WriteLine("\nExercise 2 - KM to Meters");
            Console.Write("Enter distance in kilometers: ");
            double km = Convert.ToDouble(Console.ReadLine());

            double meters = km * 1000;
            Console.WriteLine("Distance in meters = " + meters);


            // Exercise 3: Sum and Average of five numbers
            Console.WriteLine("\nExercise 3 - Sum and Average");

            Console.Write("Enter number 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 3: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 4: ");
            int n4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 5: ");
            int n5 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2 + n3 + n4 + n5;
            double average = sum / 5.0;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);


            // Exercise 4: Odd or Even
            Console.WriteLine("\nExercise 4 - Odd or Even");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");


            // Exercise 5: Highest number
            Console.WriteLine("\nExercise 5 - Highest Number");

            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine("Highest number = " + a);
            else
                Console.WriteLine("Highest number = " + b);


            // Exercise 6: Area of rectangle and square
            Console.WriteLine("\nExercise 6 - Area Calculation");

            Console.Write("Enter length of rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width of rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double rectArea = length * width;
            Console.WriteLine("Area of Rectangle = " + rectArea);

            Console.Write("Enter side of square: ");
            double side = Convert.ToDouble(Console.ReadLine());

            double squareArea = side * side;
            Console.WriteLine("Area of Square = " + squareArea);


            // Exercise 7: Time for journey
            Console.WriteLine("\nExercise 7 - Journey Time");

            Console.Write("Enter distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter speed: ");
            double speed = Convert.ToDouble(Console.ReadLine());

            double time = distance / speed;
            Console.WriteLine("Time taken = " + time);


            // Exercise 8: Third character vowel or consonant
            Console.WriteLine("\nExercise 8 - Vowel or Consonant");

            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            char thirdChar = text[2];

            if ("aeiouAEIOU".Contains(thirdChar))
                Console.WriteLine("Third character is a Vowel");
            else
                Console.WriteLine("Third character is a Consonant");

        }
    }
}