using OpenQA.Selenium;

namespace Page {
    public class ConfirmCartPage : BasePage {
        private IWebElement ConfirmButton = driver.FindElement(By.XPath("//ul[@id='order_step']//following-sibling::form/p/button"));    
        
        public FinalCartPage ConfirmOrders() {
            Click(ConfirmButton); 
            return new FinalCartPage(); 
        }      

    }
}