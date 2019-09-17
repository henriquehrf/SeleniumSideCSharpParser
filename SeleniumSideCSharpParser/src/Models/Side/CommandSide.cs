using System.Collections.Generic;

namespace SeleniumSideCSharpParser.Models.Side
{
	public class CommandSide
	{
		public string Id { get; set; }
		public string Comment { get; set; }
		public string Command { get; set; }
		public string Target { get; set; }
		public IDictionary<string, string> Targets { get; set; }
		public string Value { get; set; }
	}
}
