#pragma checksum "C:\Users\Siew Mun\Desktop\FYP-APP\HRMS\HRMS\Views\Shared\Components\CalendarModal\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32eda0a3059e8100a95c53e72e6feaac76bdf34c"
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
#line 1 "C:\Users\Siew Mun\Desktop\FYP-APP\HRMS\HRMS\Views\_ViewImports.cshtml"
using HRMS;

#line default
#line hidden
#line 2 "C:\Users\Siew Mun\Desktop\FYP-APP\HRMS\HRMS\Views\_ViewImports.cshtml"
using HRMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32eda0a3059e8100a95c53e72e6feaac76bdf34c", @"/Views/Shared/Components/CalendarModal/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1d7316414513ea68c01560b78a295bf5398467", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CalendarModal_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3280, true);
            WriteLiteral(@"<div class=""modal-header MHeader"">
    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Set Adjusted Rate</h5>
    <button type=""button"" class=""close MHeader-close"" data-dismiss=""modal"" aria-label=""Close"">
        <span aria-hidden=""true"">&times;</span>
    </button>
</div>
<div class=""modal-body"">
    <div class=""tab-pane"" id=""networking"">
        <div class=""metrics-container"">
            <h3 class=""metrics-title"">Date</h3>
            <div class=""row"" style=""margin-top:20px;"">
                <div class=""col-4"">
                    <label for=""StandardRoomWI"">Standard Room</label>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">Rp</div>
                        </div>
                        <input type=""number"" class=""form-control"" id=""StandardRoomWI"" min=""0"" placeholder=""Price"">
                    </div>
                </div>
                <div class=""col-4"">
      ");
            WriteLiteral(@"              <label for=""SuperiorRoomWI"">Superior Room</label>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">Rp</div>
                        </div>
                        <input type=""number"" class=""form-control"" id=""SuperiorRoomWI"" min=""0"" placeholder=""Price"">
                    </div>
                </div>
                <div class=""col-4"">
                    <label for=""DeluxeRoomWI"">Deluxe Room</label>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">Rp</div>
                        </div>
                        <input type=""number"" class=""form-control"" id=""DeluxeRoomWI"" min=""0"" placeholder=""Price"">
                    </div>
                </div>
                <div class=""col-4"">
                    <label for=""FamilyRoomWI"" style=""margin-top:10px;"">F");
            WriteLiteral(@"amily Room</label>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">Rp</div>
                        </div>
                        <input type=""number"" class=""form-control"" id=""FamilyRoomWI"" min=""0"" placeholder=""Price"">
                    </div>
                </div>
                <div class=""col-4"">
                    <label for=""SuiteRoomWI"" style=""margin-top:10px;"">Suite Room</label>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <div class=""input-group-text"">Rp</div>
                        </div>
                        <input type=""number"" class=""form-control"" id=""SuiteRoomWI"" min=""0"" placeholder=""Price"">
                    </div>
                </div>
            </div>
            <div class=""modal-footer"" style=""border:none; margin-top:20px;"">
                <button type=""button");
            WriteLiteral("\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Save changes</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
