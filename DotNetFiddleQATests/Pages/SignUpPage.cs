using DotNetFiddleQATests.Services.WebDriver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DotNetFiddleQATests.Pages
{
	class SignUpPage : PageBase
	{
		[FindsBy(How = How.XPath, Using = "//div[@id='signup-options']/a[text()[contains(.,'Twitter')]]")]
		private IWebElement _openTwitterButton;

		[FindsBy(How = How.XPath, Using = "//div[@id='signup-options']/a[text()[contains(.,'Facebook')]]")]
		private IWebElement _openFacebookButton;

		[FindsBy(How = How.XPath, Using = "//div[@id='signup-options']/a[text()[contains(.,'Gmail')]]")]
		private IWebElement _openGmailButton;

		[FindsBy(How = How.XPath, Using = "//div[@id='signup-options']/a[text()[contains(.,'.NET Fiddle')]]")]
		private IWebElement _openDotNetFiddlerButton;
	}
}