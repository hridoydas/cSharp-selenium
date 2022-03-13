using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumAutmation.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAutmation.Tests
{
    public class StackOverflowTest: BaseTest
    {
        IWebDriver driver;
        WebDriverWait wait;

        public StackOverflowTest(string browser)
            : base(browser)
        {

        }
        [Test]
        [Category("StackOverflow")]
        public void stackOverflow()
        {
            using (var driver = InitializeDriver()) {
                try {
                    driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);
                    driver.Manage().Window.Maximize();
                    System.Threading.Thread.Sleep(2000);
                    //List<string> list = new List<string>();
                    //ICollection<IWebElement> elements = driver.FindElements(By.XPath("//a[@class='-marketing-link js-gps-track']"));
                    //foreach (IWebElement element in elements) { 
                    //    //var e = element as IWebElement;
                    //    //Console.WriteLine(element.Text);
                    //    list.Add(element.Text);


                    //}
                    //Console.WriteLine(list[0]);

                    driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("selenium");
                    System.Threading.Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//input[@name='q']")).SendKeys(Keys.Return);
                    System.Threading.Thread.Sleep(10000);
                    driver.FindElement(By.XPath("//button[@class='s-btn s-btn__muted s-btn__outlined s-btn__sm s-btn__dropdown']")).Click();
                    System.Threading.Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//a[contains(.,'Score')]")).Click();
                    System.Threading.Thread.Sleep(2000);
                    ICollection<IWebElement> elements = driver.FindElements(By.XPath("//div[@class='s-post-summary--stats-item has-answers has-accepted-answer']"));
                    List<string> list = new List<string>();
                    string[] items = new string[400];
                    foreach (IWebElement element in elements) {
                        
                        list.Add(element.Text);
                        
                        //Console.WriteLine(element.Text + "======> \n");
                        if((element.Text.Contains("17"))|| (element.Text.Contains("18"))|| (element.Text.Contains("19"))) {
                            Console.WriteLine(element.Text + "======> \n");
                        }
                    }


                    System.Threading.Thread.Sleep(2000);

                }
                finally {
                    commonUtils.PrintLogs("browser", driver);
                }

            }
        }
    }
}
