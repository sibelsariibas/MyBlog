#pragma checksum "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Shared\Components\AboutList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d03bd3c91685179da7437bc4462c8ebc21f5688f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutList/Default.cshtml")]
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
#line 1 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\_ViewImports.cshtml"
using My_cv;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\_ViewImports.cshtml"
using My_cv.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Shared\Components\AboutList\Default.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d03bd3c91685179da7437bc4462c8ebc21f5688f", @"/Views/Shared/Components/AboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd2b27dab75ad46a810a16d642641c319b1684f6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:400px ; height:400px ; border-radius:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"section pt-4 px-3 px-lg-4\" id=\"about\">\n    <div class=\"container-narrow\">\n");
#nullable restore
#line 6 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Shared\Components\AboutList\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-md-6\">\n                <h2 class=\"h4 my-2\">");
#nullable restore
#line 10 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Shared\Components\AboutList\Default.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                <p>");
#nullable restore
#line 11 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Shared\Components\AboutList\Default.cshtml"
              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <div class=""row mt-3"">
                    <div class=""col-sm-2"">
                        <div class=""pb-1"">Yaş:</div>
                    </div>
                    <div class=""col-sm-10"">
                        <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 17 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Shared\Components\AboutList\Default.cshtml"
                                               Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-sm-2"">
                        <div class=""pb-1"">E-Mail:</div>
                    </div>
                    <div class=""col-sm-10"">
                        <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 23 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Shared\Components\AboutList\Default.cshtml"
                                               Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-sm-2"">
                        <div class=""pb-1"">Telefon:</div>
                    </div>
                    <div class=""col-sm-10"">
                        <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 29 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Shared\Components\AboutList\Default.cshtml"
                                               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    </div>\n                    <div class=\"col-sm-2\">\n                        <div class=\"pb-1\">Adres:</div>\n                    </div>\n                    <div class=\"col-sm-10\">\n                        <div class=\"pb-1 fw-bolder\">");
#nullable restore
#line 35 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Shared\Components\AboutList\Default.cshtml"
                                               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    </div>\n                </div>\n            </div>\n            <div class=\"col-md-5 offset-md-1\" data-aos=\"fade-left\" data-aos-delay=\"100\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d03bd3c91685179da7437bc4462c8ebc21f5688f7481", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1653, "~/Template/images/userımage/", 1653, 28, true);
#nullable restore
#line 40 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Shared\Components\AboutList\Default.cshtml"
AddHtmlAttributeValue("", 1681, item.ImageUrl, 1681, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n");
#nullable restore
#line 43 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Shared\Components\AboutList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
