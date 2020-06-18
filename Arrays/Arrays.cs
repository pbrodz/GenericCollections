using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    /// <summary>
    /// Arrays are useful when the size of the array can be determined at design time
    /// They use memory efficiently and perform well
    /// Mostly you only use arrays when you need multiple dimensions or if you need to squeeze out a bit more
    /// performance when working with a large, fixed number of elements
    /// Use plural for the name
    /// Another new comment for git testing purposes.
    /// DO use collection initializers
    /// 
    /// AVOID:
    /// If the size of the list is not known
    /// Manually populating an array
    /// 
    /// Derives from System.Array
    /// You get instance methods and static methods
    /// </summary>
    public class Arrays
    {

        public Arrays()
        {
            //Constructor
        }
        public string[] SimpleArrays()
        {
            //Array declaration
            //You could have reference types, primitive types or objects here
            string[] colorOptions;
            //Initialize the array.  When this statement executes, each element is initialized
            //to the array element type default value (null in this case)
            colorOptions = new string[4];

            //You can combine the above two statements into one line
            string[] colorOptionsEx = new string[4];

            //As we have the type on the left, we can use implicit
            var colorOptionsExImp = new string[4];

            //We can now populate the elements of the array as follows:
            colorOptionsExImp[0] = "Red";
            colorOptionsExImp[1] = "Espresso";
            colorOptionsExImp[2] = "White";
            colorOptionsExImp[3] = "Navy";

            //We can further simplify by using a collection initializer
            string[] colorOptionsSubOptimal = new string[4] { "Red", "Espresso", "White", "Navy" };
            //or
            var colorOptionsSubOptimal2 = new string[4] { "Red", "Espresso", "White", "Navy" };

            //Because the collection initializer syntax defines how many elements we need
            //and we can imply the type, we end up with this
            //note that we need the string type and can't use a var
            string[] colorOptionsOptimal = { "Red", "Espresso", "White", "Navy" };

            return colorOptionsExImp;
        }
    }
}
