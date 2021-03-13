using System;

namespace Task1C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a second number:");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 + num2 > 10){
                Console.Write("Sum of numbers is greater than 10.");
            }else if(num1+num2 == 10){
                    Console.Write("Sum of numbers is equal to 10.");
            }else{
                Console.Write("Sum of numbers is less than 10.");
            }
        }
    }
}

