#pragma checksum "/Users/shehryarkhan/Projects/Dynamic User-Defined Dashboards/Views/Dashboard/Elements/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "770ef68d0bfb811ff269d163bada5ace972143b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Elements_Default), @"mvc.1.0.view", @"/Views/Dashboard/Elements/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Elements/Default.cshtml", typeof(AspNetCore.Views_Dashboard_Elements_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"770ef68d0bfb811ff269d163bada5ace972143b0", @"/Views/Dashboard/Elements/Default.cshtml")]
    public class Views_Dashboard_Elements_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4, "\"", 36, 3);
            WriteAttributeValue("", 12, "height:", 12, 7, true);
#line 1 "/Users/shehryarkhan/Projects/Dynamic User-Defined Dashboards/Views/Dashboard/Elements/Default.cshtml"
WriteAttributeValue("", 19, ViewBag.DHeight, 19, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 35, ";", 35, 1, true);
            EndWriteAttribute();
            BeginContext(37, 248, true);
            WriteLiteral(" class=\"dropify-wrapper\">\n    <div class=\"dropify-message\">\n        <span class=\"fa fa-plus-square fa-4x\"></span> \n        <p>Click here to Select Dashboard Element</p>\n    </div>\n    <input type=\"button\" id=\"input-file-now\" class=\"dropify\">\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
