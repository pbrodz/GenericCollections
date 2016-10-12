using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionaries
{

    /// <summary>
    /// 
    /// System.Collections.Generic
    /// -Dictionary (most common, not sorted)
    /// -SortedList (sorted by key, faster than a sorteddictionary, faster when populating from sorted data)
    /// -SortedDictionary (sorted by key, fater than a sortedlist when populating from unsorted data)
    /// 
    /// System.Collections.ObjectModel (used when creating a library that returns dictionaries)
    /// -ReadOnlyDictionary
    /// -KeyedCollection
    /// 
    /// System.Collections.Specialized
    /// -OrderedDictionary (can be accessed by Key OR Index)
    /// 
    /// System.Collections.Concurrent (.Net 4+)
    /// --use these when you need to access the dictionary from multiple threads concurrently
    /// 
    /// Dictionaries contain elements defined as Key/Value pairs
    /// Lists contain elements
    /// Dictionaries are accessed by Key
    /// Lists are accessed by the positional Index
    /// Dictionaries allow duplicate values but unique keys
    /// Lists allow duplicate values
    /// Dictionaries are marginally faster when looking up a particular element
    /// Lists are marginally faster when iterating the entire list
    /// 
    /// DO: Use a Dictionary to hold a collection of elements by key
    /// AVOID: Using a Dictionary if there is no clear or unique key
    /// AVOID: Using a Dictionary if you don't plan on looking up elements by key
    /// </summary>
    public class GenericDictionary
    {
        public GenericDictionary()
        {
            //constructor
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public Dictionary<string, customerPreferences> PopulateDictionaries()
        {
            //Lets declare and instantiate a new generic dictionary
            Dictionary<string, string> statesOld;
            statesOld = new Dictionary<string, string>();

            //We can combine the two into a single line
            Dictionary<string, string> statesNew = new Dictionary<string, string>();

            //Because we have the type defined on the right, we can use implicits
            var statesBetter = new Dictionary<string, string>();

            //Let's add some values to this Better initialized dictionary
            statesBetter.Add("WA", "Washington");
            statesBetter.Add("CA", "California");
            statesBetter.Add("OR", "Oregon");

            //We can use collection initializers to collapse everything into a single line
            var statesBest = new Dictionary<string, string>() {
                {"WA", "Washington" },
                {"CA", "California" },
                {"OR", "Oregon" }
            };

            //Lets use the customerPreferences to make a Dictionary of objects
            //You can create the object first and use .Add, or else combing as follows:
            var customerPrefs = new Dictionary<string, customerPreferences>()
            {
                {"Paul", new customerPreferences {ID=1, Name="Paul Brodzinski", FavoriteBrowser="Chrome"}}
            };

            //Here's the longer version
            var newCust = new customerPreferences() { ID = 2, Name = "Mark Brodzinski", FavoriteBrowser = "Safari" };
            customerPrefs.Add("Mark", newCust);
            return customerPrefs;
        }
    }
    public class customerPreferences
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FavoriteBrowser { get; set; }
    }
}
