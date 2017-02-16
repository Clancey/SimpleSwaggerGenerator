using System;
using AutoRest.CSharp.Model;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using System.Collections.Generic;

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

        public string BuildConstructor()
        {
            var builder = new IndentedStringBuilder();
            var parameters = new List<string>();
            var baseParams = new List<string>();
            var subclass = ApiSubclass;
            if (subclass == "Api")
            {
                parameters = new List<string>
                {
                    "string identifier",
                    "string encryptionKey",
                    "HttpMessageHandler handler = null",
                };
                baseParams = new List<string>
                {
                    "identifier",
                    "encryptionKey",
                    "handler",
                };
            }
            else if (subclass == "BasicAuthApi")
            {
                parameters = new List<string>
                {
                    "string identifier",
                    "string encryptionKey",
                    "string loginUrl",
                    "HttpMessageHandler handler = null",
                };
                baseParams = new List<string>
                {
                    "identifier",
                    "encryptionKey",
                    "loginUrl",
                    "handler",
                };
            }
            else if (subclass == "ApiKeyApi")
            {
                parameters = new List<string>
                {
                    "string apiKey",
                    "HttpMessageHandler handler = null",
                };
                baseParams = new List<string>
                {
                    "apiKey",
                    $"\"{Definition.Name}\"",
                    $"AuthLocation.{Definition.In.ToString("G")}",
                    "handler",
                };
            }
            else if (subclass == "OAuthApi")
            {
                parameters = new List<string>
                {
                    "string identifier",
                    "string clientId",
                    "string clientSecret",
                };
                baseParams = new List<string>
                {
                    "identifier",
                    "clientId",
                    "clientSecret",
                };

                if (string.IsNullOrWhiteSpace(Definition.TokenUrl))
                {
                    parameters.Add("string tokenUrl");
                    baseParams.Add("tokenUrl");
                }
                else
                {
                    baseParams.Add($"\"{Definition.TokenUrl}\"");
                }

                if (string.IsNullOrWhiteSpace(Definition.AuthorizationUrl))
                {
                    parameters.Add("string authorizationUrl");
                    baseParams.Add("authorizationUrl");
                }
                else
                {
                    baseParams.Add($"\"{Definition.AuthorizationUrl}\"");
                }
                parameters.Add("string redirectUrl = \"http://localhost\"");
                baseParams.Add("redirectUrl");

                parameters.Add("HttpMessageHandler handler = null");
                baseParams.Add("handler");
            }
            else if (subclass == "OauthApiKeyApi")
            {
                parameters = new List<string>
                {
                    "string identifier",
                    "string apiKey",
                    $"\"{Definition.Name}\"",
                    $"AuthLocation.{Definition.In.ToString("G")}",
                    "string clientId",
                    "string clientSecret",
                };
                baseParams = new List<string>
                {
                    "identifier",
                    "apiKey",
                    "clientId",
                    "clientSecret",
                };

                if (string.IsNullOrWhiteSpace(Definition.TokenUrl))
                {
                    parameters.Add("string tokenUrl");
                    baseParams.Add("tokenUrl");
                }
                else
                {
                    baseParams.Add($"\"{Definition.TokenUrl}\"");
                }

                if (string.IsNullOrWhiteSpace(Definition.AuthorizationUrl))
                {
                    parameters.Add("string authorizationUrl");
                    baseParams.Add("authorizationUrl");
                }
                else
                {
                    baseParams.Add($"\"{Definition.AuthorizationUrl}\"");
                }
                parameters.Add("string redirectUrl = \"http://localhost\"");
                baseParams.Add("redirectUrl");

                parameters.Add("HttpMessageHandler handler = null");
                baseParams.Add("handler");
            }



            var paramString = String.Join(", ", parameters);
            var baseString = string.Join(", ", baseParams);
            builder.AppendLine($"public {Name} ({paramString} ) : base ({baseString} )");
            builder.AppendLine("{");
            builder.Indent();
            builder.AppendLine("Initialize();");
            builder.Outdent();
            builder.AppendLine("}");

            return builder.ToString();
        }
	}
}
