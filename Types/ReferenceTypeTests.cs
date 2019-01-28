using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Tests
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 10;
            Assert.AreNotEqual(x1, x2);

        }
        [TestMethod]
        public void VariablesHoldAReferece()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            //g1 = new GradeBook(); //It will not run since i can created a new reference for g1, so it points to a new position.
            g1.Name = "Archit Saxena";
            Assert.AreEqual(g1.Name, g2.Name);
            
        }
    }
}
