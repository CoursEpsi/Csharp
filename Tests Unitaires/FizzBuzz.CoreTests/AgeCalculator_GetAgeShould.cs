using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace FizzBuzz.Core.Tests
{
    [TestClass()]
    public class AgeCalculator_GetAgeShould
    {
        [TestMethod()]
        [DataRow(2022, 03, 21, 2)]
        [DataRow(2022, 01, 21, 1)]
        [DataRow(2022, 03, 20, 1)]
        [DataRow(2023, 01, 21, 2)]
        [DataRow(2023, 07, 14, 3)]
        public void ReturnAge(int yearNow, int monthNow, int dayNow, int expected)
        {
            // Given
            var dateProviderMock = new Mock<IDateProvider>();
            dateProviderMock.Setup(p => p.GetNow()).Returns(new DateTime(yearNow, monthNow, dayNow, 00, 00, 00));
            var ageCalculator = new AgeCalculator(dateProviderMock.Object);

            // When
            int actual = ageCalculator.GetAge(new DateTime(2020, 03, 21, 01, 00, 00));

            // Then
            Assert.AreEqual(expected, actual);
        }
    }
}