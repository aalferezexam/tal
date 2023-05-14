using System.ComponentModel;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TAL.StepDefinitions;
using TechTalk.SpecFlow;

namespace TAL;

[Binding]
public class Hooks
{
    private IWebDriver _driver;
    private HomeSteps _homeSteps;

    private readonly IObjectContainer _container;

    public Hooks(IObjectContainer container)
    {
        _container = container;
    }
    
    
    [BeforeScenario]
    public void Setup()
    {
        ChromeOptions options = new();
        //options.AddArgument("--start-maximized");
        _driver = new ChromeDriver(options);
        _container.RegisterInstanceAs(_driver);
    }
    
    [AfterScenario]
    public void TearDown()
    {
        _driver.Close();
    }
}