using OpenQA.Selenium;

namespace Page {
    public class ShippingCartPage : BasePage {
       
        private IWebElement ProcessToCheckOut = driver.FindElement(By.Name("processCarrier")); 
        private IWebElement TermCheckBox = driver.FindElement(By.Name("cgv")); 
        public PaymentCartPage ClickButtonNext() {  
            Click(ProcessToCheckOut); 
            return new PaymentCartPage();
        }  
        public ShippingCartPage AgreeWithTerm() {
            Click(TermCheckBox); 
            return this;
        }  

    }
}