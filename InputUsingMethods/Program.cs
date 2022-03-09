using System;

namespace InputUsingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to InputUsingMethods Project\n");
            string Name = TakeUserName();
            int Age = TakeAge();
            Console.WriteLine("\nHi " + Name + ", Your Age is: " + Age);
        }

        public static string TakeUserName()
        {
            Console.Write("Enter the Name: ");
            string Name = Console.ReadLine();
            return Name;
        }

        public static int TakeAge()
        {
            Console.Write("Enter Your Age: ");
            string StringAge = Console.ReadLine();
            int IntAge = int.Parse(StringAge);
            return IntAge;
        }
    }
}
