#pragma checksum "C:\Users\Siew Mun\Desktop\FYP-APP\HRMS\HRMS\Views\Shared\Components\WhatifModal\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba5b3a0aba3ccc87a4c352ec560e8332aa4c934b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WhatifModal_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WhatifModal/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/WhatifModal/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_WhatifModal_Default))]
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
#line 1 "C:\Users\Siew Mun\Desktop\FYP-APP\HRMS\HRMS\Views\_ViewImports.cshtml"
using HRMS;

#line default
#line hidden
#line 2 "C:\Users\Siew Mun\Desktop\FYP-APP\HRMS\HRMS\Views\_ViewImports.cshtml"
using HRMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba5b3a0aba3ccc87a4c352ec560e8332aa4c934b", @"/Views/Shared/Components/WhatifModal/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1d7316414513ea68c01560b78a295bf5398467", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WhatifModal_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "865d5f5e45064c35972245d040026c2f", async() => {
                BeginContext(6, 2184, true);
                WriteLiteral(@"
    <div class=""form-group row"">
        <label for=""sprroom"" class=""col-3 col-lg-2 col-form-label text-right"">Superior Room:</label>
        <div class=""col-8 col-lg-9 input-group"">
            <div class=""input-group-prepend"">
                <div class=""input-group-text"">Rp</div>
            </div>
            <input id=""sprroom"" type=""number"" required="""" placeholder=""Price"" class=""form-control"">
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""stdroom"" class=""col-3 col-lg-2 col-form-label text-right"">Standard Room:</label>
        <div class=""col-8 col-lg-9 input-group"">
            <div class=""input-group-prepend"">
                <div class=""input-group-text"">Rp</div>
            </div>
            <input id=""stdroom"" type=""number"" required="""" placeholder=""Price"" class=""form-control"">
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""famroom"" class=""col-3 col-lg-2 col-form-label text-right"">Family Room:</label>
        <div");
                WriteLiteral(@" class=""col-8 col-lg-9 input-group"">
            <div class=""input-group-prepend"">
                <div class=""input-group-text"">Rp</div>
            </div>
            <input id=""famroom"" type=""number"" required="""" placeholder=""Price"" class=""form-control"">
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""suiteroom"" class=""col-3 col-lg-2 col-form-label text-right"">Suite:</label>
        <div class=""col-8 col-lg-9 input-group"">
            <div class=""input-group-prepend"">
                <div class=""input-group-text"">Rp</div>
            </div>
            <input id=""suiteroom"" type=""number"" required="""" placeholder=""Price"" class=""form-control"">
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""dlxroom"" class=""col-3 col-lg-2 col-form-label text-right"">Deluxe Room:</label>
        <div class=""col-8 col-lg-9 input-group"">
            <div class=""input-group-prepend"">
                <div class=""input-group-text"">Rp</div>
            <");
                WriteLiteral("/div>\r\n            <input id=\"dlxroom\" type=\"number\" required=\"\" placeholder=\"Price\" class=\"form-control\">\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
