using OpenQA.Selenium;
using TAL.Utils;

namespace TAL.Pages;

public class QuotePage
{
    private readonly IWebDriver _driver;  

    public IWebElement AddLifeInsuranceButton =>
        _driver.FindElement(
            By.XPath("//button[@data-testid='add-cover-btn' and @name='Life Insurance Plan']"));
    
    public IWebElement AddTPDInsuranceButton =>
        _driver.FindElement(
            By.XPath("//button[@data-testid='add-cover-btn' and @name='TPD Insurance Plan']"));
    
    public IWebElement CoverAmountText =>
        _driver.FindElement(
            By.XPath("//input[@name='coverAmount']"));
    
    public IWebElement ConfirmButton =>
        _driver.FindElement(
            By.XPath("//button[@name='confirmButton']"));
    
    public IWebElement EstimatedPremiumText =>
        _driver.FindElement(
            By.XPath("//label[@name='estimatedPremium']"));
    
    public IWebElement CoverAmountChevron =>
        _driver.FindElement(
            By.XPath("//span[@name='ChevronUp']"));
    
    public IWebElement TotalPremiumText =>
        _driver.FindElement(
            By.XPath("//h3[@data-testid='total-premium']"));
    
    

    public QuotePage(IWebDriver driver)
    {
        _driver = driver;
    }
    
    public void WaitToLoadPage()
    {
        Helpers.WaitDisplayed(_driver, By.XPath("//h3[contains(text(), 'Add a benefit')]"));
    }

    public void WaitPremiumLoad()
    {
        Helpers.WaitDisplayed(_driver, By.XPath("//p[text()='Pay annually, and save']"));
    }

    public void SetCoverAmount(float coverAmount)
    {
        CoverAmountText.SendKeys(coverAmount.ToString());
        CoverAmountText.SendKeys(Keys.Tab);
        Helpers.WaitDisplayed(_driver, By.XPath("//span[@name=\"ChevronUp\" or @name=\"ChevronDown\"]"));
        CoverAmountChevron.Click();
    }

    
    
}