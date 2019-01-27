using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Amazon.StepsDefinitions
{
    [Binding]
    public sealed class ProductDetailsSteps
    {
        IWebDriver driver;

        [Given(@"I navigate to the Amazon homepage")]
        public void GivenINavigateToTheAmazonHomepage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.co.uk");
        }

        [Given(@"I search for wrist watch and I click on one of the search result displayed")]
        public void GivenISearchForWristWatchAndIClickOnOneOfTheSearchResultDisplayed()
        {
            
        }

        [Then(@"the product price is displayed")]
        public void ThenTheProductPriceIsDisplayed()
        {
            
        }

    }
}
