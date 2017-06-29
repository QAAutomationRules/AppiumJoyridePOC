using Applitools.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace JoyRidePOC.Steps
{
    [Binding]
    public sealed class TransunionHomePageSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        IWebDriver driver = ScenarioContext.Current.Get<IWebDriver>("WebDriver");
        Eyes eyes = ScenarioContext.Current.Get<Eyes>("Eyes");

        [Given(@"I navigate to the ""(.*)"" Home Page")]
        public void GivenINavigateToTheHomePage(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.XPath("//div[contains(text(),'Contact Us')]"));

        }

        [Given(@"the Transunion Home Page is displayed correctly on mobile browsers (.*)")]
        public void GivenTheTransunionHomePageIsDisplayedCorrectlyOnMobileBrowsersMobileChromePixelPhone(string mobileBrowser)
        {
            ScenarioContext.Current.Set<string>(mobileBrowser, "MobileBrowser");
            ScenarioContext.Current.Set<Size>(Helpers.GetBrowserSize(mobileBrowser, driver), "Size");
        }


        [When(@"the Base Home Page Image is Compared to the Current Home Page Image")]
        public void WhenTheBaseHomePageImageIsComparedToTheCurrentHomePageImage()
        {
            try
            {
                // Start the test 
                eyes.Open(driver, "Transunion Website", "Transunion Home Page",
                    ScenarioContext.Current.Get<Size>("Size"));

                driver.FindElement(By.XPath("//div[contains(text(),'Contact Us')]"));

                // Visual checkpoint #1.
                eyes.CheckWindow("TU Home Page");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        [When(@"the Base Mobile Home Page Image is Compared to the Current Home Page Image")]
        public void WhenTheBaseMobileHomePageImageIsComparedToTheCurrentHomePageImage()
        {
            try
            {
                // Start the test 
                eyes.Open(driver, "Transunion Website", "Transunion Mobile Home Page");

                driver.FindElement(By.XPath("//div[contains(text(),'Contact Us')]"));

                // Visual checkpoint #1.
                eyes.CheckWindow("TU Home Page");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        [Then(@"the Home Page images should match correctly")]
        public void ThenTheHomePageImagesShouldMatchCorrectly()
        {
        }

        //// Click the "My Credit Score & Report" button.
        //driver.FindElement(By.XPath("//span[contains(text(),'My Credit Score & Report')]")).Click();

        //// Visual checkpoint #2.
        //eyes.CheckWindow("My Credit Score & Report");

    }
}

