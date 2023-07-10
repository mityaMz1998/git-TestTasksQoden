using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1.Tests
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int vvod = 5;

            string[] input = {"5","100","10","24","13"};

            FormHashTable formHashTable = new FormHashTable();

            string expected = 
                "0: 5 100 10\n" +
                "1: \n" +
                "2: \n" +
                "3: 13\n" +
                "4: 24\n";

            string result = formHashTable.GetHashTable(input, vvod).ToString();

            Assert.AreEqual(expected, result);
        }
    }
}
