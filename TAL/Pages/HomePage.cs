using OpenQA.Selenium;

namespace TAL.Pages;

public class HomePage
{
    private readonly IWebDriver _driver;  
    private const String Url = "https://www.tal.com.au/";

    public IWebElement GetAQuoteLink =>
        _driver.FindElement(
            By.XPath("//div[contains(@class, \"p-navigation\")]//a[contains(text(), \"GET A QUOTE\")]"));
    
    public IWebElement InsuranceProductsLink => _driver.FindElement(
        By.XPath("//nav[@id=\"nav\"]//a[text()=\"Insurance Products\"]"));
    
    public IWebElement LifeInsuranceLink => _driver.FindElement(
        By.XPath("//nav[@id=\"nav\"]//a[contains(text(),\"Life Insurance\")]"));
    
    public IWebElement LifeInsuranceQuoteLink => _driver.FindElement(
        By.XPath("//div[@id='Get-a-quote']//div[@class='btn-holder']//a[text()='Get a quote']"));
    
    public IWebElement ContactUsLink => _driver.FindElement(
        By.XPath("//a[text()='Contact us']"));

    public HomePage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void GoTo()
    {
        _driver.Navigate().GoToUrl(Url);
    }
    

    
    
}