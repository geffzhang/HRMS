#pragma checksum "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7ca43f74a68d6e62da6191e194d26dcf6f5da5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WhatIfAnalysis), @"mvc.1.0.view", @"/Views/Home/WhatIfAnalysis.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/WhatIfAnalysis.cshtml", typeof(AspNetCore.Views_Home_WhatIfAnalysis))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7ca43f74a68d6e62da6191e194d26dcf6f5da5f", @"/Views/Home/WhatIfAnalysis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1d7316414513ea68c01560b78a295bf5398467", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WhatIfAnalysis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WhatIfAnalysisViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
  
    var DateString = Model.Date.ToString("dd-MM-yyyy");
    ViewData["Title"] = Model.Date.ToString("dd MMMM yyyy") + " Analysis";
    var xlabel = Newtonsoft.Json.JsonConvert.SerializeObject(Model.DatesLabel);
    var PredADR = Newtonsoft.Json.JsonConvert.SerializeObject(Model.PredictedAdr);
    var AdjADR = Newtonsoft.Json.JsonConvert.SerializeObject(Model.AdjustedAdr);
    var PredRP = Newtonsoft.Json.JsonConvert.SerializeObject(Model.PredictedRevPar);
    var AdjRP = Newtonsoft.Json.JsonConvert.SerializeObject(Model.AdjustedRevPar);

    var adrdiff = Math.Abs(Convert.ToDouble(Model.PredictedAdr[Model.PredictedAdr.Count - 1]) - Convert.ToDouble(Model.AdjustedAdr[Model.AdjustedAdr.Count - 1]));
    var revpardiff = Math.Abs(Convert.ToDouble(Model.PredictedRevPar[Model.PredictedRevPar.Count - 1]) - Convert.ToDouble(Model.AdjustedRevPar[Model.AdjustedRevPar.Count - 1]));

    var selectedDatePredAdr = Convert.ToDouble(Model.PredictedAdr[Model.PredictedAdr.Count - 1]);
    var selectedDatePredRP = Convert.ToDouble(Model.PredictedRevPar[Model.PredictedRevPar.Count - 1]);
    var selectedDateAdjAdr = Convert.ToDouble(Model.AdjustedAdr[Model.AdjustedAdr.Count - 1]);
    var selectedDateAdjRP = Convert.ToDouble(Model.AdjustedRevPar[Model.AdjustedRevPar.Count - 1]);

#line default
#line hidden
            BeginContext(1336, 184, true);
            WriteLiteral("\r\n<!-- pageheader -->\r\n<div class=\"row\">\r\n    <div class=\"col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12\">\r\n        <div class=\"page-header\">\r\n            <h2 class=\"pageheader-title\">");
            EndContext();
            BeginContext(1521, 17, false);
