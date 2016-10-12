using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionsGenerics.UnitTests
{
    [TestClass]
    public class GenericsTests
    {
        [TestMethod]
        public void GenericBool()
        {
            //Create an instance of the generic class passing in which types you want to use
            //In this case we'll use a boolean and a string
            var gen = new Generics.OperationResult<bool, string>(true, "message");
        }
        [TestMethod]
        public void GenericString()
        {
            //In this case we'll use a string and a string - it still works!
            var gen = new Generics.OperationResult<string, string>("hello", "message");
        }
        [TestMethod]
        public void GenericMethodInvoke_Int()
        {
            var gen = new Generics.GenericMethods();
            var expected = 1;
            //Let pass in the integer for the type
            var actual = gen.RetrieveValueGeneric<int>("select * from customer", 1);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GenericMethodInvoke_String()
        {
            var gen = new Generics.GenericMethods();
            var expected = "response";
            //Lets use the same method but use a string
            var actual = gen.RetrieveValueGeneric<string>("select * from customer", "response");
            Assert.AreEqual(actual, expected);
        }
    }
}
