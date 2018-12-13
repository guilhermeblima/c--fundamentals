using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypesTests
    {

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int number = 50;
            IncrementNumber(number);
            Assert.AreEqual(50, number);

        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("This is a book name", book1.Name);

        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "This is a book name";
        }

        [TestMethod]
        public void StringComparissons()
        {
            string name1 = "Gui";
            string name2 = "gui";

            Assert.IsFalse(String.Equals(name1, name2));
            Assert.IsTrue(String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void IntVariableHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariableHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2;
            g2 = g1;

            g1.Name = "Test Grade Book Name";

            Assert.AreEqual(g1.Name, g2.Name);

        }
    }
}