#line 24 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                                    Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1538, 194, true);
            WriteLiteral("</h2>\r\n            <div class=\"page-breadcrumb\">\r\n                <nav aria-label=\"breadcrumb\">\r\n                    <ol class=\"breadcrumb\">\r\n                        <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(1732, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc7afbc434b2456f886302cf4708aed6", async() => {
                BeginContext(1778, 9, true);
                WriteLiteral("Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1791, 109, true);
            WriteLiteral("</li>\r\n                        <li class=\"breadcrumb-item\" aria-current=\"page\">\r\n                            ");
            EndContext();
            BeginContext(1900, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a323dcbd413c460ea0cc649dae7effc8", async() => {
                BeginContext(2003, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-selected", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                                                                                  WriteLiteral(DateString);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selected"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-selected", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selected"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2014, 822, true);
            WriteLiteral(@"
                        </li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Analysis</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>


<!-- Average Daily Rate What-If -->
<div class=""row"">
    <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
        <div class=""card"">
            <h5 class=""card-header"">Average Daily Rate</h5>
            <div class=""card-body"">
                <canvas id=""averageDailyRate"" width=""400"" height=""150""></canvas>
            </div>
            <div class=""card-body border-top"">
                <div class=""row"">
                    <div class=""offset-xl-1 col-xl-3 col-lg-3 col-md-12 col-sm-12 col-12 p-3"">
                        <h4> Difference Calculated: Rp ");
            EndContext();
            BeginContext(2837, 22, false);
#line 52 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                                                  Write(adrdiff.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(2859, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
            BeginContext(2973, 192, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"offset-xl-1 col-xl-3 col-lg-3 col-md-6 col-sm-12 col-12 p-3\">\r\n                        <h2 class=\"font-weight-normal mb-3\"><span>Rp ");
            EndContext();
            BeginContext(3166, 34, false);
#line 58 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                                                                Write(selectedDatePredAdr.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(3200, 533, true);
            WriteLiteral(@"</span></h2>
                        <div class=""mb-0 mt-3 legend-item"">
                            <span class=""fa-xs text-primary mr-1 legend-title ""><i class=""fa fa-fw fa-square-full""></i></span>
                            <span class=""legend-text"">Predicted ADR</span>
                        </div>
                    </div>
                    <div class=""offset-xl-1 col-xl-3 col-lg-3 col-md-6 col-sm-12 col-12 p-3"">
                        <h2 class=""font-weight-normal mb-3"">
                            <span>Rp ");
            EndContext();
            BeginContext(3734, 33, false);
#line 66 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                                Write(selectedDateAdjAdr.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(3767, 925, true);
            WriteLiteral(@"</span>
                        </h2>
                        <div class=""text-muted mb-0 mt-3 legend-item""> <span class=""fa-xs text-secondary mr-1 legend-title""><i class=""fa fa-fw fa-square-full""></i></span><span class=""legend-text"">Adjusted ADR</span></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- RevPAR What-If -->
    <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
        <div class=""card"">
            <h5 class=""card-header"">Revenue Per Average Room</h5>
            <div class=""card-body"">
                <canvas id=""revenuePerAvg"" width=""400"" height=""150""></canvas>
            </div>
            <div class=""card-body border-top"">
                <div class=""row"">
                    <div class=""offset-xl-1 col-xl-3 col-lg-3 col-md-12 col-sm-12 col-12 p-3"">
                        <h4> Difference Calculated: Rp ");
            EndContext();
            BeginContext(4693, 25, false);
#line 85 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                                                  Write(revpardiff.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(4718, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
            BeginContext(4832, 192, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"offset-xl-1 col-xl-3 col-lg-3 col-md-6 col-sm-12 col-12 p-3\">\r\n                        <h2 class=\"font-weight-normal mb-3\"><span>Rp ");
            EndContext();
            BeginContext(5025, 33, false);
#line 91 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                                                                Write(selectedDatePredRP.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(5058, 536, true);
            WriteLiteral(@"</span></h2>
                        <div class=""mb-0 mt-3 legend-item"">
                            <span class=""fa-xs text-primary mr-1 legend-title ""><i class=""fa fa-fw fa-square-full""></i></span>
                            <span class=""legend-text"">Predicted RevPAR</span>
                        </div>
                    </div>
                    <div class=""offset-xl-1 col-xl-3 col-lg-3 col-md-6 col-sm-12 col-12 p-3"">
                        <h2 class=""font-weight-normal mb-3"">
                            <span>Rp ");
            EndContext();
            BeginContext(5595, 32, false);
#line 99 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                                Write(selectedDateAdjRP.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(5627, 648, true);
            WriteLiteral(@"</span>
                        </h2>
                        <div class=""text-muted mb-0 mt-3 legend-item""> <span class=""fa-xs text-secondary mr-1 legend-title""><i class=""fa fa-fw fa-square-full""></i></span><span class=""legend-text"">Adjusted RevPAR</span></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<!-- Line Chart -->
<script type=""text/javascript"">
    $(function () {
        var ctx = document.getElementById('averageDailyRate').getContext('2d');
        var myChart = new Chart(ctx, {
            type: 'line',

            data: {
                labels: ");
            EndContext();
            BeginContext(6276, 16, false);
#line 118 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                   Write(Html.Raw(xlabel));

#line default
#line hidden
            EndContext();
            BeginContext(6292, 104, true);
            WriteLiteral(",\r\n                datasets: [{\r\n                    label: \'Predicted ADR\',\r\n                    data: ");
            EndContext();
            BeginContext(6397, 17, false);
#line 121 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                     Write(Html.Raw(PredADR));

#line default
#line hidden
            EndContext();
            BeginContext(6414, 257, true);
            WriteLiteral(@",
                    backgroundColor: ""rgba(89, 105, 255,0.5)"",
                    borderColor: ""rgba(89, 105, 255,0.7)"",
                    borderWidth: 2

                }, {
                    label: 'Adjusted ADR',
                    data: ");
            EndContext();
            BeginContext(6672, 16, false);
#line 128 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                     Write(Html.Raw(AdjADR));

#line default
#line hidden
            EndContext();
            BeginContext(6688, 1691, true);
            WriteLiteral(@",
                    backgroundColor: ""rgba(255, 64, 123,0.5)"",
                    borderColor: ""rgba(255, 64, 123,0.7)"",
                    borderWidth: 2
                }]
            },
            options: {
                legend: {
                    display: true,
                    position: 'bottom',
                    labels: {
                        fontColor: '#71748d',
                        fontSize: 14,
                    }
                },
                scales: {
                    yAxes: [{
                        ticks: {
                            // Include a dollar sign in the ticks
                            callback: function (value, index, values) {
                                return '$' + value;
                            }
                        }
                    }]
                },

                scales: {
                    xAxes: [{
                        ticks: {
                            fontSize: 14,
             ");
            WriteLiteral(@"               fontFamily: 'Circular Std Book',
                            fontColor: '#71748d',
                        }
                    }],
                    yAxes: [{
                        ticks: {
                            fontSize: 14,
                            fontFamily: 'Circular Std Book',
                            fontColor: '#71748d',
                        }
                    }]
                }
            }
        });


        var ctx = document.getElementById('revenuePerAvg').getContext('2d');
        var myChart = new Chart(ctx, {
            type: 'line',

            data: {
                labels: ");
            EndContext();
            BeginContext(8380, 16, false);
#line 179 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                   Write(Html.Raw(xlabel));

#line default
#line hidden
            EndContext();
            BeginContext(8396, 107, true);
            WriteLiteral(",\r\n                datasets: [{\r\n                    label: \'Predicted RevPAR\',\r\n                    data: ");
            EndContext();
            BeginContext(8504, 16, false);
#line 182 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                     Write(Html.Raw(PredRP));

#line default
#line hidden
            EndContext();
            BeginContext(8520, 260, true);
            WriteLiteral(@",
                    backgroundColor: ""rgba(89, 105, 255,0.5)"",
                    borderColor: ""rgba(89, 105, 255,0.7)"",
                    borderWidth: 2

                }, {
                    label: 'Adjusted RevPAR',
                    data: ");
            EndContext();
            BeginContext(8781, 15, false);
#line 189 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\WhatIfAnalysis.cshtml"
                     Write(Html.Raw(AdjRP));

#line default
#line hidden
            EndContext();
            BeginContext(8796, 1519, true);
            WriteLiteral(@",
                    backgroundColor: ""rgba(255, 64, 123,0.5)"",
                    borderColor: ""rgba(255, 64, 123,0.7)"",
                    borderWidth: 2
                }]
            },

            options: {
                legend: {
                    display: true,
                    position: 'bottom',
                    labels: {
                        fontColor: '#71748d',
                        fontSize: 14,
                    }
                },
                scales: {
                    yAxes: [{
                        ticks: {
                            // Include a dollar sign in the ticks
                            callback: function (value, index, values) {
                                return '$' + value;
                            }
                        }
                    }]
                },

                scales: {
                    xAxes: [{
                        ticks: {
                            fontSize: 14,
           ");
            WriteLiteral(@"                 fontFamily: 'Circular Std Book',
                            fontColor: '#71748d',
                        }
                    }],
                    yAxes: [{
                        ticks: {
                            fontSize: 14,
                            fontFamily: 'Circular Std Book',
                            fontColor: '#71748d',
                        }
                    }]
                }
            }
        });
    });
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WhatIfAnalysisViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
