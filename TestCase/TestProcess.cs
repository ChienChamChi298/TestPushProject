using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Page
{
    public class TestProcess
    {   
        private BasePage basePage ; 
        private HomePage homePage; 
       
        private AuthEmail authEmail;

        private CreateAccount createAccount;  

        private MyAccount myAccount;
        
        private TShirtPage tShirtPage;    

        private AddressCartPage addressCart; 

        private PaymentCartPage paymentCart; 

        private ShippingCartPage shippingCart; 

        private SummaryCartPage summaryCart;  

        private ConfirmCartPage confirmCart;  

        private FinalCartPage finalCart;

        [Fact] 
        public void CheckProcessLoginSuccessfully_1()
        {   
            basePage = new BasePage();
            homePage = basePage.SetUp();  
            
            authEmail = homePage.ClickSignIn(); 
            createAccount = authEmail.SendText();
            createAccount.FillAllReqireField(); 
            myAccount = createAccount.Submit();   
            authEmail = myAccount.ClickSignOut(); 
        
            String email = authEmail.GetEmail();
            String password = createAccount.GetPassword(); 
            myAccount = authEmail.Login(email, password);  

            String actualName = myAccount.DisplayNameUser(); 
            String expectName = createAccount.GetName(); 
            

            Assert.Equal(actualName, expectName);
            Console.WriteLine(actualName, expectName);
            basePage.ShutDown();
        } 

        [Fact] 
        public void CheckProcessPaymentByCheckSuccessfully_2() { 
            basePage = new BasePage(); 
            homePage = basePage.SetUp();  
            authEmail = homePage.ClickSignIn();   

            string email = "chienduc298183@gmail.com"; 
            string password = "chien123456"; 
            
            myAccount = authEmail.Login(email, password); 
            homePage = myAccount.BackHomePage(); 
            tShirtPage = homePage.ClickNavigateTShirt(); 
            tShirtPage = tShirtPage.ClickAddToCart(); 
            summaryCart = tShirtPage.ClickProcessCheckOut(); 
            addressCart = summaryCart.ClickButtonNext(); 
            shippingCart = addressCart.ClickButtonNext(); 
            paymentCart = shippingCart.AgreeWithTerm().ClickButtonNext(); 
            confirmCart = paymentCart.PayByCheck();  
            finalCart = confirmCart.ConfirmOrders();   

            string expectMessage = "Your order on My Store is complete.";
            string actualMessage = finalCart.GetMessageSuccessfully();
            Assert.Equal(actualMessage, expectMessage);

        }
    }
}
