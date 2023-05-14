using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TAL.Utils;

public class Helpers
{
    public static void WaitDisplayed(IWebDriver driver, By by)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(d => d.FindElement(by).Displayed);
    }
}