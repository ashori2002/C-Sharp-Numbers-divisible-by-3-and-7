using System;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Enter number 1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            ;
            for (number2 = Convert.ToInt32(Console.ReadLine()); number1 < number2;number2--)
            {

                if(number2%7==0 && number2 % 3 == 0)
                {
                    Console.ForegroundColor = (ConsoleColor)2;
                    Console.WriteLine(number2 + "true");
                }
                else
                {
                    Console.ForegroundColor = (ConsoleColor)4;
                    Console.WriteLine(number2 + "false");
                }
            }



        }
    }
}
