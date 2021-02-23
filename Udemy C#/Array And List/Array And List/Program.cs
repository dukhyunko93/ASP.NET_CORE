using System;
using System.Collections.Generic;

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

            var numList = new List<int>() { 1, 2, 3, 4 };
            numList.Add(10);
            numList.AddRange(numbers);
            foreach (var num in numList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Index");
            Console.WriteLine("Index:" + numList.IndexOf(1));
            Console.WriteLine("Index:" + numList.LastIndexOf(1));

            Console.WriteLine("Count:" + numList.Count);

            numList.Remove(1);

            foreach (var num in numList)
            {
                if(num == 1)
                {
                    numList.Remove(num);
                }
            }
            foreach (var num in numList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
