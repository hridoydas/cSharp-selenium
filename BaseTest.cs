using System;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAutmation.SeleniumUtils;

namespace SeleniumAutmation
{
    [TestFixture(BrowserTarget.Chrome)]
    public abstract class BaseTest
    {
        protected LocalDriverBuilder builder;
        protected string startingUrl;
        protected string epochStartTime;
        protected string targetBrowser;
        protected CommonUtils commonUtils = new CommonUtils();
        
         protected BaseTest(string browser)
        {
            this.targetBrowser = browser;
            this.epochStartTime = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
        }

        public IWebDriver InitializeDriver()
        {
            LocalDriverBuilder builder = new LocalDriverBuilder();
            this.startingUrl = "https://stackoverflow.com/";
            var driver = builder.Launch(targetBrowser, this.startingUrl);
            return driver;

        }
    }
}
