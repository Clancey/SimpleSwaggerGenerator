using System;

namespace SimpleSwaggerGenerator.CLI
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var generator = new Generator
			{
				SwaggerFileLocation = "/Users/clancey/Downloads/swagger.json",
				NameSpace = "MobileCenterApis",
				OutputToMemory = true,
			};
			var output = generator.Generate();
		}
	}
}
