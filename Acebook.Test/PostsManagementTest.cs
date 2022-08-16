using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Acebook.Tests
{
  public class PostsManagement
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
    public void Post_ValidCredentials_PostingPostDynamically()
    {
      driver.Navigate().GoToUrl("http://127.0.0.1:5287");
      IWebElement signUpButton = driver.FindElement(By.Id("signup"));
      signUpButton.Click();
      IWebElement nameField = driver.FindElement(By.Id("name"));
      nameField.SendKeys("francine");
      IWebElement emailField = driver.FindElement(By.Id("email"));
      emailField.SendKeys("francine@email.com");
      IWebElement passwordField = driver.FindElement(By.Id("password"));
      passwordField.SendKeys("12345678");
      IWebElement submitButton = driver.FindElement(By.Id("submit"));
      submitButton.Click();

      driver.Navigate().GoToUrl("http://127.0.0.1:5287/signin");
      emailField = driver.FindElement(By.Id("email"));
      emailField.SendKeys("francine@email.com");
      passwordField = driver.FindElement(By.Id("password"));
      passwordField.SendKeys("12345678");
      submitButton = driver.FindElement(By.Id("submit"));
      submitButton.Click();
      driver.Navigate().GoToUrl("http://127.0.0.1:5287/posts");

      IWebElement titleField = driver.FindElement(By.Id("title"));
      titleField.SendKeys("Title test");
      IWebElement contentField = driver.FindElement(By.Id("content"));
      contentField.SendKeys("Content test");

      IWebElement submitPostButton = driver.FindElement(By.Id("submit"));
      submitPostButton.Click();

      string currentUrl = driver.Url;
      Assert.AreEqual("http://127.0.0.1:5287/posts", currentUrl);
    }
  }
}