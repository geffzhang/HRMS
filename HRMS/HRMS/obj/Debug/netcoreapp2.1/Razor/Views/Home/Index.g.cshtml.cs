#pragma checksum "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3038d557dfeedd47edebc21fb49f384c1a571fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
#line 1 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3038d557dfeedd47edebc21fb49f384c1a571fa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1d7316414513ea68c01560b78a295bf5398467", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CalendarEvent>
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
        private global::HRMS.TagHelpers.CalendarTagHelper __HRMS_TagHelpers_CalendarTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";
    List<CalendarEvent> events = new List<CalendarEvent>();
    DateTime thisDate = new DateTime(2018, 12, 15);
    events.Add(new CalendarEvent { Title = "hellp", Date = thisDate, Type = "info" });


#line default
#line hidden
            BeginContext(303, 8, true);
            WriteLiteral("\r\n\r\n<h2>");
            EndContext();
            BeginContext(312, 17, false);
#line 13 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(329, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(338, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("calendar", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51752a82faf54d88bb7aeef3f3542b7d", async() => {
            }
            );
            __HRMS_TagHelpers_CalendarTagHelper = CreateTagHelper<global::HRMS.TagHelpers.CalendarTagHelper>();
            __tagHelperExecutionContext.Add(__HRMS_TagHelpers_CalendarTagHelper);
#line 15 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\Index.cshtml"
__HRMS_TagHelpers_CalendarTagHelper.Month = 12;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("month", __HRMS_TagHelpers_CalendarTagHelper.Month, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\Index.cshtml"
__HRMS_TagHelpers_CalendarTagHelper.Year = 2018;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("year", __HRMS_TagHelpers_CalendarTagHelper.Year, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "C:\Users\USER\Desktop\FYP-APP\HRMS\HRMS\Views\Home\Index.cshtml"
__HRMS_TagHelpers_CalendarTagHelper.Events = events;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("events", __HRMS_TagHelpers_CalendarTagHelper.Events, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CalendarEvent> Html { get; private set; }
    }
}
#pragma warning restore 1591
