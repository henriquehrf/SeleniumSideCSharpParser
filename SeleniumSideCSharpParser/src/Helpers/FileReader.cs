using System.IO;
using System.Text;

namespace SeleniumSideCSharpParser.src.Helpers
{
	public static class FileReader
	{
		public static string ContentFile(string path)
		{
			if (File.Exists(path))
				return File.ReadAllText(path, Encoding.UTF8);

			throw new IOException("File not found!");
		}
	}
}
