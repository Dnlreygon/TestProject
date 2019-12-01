using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestProyect
{
    [Binding]
    public class TestProyectSteps
    {

        IWebDriver driver;

        [Given(@"Open google web browser")]
        public void GivenOpenGoogleWebBrowser()
        {
            driver = new ChromeDriver();
           
        }
        
        [When(@"I navigate to google page")]
        public void WhenINavigateToGooglePage()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
        [Then(@"Validate search bar is Displayed\.")]
        public void ThenValidateSearchBarIsDisplayed_()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//input[@name='q']")).Displayed,"Search is not display"); ;
        }
             

        [Then(@"Validate google logo is displayed")]
        public void ThenValidateGoogleLogoIsDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//img[@id='hplogo']")).Displayed,"Google logo is not display");
        }

        [When(@"Search ""(.*)""")]
        public void WhenSearch(string searchText)
        {
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys(searchText);
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys(Keys.Enter);
        }
        [When(@"Search for ""(.*)""")]
        public void WhenSearchFor(string searchText2)
        {
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys(searchText2);
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys(Keys.Enter);
        }

        [Then(@"Validate youtube results are down")]
        public void ThenValidateYoutubeResultsAreDown()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='res']")).Displayed,"Not results were found");
        }

        [Then(@"Validate google results are down")]
        public void ThenValidateGoogleResultsAreDown()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='res']")).Displayed,"Not results were found");
        }

               [AfterScenario]

        public void finalization()
        {
            driver.Quit();
        }
    }
}
