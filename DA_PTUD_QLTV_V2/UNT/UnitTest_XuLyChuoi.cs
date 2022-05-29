using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTL;

namespace UNT
{
    /// <summary>
    /// Summary description for UnitTest_XuLyChuoi
    /// </summary>
    [TestClass]
    public class UnitTest_XuLyChuoi
    {
        XuLyChuoiUTL xlcUTL = new XuLyChuoiUTL();

        public UnitTest_XuLyChuoi()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TC_TaoMaTheLoaiChoBanIn_001()
        {
            string tenTheLoai = "Chính trị - pháp luật";

            string actual = xlcUTL.TaoTenVietTatTheLoai(tenTheLoai);
            string expected = "CT";

            Assert.AreEqual(expected, actual, true, "Sai mã thể loại");
        }
    }
}
