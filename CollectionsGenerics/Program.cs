using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    /// <summary>
    /// Array (System)
    /// ArrayList (System.Collections .Net 1.0 - obsolete)
    /// List<T> (System.Collections.Generic .Net 2+)
    /// LinkedList<T> (System.Collections.Generic .Net 2+)
    /// Queue<T> (System.Collections.Generic .Net 2+)
    /// Stack<T> (System.Collections.Generic .Net 2+)
    /// Dictionary<T> (System.Collections.Generic .Net 2+)
    /// SortedList<T> (System.Collections.Generic .Net 2+)
    /// SortedDictionary<T> (System.Collections.Generic .Net 2+)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {


            var arrays = new Arrays();

            //Simple arrays
            var simpleArrays = arrays.SimpleArrays();

            //Using simple output with the for loop
            //for lets you change the iterating element
            //for lets you change what you're are iterating instead of all of them
            for (int i = 0; i < simpleArrays.Length; i++)
            {
                Console.WriteLine("Simply: " + simpleArrays[i]);
                Console.WriteLine(String.Format("Formattingly: {0}", simpleArrays[i]));
            }
            Console.ReadLine();

            //Using string interpolation feature with foreach
            //foreach always goes through ALL elements in the array
            //foreach doesn't let you change the iterating element - it's read only
            //foreach is QUICK and EASY
            foreach (var color in simpleArrays)
                Console.WriteLine($"The color is: {color}");
            Console.ReadLine();

            //Lets use an instance method to set a value in the array
            simpleArrays.SetValue("Blue", 3);
            Console.WriteLine($"The new value in position 3 is: {simpleArrays[3]}");
            Console.ReadLine();

            //Reading from a Generic List<T>
            //Lets create and populate a generic list first
            var orders = new List<Lists.order>() { new Lists.order() {id=1, customer="Paul", value=1000.0f} };
            var pooh = new System.DateTime(2017, 01, 01);
            foreach (var order in orders)
            {
                //We have overridden the ToString() in the order class to format it correctly
                //so we only need to call it here - ToString() is the default method that is invoked
                //so there is no need to explicitly state the .ToString() method here
                Console.WriteLine(order);
            }
            Console.ReadLine();

        }
    }
}
