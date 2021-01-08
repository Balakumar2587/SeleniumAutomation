using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;
using System.Configuration;
using System.Collections.Specialized;

namespace SeleniumAutomation
{
    [TestClass]
    public class Initialclass
    {
        [TestMethod]
        public void Invoke()
        {
           
                IWebDriver webdriver = new ChromeDriver();
                webdriver.Manage().Window.Maximize();
                webdriver.Navigate().GoToUrl("https://visualstudio.microsoft.com/");
                webdriver.FindElements(By.CssSelector("button[id*='search']"))[0].Click();
                webdriver.FindElement(By.XPath("//*[@id='cli_shellHeaderSearchInput']")).SendKeys("visual studio community");
                webdriver.FindElement(By.Id("search")).Click();
                webdriver.FindElement(By.XPath("//*[@id='content']/div[2]/div/div/div/div[1]/div[1]/h2/a")).Click();


                webdriver.Close();
                webdriver.Dispose();
            
        }
    }
}
