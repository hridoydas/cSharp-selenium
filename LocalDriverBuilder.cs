using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumAutmation.SeleniumUtils.Wrappers;

namespace SeleniumAutmation.SeleniumUtils
{
    public class LocalDriverBuilder
    {
        private readonly WebDriverFactory factory;

        public LocalDriverBuilder() : this(new WebDriverFactory())
        {

        } 
        internal LocalDriverBuilder(WebDriverFactory factory)
        {
            this.factory = factory;
        }
        public virtual IWebDriver Launch(string browserTarget, string startingUrl)
        {
            var driver = CreateWebDriver(browserTarget);
            driver.Navigate().GoToUrl(startingUrl);
            return driver;  
        }

        private IWebDriver CreateWebDriver(string browserTarget)
        {
            switch (browserTarget)
            {
                case BrowserTarget.Chrome:
                    return factory.CreateLocalCromeDriver();
                default:
                    throw new NotSupportedException($"{browserTarget} is not supported.");
            }
        }
    }
}
