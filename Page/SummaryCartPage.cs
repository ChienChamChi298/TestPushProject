using OpenQA.Selenium;
namespace Page {
    public class SummaryCartPage : BasePage {
       
        private IWebElement ProcessToCheckOut = driver.FindElement(By.XPath("//a[@href='http://automationpractice.com/index.php?controller=order&step=1']")); 

        public AddressCartPage ClickButtonNext() {
            Click(ProcessToCheckOut); 
            return new AddressCartPage();
        } 
    }
}