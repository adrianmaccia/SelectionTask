using System;

namespace Task1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your gender, M or F:");
            string gender = Console.ReadLine();

            Console.Write("Enter your age:");
            int ageNum = int.Parse(Console.ReadLine());

            if(ageNum > 17){
                Console.Write(gender + " is an adult.");
            } else{
                Console.Write(gender + " is not an adult.");
            }

        }
    }
}
