using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GenericDictionaries;

namespace CollectionsGenerics.UnitTests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void AddingDupes()
        {
            var localBook = new GenericDictionary();
            localBook.PopulateDictionaries();
        }
        [TestMethod]
        public void HappyDictionary()
        {
            var expected = new Dictionary<string, customerPreferences>()
            {
                {"Paul", new customerPreferences {ID=1, Name="Paul Brodzinski", FavoriteBrowser="Chrome" } },
                {"Mark", new customerPreferences {ID=2, Name="Mark Brodzinski", FavoriteBrowser="Safari" } }
            };
            var actualDictionary = new GenericDictionary();
            var actual = actualDictionary.PopulateDictionaries();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
