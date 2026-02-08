using System;

class Calculator
{
    public static double? Calculate(int first, int second, string operation)
    {
        switch (operation)
        {
            case "+":
                return first + second;

            case "-":
                return first - second;

            case "*":
                return first * second;

            case "/":
                if (second == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return null;
                }
                return Math.Round((double)first / second, 2);

            case "%":
                if (second == 0)
                {
                    Console.WriteLine("Cannot modulo by zero");
                    return null;
                }
                return first % second;

            case "=":
                return null;

            default:
                Console.WriteLine("Incorrect Operation Used, please try again");
                return null;
        }
    }
}
