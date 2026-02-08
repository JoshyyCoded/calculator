using System;

class Program
{
    static void Main(string[] args)
    {
        int firstNumber, secondNumber;
        string operation;
        bool runInput = true;

        while (runInput)
        {
            while (true)
            {
                Console.Write("Enter the first number: ");
                if (int.TryParse(Console.ReadLine(), out firstNumber))
                    break;

                Console.WriteLine("Invalid input. Only integers are accepted.");
            }

            while (true)
            {
                Console.Write("Enter the second number: ");
                if (int.TryParse(Console.ReadLine(), out secondNumber))
                    break;

                Console.WriteLine("Invalid input. Only integers are accepted.");
            }

            while (true)
            {
                Console.Write("Choose an operation (+, -, *, /, %, = ): ");
                operation = Console.ReadLine();

                var result = Calculator.Calculate(firstNumber, secondNumber, operation);

                if (operation == "=")
                {
                    Console.WriteLine("Program terminated.");
                    runInput = false;
                    break;
                }

                if (result == null)
                    continue;

                Console.WriteLine($"Result: {result}");
                break;
            }
        }
    }
}
