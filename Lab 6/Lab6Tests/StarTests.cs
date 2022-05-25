using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Tests
{
    [TestClass()]
    public class StarTests
    {
        [TestMethod()]
        public void StarTest()
        {
            Star sun = new Star("Sun", 1);
            if(sun.Name != "Sun") 
            Assert.Fail();
        }

        [TestMethod()]
        public void showInfTest()
        {
            Star sun = new Star("Sun", 1);
            if(sun.showInf(5) != 5)
            Assert.Fail();
        }

       
    }
}