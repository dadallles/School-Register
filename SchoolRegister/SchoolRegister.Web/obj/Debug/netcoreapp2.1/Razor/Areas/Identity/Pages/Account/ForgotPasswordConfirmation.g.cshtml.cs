#pragma checksum "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba2e21c157b4a2f07244cb261453fa97f0d16ef1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SchoolRegister.Web.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml", typeof(SchoolRegister.Web.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), null)]
namespace SchoolRegister.Web.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using SchoolRegister.Web.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using SchoolRegister.BLL.Entities;

#line default
#line hidden
#line 1 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using SchoolRegister.Web.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 2 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2e21c157b4a2f07244cb261453fa97f0d16ef1", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"845ee717b41a349a3cb20d20bec35417de6f83fa", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2802b3d98d7da6f3a7ae2e90644c2c42bebb8bf6", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = Localizer["ForgotPasswordConfirm"];

#line default
#line hidden
            BeginContext(183, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(189, 17, false);
#line 9 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(206, 14, true);
            WriteLiteral("</h2>\n<p>\n    ");
            EndContext();
            BeginContext(221, 26, false);
#line 11 "C:\Users\Dawid\Documents\GIT\ASP-.Net-Core-Learning\SchoolRegister\SchoolRegister.Web\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
Write(Localizer["CheckEmailMsg"]);

#line default
#line hidden
            EndContext();
            BeginContext(247, 7, true);
            WriteLiteral("\n</p>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordConfirmation> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation>)PageContext?.ViewData;
        public ForgotPasswordConfirmation Model => ViewData.Model;
    }
}
#pragma warning restore 1591