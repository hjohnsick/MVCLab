#pragma checksum "C:\Users\hjohnsick\Desktop\GrandCircusLabs\MVCLab\MVCLab\Views\Division\Answer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f048618ab0a1e80099c3ab5ac991f42d238ae0c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Division_Answer), @"mvc.1.0.view", @"/Views/Division/Answer.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\hjohnsick\Desktop\GrandCircusLabs\MVCLab\MVCLab\Views\_ViewImports.cshtml"
using MVCLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hjohnsick\Desktop\GrandCircusLabs\MVCLab\MVCLab\Views\_ViewImports.cshtml"
using MVCLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f048618ab0a1e80099c3ab5ac991f42d238ae0c2", @"/Views/Division/Answer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3203db848336499b4bb043e09fd62d44056bc97", @"/Views/_ViewImports.cshtml")]
    public class Views_Division_Answer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnswerModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hjohnsick\Desktop\GrandCircusLabs\MVCLab\MVCLab\Views\Division\Answer.cshtml"
  
    ViewData["Title"] = "Answer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>Quotient Result ");
#nullable restore
#line 7 "C:\Users\hjohnsick\Desktop\GrandCircusLabs\MVCLab\MVCLab\Views\Division\Answer.cshtml"
               Write(Model.GetQuotient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Remainder Result ");
#nullable restore
#line 8 "C:\Users\hjohnsick\Desktop\GrandCircusLabs\MVCLab\MVCLab\Views\Division\Answer.cshtml"
                Write(Model.GetRemainder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnswerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591