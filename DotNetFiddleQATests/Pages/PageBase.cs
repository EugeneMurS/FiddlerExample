using DotNetFiddleQATests.Services.WebDriver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DotNetFiddleQATests.Pages
{
	internal class PageBase
	{
		protected readonly IWebDriver Driver = Browser.Driver;

		public PageBase() {
			PageFactory.InitElements(Driver, this);
		}
	}
}