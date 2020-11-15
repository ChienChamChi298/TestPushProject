using OpenQA.Selenium;

namespace Page {
    public class FinalCartPage : BasePage {
        private IWebElement OrderSuccessLabel = driver.FindElement(By.XPath("//ul[@id='order_step']//following-sibling::p"));   

        public string GetMessageSuccessfully() {
            return GetText(OrderSuccessLabel);
        }
    }
}