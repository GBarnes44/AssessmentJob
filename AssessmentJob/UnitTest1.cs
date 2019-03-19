using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;

namespace AssessmentJob
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            // Open Browser //

            var driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("https://www.aaalife.com/term-life-insurance-quote-input");
            System.Threading.Thread.Sleep(3000);
            Actions act = new Actions(driver);
            driver.Manage().Window.Maximize();

            // Add ZIP CODE //

            driver.FindElementByXPath("//input[@id='zip']").SendKeys("48237");
            System.Threading.Thread.Sleep(3000);

            // Gender Selection //

            var gender = driver.FindElementById("gender");
            var selectElement_gen = new SelectElement(gender);
            System.Threading.Thread.Sleep(3000);
            selectElement_gen.SelectByText("Male");
            System.Threading.Thread.Sleep(3000);

            // Date Of Birth //

            // Month //
            var month = driver.FindElementById("month");
            var selectElement_month = new SelectElement(month);
            System.Threading.Thread.Sleep(3000);
            selectElement_month.SelectByText("October");
            System.Threading.Thread.Sleep(3000);

            // Day //
            var day = driver.FindElementById("day");
            var selectElement_day = new SelectElement(day);
            System.Threading.Thread.Sleep(3000);
            selectElement_day.SelectByText("19");
            System.Threading.Thread.Sleep(3000);

            // Year //
            var year = driver.FindElementById("year");
            var selectElement_year = new SelectElement(year);
            System.Threading.Thread.Sleep(3000);
            selectElement_year.SelectByText("1978");
            System.Threading.Thread.Sleep(3000);

            // AAA Member (Yes or No radio) //

            driver.FindElementByXPath("//label[@for='isMemberNo']").Click();
            System.Threading.Thread.Sleep(3000);

            // Email account //

            driver.FindElementById("contact_email").SendKeys("gary.m.barnes@outlook.com");
            System.Threading.Thread.Sleep(3000);

            // Height and Weight //

            // Height in Feet //
            var feet = driver.FindElementById("feet");
            var selectElement_feet = new SelectElement(feet);
            System.Threading.Thread.Sleep(3000);
            selectElement_feet.SelectByText("6");
            System.Threading.Thread.Sleep(3000);

            // Height in Inches //
            var inches = driver.FindElementById("inches");
            var selectElement_inches = new SelectElement(inches);
            System.Threading.Thread.Sleep(3000);
            selectElement_inches.SelectByText("3");
            System.Threading.Thread.Sleep(3000);

            // Weight //
            driver.FindElementById("weight").SendKeys("218");
            System.Threading.Thread.Sleep(3000);

            // Nicotine radio //

            driver.FindElementByXPath("//label[@for='nicotineUseNo']").Click();
            System.Threading.Thread.Sleep(3000);

            // Rate of Health //

            var rate = driver.FindElementById("rateYourHealth");
            var selectElement_rate = new SelectElement(rate);
            System.Threading.Thread.Sleep(3000);
            selectElement_rate.SelectByText("Excellent");
            System.Threading.Thread.Sleep(3000);

            // Coverage Ammount //
            var cover = driver.FindElementById("coverageAmount");
            var selectElement_cover = new SelectElement(cover);
            System.Threading.Thread.Sleep(3000);
            selectElement_cover.SelectByText("$650,000");
            System.Threading.Thread.Sleep(3000);

            // Term Length //
            var term = driver.FindElementById("termLength");
            var selectElement_term = new SelectElement(term);
            System.Threading.Thread.Sleep(3000);
            selectElement_term.SelectByText("10 Years");
            System.Threading.Thread.Sleep(3000);

            // Select Quote Options //

            driver.FindElementById("seeQuote").Click();
            System.Threading.Thread.Sleep(10000);

            // Login //

            driver.FindElementByXPath("//div[@class='top-nav large-12 columns']//a[@class='login btn'][contains(text(),'Log In')]").Click();
            System.Threading.Thread.Sleep(3000);

            // User //
            driver.FindElementByXPath("//input[@name='pageForm:formUserid']").SendKeys("Name");
            System.Threading.Thread.Sleep(3000);
            // Password //
            driver.FindElementByXPath("//input[@id='pageForm:formPassword']").SendKeys("Pa$$word");
            System.Threading.Thread.Sleep(3000);

            //driver.Quit();
        }
    }
}
