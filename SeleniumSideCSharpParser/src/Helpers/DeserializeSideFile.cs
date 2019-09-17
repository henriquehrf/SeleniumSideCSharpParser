using Newtonsoft.Json;
using SeleniumSideCSharpParser.Models.Side;

namespace SeleniumSideCSharpParser.src.Helpers
{
	public static class DeserializeSideFile
	{
		public static ProjectSide Deserialize(string path)
		{
			var json = FileReader.ContentFile(path);
			return JsonConvert.DeserializeObject<ProjectSide>(json);
		}
	}
}
