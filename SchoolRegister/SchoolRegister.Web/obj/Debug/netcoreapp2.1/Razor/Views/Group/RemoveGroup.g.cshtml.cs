#pragma checksum "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\Group\RemoveGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f5c37e3e71f89982f42916fc8e0cf374e176428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_RemoveGroup), @"mvc.1.0.view", @"/Views/Group/RemoveGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Group/RemoveGroup.cshtml", typeof(AspNetCore.Views_Group_RemoveGroup))]
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
#line 1 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\_ViewImports.cshtml"
using SchoolRegister.Web;

#line default
#line hidden
#line 2 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\_ViewImports.cshtml"
using SchoolRegister.Web.Models;

#line default
#line hidden
#line 1 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\Group\RemoveGroup.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f5c37e3e71f89982f42916fc8e0cf374e176428", @"/Views/Group/RemoveGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d0783724ed864fe6452b5b898b23f5c64f72546", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_RemoveGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolRegister.ViewModels.VMs.GroupVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\Group\RemoveGroup.cshtml"
  
    ViewData["Title"] = Localizer["RemoveGroup"];

#line default
#line hidden
            BeginContext(178, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(184, 24, false);
#line 8 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\Group\RemoveGroup.cshtml"
Write(Localizer["RemoveGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(208, 11, true);
            WriteLiteral("</h2>\n\n<h3>");
            EndContext();
            BeginContext(220, 31, false);
#line 10 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\Group\RemoveGroup.cshtml"
Write(Localizer["RemoveGroupConfirm"]);

#line default
#line hidden
            EndContext();
            BeginContext(251, 79, true);
            WriteLiteral("</h3>\n<div>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(331, 38, false);
#line 15 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\Group\RemoveGroup.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(369, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(410, 34, false);
#line 18 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\Group\RemoveGroup.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(444, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(485, 17, false);
#line 21 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\Group\RemoveGroup.cshtml"
       Write(Localizer["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(502, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(543, 36, false);
#line 24 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\Group\RemoveGroup.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(579, 30, true);
            WriteLiteral("\n        </dd>\n    </dl>\n\n    ");
            EndContext();
            BeginContext(609, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ab90cd56b0f4a33805eeabf70b85ba8", async() => {
                BeginContext(640, 29, true);
                WriteLiteral("\n        <input type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 669, "\"", 697, 1);
#line 29 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\Group\RemoveGroup.cshtml"
WriteAttributeValue("", 677, Localizer["Delete"], 677, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(698, 38, true);
                WriteLiteral(" class=\"btn btn-default\" /> |\n        ");
                EndContext();
                BeginContext(736, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a842ce0093e44cffbd40a4525ab6b262", async() => {
                    BeginContext(759, 26, false);
#line 30 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Views\Group\RemoveGroup.cshtml"
                         Write(Localizer["BackListGroup"]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(789, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(801, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolRegister.ViewModels.VMs.GroupVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
