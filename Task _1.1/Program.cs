using System.Globalization;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first 9 digits:");
            string isbn = Console.ReadLine();

            int control = 0;
            for (int i = 0; i < 9; i++)
            {
               control = int.Parse(isbn[i].ToString()) * (10-i);
            }
            control = control % 11;

            if (control == 10)
            {
                Console.WriteLine("The ISBN-10 number is: " + isbn + "X");
            }
            else
            {
                Console.WriteLine("The ISBN-10 number is: " + isbn + control);
            }
        }
    }
}
