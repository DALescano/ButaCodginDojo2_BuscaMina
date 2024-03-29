﻿using Kata002;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Minas
{
    
    
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
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
        ///A test for inicializarmatriz
        ///</summary>
        [TestMethod()]
        public void inicializarmatrizTest()
        {
            Program target = new Program(); // TODO: Initialize to an appropriate value
            target.inicializarmatriz();
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for pintarmina
        ///</summary>
        [TestMethod()]
        public void pintarminaTest()
        {
            Program target = new Program(); // TODO: Initialize to an appropriate value
            target.pintarmina();
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for sumar
        ///</summary>
        /*[TestMethod()]
        public void sumarTest()
        {
            Program target = new Program(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.sumar();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }*/

       [TestMethod()]
       public void ProbarTest()
       {
           Program target = new Program(); // TODO: Initialize to an appropriate value
           /*int expected = 0; // TODO: Initialize to an appropriate value
           int actual;*/
           bool band3=target.checkPosAndSetValue(1,1,3,3);
           //target.checkPosAndSetValue();
           Assert.AreEqual(band3, false);
            //Assert.Inconclusive("Verify the correctness of this test method.");
       }
     
           
    }
}
