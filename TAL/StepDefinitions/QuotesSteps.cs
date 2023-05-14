using OpenQA.Selenium;
using TAL.Pages;
using TAL.Tests.Models;
using TAL.Utils;
using TechTalk.SpecFlow;

namespace TAL.StepDefinitions;

[Binding]
public class QuotesSteps
{

    private readonly IWebDriver _driver;
    private HomePage _homePage;
    private QuotePage _quotePage;

    public QuotesSteps(IWebDriver driver)
    {
        _driver = driver;
    }

    [Given(@"I create a quote with the following details")]
    public void GivenICreateAQuoteWithTheFollowingDetails(Table table)
    {
        InsuranceApplicant applicant = new InsuranceApplicant
        {
            FirstName = table.Rows[0]["FirstName"],
            LastName = table.Rows[0]["LastName"],
            Gender = table.Rows[0]["Gender"],
            IsSmoker = Convert.ToBoolean(table.Rows[0]["IsSmoker"]),
            BirthDate = table.Rows[0]["BirthDate"],
            Occupation = table.Rows[0]["Occupation"],
            AnnualIncome = table.Rows[0]["AnnualIncome"],
            PhoneNumber = table.Rows[0]["PhoneNumber"],
            EmailAddress = table.Rows[0]["EmailAddress"],
            PostCode = table.Rows[0]["PostCode"]
        };
        
        CoverBuilderPage coverBuilderPage = new CoverBuilderPage(_driver);
        coverBuilderPage.CreateQuote(applicant);

        _quotePage = new QuotePage(_driver);
        _quotePage.WaitToLoadPage();
    }

    [When(@"I add Life Insurance with (.*) cover")]
    public void GivenIAddLifeInsuranceWithCover(int coverAmount)
    {
        _quotePage.AddLifeInsuranceButton.Click();
        _quotePage.SetCoverAmount(1500000);
        _quotePage.ConfirmButton.Click();
        _quotePage.WaitPremiumLoad();
    }

    [Then(@"The total monthly premium is (.*)")]
    public void ThenTheTotalMonthlyPremiumIs(float totalPremium)
    {
        float actual = float.Parse(_quotePage.TotalPremiumText.Text.Replace("$", String.Empty));
        Assert.That(actual, Is.EqualTo(totalPremium));
    }
}