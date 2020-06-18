using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;
using System.Collections.Generic;
using Tuples;

namespace CollectionsGenerics.UnitTests
{
    [TestClass]
    public class TupleTests
    {
        [TestMethod]
        public void lists()
        {
            var myTuples = new TupleClass();
            myTuples.SimpleTuples();
        }
    }
}
