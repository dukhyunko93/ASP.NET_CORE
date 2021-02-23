using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_And_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Length
            var numbers = new[] { 3, 4, 7, 9, 2, 14, 6 };
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);
            foreach(var n in numbers){
                Console.WriteLine(n);
            }

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Copy");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Sort");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Reverse");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}
