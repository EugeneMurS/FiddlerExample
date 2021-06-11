using DotNetFiddleQATests.Services.WebDriver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DotNetFiddleQATests.Pages
{
	class GettingStartedPage : PageBase {
		[FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Back To Editor')]]")]
		private IWebElement _backToEditorButton;

		[FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Getting Started')]]")]
		private IWebElement _gettingStartedButton;

		[FindsBy(How = How.XPath, Using = "//a[@id='run-button']")]
		private IWebElement _searchButton;

		public bool IsOpened()
		{
			return Driver.IsElementPresent(By.XPath("//h1[text()='Overview']"));
		}

		public void ClickOnBackToEditorButton()
		{
			_backToEditorButton.Click();
		}

		public void ClickOnGettingStartedButton()
		{
			_gettingStartedButton.Click();
		}

		public void ClickOnSearchButton()
		{
			_searchButton.Click();
		}
	}
}