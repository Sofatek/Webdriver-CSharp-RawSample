using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Automate1
{
    class Automate
    {
        public void Run()
        {
            // Instantiate ChromeDriver
            // (Chrome has to be installed on the computer)
            var options = new ChromeOptions();

            options.AddUserProfilePreference("profile.default_content_settings.popups", "0");
            options.AddUserProfilePreference("disable-popup-blocking", "true");

            var driver = new ChromeDriver(options);

            // Navigate to url
            string url = "https://wapractice.herokuapp.com/sample1";
            driver.Navigate().GoToUrl(url);

            driver.FindElement(By.Name("username")).SendKeys("test");
            driver.FindElement(By.Name("password")).SendKeys("password");
            driver.FindElement(By.CssSelector("form")).Submit();

            Thread.Sleep(1500);

            // Back to return to the form
            driver.Navigate().Back();

            driver.FindElement(By.Name("username")).SendKeys("test");
            driver.FindElement(By.Name("password")).SendKeys("password");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }
    }
}
