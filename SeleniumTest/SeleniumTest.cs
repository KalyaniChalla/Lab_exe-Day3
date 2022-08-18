using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Threading;

namespace Lab_exe
{
[TestClass]
public class SeleniumTest
 {
/*
   [DataTestMethod]
   [DataRow("CH","https://www.demoblaze.com")]
   public void LaunchBrowser(string browsername,string url)
   {
    IWebDriver driver;
    if(browsername=="CH")
    {
        driver =new ChromeDriver(@"C:\RootFolder\IWebDriver");
    }
        driver.Navigate().GoToUrl(url);
        Thread.Sleep(5000);
        driver.Quit();
   }
*/
    /*[TestMethod]
    
     public void TestMethod2()
        {
            IWebDriver driver= new ChromeDriver(@"C:\RootFolder\IWebDriver");
            driver.Navigate().GoToUrl("https://www.demoblaze.com");
            IWebElement Contact=driver.FindElement(By.LinkText("Contact"));
            Contact.Click();
            Thread.Sleep(5000);
        } */

         
     /*[DataTestMethod]
        [DataRow("asdhge@gmail.com","asdhge","Hello Store")]
        public void LaunchBrowser(string op1, string op2, string op3)
       {
        IWebDriver driver;
        driver =new ChromeDriver(@"C:\RootFolder\IWebDriver");
         driver.Navigate().GoToUrl("https://www.demoblaze.com/");
        IWebElement Contact=driver.FindElement(By.LinkText("Contact")); 
        Contact.Click();
        Thread.Sleep(5000);

        IWebElement ContactEmail=driver.FindElement(By.Id("recipient-email")); 
        ContactEmail.SendKeys(op1);
        Thread.Sleep(2000);

        IWebElement ContactName=driver.FindElement(By.Id("recipient-name")); 
        ContactName.SendKeys(op2);
        Thread.Sleep(2000);

        IWebElement Message=driver.FindElement(By.Id("message-text")); 
        Message.SendKeys(op3);
        Thread.Sleep(5000);
   }
   */

   [DataTestMethod]
   [DataRow("CH","qwerty@gmail.com","qwerty","Hello qwerty")]
   [DataRow("FF","asdfgh@gmail.com","asdfgh","Hello asdfgh")]
   [DataRow("Edge","zxcvbn@gmail.com","zxcvbn","Hello zxcvbn")]
   public void LaunchBrowser(string op1, string op2, string op3, string op4)
   {
    IWebDriver driver;
    if(op1=="CH")
    {
     driver= new ChromeDriver(@"C:\RootFolder\IWebDriver");
    }
    else if(op1=="FF")
    {
        driver= new FirefoxDriver(@"C:\RootFolder\IWebDriver");
    }
    else
    {
        driver= new EdgeDriver(@"C:\RootFolder\IWebDriver");
    }
    driver.Navigate().GoToUrl("https://www.demoblaze.com/");
        IWebElement Contact=driver.FindElement(By.LinkText("Contact")); 
        Contact.Click();
        Thread.Sleep(5000);

        IWebElement ContactEmail=driver.FindElement(By.Id("recipient-email")); 
        ContactEmail.SendKeys(op2);
        Thread.Sleep(5000);

        IWebElement ContactName=driver.FindElement(By.Id("recipient-name")); 
        ContactName.SendKeys(op3);
        Thread.Sleep(5000);

        IWebElement Message=driver.FindElement(By.Id("message-text")); 
        Message.SendKeys(op4);
        Thread.Sleep(5000);
        driver.Quit();

        /*IWebElement Close=driver.FindElement(By.XPath("//button[text()='Send message']//preceding-sibiling::button[text()='Close']")); 
        Close.Click();
        Thread.Sleep(5000);
        driver.Quit();
        */
   }

 }
}