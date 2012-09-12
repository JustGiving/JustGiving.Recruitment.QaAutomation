using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace JustGiving.Recruitment.QaAutomation.Website.Tests
{
    [TestFixture]
    public class ExampleTest
    {
        private IWebDriver _driver;

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            _driver = new FirefoxDriver();
            _driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, 30));
        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            if (_driver != null)
            {
                _driver.Close();
            }
        }

        [Test]
        public void WhenVisitingTheDemoWebsite_HomePageTitleIsCorrect()
        {
            _driver.Navigate().GoToUrl("http://localhost:9876");

            Assert.That(_driver.Title, Is.EqualTo("Home Page"));
        }
    }
}
