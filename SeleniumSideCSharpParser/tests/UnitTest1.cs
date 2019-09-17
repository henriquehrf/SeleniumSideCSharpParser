using OpenQA.Selenium;
using SeleniumSideCSharpParser.src.Fixtures;
using Xunit;

namespace SeleniumSideCSharpParser
{
	[Collection("Chrome Driver")]
	public class UnitTest1
	{
		private IWebDriver _driver;

		public UnitTest1(TestFixture fixture)
		{
			_driver = fixture.Driver;
		}

		[Fact]
		public void Test1()
		{
			//initial commit
		}
	}
}
