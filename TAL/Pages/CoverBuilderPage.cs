using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TAL.Tests.Models;
using TAL.Utils;

namespace TAL.Pages;

public class CoverBuilderPage
{
    private readonly IWebDriver _driver;
    private readonly WebDriverWait _wait;
    
    public IWebElement DateOfBirthInput => _driver.FindElement(By.Name("dateOfBirth"));

    public IWebElement GenderRadioInputM => _driver.FindElement(By.XPath("//input[@name=\"genderRadio\" and @value=\"M\"]/following-sibling::div"));
    public IWebElement GenderRadioInputF => _driver.FindElement(By.XPath("//input[@name=\"genderRadio\" and @value=\"F\"]/following-sibling::div"));
    
    public IWebElement IsSmokerRadioInputY => _driver.FindElement(By.XPath("//input[@name=\"isSmoker\" and @value=\"true\"]/following-sibling::div"));
    public IWebElement IsSmokerRadioInputN => _driver.FindElement(By.XPath("//input[@name=\"isSmoker\" and @value=\"false\"]/following-sibling::div"));
    
    public IWebElement OccupationText => _driver.FindElement(By.Name("occupation"));
    public IWebElement IsSelfEmployedCheckbox => _driver.FindElement(By.XPath("//input[@name=\"isSelfEmployed\"]/following-sibling::div"));
    public IWebElement AnnualIncomeText => _driver.FindElement(By.Name("annualIncome"));

    public IWebElement OccupationChevron => _driver.FindElement(By.XPath("//span[@name=\"ChevronUp\" or @name=\"ChevronDown\"]"));
    public IWebElement ContinueButton => _driver.FindElement(By.Name("continue"));
    public IWebElement FirstNameText => _driver.FindElement(By.Name("firstName"));
    public IWebElement LastNameText => _driver.FindElement(By.Name("lastName"));
    public IWebElement PhoneNumberText => _driver.FindElement(By.Name("phoneNumber"));
    public IWebElement EmailAddressText => _driver.FindElement(By.Name("emailAddress"));
    public IWebElement PostCodeText => _driver.FindElement(By.Name("postcode"));
    
    public IWebElement CalculateMyQuoteButton => _driver.FindElement(By.XPath("//button[@data-testid=\"calculate-my-quote\"]"));
    


    public CoverBuilderPage(IWebDriver driver)
    {
        _driver = driver;
        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
    }

    public void WaitToLoadPage1()
    {
        Helpers.WaitDisplayed(_driver, By.XPath("//small[text()=\"Step 1 of 2\"]"));
    }

    public void WaitToLoadPage2()
    {
        Helpers.WaitDisplayed(_driver, By.XPath("//small[text()=\"Step 2 of 2\"]"));
    }

    public void SetOccupation(String occupation)
    {
        OccupationText.Click();
        OccupationText.SendKeys(occupation);
        Helpers.WaitDisplayed(_driver, By.XPath("//span[@name=\"ChevronUp\" or @name=\"ChevronDown\"]"));
        OccupationChevron.Click();
    }

    public void CreateQuote(InsuranceApplicant applicant)
    { 
        // Page 1
        WaitToLoadPage1();
        DateOfBirthInput.Click();
        DateOfBirthInput.SendKeys(applicant.BirthDate);
        
        GenderRadioInputM.Click();
        
        IsSmokerRadioInputN.Click();
        SetOccupation(applicant.Occupation);
        
        IsSelfEmployedCheckbox.Click();
        
        AnnualIncomeText.Click();
        AnnualIncomeText.SendKeys(applicant.AnnualIncome);
        
        ContinueButton.Click();
        
        // Page 2
        WaitToLoadPage2();
        FirstNameText.Click();
        FirstNameText.SendKeys(applicant.FirstName);
        
        LastNameText.Click();
        LastNameText.SendKeys(applicant.LastName);
        
        PhoneNumberText.Click();
        PhoneNumberText.SendKeys(applicant.PhoneNumber);
        
        EmailAddressText.Click();
        EmailAddressText.SendKeys(applicant.EmailAddress);
        
        PostCodeText.Click();
        PostCodeText.SendKeys(applicant.PostCode);
        
        CalculateMyQuoteButton.Click();
    }
    
}