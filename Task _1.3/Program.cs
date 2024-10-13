using System.Globalization;

namespace FirstTask
{
    internal class Program
    {

        static Array RemoveExtraNumbers(int[] numbers)
        {
            var  newNumbers = new List<int>();
            newNumbers.Add(numbers[0]);
            foreach (int number in numbers)
            {
                int count = 0;
                foreach (int n in newNumbers)
                {
                    if (number == n)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    newNumbers.Add(number);
                }
            }
            return newNumbers.Distinct().ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items:");
            int listSize = int.Parse(Console.ReadLine());
            int[] numbers = new int[listSize];
            for (int i = 0; i < listSize; i++)
            {
                Console.Clear();
                Console.WriteLine($"Enter the {i + 1} number:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Result:");
            foreach (int number in RemoveExtraNumbers(numbers)) Console.Write(number);

        }
    }
}
