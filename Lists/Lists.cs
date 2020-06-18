using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class order
    {
        public int id { get; set; }
        public string customer { get; set; }
        public double value { get; set; }

        /// <summary>
        /// Let's override the ToString method to return nicely formatted strings
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ID is: {this.id} Customer Name is: {this.customer} Value of the Order is: {this.value}";
        }
    }

    public class genOrder<T>
    {
        public int id { get; set; }
        public T customer { get; set; }
        public double value { get; set; }
    }

    /// <summary>
    /// Generic Lists are the best choice in most cases
    /// Use Add instead of Insert when populating the list
    /// Use a Plural for the name (for multiple elements)
    /// Avoid removing elements - it's SLOW.  Linked List is faster
    /// </summary>
    public class Lists
    {
        public void GenericLists()
        {
            //Declare a list of strings
            List<string> colorsOld;
            //Initialize the list of strings
            colorsOld = new List<string>();

            //We can combine those two statements into one
            List<string> colorsNewer = new List<string>();

            //As we have the type on the right, we can then optimize to use implicit typing
            var colors = new List<string>();
            //Always add to the end of the list
            colors.Add("Red");
            colors.Add("Espresso");
            colors.Add("White");
            colors.Add("Navy");

            //You can insert into the List like this
            colors.Insert(3, "Blue");

            //You can also remove - the first instance will be removed
            colors.Remove("Espresso");

            //Lets use a List initializer now
            var colorsBest = new List<string>() { "Red", "Espresso", "White", "Navy" };
        }

    }
}
