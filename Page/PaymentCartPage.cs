using OpenQA.Selenium;

namespace Page {
    public class PaymentCartPage : BasePage {
        private IWebElement PayByCheckLink = driver.FindElement(By.XPath("//*[contains(text(), 'Pay by check')]")); 
        
        public ConfirmCartPage PayByCheck() {   
            Click(PayByCheckLink); 
            return new ConfirmCartPage();
        }  

    }
}