using OpenQA.Selenium;

namespace Page {
    public class AddressCartPage : BasePage {
       
        private IWebElement ProcessToCheckOut = driver.FindElement(By.Name("processAddress")); 

        public ShippingCartPage ClickButtonNext() {
            Click(ProcessToCheckOut); 
            return new ShippingCartPage();
        } 
    }
}