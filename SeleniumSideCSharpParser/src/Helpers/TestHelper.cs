using System.IO;
using System.Reflection;

namespace SeleniumSideCSharpParser.src.Helpers
{
	public static class TestHelper
	{
		public static string PastaDoExecutavel => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
	}
}
