using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SeleniumAutmation.PageObjects
{
    class HomePage
    {
        IWebDriver driver;
        WebDriverWait wait;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        IWebElement SearchField {
            get {
                return driver.FindElement(By.XPath("//input[@name='q']"));
            }

        }

        IWebElement moreDropDown {
            get {
                return driver.FindElement(By.XPath("//button[@class='s-btn s-btn__muted s-btn__outlined s-btn__sm s-btn__dropdown']"));
            }

        }

        IWebElement scoreDropdown {
            get {
                return driver.FindElement(By.XPath("(//a[@class='mln12 mrn12 px12 py6 fl1 s-block-link'])[4]"));
            }
        }

        public String accepteAnswer() {
            //get {
                string a= driver.FindElement(By.XPath("//div[@class='s-post-summary--stats-item has-answers has-accepted-answer']")).ToString();
                return a;
            //}
        }



        public void EnterSearchText(string searchTerm)
        {
            driver.Manage().Window.Maximize();
            wait.Until(x => SearchField).SendKeys(searchTerm);
            SearchField.SendKeys(Keys.Return);
            wait.Until(x => moreDropDown).Click();
            System.Threading.Thread.Sleep(5000);
            wait.Until(x => scoreDropdown).Click();
            System.Threading.Thread.Sleep(5000);
            
        }

    }
}
