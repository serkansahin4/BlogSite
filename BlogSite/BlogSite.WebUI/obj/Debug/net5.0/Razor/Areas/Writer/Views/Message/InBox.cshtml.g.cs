#pragma checksum "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Message\InBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4372896cf094a2b8dcba002377d7f63c787e832e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_InBox), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/InBox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4372896cf094a2b8dcba002377d7f63c787e832e", @"/Areas/Writer/Views/Message/InBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eabe6a6f25a92e33a4b8a2dc8b45313d62d5785d", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Message_InBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Message>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MessageDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Writer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Message\InBox.cshtml"
  
    ViewData["Title"] = "InBox";
    Layout = "~/Areas/Writer/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>InBox</h1>
<table class=""table table-hover"">
    <thead>
        <tr>
            <th>#</th>
            <th>Konu</th>
            <th>Gönderen</th>
            <th>Tarih</th>
            <th>Mesajı Aç</th>
        </tr>
        
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Message\InBox.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Message\InBox.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Message\InBox.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Message\InBox.cshtml"
           Write(item.SenderWriter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Message\InBox.cshtml"
           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4372896cf094a2b8dcba002377d7f63c787e832e6287", async() => {
                WriteLiteral("Mesajı Aç");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Message\InBox.cshtml"
                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        </tr>\n");
#nullable restore
#line 28 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Areas\Writer\Views\Message\InBox.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </tbody>\r\n</table>\r\n<a href=\"#\" class=\"btn btn-primary\">Yeni Mesaj Oluştur</a>");
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
