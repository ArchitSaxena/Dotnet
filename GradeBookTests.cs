using Grade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.addGrade(90);
            book.addGrade(10);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.MaxGrade);
        }
        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.addGrade(90);
            book.addGrade(10);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.MinGrade);
        }
    }
}
