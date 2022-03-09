using System;

namespace InputUsingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to InputUsingMethods Project");
            string Name = TakeUserName();
            Console.WriteLine("Hi " + Name + ", How are you?");
        }

        public static string TakeUserName()
        {
            Console.Write("Enter the Name: ");
            string Name = Console.ReadLine();
            return Name;
        }
    }
}
