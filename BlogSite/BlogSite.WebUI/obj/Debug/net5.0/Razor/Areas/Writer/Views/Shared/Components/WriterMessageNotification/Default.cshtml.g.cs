#pragma checksum "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Shared\Components\WriterMessageNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7daeb6d1a90fbdf1a4a39edadd12a24d54c83b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Shared_Components_WriterMessageNotification_Default), @"mvc.1.0.view", @"/Areas/Writer/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
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
#line 1 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\_ViewImports.cshtml"
using BlogSite.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\_ViewImports.cshtml"
using BlogSite.WebUI.Areas.Writer.Models.ViewModels.Blog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7daeb6d1a90fbdf1a4a39edadd12a24d54c83b6", @"/Areas/Writer/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eabe6a6f25a92e33a4b8a2dc8b45313d62d5785d", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Shared_Components_WriterMessageNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Message>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/writer/assets/images/faces/face4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"messageDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Mesajlar</h6>\r\n    <div class=\"dropdown-divider\"></div>\r\n");
#nullable restore
#line 5 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
     foreach (var item in Model)
    {
        
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a class=\"dropdown-item preview-item\">\r\n        <div class=\"preview-thumbnail\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b7daeb6d1a90fbdf1a4a39edadd12a24d54c83b65271", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n            <h6 class=\"preview-subject ellipsis mb-1 font-weight-normal\">");
#nullable restore
#line 14 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                                                    Write(item.SenderWriter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <p class=\"text-gray mb-0\">");
#nullable restore
#line 15 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                 Write(item.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </div>\r\n    </a>\r\n");
#nullable restore
#line 18 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6 class=\"p-3 mb-0 text-center\">3 yeni mesaj</h6>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
