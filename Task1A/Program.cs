using System;

namespace Task1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:");
            int ageNum = int.Parse(Console.ReadLine());

            if(ageNum > 17){
                Console.Write("Legally adult age.");
            } else{
                Console.Write("Legally not adult age.");
            }
        }
    }
}
