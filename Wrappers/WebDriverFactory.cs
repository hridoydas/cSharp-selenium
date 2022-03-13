using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutmation.SeleniumUtils.Wrappers
{
    internal class WebDriverFactory
    {
        public virtual IWebDriver CreateLocalCromeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.SetLoggingPreference(LogType.Browser, LogLevel.All);  
            return new ChromeDriver(options);   

        }
    }
}
