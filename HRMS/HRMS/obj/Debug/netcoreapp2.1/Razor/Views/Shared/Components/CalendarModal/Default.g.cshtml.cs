#pragma checksum "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Shared\Components\CalendarModal\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dab828d65bf6f87eeb81b35e32c3e5bc364bfa9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CalendarModal_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CalendarModal/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CalendarModal/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CalendarModal_Default))]
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
#line 1 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\_ViewImports.cshtml"
using HRMS;

#line default
#line hidden
#line 2 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\_ViewImports.cshtml"
using HRMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dab828d65bf6f87eeb81b35e32c3e5bc364bfa9b", @"/Views/Shared/Components/CalendarModal/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1d7316414513ea68c01560b78a295bf5398467", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CalendarModal_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DailyPredictionModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 1679, true);
            WriteLiteral(@"
<div class=""modal-header MHeader"">
    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Details</h5>
    <button type=""button"" class=""close MHeader-close"" data-dismiss=""modal"" aria-label=""Close"">
        <span aria-hidden=""true"">&times;</span>
    </button>
</div>
<div class=""modal-body"">
    <ul class=""nav nav-tabs"" id=""tabContent"">
        <li class=""nav-item""><a href=""#details"" class=""nav-link active"" data-toggle=""tab"">Room Rates</a></li>
        <li class=""nav-item""><a href=""#access-security"" class=""nav-link"" data-toggle=""tab"">Metrics</a></li>
        <li class=""nav-item""><a href=""#networking"" class=""nav-link"" data-toggle=""tab"">What-If Analysis</a></li>
    </ul>

    <div class=""tab-content"">
        <div class=""tab-pane active"" id=""details"">
            <div class=""row"">
                <div class=""col-sm"">
                    <h3 class=""room-rates-title"">Revenue Forecast</h3>
                    <div>

                    </div>
                </div>
                <div clas");
            WriteLiteral(@"s=""col-sm"">
                    <h3 class=""room-rates-title"">Growth Comparison</h3>
                </div>
            </div>
            <div class=""modal-footer"" style=""border:none; margin-top:20px;"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
        <div class=""tab-pane"" id=""access-security"">
            Prediction metrics herfe
        </div>
        <div class=""tab-pane"" id=""networking"">
            What-If analysis
        </div>
    </div>

</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DailyPredictionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591