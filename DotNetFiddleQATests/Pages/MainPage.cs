using DotNetFiddleQATests.Services.WebDriver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DotNetFiddleQATests.Pages
{
	class MainPage : PageBase
	{
		[FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Getting Started')]]")]
		private IWebElement _gettingStartedButton;

		public void ClickOnGettingStartedButton()
		{
			Driver.FindElement(By.XPath("//a[text()[contains(.,'Getting Started')]]"), 3)
				.Click("'Getting Started' Button");
		}
	}
}