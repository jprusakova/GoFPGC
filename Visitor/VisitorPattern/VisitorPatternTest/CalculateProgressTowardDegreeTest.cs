using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorPattern;

namespace VisitorPatternTest
{
    [TestClass]
    public class CalculateProgressTowardDegreeTest
    {
        readonly CalculateProgressTowardDegree _calculator = new CalculateProgressTowardDegree("CS", 2);

        [TestMethod]
        public void EmptyShouldReturnZero()
        {
            Assert.AreEqual(0, _calculator.TotalCreditHours);
        }

        [TestMethod]
        public void SingleElectiveShouldReturnElectiveHours()
        {
            ElectiveCourse elective = new ElectiveCourse("Elective");
            elective.ReceiveVisitor(_calculator);
            Assert.AreEqual(3, _calculator.TotalCreditHours);
        }

        [TestMethod]
        public void MultipleElectiveShouldCountUpToMaxElectiveHours()
        {
            ElectiveCourse elective = new ElectiveCourse("Elective");
            elective.ReceiveVisitor(_calculator);
            ElectiveCourse elective2 = new ElectiveCourse("Elective2");
            elective2.ReceiveVisitor(_calculator);

            Assert.AreEqual(3, _calculator.TotalCreditHours);
        }

        [TestMethod]
        public void CoreCourseForDegreeShouldReturnHours()
        {
            CoreCourse coreCourse = new CoreCourse(".Net programming", 4, "CS");
            coreCourse.ReceiveVisitor(_calculator);
            Assert.AreEqual(4, _calculator.TotalCreditHours);
        }

        [TestMethod]
        public void CoreCourseForDifferentDegreeShouldReturnZero()
        {
            CoreCourse coreCourse = new CoreCourse("TV programming", 4, "Literature");
            coreCourse.ReceiveVisitor(_calculator);
            Assert.AreEqual(0, _calculator.TotalCreditHours);
        }
    }
}
