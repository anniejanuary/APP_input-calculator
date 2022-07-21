using System;

namespace UserInputExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Calculate());
            Console.Read();
        }
        public static int Calculate() 
        {
            Console.WriteLine("Please enter the first number and press enter: "); 
            string numberInput = Console.ReadLine(); ///storing that number in a string

            Console.WriteLine("Please neter the second number: ");
            string numberInput2 = Console.ReadLine();///storing that number in a string

            int num1 = int.Parse(numberInput);
            int num2 = int.Parse(numberInput2);

            int result = num1 + num2;

            Console.WriteLine("The result is: ");

            return result;
         
        }
    }
}
