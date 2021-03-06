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

namespace AutoRest.CSharp.Templates.Rest.Common
{

#line 3 "ExtensionMethodTemplate.cshtml"
using System;

#line default
#line hidden
using System.Collections.Generic;
using System.Linq;

#line 2 "ExtensionMethodTemplate.cshtml"
using System.Text;

#line default
#line hidden

#line 4 "ExtensionMethodTemplate.cshtml"
using AutoRest.Core.Model;

#line default
#line hidden

#line 5 "ExtensionMethodTemplate.cshtml"
using AutoRest.Core.Utilities;

#line default
#line hidden

#line 6 "ExtensionMethodTemplate.cshtml"
using AutoRest.CSharp;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class ExtensionMethodTemplate : AutoRest.Core.Template<AutoRest.CSharp.Model.MethodCs>
{

#line hidden

public override void Execute()
{

#line 8 "ExtensionMethodTemplate.cshtml"
  
if (Model.SyncMethods == SyncMethodsGenerationMode.All || Model.SyncMethods == SyncMethodsGenerationMode.Essential)
{
    if (!String.IsNullOrEmpty(Model.Description) || !String.IsNullOrEmpty(Model.Summary))
    {


#line default
#line hidden
WriteLiteral("/// <summary>\n");


#line 14 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", String.IsNullOrEmpty(Model.Summary) ? Model.Description.EscapeXmlComment() : Model.Summary.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");


#line 15 "ExtensionMethodTemplate.cshtml"
        if (!String.IsNullOrEmpty(Model.ExternalDocsUrl))
        {


#line default
#line hidden
WriteLiteral("/// <see href=\"");


#line 17 "ExtensionMethodTemplate.cshtml"
            Write(Model.ExternalDocsUrl);


#line default
#line hidden
WriteLiteral("\" />\n");


#line 18 "ExtensionMethodTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("/// </summary>\n");


#line 20 "ExtensionMethodTemplate.cshtml"
    }
    if (!String.IsNullOrEmpty(Model.Description) && !String.IsNullOrEmpty(Model.Summary))
    {


#line default
#line hidden
WriteLiteral("/// <remarks>\n");


#line 24 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", Model.Description.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </remarks>\n");


#line 26 "ExtensionMethodTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("/// <param name=\'operations\'>\n");

WriteLiteral("/// The operations group for this extension method.\n");

WriteLiteral("/// </param>\n");


#line 30 "ExtensionMethodTemplate.cshtml"
    foreach (var parameter in Model.LocalParameters)
    {


#line default
#line hidden
WriteLiteral("/// <param name=\'");


#line 32 "ExtensionMethodTemplate.cshtml"
              Write(parameter.Name);


#line default
#line hidden
WriteLiteral("\'>\n");


#line 33 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", parameter.Documentation.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </param>\n");


#line 35 "ExtensionMethodTemplate.cshtml"
    }
if (Model.Deprecated)
{


#line default
#line hidden
WriteLiteral("[System.Obsolete()]\n");


#line 39 "ExtensionMethodTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("public static ");


#line 40 "ExtensionMethodTemplate.cshtml"
           Write(Model.ReturnTypeString);


#line default
#line hidden
WriteLiteral(" ");


#line 40 "ExtensionMethodTemplate.cshtml"
                                    Write(Model.Name);


#line default
#line hidden
WriteLiteral("(");


#line 40 "ExtensionMethodTemplate.cshtml"
                                                 Write(Model.GetExtensionParameters(Model.GetSyncMethodParameterDeclaration(false)));


#line default
#line hidden
WriteLiteral(")\n");

WriteLiteral("{\n");


#line 42 "ExtensionMethodTemplate.cshtml"
    if (Model.ReturnType.Body != null)
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("return ((I");


#line 44 "ExtensionMethodTemplate.cshtml"
            Write(Model.MethodGroup.TypeName);


#line default
#line hidden
WriteLiteral(")operations).");


#line 44 "ExtensionMethodTemplate.cshtml"
                                                      Write(Model.Name);


#line default
#line hidden
WriteLiteral("Async(");


#line 44 "ExtensionMethodTemplate.cshtml"
                                                                         Write(Model.SyncMethodInvocationArgs);


#line default
#line hidden
WriteLiteral(").GetAwaiter().GetResult();\n");


#line 45 "ExtensionMethodTemplate.cshtml"
    }
    else if (Model.ReturnType.Headers != null)
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("return ((I");


#line 48 "ExtensionMethodTemplate.cshtml"
            Write(Model.MethodGroup.TypeName);


#line default
#line hidden
WriteLiteral(")operations).");


#line 48 "ExtensionMethodTemplate.cshtml"
                                                      Write(Model.Name);


#line default
#line hidden
WriteLiteral("Async(");


#line 48 "ExtensionMethodTemplate.cshtml"
                                                                         Write(Model.SyncMethodInvocationArgs);


#line default
#line hidden
WriteLiteral(").GetAwaiter().GetResult();\n");


#line 49 "ExtensionMethodTemplate.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("((I");


#line 52 "ExtensionMethodTemplate.cshtml"
     Write(Model.MethodGroup.TypeName);


#line default
#line hidden
WriteLiteral(")operations).");


#line 52 "ExtensionMethodTemplate.cshtml"
                                               Write(Model.Name);


#line default
#line hidden
WriteLiteral("Async(");


#line 52 "ExtensionMethodTemplate.cshtml"
                                                                  Write(Model.SyncMethodInvocationArgs);


#line default
#line hidden
WriteLiteral(").GetAwaiter().GetResult();\n");


#line 53 "ExtensionMethodTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("}\n");


#line 55 "ExtensionMethodTemplate.cshtml"


#line default
#line hidden

#line 55 "ExtensionMethodTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden

#line 55 "ExtensionMethodTemplate.cshtml"
          
}

if (!String.IsNullOrEmpty(Model.Description) || !String.IsNullOrEmpty(Model.Summary))
{


#line default
#line hidden
WriteLiteral("/// <summary>\n");


#line 61 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", String.IsNullOrEmpty(Model.Summary) ? Model.Description.EscapeXmlComment() : Model.Summary.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");


#line 62 "ExtensionMethodTemplate.cshtml"
    if (!String.IsNullOrEmpty(Model.ExternalDocsUrl))
    {


#line default
#line hidden
WriteLiteral("/// <see href=\"");


#line 64 "ExtensionMethodTemplate.cshtml"
            Write(Model.ExternalDocsUrl);


#line default
#line hidden
WriteLiteral("\" />\n");


#line 65 "ExtensionMethodTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("/// </summary>\n");


#line 67 "ExtensionMethodTemplate.cshtml"
}
if (!String.IsNullOrEmpty(Model.Description) && !String.IsNullOrEmpty(Model.Summary))
{


#line default
#line hidden
WriteLiteral("/// <remarks>\n");


#line 71 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", Model.Description.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </remarks>\n");


#line 73 "ExtensionMethodTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("/// <param name=\'operations\'>\n");

WriteLiteral("/// The operations group for this extension method.\n");

WriteLiteral("/// </param>\n");


#line 77 "ExtensionMethodTemplate.cshtml"
foreach (var parameter in Model.LocalParameters)
{


#line default
#line hidden
WriteLiteral("/// <param name=\'");


#line 79 "ExtensionMethodTemplate.cshtml"
              Write(parameter.Name);


#line default
#line hidden
WriteLiteral("\'>\n");


#line 80 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", parameter.Documentation.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </param>\n");


#line 82 "ExtensionMethodTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("/// <param name=\'cancellationToken\'>\n");

WriteLiteral("/// The cancellation token.\n");

WriteLiteral("/// </param>\n");


#line 86 "ExtensionMethodTemplate.cshtml"
if (Model.Deprecated)
{


#line default
#line hidden
WriteLiteral("[System.Obsolete()]\n");


#line 89 "ExtensionMethodTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("public static async ");


#line 90 "ExtensionMethodTemplate.cshtml"
                 Write(Model.TaskExtensionReturnTypeString);


#line default
#line hidden
WriteLiteral(" ");


#line 90 "ExtensionMethodTemplate.cshtml"
                                                       Write(Model.Name);


#line default
#line hidden
WriteLiteral("Async(");


#line 90 "ExtensionMethodTemplate.cshtml"
                                                                         Write(Model.GetExtensionParameters(Model.GetAsyncMethodParameterDeclaration()));


#line default
#line hidden
WriteLiteral(")\n");

WriteLiteral("{\n");


#line 92 "ExtensionMethodTemplate.cshtml"
    if (Model.ReturnType.Body != null)
    {
        if (Model.ReturnType.Body.IsPrimaryType(KnownPrimaryType.Stream))
        {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("var _result = await operations.");


#line 96 "ExtensionMethodTemplate.cshtml"
                                 Write(Model.Name);


#line default
#line hidden
WriteLiteral("WithHttpMessagesAsync(");


#line 96 "ExtensionMethodTemplate.cshtml"
                                                                    Write(Model.GetAsyncMethodInvocationArgs("null"));


#line default
#line hidden
WriteLiteral(").ConfigureAwait(false);\n");

WriteLiteral("    ");

WriteLiteral("_result.Request.Dispose();\n");

WriteLiteral("    ");

WriteLiteral("return _result.Body;\n");


#line 99 "ExtensionMethodTemplate.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("using (var _result = await operations.");


#line 102 "ExtensionMethodTemplate.cshtml"
                                        Write(Model.Name);


#line default
#line hidden
WriteLiteral("WithHttpMessagesAsync(");


#line 102 "ExtensionMethodTemplate.cshtml"
                                                                           Write(Model.GetAsyncMethodInvocationArgs("null"));


#line default
#line hidden
WriteLiteral(").ConfigureAwait(false))\n");

WriteLiteral("    ");

WriteLiteral("{\n");

WriteLiteral("    ");

WriteLiteral("    return _result.Body;\n");

WriteLiteral("    ");

WriteLiteral("}\n");


#line 106 "ExtensionMethodTemplate.cshtml"
        }
    }
    else if (Model.ReturnType.Headers != null)
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("using (var _result = await operations.");


#line 110 "ExtensionMethodTemplate.cshtml"
                                        Write(Model.Name);


#line default
#line hidden
WriteLiteral("WithHttpMessagesAsync(");


#line 110 "ExtensionMethodTemplate.cshtml"
                                                                           Write(Model.GetAsyncMethodInvocationArgs("null"));


#line default
#line hidden
WriteLiteral(").ConfigureAwait(false))\n");

WriteLiteral("    ");

WriteLiteral("{\n");

WriteLiteral("    ");

WriteLiteral("    return _result.Headers;\n");

WriteLiteral("    ");

WriteLiteral("}\n");


#line 114 "ExtensionMethodTemplate.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteral("    ");

WriteLiteral("await operations.");


#line 117 "ExtensionMethodTemplate.cshtml"
                   Write(Model.Name);


#line default
#line hidden
WriteLiteral("WithHttpMessagesAsync(");


#line 117 "ExtensionMethodTemplate.cshtml"
                                                      Write(Model.GetAsyncMethodInvocationArgs("null"));


#line default
#line hidden
WriteLiteral(").ConfigureAwait(false);\n");


#line 118 "ExtensionMethodTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("}\n");


#line 120 "ExtensionMethodTemplate.cshtml"

    if (Model.SyncMethods == SyncMethodsGenerationMode.All)
    {


#line default
#line hidden

#line 123 "ExtensionMethodTemplate.cshtml"
Write(EmptyLine);


#line default
#line hidden

#line 123 "ExtensionMethodTemplate.cshtml"
          
    if (!String.IsNullOrEmpty(Model.Description) || !String.IsNullOrEmpty(Model.Summary))
    {


#line default
#line hidden
WriteLiteral("/// <summary>\n");


#line 127 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", String.IsNullOrEmpty(Model.Summary) ? Model.Description.EscapeXmlComment() : Model.Summary.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");


#line 128 "ExtensionMethodTemplate.cshtml"
        if (!String.IsNullOrEmpty(Model.ExternalDocsUrl))
        {


#line default
#line hidden
WriteLiteral("/// <see href=\"");


#line 130 "ExtensionMethodTemplate.cshtml"
            Write(Model.ExternalDocsUrl);


#line default
#line hidden
WriteLiteral("\" />\n");


#line 131 "ExtensionMethodTemplate.cshtml"
        }


#line default
#line hidden
WriteLiteral("/// </summary>\n");


#line 133 "ExtensionMethodTemplate.cshtml"
    }
    if (!String.IsNullOrEmpty(Model.Description) && !String.IsNullOrEmpty(Model.Summary))
    {


#line default
#line hidden
WriteLiteral("/// <remarks>\n");


#line 137 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", Model.Description.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </remarks>\n");


#line 139 "ExtensionMethodTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("/// <param name=\'operations\'>\n");

WriteLiteral("/// The operations group for this extension method.\n");

WriteLiteral("/// </param>\n");


#line 143 "ExtensionMethodTemplate.cshtml"
    foreach (var parameter in Model.LocalParameters)
    {


#line default
#line hidden
WriteLiteral("/// <param name=\'");


#line 145 "ExtensionMethodTemplate.cshtml"
              Write(parameter.Name);


#line default
#line hidden
WriteLiteral("\'>\n");


#line 146 "ExtensionMethodTemplate.cshtml"
Write(WrapComment("/// ", parameter.Documentation.EscapeXmlComment()));


#line default
#line hidden
WriteLiteral("\n");

WriteLiteral("/// </param>\n");


#line 148 "ExtensionMethodTemplate.cshtml"
    }


#line default
#line hidden
WriteLiteral("/// <param name=\'customHeaders\'>\n");

WriteLiteral("/// Headers that will be added to request.\n");

WriteLiteral("/// </param>\n");


#line 152 "ExtensionMethodTemplate.cshtml"
if (Model.Deprecated)
{


#line default
#line hidden
WriteLiteral("[System.Obsolete()]\n");


#line 155 "ExtensionMethodTemplate.cshtml"
}


#line default
#line hidden
WriteLiteral("public static ");


#line 156 "ExtensionMethodTemplate.cshtml"
           Write(Model.OperationResponseReturnTypeString);


#line default
#line hidden
WriteLiteral(" ");


#line 156 "ExtensionMethodTemplate.cshtml"
                                                     Write(Model.Name);


#line default
#line hidden
WriteLiteral("WithHttpMessages(");


#line 156 "ExtensionMethodTemplate.cshtml"
                                                                                  Write(Model.GetExtensionParameters(Model.GetSyncMethodParameterDeclaration(true)));


#line default
#line hidden
WriteLiteral(")\n");

WriteLiteral("{\n");

WriteLiteral("    return operations.");


#line 158 "ExtensionMethodTemplate.cshtml"
                    Write(Model.Name);


#line default
#line hidden
WriteLiteral("WithHttpMessagesAsync(");


#line 158 "ExtensionMethodTemplate.cshtml"
                                                       Write(Model.GetAsyncMethodInvocationArgs("customHeaders", "System.Threading.CancellationToken.None"));


#line default
#line hidden
WriteLiteral(").ConfigureAwait(false).GetAwaiter().GetResult();\n");

WriteLiteral("}\n");

WriteLiteral("\n");


#line 161 "ExtensionMethodTemplate.cshtml"
    }


#line default
#line hidden
}
}
}
#pragma warning restore 1591
