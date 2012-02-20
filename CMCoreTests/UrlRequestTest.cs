﻿using CMCoreNET.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace CMCoreTests
{
    
    
    /// <summary>
    ///This is a test class for UrlRequestTest and is intended
    ///to contain all UrlRequestTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UrlRequestTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Headers
        ///</summary>
        [TestMethod()]
        public void HeadersTest()
        {
            string url = string.Empty; // TODO: Initialize to an appropriate value
            UrlRequest target = new UrlRequest(url); // TODO: Initialize to an appropriate value
            WebHeaderCollection actual;
            actual = target.Headers;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
