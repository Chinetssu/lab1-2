using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void SearchTestPos()
        {
            var amount = 5;
            var sequence = new int[] { 4, 2, 333, 333, 4 };
            var result = Logic.Search(amount, sequence);
            Assert.AreEqual("Пара одинаковых соседних чисел найдена \r\n Их порядковые номера: " + 3 + " и " + 4, result);
        }

        [TestMethod()]
        public void SearchTestNeg()
        {
            var amount = 5;
            var sequence = new int[] { 4, 2, 33, 333, 4 };
            var result = Logic.Search(amount, sequence);
            Assert.AreEqual("Пары одинаковых соседних чисел нет", result);
        }
    }
}