
using OpenQA.Selenium;
namespace Page{
    public class MyAccount : BasePage {
        
        private IWebElement SignOutButton = driver.FindElement(By.XPath("//div[@id='contact-link']//preceding-sibling::div[1]/a")); 
        private IWebElement UserNameLabel = driver.FindElement(By.XPath("//div[@id='contact-link']//preceding-sibling::div[2]/a")); 
        private IWebElement HomeLink = driver.FindElement(By.XPath("//div[@id='center_column']/ul/li"));     
        public AuthEmail  ClickSignOut() {
            Click(SignOutButton);   
            return new AuthEmail();
        } 

        public string DisplayNameUser() {
            return GetText(UserNameLabel);
        }

        public HomePage BackHomePage() {
            Click(HomeLink); 
            return new HomePage();
        } 
    }
}