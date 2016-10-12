using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /// <summary>
    /// Do use generics to build reusable, type-neutral classes
    /// Do not use generics when it is not needed
    /// Only use generic types on the class level if multiple methods need it
    /// Otherwise just define them at the method level
    /// </summary>
    public class Generics
    {
        //This is the new Expression-Body-Syntax feature that lets you create a method in a single
        //line of code
        //Just here for fun
        public decimal CalculateSuggestedPrice(decimal markupPercent) =>
            100m + (100m * markupPercent / 100);
    }
    /// <summary>
    /// Read: Public class OperationResult of type T
    /// The T is called a "Type Parameter" and then lets you use it within the class
    /// This is now a generic class because it has a generic type parameter
    /// We also made the message from a String into another type (by convention T and V are used)
    /// So now we are completely generic.
    /// So, by convention you would use T and V, but you can use anything as long as you prefix with T and V
    /// Make these variable types easier to read
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// /// <typeparam name="VMessage"></typeparam>
    public class OperationResult<TResult, VMessage>
    {
        public OperationResult()
        {

        }
        public OperationResult(TResult result, VMessage message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        //The Result can be of any type
        public TResult Result { get; set; }
        public VMessage Message { get; set; }
    }
    public class GenericMethods
    {
        //How could we change this method to return a generic type instead of a hard-coded integer?
        public int RetrieveValue(string sql, int defaultValue)
        {
            return defaultValue;
        }
        //We could put the <T> on the class as we did for the first example, sure
        //But if no other method in the class needs this type, then this is wasteful
        //I've commented out this method because I don't want to inject <T> on the class
        //public T RetrieveValueGen1(string sql, T defaultValue)
        //{
        //    return defaultValue;
        //}
        //But there is a way to do it at the method level instead
        /// <summary>
        /// So, this method returns a generic
        /// Uses a SQL string and returns a generic
        /// </summary>
        public V RetrieveValueGeneric<V>(string sql, V defaultValue)
        {
            //Right-click in here and choose Create Unit Tests... for a quick way to write a test
            V value = defaultValue;

            return value;
        }
    }
    /// <summary>
    /// Say we don't want people passing in objects or other crap into our generic methods and classes - that where generic constraints come in
    /// where T : struct (for value types)
    /// where T : class (for reference types)
    /// where T : new() (for when the type must have a public, parameterless constructor)
    /// where T : <class> (where <class> is a specific class)
    /// where T : interface (where interface is a specific interface)
    /// so this class is constraining the class to value types!
    /// 
    /// NOTE: Constraints can't do both reference and value types at the same time
    /// You'd need to define an overload to handle that
    /// </summary>
    public class ConstrainedClass <T> where T : struct
    {
        /// <summary>
        /// This method takes in a class with a public parameterless constructor that is instantiated
        /// code is ommitted to populate this new object
        /// and the result is returned
        /// </summary>
        public V Populate<V>(string sql) where V : class, new()
        {
            V instance = new V();
            //code here to populate the object
            return instance;
        }
    }
    /// <summary>
    /// Here we can see multiple generic constraints on a class definition
    /// </summary>
    public class MultiConstrainedClass <T, V> where T : struct where V : class
    {
        /// <summary>
        /// and multiple generic constraints on a method - just for compelteness :)
        /// Here, we're taking in a couple of generics each with their own constraint
        /// </summary>
        public Y Populate<X, Y>(string SQL, Y result) where X : struct where Y : struct
        {
            Y retVal = result;
            return retVal;
        }
    }
}
