using OpenQA.Selenium;
using TAL.Utils;

namespace TAL.Pages;

public class ContactUsPage

{
    private readonly IWebDriver _driver;

    public IWebElement NameText => _driver.FindElement(By.XPath("//label[text()='Name']/following-sibling::input"));
    public IWebElement EmailText => _driver.FindElement(By.XPath("//label[text()='Email']/following-sibling::input"));
    public IWebElement PhoneText => _driver.FindElement(By.XPath("//label[text()='Phone']/following-sibling::input"));
    public IWebElement GeneralEnquiryDropdown => _driver.FindElement(By.XPath("//label[text()='I want to']/following-sibling::select//option[@value='Make a general enquiry']"));

    public ContactUsPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void WaitForPage()
    {
        Helpers.WaitDisplayed(_driver, By.XPath("//h1[text()='Contact us']"));
    }

    

    
    
}