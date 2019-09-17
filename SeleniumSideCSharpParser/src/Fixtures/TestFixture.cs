using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumSideCSharpParser.src.Helpers;
using System;

namespace SeleniumSideCSharpParser.src.Fixtures
{
	public class TestFixture : IDisposable
	{
		public IWebDriver Driver { get; private set; }

		//Setup
		public TestFixture()
		{
			Driver = new ChromeDriver(TestHelper.PastaDoExecutavel);
		}

		//TearDown
		public void Dispose()
		{
			Driver.Quit();
		}
	}
}
