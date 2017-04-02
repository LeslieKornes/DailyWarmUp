using System;

namespace FourTwoExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user to input a letter 3x and then print them to the console in reverse
            Console.WriteLine("Enter a letter!");
            char letter1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter another letter!");
            char letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter a final letter!");
            char letter3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Your letters in reverse are: {letter3}, {letter2}, and {letter1}");

            //similar using a char array
            char[] userLetters = new char[] { letter1, letter2, letter3 };
            Console.WriteLine("Your letters in reverse are:");
            for (int i = userLetters.Length - 1; i >= 0; i--)
            {
                Console.Write(userLetters[i] + " ");
            }

            //ask for a number, then ask for a second number for the width. Print a triangle of the number to the console
            //starting with the width input

            Console.WriteLine("Please enter your favorite number from 1-9");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter a number from 1-9 that will be the beginning width of your number choice triangle.");
            int width = Convert.ToInt16(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
                width--;
            }

            //Write a program that takes two numbers as input and perform an operation (+,-,*,x,/) 
            //on them and displays the result of that operation

            double num1;
            double num2;
            char minus = '-';
            char plus = '+';
            char times = 'x';
            char multiply = '*';
            char dividedBy = '/';
            char chosenOperation;
            double finalAnswer;
            string operation = "";

            Console.WriteLine("Please enter a number you'd like to begin your equation with.");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the symbol (+, -, x, *, /) for your desired operation.");
            chosenOperation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please enter the second number for your equation.");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (chosenOperation == '-')
            {
                finalAnswer = num1 - num2;
                operation = "minus";
            }
            else if (chosenOperation == '+')
            {
                finalAnswer = num1 + num2;
                operation = "plus";
            }
            else if (chosenOperation == 'x' || chosenOperation == '*')
            {
                finalAnswer = num1 * num2;
                operation = "multiplied by";
            }
            else
            {
                finalAnswer = num1 / num2;
                operation = "divided by";
            }
            Console.WriteLine($"{num1} {operation} {num2} is {finalAnswer}");

            //Ugh, shorter way

            double x;
            double y;
            char operationPick;

            Console.WriteLine("Input your first number.");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your operation choice (+, -, *, x, /).");
            operationPick = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter your second number.");
            y = Convert.ToDouble(Console.ReadLine());

            if (operationPick == '+')
                Console.WriteLine($"{x} + {y} equals {x + y}");

            else if (operationPick == '-')
                Console.WriteLine($"{x} - {y} equals {x - y}");
            
            else if (operationPick == '*' || operationPick == 'x')
                Console.WriteLine($"{x} x {y} equals {x * y}");
            
            else if (operationPick == '/')
                Console.WriteLine($"{x} / {y} equals {x / y}");
            
            else
                Console.WriteLine("Invalid input");
            

            //Ask user for radius of a circle.Use this to calculate perimeter / circumference(2piR) and area(piRsquared)

            double radius;

            Console.WriteLine("Please give me the radius of your circle and I will provide the perimeter and area.");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The perimeter of your circle is {0}, and the area is {1}.", (2 * Math.PI * radius), ((Math.PI) * Math.Pow(radius, 2)));

            //Write a program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5)

            int a;
            int b;

            Console.WriteLine("For the equation a = b2 + 2b + 1:");

            for (b = -5; b <= 5; b++)
            {
                a= b*b - 2*b + 1;
                Console.WriteLine($"b = {b}; a = ({Math.Pow(b, 2)}) - 2*{b} + 1 = {a}");
                Console.WriteLine();
            }
        }
    }
}
