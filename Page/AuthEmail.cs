using System;
using OpenQA.Selenium;
namespace Page { 
    public class AuthEmail : BasePage{
        private static string email ; /*= "chienduc298183@gmail.com / chien123456" ; */  

        private IWebElement EmailTextBox = driver.FindElement(By.Id("email_create"));  
        private IWebElement SubmitButton = driver.FindElement(By.Id("SubmitCreate"));  

        private IWebElement UserEmailTextBox = driver.FindElement(By.Id("email"));   
        private IWebElement PasswordTextBox = driver.FindElement(By.Id("passwd"));   
        private IWebElement LoginButton = driver.FindElement(By.Id("SubmitLogin"));  
       
        private string InitEmail() {
            Random rd = new Random();
            int random = rd.Next(100,200);
            return  "chienduc298" + random + "@gmail.com"; 
        }


        public CreateAccount SendText() { 
             email = InitEmail();
             SendKey(EmailTextBox, email); 
             Click(SubmitButton); 
             return new CreateAccount();
        } 


        public MyAccount Login(string email, string password) {  
            SendKey(UserEmailTextBox, email);  
            SendKey(PasswordTextBox, password); 
            Click(LoginButton);  
            return new MyAccount();
        }   



        public string GetEmail() {
            return email;
        }

    }
} 

