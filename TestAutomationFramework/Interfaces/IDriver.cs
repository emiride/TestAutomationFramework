using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.Interfaces
{
    public interface IDriver
    {
        void CreateWebDriver();
        IWebDriver GetDriver();
        void QuitDriver();
    }
}
