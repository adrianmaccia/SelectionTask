using System;

namespace Task2A
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Enter your username:");
           string username = Console.ReadLine();

           string uname = "Admin";

           if (username == uname){
               
               Console.WriteLine("Login Successful!");
               Console.WriteLine("Enter your password:");
               string password = Console.ReadLine();

               string pword = "Password";

                if(password == pword){
                    Console.WriteLine("login successful");
                } else{
                    Console.WriteLine("login unsuccessful");
                }

           } else{
               Console.WriteLine("login unsuccessful");
           }
        }
    }
}
