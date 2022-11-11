using Microsoft.VisualStudio.TestTools.UnitTesting;
using testapp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void isOddNumberTest()
        {
            Program p = new Program();
            Assert.IsTrue(p.isOddNumber(3));
        }
    }
}