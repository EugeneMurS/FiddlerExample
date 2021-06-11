using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace DotNetFiddleQATests.Services.WebDriver
{
	class Browser
	{
		public static IWebDriver Driver { get; private set; }

		public static void Init()
		{
			switch (ConfigurationManager.AppSettings["Browser"])
			{
				case "Firefox":
					Driver = new FirefoxDriver();
					break;

				case "IE":
					Driver = new InternetExplorerDriver();
					break;

				case "Chrome":
					Driver = new ChromeDriver();
					break;
				default:
					throw new ArgumentException(
						"Browser's name is not recognized! Please, check 'Browser' property in App.config");
			}

			Driver.Manage().Window.Maximize();
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
		}

		public static void LoadApplication()
		{
			Driver.Url = ConfigurationManager.AppSettings["URL"];
		}

		public static void Close()
		{
			if (Driver != null)
			{
				Driver.Quit();
			}
		}
	}
}