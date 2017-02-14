using System;
using AutoRest.Core;
using AutoRest.Core.Utilities;
namespace SimpleSwaggerGenerator
{
	public class Generator
	{
		public string SwaggerUrl { get; set; }
		public string SwaggerFileLocation { get; set; }
		public string SwaggerJson { get; set; }
		public string NameSpace { get; set; }
		public bool OutputToMemory { get; set; }
		public string OutputFile { get; set; }

		public string Generate()
		{
			using (DependencyInjection.NewContext)
			{
				Settings.Create(new string[0]);
				Settings.Instance.Namespace = NameSpace;
				Settings.Instance.OutputFileName = "api.cs";
				Settings.Instance.SwaggerFilePath = SwaggerFileLocation;
				Settings.Instance.SwaggerJson = SwaggerJson;
				Settings.Instance.SwaggerUrl = SwaggerUrl;
				Settings.Instance.OutputFileName = OutputFile;
				Settings.Instance.OutputInMemory = OutputToMemory;
				return AutoRestController.Generate();
			}
		}

	}
}
