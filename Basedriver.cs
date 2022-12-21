using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject.Drivers
{
    public class Basedriver
    {
        public IWebDriver driver;
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://weather.com");
            driver.Manage().Window.Maximize();

        }
        public void closedriver()
        {
            driver.Quit();
        }
    }
}
