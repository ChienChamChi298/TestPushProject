using OpenQA.Selenium; 

namespace Page { 
    public class HomePage : BasePage {
        private IWebElement ButtonSignIn = driver.FindElement(By.XPath("//div[@id='contact-link']//preceding-sibling::div/a"));
        private IWebElement TShirtLink = driver.FindElement(By.XPath("//div[@id='block_top_menu']/ul/li[3]"));

        public AuthEmail ClickSignIn() {
           Click(ButtonSignIn); 
           return new AuthEmail();
        } 

        public TShirtPage ClickNavigateTShirt() {
            Click(TShirtLink); 
            return new TShirtPage();
        }
    }
}