using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core.Tests
{
    [TestClass()]
    public class Worker_GetFizzBuzzShould
    {
        [TestMethod()]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        public void ReturnNumber_WhenNumberIsAbove(int input, string expected)
        {
            // Given
            Worker worker = new Worker();

            // When
            var actual = worker.GetFizzBuzz(input);

            // Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(3)]
        [DataRow(9)]
        [DataRow(18)]
        public void ReturnFizz_WhenNumberIsAbove(int input)
        {
            // Given
            Worker worker = new Worker();

            // When
            var actual = worker.GetFizzBuzz(input);

            // Then
            string expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(20)]
        public void ReturnBuzz_WhenNumberIsAbove(int input)
        {
            // Given
            Worker worker = new Worker();

            // When
            var actual = worker.GetFizzBuzz(input);

            // Then
            string expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(15)]
        [DataRow(45)]
        [DataRow(90)]
        public void ReturnFizzBuzz_WhenNumberIsAbove(int input)
        {
            // Given
            Worker worker = new Worker();

            // When
            var actual = worker.GetFizzBuzz(input);

            // Then
            string expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }
    }
}