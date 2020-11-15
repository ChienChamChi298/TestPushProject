using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Page {
    public class BasePage {
        protected  static IWebDriver driver; 
        

        public HomePage SetUp() { 
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver =  new ChromeDriver(); 
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php"); 
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(20);  
            driver.Manage().Window.Maximize();
            return new HomePage();
        } 

        public void WaitForVisibility(IWebElement e) {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); 
            wait.Until(drv => e);
        }

        public void Click(IWebElement e) {
            WaitForVisibility(e); 
            e.Click();
        } 

        public void SendKey(IWebElement e, string text) {
            WaitForVisibility(e);  
            e.SendKeys(text); 
        }  

        public void Select(IWebElement e, string text) {
            WaitForVisibility(e);  
            e.Click(); 
            e.SendKeys(text); 
            e.SendKeys(Keys.Enter); 
        }  

        public void HoverAndClick(IWebElement hover, IWebElement click) { 
            WaitForVisibility(hover); 
            Actions action = new Actions(driver); 
            action.MoveToElement(hover).Click(click).Build().Perform(); 
        }

        public string GetText(IWebElement e) { 
            WaitForVisibility(e); 
            return e.Text;
        }

        public void ClearText(IWebElement e) {
            WaitForVisibility(e);  
            e.Clear(); 
        }  

        public void ShutDown() {
            driver.Quit();
        } 


    }
}