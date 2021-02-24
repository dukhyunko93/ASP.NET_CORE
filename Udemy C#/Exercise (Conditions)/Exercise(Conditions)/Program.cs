using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Conditions_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            Console.WriteLine("Enter a number:");

            int number = Convert.ToInt32(Console.ReadLine());
            var result = (number > 0 && number < 11) ? "Valid" : "Invalid";

            Console.WriteLine(result);

            //Example 2
            Console.WriteLine("Enter a number:");
            int compare1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int compare2 = Convert.ToInt32(Console.ReadLine());

            var result2 = Math.Max(compare1, compare2);

            Console.WriteLine(result2);

            //Example 4
            Console.WriteLine("Enter a Speed Limit:");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a speed:");
            int speed = Convert.ToInt32(Console.ReadLine());

            if (speed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                double limit = (speed - speedLimit) / 5;
                double penalty = Math.Ceiling(limit);

                var message = (penalty < 12) ? string.Format("You have inccured {0}points.", penalty) : "Your License is suspened!";
                Console.WriteLine(message);
            }



        }
       
    }
}
