namespace SeleniumSideCSharpParser.Models.Side
{
	public class ProjectSide
	{
		public string Id { get; set; }
		public string Version { get; set; }
		public string Url { get; set; }
		public TestsSide[] Tests { get; set; }

	}
}
