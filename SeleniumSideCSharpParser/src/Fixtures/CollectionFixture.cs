using Xunit;

namespace SeleniumSideCSharpParser.src.Fixtures
{
	[CollectionDefinition("Chrome Driver")]
	public class CollectionFixture : ICollectionFixture<TestFixture>
	{
	}
}
