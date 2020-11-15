using OpenQA.Selenium;

namespace Page {
    public class TShirtPage : BasePage {
        private IWebElement ProductHover = driver.FindElement(By.XPath("//div[@id='center_column']/ul/li"));
        private IWebElement AddToCartButton = driver.FindElement(By.XPath("//a[@data-id-product='1']")); 
        private IWebElement ProcessToCheckOut = driver.FindElement(By.XPath("//div[@id='layer_cart']//child::span[contains(text(),'checkout')]")); 
        public TShirtPage ClickAddToCart() {
            HoverAndClick(ProductHover, AddToCartButton); 
            return this;
        }  

        public  SummaryCartPage ClickProcessCheckOut() {
            Click(ProcessToCheckOut); 
            return new SummaryCartPage();
        }
    }
}