#pragma checksum "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Shared\Components\CalendarModal\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cdbcf35951f5f16be3171d8136146d45c6ccbbd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cdbcf35951f5f16be3171d8136146d45c6ccbbd", @"/Views/Shared/Components/CalendarModal/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1d7316414513ea68c01560b78a295bf5398467", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CalendarModal_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("was-validated"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2688, true);
            WriteLiteral(@"<div class=""modal-header MHeader"">
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
                <div class=""col-5"">
                    <h3 class=""room-rates-title"">Revenue Forecast</h3>
                    <div class=""room-rates-desc"">
                        ADR: $125
                    </d");
            WriteLiteral(@"iv>
                    <div class=""room-rates-desc"">
                        OCCUPANCY: 81%
                    </div>
                    <div class=""room-rates-desc"">
                        RevPAR: $91
                    </div>
                </div>
                <div class=""col-6"">
                    <h3 class=""room-rates-title"">Growth Comparison</h3>
                    <div class=""row"">
                        <div class=""col-6"">
                            <h4 class=""room-rates-growth-title"">Yesterday</h4>
                            <div class=""room-rates-desc"">
                                ADR: -0.3%
                            </div>
                            <div class=""room-rates-desc"">
                                OCCUPANCY: -1%
                            </div>
                            <div class=""room-rates-desc"">
                                RevPAR: -0.4%
                            </div>
                        </div>
                        <div c");
            WriteLiteral(@"lass=""col-6"">
                            <h4 class=""room-rates-growth-title"">Previous Month</h4>
                            <div class=""room-rates-desc"">
                                ADR: -0.3%
                            </div>
                            <div class=""room-rates-desc"">
                                OCCUPANCY: -1%
                            </div>
                            <div class=""room-rates-desc"">
                                RevPAR: -0.4%
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            ");
            EndContext();
            BeginContext(2688, 5650, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9422a353c3c74fa7b26a06699623152a", async() => {
                BeginContext(2716, 5615, true);
                WriteLiteral(@"
                <div class=""form-row"">
                    <div class=""custom-control custom-radio room-rates-radio col"">
                        <input type=""radio"" class=""custom-control-input"" id=""RecommendedRate"" name=""radio-stacked"" required checked>
                        <label class=""custom-control-label"" for=""RecommendedRate"">Use Recommended Rate</label>
                        <div class=""room-rates-recommended"">
                            Standard Room: $112
                        </div>
                        <div class=""room-rates-recommended"">
                            Superior Room: $180
                        </div>
                        <div class=""room-rates-recommended"">
                            Deluxe Room: $200
                        </div>
                        <div class=""room-rates-recommended"">
                            Family Room: $210
                        </div>
                        <div class=""room-rates-recommended"">
                      ");
                WriteLiteral(@"      Suite Room: $280
                        </div>
                    </div>
                    <div class=""custom-control custom-radio mb-3 room-rates-radio col"">
                        <input type=""radio"" class=""custom-control-input"" id=""DefaultRate"" name=""radio-stacked"" required>
                        <label class=""custom-control-label"" for=""DefaultRate"">Use Default Rate</label>
                        <div class=""room-rates-recommended"">
                            Standard Room: $102
                        </div>
                        <div class=""room-rates-recommended"">
                            Superior Room: $150
                        </div>
                        <div class=""room-rates-recommended"">
                            Deluxe Room: $190
                        </div>
                        <div class=""room-rates-recommended"">
                            Family Room: $200
                        </div>
                        <div class=""room-rates-recommende");
                WriteLiteral(@"d"">
                            Suite Room: $230
                        </div>
                    </div>
                </div>
                <div class=""form-row"">
                    <div class=""custom-control custom-radio mb-3 room-rates-radio"" style=""padding-left:0px;"">
                        <input type=""radio"" class=""custom-control-input"" id=""AdjustedRate"" name=""radio-stacked"" required>
                        <label class=""custom-control-label"" for=""AdjustedRate"">Set a adjusted rate</label>
                    </div>
                    <div class=""w-100""></div>
                    <!--Input group-->
                    <div class=""col-4"">
                        <label for=""StandardRoom"">Standard Room</label>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <div class=""input-group-text"">Rp</div>
                            </div>
                            <input type=""number"" class=""");
                WriteLiteral(@"form-control"" id=""StandardRoom"" min=""0"" placeholder=""Price"">
                        </div>
                    </div>
                    <div class=""col-4"">
                        <label for=""SuperiorRoom"">Superior Room</label>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <div class=""input-group-text"">Rp</div>
                            </div>
                            <input type=""number"" class=""form-control"" id=""SuperiorRoom"" min=""0"" placeholder=""Price"">
                        </div>
                    </div>
                    <div class=""col-4"">
                        <label for=""DeluxeRoom"">Deluxe Room</label>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <div class=""input-group-text"">Rp</div>
                            </div>
                            <input type=""number"" class=""");
                WriteLiteral(@"form-control"" id=""DeluxeRoom"" min=""0"" placeholder=""Price"">
                        </div>
                    </div>
                    <div class=""col-4"">
                        <label for=""FamilyRoom"" style=""margin-top:10px;"">Family Room</label>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <div class=""input-group-text"">Rp</div>
                            </div>
                            <input type=""number"" class=""form-control"" id=""FamilyRoom"" min=""0"" placeholder=""Price"">
                        </div>
                    </div>
                    <div class=""col-4"">
                        <label for=""SuiteRoom"" style=""margin-top:10px;"">Suite Room</label>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <div class=""input-group-text"">Rp</div>
                            </div>
                ");
                WriteLiteral(@"            <input type=""number"" class=""form-control"" id=""SuiteRoom"" min=""0"" placeholder=""Price"">
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"" style=""border:none; margin-top:20px;"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-primary"">Save changes</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8338, 5459, true);
            WriteLiteral(@"
        </div>
        <div class=""tab-pane"" id=""access-security"">
            <div class=""metrics-container"">
                <h3 class=""metrics-title"">Distribution Status</h3>
                <div class=""row"">
                    <div class=""col-6"">
                        <h4 class=""metrics-sub-title"">ADR</h4>
                        <div class=""row"">
                            <div class=""col-10"">
                                Seasonal Demands
                            </div>
                            <div class=""col-2"">
                                10%
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-10"">
                                Historical Data
                            </div>
                            <div class=""col-2"">
                                10%
                            </div>
                        </div>
                        <div class=");
            WriteLiteral(@"""row"">
                            <div class=""col-10"">
                                Social Media
                            </div>
                            <div class=""col-2"">
                                10%
                            </div>
                        </div>
                    </div>
                    <div class=""col-6"">
                        <h4 class=""metrics-sub-title"">OCCUPANCY</h4>
                        <div class=""row"">
                            <div class=""col-10"">
                                Seasonal Demands
                            </div>
                            <div class=""col-2"">
                                10%
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-10"">
                                Historical Data
                            </div>
                            <div class=""col-2"">
                               ");
            WriteLiteral(@" 10%
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-10"">
                                Social Media
                            </div>
                            <div class=""col-2"">
                                10%
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""tab-pane"" id=""networking"">
            <div class=""metrics-container"">
                <h3 class=""metrics-title"">What-If Analytics</h3>
                <div class=""row"" style=""margin-top:20px;"">
                    <div class=""col-4"">
                        <label for=""StandardRoomWI"">Standard Room</label>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <div class=""input-group-text"">Rp</div>
            ");
            WriteLiteral(@"                </div>
                            <input type=""number"" class=""form-control"" id=""StandardRoomWI"" min=""0"" placeholder=""Price"">
                        </div>
                    </div>
                    <div class=""col-4"">
                        <label for=""SuperiorRoomWI"">Superior Room</label>
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
    ");
            WriteLiteral(@"                        </div>
                            <input type=""number"" class=""form-control"" id=""DeluxeRoomWI"" min=""0"" placeholder=""Price"">
                        </div>
                    </div>
                    <div class=""col-4"">
                        <label for=""FamilyRoomWI"" style=""margin-top:10px;"">Family Room</label>
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
                            ");
            WriteLiteral(@"    <div class=""input-group-text"">Rp</div>
                            </div>
                            <input type=""number"" class=""form-control"" id=""SuiteRoomWI"" min=""0"" placeholder=""Price"">
                        </div>
                    </div>
                </div>
            </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
