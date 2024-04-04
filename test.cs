using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class Var07_CoupleTests
    {
        [TestMethod]
        public void Constructor_WithDateParameters_CreatesInstance()
        {
            // Arrange
            DateTime startTime = new DateTime(2024, 4, 4, 9, 0, 0);
            DateTime endTime = new DateTime(2024, 4, 4, 17, 0, 0);
            DateTime breakStartTime = new DateTime(2024, 4, 4, 12, 0, 0);
            DateTime breakEndTime = new DateTime(2024, 4, 4, 13, 0, 0);

            string shiftLink = "MorningShift";

            // Act
            var couple = new Var07_Couple(startTime, endTime, breakStartTime, breakEndTime, shiftLink);

            //// Assert
            //Assert.IsNotNull(couple);
            //Assert.AreEqual(startTime, couple.StartTime);
            //Assert.AreEqual(endTime, couple.EndTime);
            //Assert.AreEqual(breakStartTime, couple.BreakStartTime);
            //Assert.AreEqual(breakEndTime, couple.BreakEndTime);
            //Assert.AreEqual(shiftLink, couple.ShiftLink);
        }

        [TestMethod]
        public void Constructor_WithTimeSpanParameters_CreatesInstance()
        {
            // Arrange
            TimeSpan startTime = new TimeSpan(9, 0, 0);
            TimeSpan endTime = new TimeSpan(8, 0, 0);//17
            TimeSpan breakStartTime = new TimeSpan(12, 0, 0);
            TimeSpan breakEndTime = new TimeSpan(13, 0, 0);

            string shiftLink = "MorningShift";

            // Act
            var couple = new Var07_Couple(startTime, endTime, breakStartTime, breakEndTime, shiftLink);

            // Assert
            //Assert.IsNotNull(couple);
            //Assert.AreEqual(DateTime.Today.Add(startTime), couple.StartTime);
            //Assert.AreEqual(DateTime.Today.Add(endTime), couple.EndTime);
            //Assert.AreEqual(DateTime.Today.Add(breakStartTime), couple.BreakStartTime);
            //Assert.AreEqual(DateTime.Today.Add(breakEndTime), couple.BreakEndTime);
            //Assert.AreEqual(shiftLink, couple.ShiftLink);
        }
        [TestMethod]
        public void Constructor_WithInvalidTimeParameters_ThrowsException()
        {
            // Arrange
            TimeSpan startTime = new TimeSpan(9, 0, 0);
            TimeSpan endTime = new TimeSpan(8, 0, 0); // End time before start time
            TimeSpan breakStartTime = new TimeSpan(12, 0, 0);
            TimeSpan breakEndTime = new TimeSpan(13, 0, 0);
            string shiftLink = "MorningShift";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Var07_Couple(startTime, endTime, breakStartTime, breakEndTime, shiftLink));
        }
    }
}
