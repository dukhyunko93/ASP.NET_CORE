using System;

namespace Referece_and_Value_Type
{
    public class Person
    {
        public int Age;
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0}, b:{1}", a, b));

            //Reference Type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1:{0}, array2:{1}", array1[0], array2[0]));

            var number = 1;
            Person.Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            Person.MakeOld(person);
            Console.WriteLine(person.Age);
        }
    }
}
 