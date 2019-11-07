using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework;
using TestAutomationFramework.Enums;
using TestAutomationFramework.Interfaces;

namespace UITests
{
    [TestFixture]
    public abstract class BaseTest
    {
        protected DriverManager DriverManager;
        [SetUp]
        public void TestSetup()
        {
            DriverManager.GetDriver(DriverTypeEnum.Chrome);
        }

        [TearDown]
        public void TestTearDown()
        {
            DriverManager.QuitDriver();
        }
    }
}
