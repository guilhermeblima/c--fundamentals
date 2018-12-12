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
        public void TestComputeHightestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(5);
            book.AddGrade(10);
            book.AddGrade(7);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(10, stats.HighestGrade);
        }

        [TestMethod]
        public void TestComputeLowesGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(5);
            book.AddGrade(2);
            book.AddGrade(7);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(2, stats.LowestGrade);
        }

        [TestMethod]
        public void TestComputeAverage()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(5);
            book.AddGrade(10);
            book.AddGrade(7);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(7.33, stats.AverageGrade, 0.01); // as comparing float numbers, added delta 0.01
        }
    }

}
