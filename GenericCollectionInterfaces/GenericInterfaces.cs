using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionInterfaces
{
    /// <summary>
    /// An interface is a specification identifying a related set of properties and methods
    /// A class commits to supporting the interface by implementing the interface
    /// HERE'S THE KEY: You can use the interface as a data type to work with any class that implements the interface!
    /// This allows you to write more generalized code because any instance that implements the interface
    /// can be passed into the interface as a parameter; e.g. passing in MOCKs
    /// 
    /// So, the case of passing in different collection types into a method isn't just about generics, it's about interfaces
    /// e.g. if your method signature expects a List<T> but you then want to use that same method to with with an Array[] then
    /// you can't do it
    /// If, however, you change your method signature to allow an interface from which both derive - it works and you avoid
    /// creating a second method to handle arrays as distinct from lists.
    /// 
    /// IEnumerable<T> -> GetEnumerator (we use foreach to loop through)
    /// ICollection<T> -> extends IEnumerable<T> and adds Add, Count and Remove
    /// IList<T> -> extends ICollection<T> and adds methods specifically for working with lists by index
    /// IDictionary<T,V> -> also extends ICollection<T> and adds methods specifically for working with lists of key, value pairs
    /// 
    /// Array -> implements IEnumerable, ICollection and IList (but because it's old/pre-generics, there are special rules)
    /// List -> implements IEnumerable, ICollection and IList
    /// Dictionary -> implements IEnumerable, ICollection and IDictionary
    /// </summary>
    public class GenericInterfaces
    {
        
    }

    public class person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Populate
    {
        /// <summary>
        /// Here's an example
        /// This method is saying that it will take in any collection of person objects as long as that
        /// that collection has the properties and methods identified in the ICollection of T interface
        /// So, List, Array and Dictionary all implement the .Net build-in ICollection interface so I could pass in
        /// an instance of any class that implements any of those and it will work
        /// </summary>
        public string SendEmail(ICollection<person> people, string message)
        {
            return message;
        }
    }
    /// <summary>
    /// Here's an example interface - let's break it down
    /// It's named "I" + name to identify this as an interface
    /// The of <T> specifies a generic data type that is passed in and can be used within the properties and methods
    /// so, you see T representing the type of the thing you're working with, allowing for generic code
    /// This interface inherits from and extends IEnumerable<T>
    /// </summary>
    public interface ICollection<T> : IEnumerable<T>
    {
        //Here is the specification required for this interface
        //The class that implements this must provide the code
        int Count { get; }
        void Add(T item);
        void Clear();
        bool Contains(T item);
        bool Remove(T item);
    }

    //Here is a class that INTENDS TO IMPLEMENT the above interface - it MUST provide an implementation of each
    //and every method and property
    public class List<T> : ICollection<T>
    {
        private int _size;
        private T[] _items;
        public void Add(T item)
        {

        }
        public int Count
        {
            get { return _size; }
        }
        public void Clear()
        {

        }
        public bool Contains(T item)
        {
            return false;
        }
        public bool Remove(T item)
        {
            return true;
        }
        //Because this inherits from IEnumerable, you also have to implement the GetEnumerator
        //This is the only generic collection interface override method
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
