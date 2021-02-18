using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstName = "Duke";
            var lastName = "Ko";

            var fullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var fornattedNames = string.Join(",", names);
            Console.WriteLine(fornattedNames);

            var text = @"Hi John
Look into the following paths
C:\folder1\folder2\folder2";

            Console.WriteLine(text);
        }
    }
}
