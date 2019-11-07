using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using TestAutomationFramework.Drivers;
using TestAutomationFramework.Enums;
using TestAutomationFramework.Interfaces;

namespace TestAutomationFramework
{
    public abstract class DriverManager
    {
        private ChromeDriver chromeDriver;
        private IDriver driver;
        private DriverManager() { }

        public IWebDriver GetDriver(DriverTypeEnum driverType)
        {
            if (driverType == DriverTypeEnum.Chrome)
            {
                return chromeDriver.GetDriver();
            }
            else if(driverType == DriverTypeEnum.Edge)
            {
                return new EdgeDriver();
            }
            throw new NotSupportedException();
        }

        public void QuitDriver()
        {
            driver.QuitDriver();
        }
    }
}
