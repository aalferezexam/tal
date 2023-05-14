using OpenQA.Selenium;
using TAL.Pages;
using TechTalk.SpecFlow;

namespace TAL.StepDefinitions;

[Binding]
public class ContactSteps
{
    private readonly IWebDriver _driver;
    private ContactUsPage _contactUsPage;

    public ContactSteps(IWebDriver driver)
    {
        _driver = driver;
        _contactUsPage = new ContactUsPage(driver);
    }
    
    [Given(@"I create a general enquiry with the following details")]
    public void GivenICreateAMessageWithTheFollowingDetails(Table table)
    {
        string name = table.Rows[0]["Name"];
        string email = table.Rows[0]["Email"];
        string phone = table.Rows[0]["Phone"];
        string query = table.Rows[0]["Query"];
        
        _contactUsPage.NameText.SendKeys(name);
        _contactUsPage.EmailText.SendKeys(email);
        _contactUsPage.PhoneText.SendKeys(phone);
        _contactUsPage.GeneralEnquiryDropdown.Click();
    }
}