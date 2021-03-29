using Microsoft.VisualStudio.TestTools.UnitTesting;
using horse_racing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horse_racing.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Gurpreet gp = new Gurpreet(1,1,1);
            if (gp.budgetRest(1) > 0)
            {
                Assert.IsTrue(true);
            }
            
        }
        [TestMethod()]
        public void Form2Test()
        {
            Harpreet Hp = new Harpreet(1, 1, 1);
            if (Hp.budgetRest(1) > 0)
            {
                Assert.IsTrue(true);
            }

        }
    }
}