#pragma checksum "C:\Users\матвей1\source\repos\XO_WebApp\Views\Home\win.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1677bf3779d9d1efcd34308a38bdd4a786b7528"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_win), @"mvc.1.0.view", @"/Views/Home/win.cshtml")]
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
#line 1 "C:\Users\матвей1\source\repos\XO_WebApp\Views\_ViewImports.cshtml"
using XO_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\матвей1\source\repos\XO_WebApp\Views\_ViewImports.cshtml"
using XO_WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1677bf3779d9d1efcd34308a38bdd4a786b7528", @"/Views/Home/win.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d70c843fe2fab7d34686aa73d958b8d8c9b9d14a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_win : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>");
#nullable restore
#line 2 "C:\Users\матвей1\source\repos\XO_WebApp\Views\Home\win.cshtml"
Write(Model.xo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" win</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
