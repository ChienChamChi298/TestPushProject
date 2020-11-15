using OpenQA.Selenium;

namespace Page { 
    public class CreateAccount : BasePage {
        private string password = "chien123456";  
        private string firstname = "Chien"; 
        private string lastname = "Nguyen"; 
        private string address = "Florida Museum";
        private string city = "Tallahassee"; 
        private string state = "Floria";  
        private string zipcode = "33936"; 
        private string phone = "0123564762"; 
        private string anotherEmail = "anotheremail@gmail.com"; 

        private IWebElement FirstNameTextBox = driver.FindElement(By.XPath("//*[@id='customer_firstname']"));
        private IWebElement LastNameTextBox=  driver.FindElement(By.Id("customer_lastname"));
        private IWebElement PasswordTextBox=  driver.FindElement(By.Id("passwd"));
        private IWebElement FirstNameTextBox2=  driver.FindElement(By.Id("firstname"));
        private IWebElement LastNameTextBox2 =  driver.FindElement(By.Id("lastname"));
        private IWebElement AddressTextBox =  driver.FindElement(By.Id("address1"));  
        private IWebElement CityTextBox =  driver.FindElement(By.Id("city"));  
        private IWebElement StateSelectBox = driver.FindElement(By.Id("id_state")); 
        private IWebElement ZipCodeTextBox =  driver.FindElement(By.Id("postcode"));  
        private IWebElement PhoneTextBox = driver.FindElement(By.Id("phone_mobile")); 
        private IWebElement AnotherEmailTextBox = driver.FindElement(By.Id("alias"));  
        private IWebElement SubmitButton = driver.FindElement(By.Id("submitAccount")); 

        public CreateAccount FillAllReqireField() {
            SendKey(FirstNameTextBox, firstname); 
            SendKey(LastNameTextBox, lastname); 
            SendKey(PasswordTextBox, password); 
            SendKey(FirstNameTextBox2, firstname); 
            SendKey(LastNameTextBox2, lastname);  
            SendKey(AddressTextBox, address);   
            SendKey(CityTextBox, city);  
            Select(StateSelectBox, state);
            SendKey(ZipCodeTextBox, zipcode); 
            SendKey(PhoneTextBox, phone); 
            ClearText(AnotherEmailTextBox); 
            SendKey(AnotherEmailTextBox, anotherEmail); 
            return this;
        } 

        public MyAccount Submit() {
            Click(SubmitButton);  
            return new MyAccount();
        } 
        
        public string GetName() {
            return firstname + " " + lastname;
        }

        public string GetPassword() {
            return password;
        } 

    }
}