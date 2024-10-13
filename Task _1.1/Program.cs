using System.Globalization;

namespace FirstTask
{
    internal class Program
    {
        static string IntToDuodecimal(int number)
        {
            if (number == 0)
                return "0";

            string digits = "0123456789AB"; 
            string result = "";
            int remainder;

            while (number > 0)
            {
                remainder = number % 12;
                result = digits[remainder] + result; 
                number /= 12;
            }

            return result;
        }

        static int CountA(string number)
        {
            int count = 0;
            foreach (char c in number)
            {
                if (c == 'A') count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++) 
            { 
                string duodecimal = IntToDuodecimal(i);
                if(CountA(duodecimal) == 2)
                {
                    Console.WriteLine($"{i} ({duodecimal})");
                }
            }

        }
    }
}
