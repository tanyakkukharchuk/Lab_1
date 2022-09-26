using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcClassBr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClassBr.Tests
{
    [TestClass()]
    public class CalcClassTests
    {
        public TestContext TestContext { get; set; }
        [DataSource("System.Data.SqlClient" , @"Data Source=DESKTOP-LGA1DK7\SQLEXPRESS;Initial Catalog=testdata;Integrated Security=True", "TestData", DataAccessMethod.Sequential)]
        [TestMethod]
        public void IABSTest()
        {
            //ARRANGE
            long a = (long)TestContext.DataRow["a"];
            long expected = (long)TestContext.DataRow["expected"];
            //ACT
            var result = CalcClass.IABS(a);
            //ASSERT
            Assert.AreEqual(expected, result);

        }
    }
}