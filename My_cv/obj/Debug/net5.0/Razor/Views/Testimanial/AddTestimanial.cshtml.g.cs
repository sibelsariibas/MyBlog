#pragma checksum "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Testimanial\AddTestimanial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451b96b09a9f14665e9c672c70592d5ce9fef8fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimanial_AddTestimanial), @"mvc.1.0.view", @"/Views/Testimanial/AddTestimanial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"451b96b09a9f14665e9c672c70592d5ce9fef8fb", @"/Views/Testimanial/AddTestimanial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd2b27dab75ad46a810a16d642641c319b1684f6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Testimanial_AddTestimanial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Testimanial\AddTestimanial.cshtml"
  
    ViewData["Title"] = "AddTestimanial";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Testimanial\AddTestimanial.cshtml"
 using (Html.BeginForm("AddTestimanial", "Testimanial", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-10 grid-margin stretch-card\">\n        <div class=\"card\">\n            <div class=\"card-body\">\n                <h4 class=\"card-title\">Referans</h4>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "451b96b09a9f14665e9c672c70592d5ce9fef8fb4530", async() => {
                WriteLiteral("\n                    <div class=\"form-group\">\n                        <label>Ad Soyad</label>\n                        <input type=\"text\" class=\"form-control\" placeholder=\"Ad Soyad\" name=\"ClientName\">\n                        <text style=\"color:gray\">");
#nullable restore
#line 16 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Testimanial\AddTestimanial.cshtml"
                                            Write(Html.ValidationMessage("ClientName"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</text>
                    </div>
                    <div class=""form-group"">
                        <label>Firma Bilgisi</label>
                        <input type""text"" class=""form-control"" placeholder=""Firma Bilgisi"" name=""Company"">
                        <text style=""color:gray"">");
#nullable restore
#line 21 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Testimanial\AddTestimanial.cshtml"
                                            Write(Html.ValidationMessage("Company"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</text>\n                    </div>\n                    <button type=\"submit\" class=\"btn btn-primary mr-2\">Kaydet</button>\n                ");
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
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 28 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Testimanial\AddTestimanial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
