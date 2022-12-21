using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherProject.Drivers;

namespace WeatherProject.Pages
{
    public class homepageclass : Basedriver
    {
        
        public homepageclass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"WxuContentMedia-main-9a569883-261d-4754-b982-44d8abc1e0b6\"]/section/div[1]/div[1]/div/a/div[1]/div[2]")]
        public IWebElement Today;  // Todays weather


        [FindsBy(How = How.XPath, Using = "//*[@id=\"labClick\"]/img")]
        public IWebElement TimesofIndia;  





        




    }
}
