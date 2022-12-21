using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using WeatherProject.Drivers;
using WeatherProject.Pages;

namespace WeatherProject.StepDefinitions
{

    [Binding]
    public class HomepageFeatureStepDefinitions : Basedriver
    {
        //Basedriver baseDriver;
        homepageclass h;

        [Given(@"Website must be open")]
        public void GivenWebsiteMustBeOpen()
        {

            Setup();
            Thread.Sleep(3000);
        }

        [When(@"I click on today button")]
        public void WhenIClickOnTodayButton()
        {
           h = new homepageclass(driver);
           h.Today.Click();
            driver.Navigate().Back();   


        }

        [Then(@"Today page will open")]
        public void ThenTodayPageWillOpen()
        {
            Task.Delay(1000).Wait();    
          
          
        }

        //Scenario2
        [Given(@"Website must be provided")]
        public void GivenWebsiteMustBeProvided()
        {
            
            h = new homepageclass(driver);
            //Task.Delay(1000).Wait();


        }

        [When(@"User able to click Times of India button")]
        public void WhenUserAbleToClickTimesOfIndiaButton()
        {
            Setup();
           // h = new homepageclass(driver);
            h.TimesofIndia.Click();
        }

        [Then(@"page must be redirected to homepage")]
        public void ThenPageMustBeRedirectedToHomepage()
        {
            driver.Navigate().Back();
        }









    }
}
