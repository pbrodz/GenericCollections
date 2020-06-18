using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuples
{
    /// <summary>
    /// Usage of Tuple
    ///Tuples can be used in the following scenarios:
    ///     When you want to return multiple values from a method without using ref or out parameters.
    ///     When you want to pass multiple values to a method through a single parameter.
    ///     When you want to hold a database record or some values temporarily without creating a separate class.
    ///Tuple Limitations:
    ///     Tuple is a reference type and not a value type.It allocates on heap and could result in CPU intensive operations.
    ///     Tuple is limited to include 8 elements.You need to use nested tuples if you need to store more elements. However, this may result in ambiguity.
    ///     Tuple elements can be accessed using properties with a name pattern Item<elementNumber> which does not make sense.
    /// </summary>
    public class TupleClass
    {
        public TupleClass()
        {

        }

        public void SimpleTuples()
        {
            // Simple Tuple example
            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Paul", "Brodzinski");

            // Using the Create method to create the Tuple
            var person2 = Tuple.Create(1, "Paul", "Brodzinski");

            // You can have up to 8 elements in a Tuple
            Console.WriteLine(person.Item1);
            Console.WriteLine(person2.Item2);

            // To include more than 8 items, you can nest Tuples
            var person3 = Tuple.Create(1, 2, 3, 4, 5, 6, Tuple.Create(7, 8, 9, 10, 11, 12, 13, 14));
            Console.WriteLine(person3.Item7.Item1);
            // Rest is used to get the last element only for a max (scope 8 Tuple)
            Console.WriteLine(person3.Item7.Rest);

            var person4 = Tuple.Create(1, "Steve", "Jobs");
            DisplayTuple(person);

            // Black-belt - here is a list of tuples, initialized to a single value
            var myTupleList = new List<(int, string, string)>() { (1, "Justin", "Potato") };
            myTupleList.Add((2, "Paul", "Cauliflower"));
            var justMe = myTupleList.Where(p => String.Equals(p.Item2, "Paul", StringComparison.OrdinalIgnoreCase));
            foreach(var p in myTupleList)
            {
                Console.WriteLine($"{p.Item2} {p.Item2}");
            }
        }
        public void DisplayTuple(Tuple<int, string, string> inputPerson)
        {
            Console.WriteLine($"Id = {inputPerson.Item1}");
            Console.WriteLine($"First Name = {inputPerson.Item2}");
            Console.WriteLine($"Last Name = {inputPerson.Item3}");
        }
    }
}
