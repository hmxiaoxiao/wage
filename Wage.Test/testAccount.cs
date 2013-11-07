using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Wage.Core;
using System.IO;

namespace Wage.Test
{
    /// <summary>
    /// 测试数据库的库
    /// </summary>
    [TestClass]
    public class TestWage_Core_DB
    {
        [TestMethod]
        public void test_GeneFilename ()
        {
            Assert.IsTrue(DB.GeneFilename(2013, 1) == "201301.gz");
            Assert.IsTrue(DB.GeneFilename(2013, 12) == "201312.gz");
        }
    }
}
