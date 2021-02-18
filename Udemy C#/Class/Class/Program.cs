using System;
using Class.Math;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var result = Calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
