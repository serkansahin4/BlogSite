#pragma checksum "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "747019718350688ca9282b62fe617d752d6e12b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\_ViewImports.cshtml"
using BlogSite.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\_ViewImports.cshtml"
using BlogSite.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\_ViewImports.cshtml"
using BlogSite.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747019718350688ca9282b62fe617d752d6e12b7", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c07081cff3fe8e69fb9e8da1e55f5458c75321", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Blog Posts</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 14 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 564, "\"", 593, 2);
            WriteAttributeValue("", 571, "/Blog/Details/", 571, 14, true);
#nullable restore
#line 17 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml"
WriteAttributeValue("", 585, item.Id, 585, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "747019718350688ca9282b62fe617d752d6e12b75561", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 639, "~/", 639, 2, true);
#nullable restore
#line 18 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 641, item.BlogImage, 641, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 24 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml"
                                                                           Write(item.CreatedDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 21
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fas fa-eye""></i> ");
#nullable restore
#line 34 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml"
                                                                  Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1844, "\"", 1873, 2);
            WriteAttributeValue("", 1851, "/Blog/Details/", 1851, 14, true);
#nullable restore
#line 40 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1865, item.Id, 1865, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml"
                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <p class=\"card-text mb-3\">");
#nullable restore
#line 42 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml"
                                                     Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2043, "\"", 2072, 2);
            WriteAttributeValue("", 2050, "/Blog/Details/", 2050, 14, true);
#nullable restore
#line 43 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2064, item.Id, 2064, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Daha Fazla..</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 46 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
