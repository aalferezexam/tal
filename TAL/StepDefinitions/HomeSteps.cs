using OpenQA.Selenium;
using TAL.Pages;
using TAL.Tests.Models;
using TAL.Utils;
using TechTalk.SpecFlow;

namespace TAL.StepDefinitions;

[Binding]
public class HomeSteps
{

    private readonly IWebDriver _driver;
    private HomePage _homePage;
    private QuotePage _quotePage;

    public HomeSteps(IWebDriver driver)
    {
        _driver = driver;
    }
    
    [Given(@"I am on the home page")]
    public void GivenIAmOnTheHomePage()
    {
        _homePage = new HomePage(_driver);
        _homePage.GoTo();
    }

    [Given(@"I navigate to the quote page")]
    public void GivenINavigateToTheQuotePage()
    {
        _homePage.GetAQuoteLink.Click();
    }
    
    [Given(@"I navigate to the insurance page and make a quote")]
    public void GivenINavigateToTheInsurancePageAndMakeAQuote()
    {
        _homePage.InsuranceProductsLink.Click();
        _homePage.LifeInsuranceLink.Click();
        _homePage.LifeInsuranceQuoteLink.Click();
    }

    [Given(@"I navigate to the contact us page")]
    public void GivenINavigateToTheContactUsPage()
    {
        _homePage.ContactUsLink.Click();

        ContactUsPage contactUsPage = new ContactUsPage(_driver);
        contactUsPage.WaitForPage();
    }
}