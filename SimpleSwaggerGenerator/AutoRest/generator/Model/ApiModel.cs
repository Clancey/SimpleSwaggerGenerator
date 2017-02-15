using System;
using AutoRest.CSharp.Model;
using AutoRest.Core.Model;

namespace AutoRest.CSharp.Model
{
	public class ApiModel
	{
		public CodeModelCs CodeModel { get; set; }
		public SecurityDefinition Definition { get; set; }
		public MethodGroup[] Operations { get; set; }
		public string ApiSubclass
		{
			get
			{
				switch (Definition?.SecuritySchemeType)
				{
					case SecuritySchemeType.ApiKey:
						return "ApiKeyApi";
					case SecuritySchemeType.Basic:
						return "BasicAuthApi";
					case SecuritySchemeType.OAuth2:
						return "OAuthApi";
					case SecuritySchemeType.OauthApiKey:
						return "OauthApiKeyApi";
				}
				return "Api";
			}
		}

		public string Name => $"{CodeModel?.Name}{ApiSubclass}";
	}
}
