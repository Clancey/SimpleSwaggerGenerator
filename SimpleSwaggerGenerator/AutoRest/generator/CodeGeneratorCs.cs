// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoRest.Core;
using AutoRest.Core.Model;
using AutoRest.Core.Logging;
using AutoRest.Core.Utilities;
using AutoRest.CSharp.Model;
using AutoRest.CSharp.Templates.Rest.Client;
using AutoRest.CSharp.Templates.Rest.Common;
using static AutoRest.Core.Utilities.DependencyInjection;
using AutoRest.Extensions;
using System.Text;

namespace AutoRest.CSharp
{
    public class CodeGeneratorCs : CodeGenerator
    {
        private const string ClientRuntimePackage = "Microsoft.Rest.ClientRuntime.2.2.0";

        public override bool IsSingleFileGenerationSupported => true;


        public override string UsageInstructions => string.Format(CultureInfo.InvariantCulture,
			SimpleSwaggerGenerator.AutoRest.generator.Properties.Resources.UsageInformation, ClientRuntimePackage);

        public override string ImplementationFileExtension => ".cs";

        private async Task GenerateServerSideCode(CodeModelCs codeModel)
        {
            //foreach (string methodGrp in codeModel.MethodGroupNames)
            //{
            //    using (NewContext)
            //    {
            //        codeModel.Name = methodGrp;
            //        // Service server
            //        var serviceControllerTemplate = new AutoRest.CSharp.Templates.Rest.Server.ServiceControllerTemplate { Model = codeModel };
            //        await Write(serviceControllerTemplate, $"{codeModel.Name}{ImplementationFileExtension}");
            //    }
            //}
            //// Models
            //foreach (CompositeTypeCs model in codeModel.ModelTypes.Union(codeModel.HeaderTypes))
            //{
            //    var modelTemplate = new ModelTemplate { Model = model };
            //    await Write(modelTemplate, Path.Combine(Settings.Instance.ModelsName, $"{model.Name}{ImplementationFileExtension}"));
            //}
        }

        private async Task<string> GenerateClientSideCode(CodeModelCs codeModel)
        {
			var sb = new StringBuilder();

			var isInMemory = Settings.Instance.OutputInMemory;

            // Service client
            var serviceClientTemplate = new ServiceClientTemplate { Model = codeModel };
			if (isInMemory)
				GenerateTemplateCode(serviceClientTemplate, sb);
			else
            	await Write(serviceClientTemplate, $"{codeModel.Name}{ImplementationFileExtension}");

            // Service client interface
   //         var serviceClientInterfaceTemplate = new ServiceClientInterfaceTemplate { Model = codeModel };
   //         await Write(serviceClientInterfaceTemplate, $"I{codeModel.Name}{ImplementationFileExtension}");
			//GenerateTemplateCode(serviceClientInterfaceTemplate, sb);

            // operations
            foreach (MethodGroupCs methodGroup in codeModel.Operations)
            {
                if (!methodGroup.Name.IsNullOrEmpty())
                {
                    // Operation
                    var operationsTemplate = new MethodGroupTemplate { Model = methodGroup };
					if (isInMemory)
						GenerateTemplateCode(operationsTemplate, sb);
					else
                    await Write(operationsTemplate, $"{operationsTemplate.Model.TypeName}{ImplementationFileExtension}");

                    // Operation interface
                    var operationsInterfaceTemplate = new MethodGroupInterfaceTemplate { Model = methodGroup };
					if (isInMemory)
						GenerateTemplateCode(operationsInterfaceTemplate, sb);
					else
                    	await Write(operationsInterfaceTemplate, $"I{operationsInterfaceTemplate.Model.TypeName}{ImplementationFileExtension}");
                }

                var operationExtensionsTemplate = new ExtensionsTemplate { Model = methodGroup };
				if (isInMemory)
					GenerateTemplateCode(operationExtensionsTemplate, sb);
				else
                	await Write(operationExtensionsTemplate, $"{methodGroup.ExtensionTypeName}Extensions{ImplementationFileExtension}");
            }

            // Models
            foreach (CompositeTypeCs model in codeModel.ModelTypes.Union(codeModel.HeaderTypes))
            {
                if (model.Extensions.ContainsKey(SwaggerExtensions.ExternalExtension) &&
                    (bool)model.Extensions[SwaggerExtensions.ExternalExtension])
                {
                    continue;
                }

                var modelTemplate = new ModelTemplate{ Model = model };
				if (isInMemory)
					GenerateTemplateCode(modelTemplate, sb);
                else
					await Write(modelTemplate, Path.Combine(Settings.Instance.ModelsName, $"{model.Name}{ImplementationFileExtension}"));
            }

            // Enums
            foreach (EnumTypeCs enumType in codeModel.EnumTypes)
            {
                var enumTemplate = new EnumTemplate { Model = enumType };
				if (isInMemory)
					GenerateTemplateCode(enumTemplate, sb);
				else
                	await Write(enumTemplate, Path.Combine(Settings.Instance.ModelsName, $"{enumTemplate.Model.Name}{ImplementationFileExtension}"));
            }

            // Exceptions
            foreach (CompositeTypeCs exceptionType in codeModel.ErrorTypes)
            {
                var exceptionTemplate = new ExceptionTemplate { Model = exceptionType, };
				if (isInMemory)
					GenerateTemplateCode(exceptionTemplate, sb);
				else
                	await Write(exceptionTemplate, Path.Combine(Settings.Instance.ModelsName, $"{exceptionTemplate.Model.ExceptionTypeDefinitionName}{ImplementationFileExtension}"));
            }

			//// Xml Serialization
			//if (codeModel.ShouldGenerateXmlSerialization)
			//{
			//    var xmlSerializationTemplate = new XmlSerializationTemplate();
			//    await Write(xmlSerializationTemplate, Path.Combine(Settings.Instance.ModelsName, $"{XmlSerialization.XmlDeserializationClass}{ImplementationFileExtension}"));
			//}
			return sb.ToString();
        }

		void GenerateTemplateCode(ITemplate template, StringBuilder stringBuilder)
		{
			var lineEnding = Environment.NewLine;

			using (StringReader streamReader = new StringReader(template.ToString()))
			{
				var skipEmptyLines = true;

				string line;
				while ((line = streamReader.ReadLine()) != null)
				{
					// remove any errant line endings, and trim whitespace from the end too.
					line = line.Replace("\r", "").Replace("\n", "").TrimEnd(' ', '\r', '\n', '\t');

					if (line.Contains(TemplateConstants.EmptyLine))
					{
						stringBuilder.AppendLine(lineEnding);
					}
					else if (!skipEmptyLines || !string.IsNullOrWhiteSpace(line))
					{
						stringBuilder.AppendLine(line);
					}
				}
			}
		}


        private async Task<string> GenerateRestCode(CodeModelCs codeModel)
        {
            
			return await GenerateClientSideCode(codeModel);
		}

        /// <summary>
        /// Generates C# code for service client.
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        public override Task<string> Generate(CodeModel cm)
        {
            // get c# specific codeModel
            var codeModel = cm as CodeModelCs;
            if (codeModel == null)
            {
                throw new InvalidCastException("CodeModel is not a c# CodeModel");
            }
			return GenerateClientSideCode(codeModel);
        }
    }
}
