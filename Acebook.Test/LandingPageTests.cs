namespace Acebook.Test;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

public class LandingPageTests
{
  ChromeDriver driver;

  [SetUp]
  public void Setup()
  {
    driver = new ChromeDriver();
  }

  [TearDown]
  public void TearDown() {
    driver.Quit();
  }

  [Test]
  public void LandingPage_ShowsWelcomeMessage()
  {
    driver.Navigate().GoToUrl("http://127.0.0.1:5287");
    IWebElement greeting = driver.FindElement(By.Id("greeting"));
    Assert.AreEqual("Welcome To Acebook", greeting.GetAttribute("innerHTML"));
  }
}