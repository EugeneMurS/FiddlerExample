using System.Configuration;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using DotNetFiddleQATests.Pages;
using DotNetFiddleQATests.Services.WebDriver;
using NUnit.Framework;

namespace DotNetFiddleQATests.Tests
{
	[TestFixture]
	class GettingStartedTests
	{
		public static ExtentReports Report = new ExtentReports();
		public static ExtentTest Test;

		[SetUp]
		public void StartBrowser()
		{
			var htmlReporter = new ExtentHtmlReporter(ConfigurationManager.AppSettings["Reports"]);
			Report.AttachReporter(htmlReporter);
			Browser.Init();
			Browser.LoadApplication();
		}

		[Test]
		public void GettingStartedButtonTest()
		{
			Test = Report.CreateTest("'Getting Started' button is working",
				"Verify 'Getting Started' page is opened after 'Getting Started' button click");
			var mainPage = new MainPage();
			mainPage.ClickOnGettingStartedButton();
			var gettingStartedPage = new GettingStartedPage();
			Assert.IsTrue(gettingStartedPage.IsOpened(), "'Getting Started' page is not displayed");
		}

		[TearDown]
		public void CloseBrowser()
		{
			Browser.Close();
			Report.Flush();
		}
	}
}