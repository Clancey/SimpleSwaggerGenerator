#pragma warning disable 1591
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace AutoRest.CSharp.Templates.Rest.Client
{

#line 2 "ServiceClientTemplate.cshtml"
using System;

#line default
#line hidden
using System.Collections.Generic;

#line 3 "ServiceClientTemplate.cshtml"
using System.Linq;

#line default
#line hidden
using System.Text;

#line 4 "ServiceClientTemplate.cshtml"
using AutoRest.Core.Utilities;

#line default
#line hidden

#line 5 "ServiceClientTemplate.cshtml"
using AutoRest.CSharp.Model;

#line default
#line hidden

#line 6 "ServiceClientTemplate.cshtml"
using AutoRest.CSharp.Templates;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class ServiceClientTemplate : AutoRest.Core.Template<CodeModelCs>
{

#line hidden

public override void Execute()
{

#line 8 "ServiceClientTemplate.cshtml"
Write(Header("// "));


#line default
#line hidden
WriteLiteral("\n");


#line 9 "ServiceClientTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\nnamespace ");


#line 10 "ServiceClientTemplate.cshtml"
     Write(Settings.Namespace);


#line default
#line hidden
WriteLiteral("\n{\n    using SimpleAuth;\n");


#line 13 "ServiceClientTemplate.cshtml"
 foreach (var usingString in Model.Usings) {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("using ");


#line 14 "ServiceClientTemplate.cshtml"
       Write(usingString);


#line default
#line hidden
WriteLiteral(";\n");


#line 15 "ServiceClientTemplate.cshtml"
}


#line default
#line hidden

#line 16 "ServiceClientTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n");


#line 17 "ServiceClientTemplate.cshtml"
    

#line default
#line hidden

#line 17 "ServiceClientTemplate.cshtml"
     if (!string.IsNullOrWhiteSpace(Model.Documentation))
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("/// <summary>\n");

WriteLiteral("    ");


#line 20 "ServiceClientTemplate.cshtml"
 Write(WrapComment("/// ", Model.Documentation.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("    ");

WriteLiteral("/// </summary>\n");


#line 22 "ServiceClientTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("\n    public partial class ");


#line 24 "ServiceClientTemplate.cshtml"
                    Write(Model.Name);


#line default
#line hidden
WriteLiteral(" : Microsoft.Rest.ServiceClient<");


#line 24 "ServiceClientTemplate.cshtml"
                                                               Write(Model.Name);


#line default
#line hidden
WriteLiteral(">\n    {\n");

WriteLiteral("        ");


#line 26 "ServiceClientTemplate.cshtml"
    Write(Include(new ServiceClientBodyTemplate(), Model));


#line default
#line hidden
WriteLiteral(@"

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary> 
        partial void CustomInitialize();

        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
");


#line 38 "ServiceClientTemplate.cshtml"
        

#line default
#line hidden

#line 38 "ServiceClientTemplate.cshtml"
         foreach (var operation in Model.AllOperations) 
        {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("this.");


#line 40 "ServiceClientTemplate.cshtml"
               Write(operation.NameForProperty);


#line default
#line hidden
WriteLiteral(" = new ");


#line 40 "ServiceClientTemplate.cshtml"
                                                  Write(operation.TypeName);


#line default
#line hidden
WriteLiteral("(this);\n");


#line 41 "ServiceClientTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("\n");


#line 43 "ServiceClientTemplate.cshtml"
        

#line default
#line hidden

#line 43 "ServiceClientTemplate.cshtml"
         if (Model.IsCustomBaseUri)
        {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("this.BaseUri = \"");


#line 45 "ServiceClientTemplate.cshtml"
                         Write(Model.BaseUrl);


#line default
#line hidden
WriteLiteral("\";\n");


#line 46 "ServiceClientTemplate.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("this.BaseUri = new System.Uri(\"");


#line 49 "ServiceClientTemplate.cshtml"
                                        Write(Model.BaseUrl);


#line default
#line hidden
WriteLiteral("\");\n");


#line 50 "ServiceClientTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("\n");


#line 52 "ServiceClientTemplate.cshtml"
        

#line default
#line hidden

#line 52 "ServiceClientTemplate.cshtml"
         foreach (var property in Model.Properties.Where(p => !p.DefaultValue.IsNullOrEmpty()))
        {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("this.");


#line 54 "ServiceClientTemplate.cshtml"
               Write(property.Name);


#line default
#line hidden
WriteLiteral(" = ");


#line 54 "ServiceClientTemplate.cshtml"
                                  Write(property.DefaultValue);


#line default
#line hidden
WriteLiteral(";\n");


#line 55 "ServiceClientTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral(@"
            SerializationSettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new Microsoft.Rest.Serialization.ReadOnlyJsonContractResolver(),
                Converters = new  System.Collections.Generic.List<Newtonsoft.Json.JsonConverter>
                    {
                        new Microsoft.Rest.Serialization.Iso8601TimeSpanConverter()
                    }
            };
");


#line 70 "ServiceClientTemplate.cshtml"
            

#line default
#line hidden

#line 70 "ServiceClientTemplate.cshtml"
             if (Model.NeedsTransformationConverter)
            {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("SerializationSettings.Converters.Add(new Microsoft.Rest.Serialization.Transformat" +
"ionJsonConverter());\n");


#line 73 "ServiceClientTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral(@"            DeserializationSettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new Microsoft.Rest.Serialization.ReadOnlyJsonContractResolver(),
                Converters = new System.Collections.Generic.List<Newtonsoft.Json.JsonConverter>
                    {
                        new Microsoft.Rest.Serialization.Iso8601TimeSpanConverter()
                    }
            };
");


#line 86 "ServiceClientTemplate.cshtml"
            

#line default
#line hidden

#line 86 "ServiceClientTemplate.cshtml"
             foreach (var polymorphicType in Model.ModelTypes.Where(t => t.IsPolymorphic))
            {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("SerializationSettings.Converters.Add(new Microsoft.Rest.Serialization.Polymorphic" +
"SerializeJsonConverter<");


#line 88 "ServiceClientTemplate.cshtml"
                                                                                                                  Write(polymorphicType.Name);


#line default
#line hidden
WriteLiteral(">(\"");


#line 88 "ServiceClientTemplate.cshtml"
                                                                                                                                            Write(polymorphicType.PolymorphicDiscriminator);


#line default
#line hidden
WriteLiteral("\"));\n");

WriteLiteral("            ");

WriteLiteral("DeserializationSettings.Converters.Add(new  Microsoft.Rest.Serialization.Polymorp" +
"hicDeserializeJsonConverter<");


#line 89 "ServiceClientTemplate.cshtml"
                                                                                                                       Write(polymorphicType.Name);


#line default
#line hidden
WriteLiteral(">(\"");


#line 89 "ServiceClientTemplate.cshtml"
                                                                                                                                                 Write(polymorphicType.PolymorphicDiscriminator);


#line default
#line hidden
WriteLiteral("\"));\n");


#line 90 "ServiceClientTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral("\n            CustomInitialize();\n            \n");


#line 94 "ServiceClientTemplate.cshtml"
            

#line default
#line hidden

#line 94 "ServiceClientTemplate.cshtml"
             if (Model.NeedsTransformationConverter)
            {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("DeserializationSettings.Converters.Add(new Microsoft.Rest.Serialization.Transform" +
"ationJsonConverter());\n");


#line 97 "ServiceClientTemplate.cshtml"
            }


#line default
#line hidden
WriteLiteral("    \n        }    \n    \n");


#line 101 "ServiceClientTemplate.cshtml"
        

#line default
#line hidden

#line 101 "ServiceClientTemplate.cshtml"
         foreach (MethodCs method in Model.Methods.Where( m => m.Group.IsNullOrEmpty()))
        {


#line default
#line hidden
WriteLiteral("        ");


#line 103 "ServiceClientTemplate.cshtml"
      Write(Include(new MethodTemplate(), method));


#line default
#line hidden
WriteLiteral("\n");


#line 104 "ServiceClientTemplate.cshtml"
        

#line default
#line hidden

#line 104 "ServiceClientTemplate.cshtml"
   Write(EmptyLine);


#line default
#line hidden

#line 104 "ServiceClientTemplate.cshtml"
                  


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("\n");


#line 106 "ServiceClientTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("    }\n}\n");

}
}
}
#pragma warning restore 1591