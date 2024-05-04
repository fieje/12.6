using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReadWordsFromFile()
        {
            string fileName = "test_input.txt";
            File.WriteAllText(fileName, "apple\nbanana\norange\ngrape\nwatermelon\npineapple");

            Queue<string> queue = Program.ReadWordsFromFile(fileName);

            Assert.AreEqual(6, queue.Count);
            CollectionAssert.AreEqual(new string[] { "apple", "banana", "orange", "grape", "watermelon", "pineapple" }, queue.ToArray());

            File.Delete(fileName);
        }

        [TestMethod]
        public void TestCountElements()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("apple");
            queue.Enqueue("banana");
            queue.Enqueue("orange");

            int count = Program.CountElements(queue);

            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void TestPrintWordsWithLength()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("apple");
            queue.Enqueue("banana");
            queue.Enqueue("orange");
            queue.Enqueue("grape");
            queue.Enqueue("watermelon");
            queue.Enqueue("pineapple");

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            Program.PrintWordsWithLength(queue, 6);

            string expectedOutput = "Words with length 6:\r\nbanana\r\norange\r\n";

            Assert.AreEqual(expectedOutput, consoleOutput.ToString());
        }
    }
}
