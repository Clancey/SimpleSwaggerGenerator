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

#line 2 "SimpleAuthApiTemplate.cshtml"
using System;

#line default
#line hidden
using System.Collections.Generic;

#line 3 "SimpleAuthApiTemplate.cshtml"
using System.Linq;

#line default
#line hidden
using System.Text;

#line 4 "SimpleAuthApiTemplate.cshtml"
using AutoRest.Core.Utilities;

#line default
#line hidden

#line 5 "SimpleAuthApiTemplate.cshtml"
using AutoRest.Core.Model;

#line default
#line hidden

#line 6 "SimpleAuthApiTemplate.cshtml"
using AutoRest.CSharp.Model;

#line default
#line hidden

#line 7 "SimpleAuthApiTemplate.cshtml"
using AutoRest.CSharp.Templates;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class SimpleAuthApiTemplate : AutoRest.Core.Template<ApiModel>
{

#line hidden

public override void Execute()
{

#line 9 "SimpleAuthApiTemplate.cshtml"
Write(Header("// "));


#line default
#line hidden
WriteLiteral("\n");


#line 10 "SimpleAuthApiTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\nnamespace ");


#line 11 "SimpleAuthApiTemplate.cshtml"
     Write(Settings.Namespace);


#line default
#line hidden
WriteLiteral("\n{\n    using SimpleAuth;\n");


#line 14 "SimpleAuthApiTemplate.cshtml"
 foreach (var usingString in Model.CodeModel.Usings) {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("using ");


#line 15 "SimpleAuthApiTemplate.cshtml"
       Write(usingString);


#line default
#line hidden
WriteLiteral(";\n");


#line 16 "SimpleAuthApiTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("    ");


#line 18 "SimpleAuthApiTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden
WriteLiteral("\n");


#line 19 "SimpleAuthApiTemplate.cshtml"
    

#line default
#line hidden

#line 19 "SimpleAuthApiTemplate.cshtml"
     if (!string.IsNullOrWhiteSpace(Model.CodeModel.Documentation))
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("/// <summary>\n");

WriteLiteral("    ");


#line 22 "SimpleAuthApiTemplate.cshtml"
 Write(WrapComment("/// ", Model.CodeModel.Documentation.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("    ");

WriteLiteral("/// </summary>\n");


#line 24 "SimpleAuthApiTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("\n    public partial class ");


#line 26 "SimpleAuthApiTemplate.cshtml"
                    Write(Model.Name);


#line default
#line hidden
WriteLiteral(" : ");


#line 26 "SimpleAuthApiTemplate.cshtml"
                                  Write(Model.ApiSubclass);


#line default
#line hidden
WriteLiteral("\n    {\n    \t/// <summary>\n        /// An optional partial-method to perform custo" +
"m initialization.\n        ///</summary>\n        partial void CustomInitialize();" +
"\n\n");


#line 33 "SimpleAuthApiTemplate.cshtml"
        

#line default
#line hidden

#line 33 "SimpleAuthApiTemplate.cshtml"
         foreach (var operation in Model.Operations)
        {


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("/// <summary>\n");

WriteLiteral("        ");

WriteLiteral("/// Gets the ");


#line 36 "SimpleAuthApiTemplate.cshtml"
                   Write(operation.TypeName);


#line default
#line hidden
WriteLiteral(".\n");

WriteLiteral("        ");

WriteLiteral("/// </summary>\n");

WriteLiteral("        ");

WriteLiteral("public virtual ");


#line 38 "SimpleAuthApiTemplate.cshtml"
                     Write(operation.TypeName);


#line default
#line hidden
WriteLiteral(" ");


#line 38 "SimpleAuthApiTemplate.cshtml"
                                           Write(operation.NameForProperty);


#line default
#line hidden
WriteLiteral(" { get; private set; }\n");


#line 39 "SimpleAuthApiTemplate.cshtml"
        

#line default
#line hidden

#line 39 "SimpleAuthApiTemplate.cshtml"
   Write(EmptyLine);


#line default
#line hidden

#line 39 "SimpleAuthApiTemplate.cshtml"
                  
        }


#line default
#line hidden
WriteLiteral("\n        /// <summary>\n        /// Initializes client properties.\n        /// </s" +
"ummary>\n        private void Initialize()\n        {\n");


#line 47 "SimpleAuthApiTemplate.cshtml"
        

#line default
#line hidden

#line 47 "SimpleAuthApiTemplate.cshtml"
         foreach (var operation in Model.Operations)
        {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("this.");


#line 49 "SimpleAuthApiTemplate.cshtml"
               Write(operation.NameForProperty);


#line default
#line hidden
WriteLiteral(" = new ");


#line 49 "SimpleAuthApiTemplate.cshtml"
                                                  Write(operation.TypeName);


#line default
#line hidden
WriteLiteral("(this);\n");


#line 50 "SimpleAuthApiTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("\n\n");


#line 53 "SimpleAuthApiTemplate.cshtml"
        

#line default
#line hidden

#line 53 "SimpleAuthApiTemplate.cshtml"
         if (Model.CodeModel.IsCustomBaseUri)
        {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("this.BaseUri = \"");


#line 55 "SimpleAuthApiTemplate.cshtml"
                         Write(Model.CodeModel.BaseUrl);


#line default
#line hidden
WriteLiteral("\";\n");


#line 56 "SimpleAuthApiTemplate.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteral("            ");

WriteLiteral("this.BaseUri = new System.Uri(\"");


#line 59 "SimpleAuthApiTemplate.cshtml"
                                        Write(Model.CodeModel.BaseUrl);


#line default
#line hidden
WriteLiteral("\");\n");


#line 60 "SimpleAuthApiTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("\n            CustomInitialize();\n        }\n\n");


#line 65 "SimpleAuthApiTemplate.cshtml"
        

#line default
#line hidden

#line 65 "SimpleAuthApiTemplate.cshtml"
         foreach (MethodCs method in Model.CodeModel.Methods.Where( m => m.Group.IsNullOrEmpty() && (m.HasSecurity(Model.Definition.ApiKey))))
        {


#line default
#line hidden
WriteLiteral("        ");


#line 67 "SimpleAuthApiTemplate.cshtml"
      Write(Include(new SimpleAuthMethodTemplate(), method));


#line default
#line hidden
WriteLiteral("\n");


#line 68 "SimpleAuthApiTemplate.cshtml"
        

#line default
#line hidden

#line 68 "SimpleAuthApiTemplate.cshtml"
   Write(EmptyLine);


#line default
#line hidden

#line 68 "SimpleAuthApiTemplate.cshtml"
                  


#line default
#line hidden
WriteLiteral("        ");

WriteLiteral("\n");


#line 70 "SimpleAuthApiTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("\n");


#line 72 "SimpleAuthApiTemplate.cshtml"
        

#line default
#line hidden

#line 72 "SimpleAuthApiTemplate.cshtml"
         foreach (MethodGroupCs operation in Model.Operations)
        {


#line default
#line hidden
WriteLiteral("        ");


#line 74 "SimpleAuthApiTemplate.cshtml"
      Write(Include(new SimpleAuthApiGroupedCallsTemplate(), new Tuple<ApiModel,MethodGroupCs>(Model,operation)));


#line default
#line hidden
WriteLiteral("\n");


#line 75 "SimpleAuthApiTemplate.cshtml"
        

#line default
#line hidden

#line 75 "SimpleAuthApiTemplate.cshtml"
   Write(EmptyLine);


#line default
#line hidden

#line 75 "SimpleAuthApiTemplate.cshtml"
                  
        }


#line default
#line hidden
WriteLiteral("\n\t\t}\n    }\n}");

}
}
}
#pragma warning restore 1591