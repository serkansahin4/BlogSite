#pragma checksum "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "030f86d54e10cb247db6640ff409741506b97bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"030f86d54e10cb247db6640ff409741506b97bbd", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c07081cff3fe8e69fb9e8da1e55f5458c75321", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogSite.WebUI.Models.ViewModels.Login.LoginVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Login/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\">Şimdi Giriş Yap</h3>\r\n        <div class=\"row inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 11 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Login\Index.cshtml"
                 if(ViewBag.SignControlMessage!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <p>");
#nullable restore
#line 13 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Login\Index.cshtml"
                      Write(ViewBag.SignControlMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 15 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Login\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "030f86d54e10cb247db6640ff409741506b97bbd5603", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1 mb-2"">Mail Adresi</label>
                        <input type=""email"" name=""Email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 895, "\"", 909, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 910, "\"", 921, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <small id=\"emailHelp\" class=\"form-text text-muted\">We\'ll never share your email with anyone else.</small>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Login\Index.cshtml"
               Write(Html.ValidationMessage("Email"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1 mb-2"">Parola</label>
                        <input type=""password"" name=""Password"" class=""form-control"" id=""exampleInputPassword1""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1374, "\"", 1388, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1389, "\"", 1400, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                     ");
#nullable restore
#line 26 "C:\Users\Serkan\Desktop\GİTHUB REPOLARIM\BlogSitesi\BlogSite\BlogSite.WebUI\Views\Login\Index.cshtml"
                Write(Html.ValidationMessage("Password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    \r\n                    <button type=\"submit\" class=\"btn btn-primary submit mb-4\">Giriş Yap</button>\r\n                    <p><a href=\"/Register/Index\"> Bir hesaba sahip değilmisin ?</a></p>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogSite.WebUI.Models.ViewModels.Login.LoginVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
