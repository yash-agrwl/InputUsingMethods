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
            string Location = TakeLocation();
            Console.WriteLine("\nHi " + Name + ", Your Age is: " + Age + " and Your Location is: " + Location);
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

        public static string TakeLocation()
        {
            Console.Write("Enter Your Location: ");
            return Console.ReadLine();
        }
    }
}
