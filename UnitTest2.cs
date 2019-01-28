using System;
using Grade;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void computesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.addGrade(10);
            book.addGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.MaxGrade);
        }

        public void computesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.addGrade(10);
            book.addGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.MinGrade);
        }
    }
}
