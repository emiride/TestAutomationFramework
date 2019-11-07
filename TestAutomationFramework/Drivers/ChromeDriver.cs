
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestAutomationFramework.Interfaces;

namespace TestAutomationFramework.Drivers
{
    public abstract class ChromeDriver : IDriver
    {
        private IWebDriver _driver;

        private ChromeDriver(){}

        public void CreateWebDriver()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        }

        public void CreateWebDriver(ChromeOptions chromeOptions)
        { 
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver(chromeOptions);
        }

        public IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                CreateWebDriver();
            }

            return _driver;
        }

        public void QuitDriver()
        {
            if (_driver != null)
            {
                _driver.Close();
                _driver.Quit();
                _driver.Dispose();
            }
        }
    }
}
