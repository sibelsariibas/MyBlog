#pragma checksum "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d72557fb09f7614e7021909b74a6f7cf43d9ea11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d72557fb09f7614e7021909b74a6f7cf43d9ea11", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd2b27dab75ad46a810a16d642641c319b1684f6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Teknik Bilgi</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Oran</th>
                            <th scope=""col"">Sil</th>
                            <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 25 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 28 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml"
                           Write(item.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 29 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                <div class=\"d-flex align-items-center\">\n                                    <span class=\"completion mr-2\">");
#nullable restore
#line 32 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml"
                                                             Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\n                                    <div>\n                                        <div class=\"progress\">\n                                            <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1399, "\"", 1426, 1);
#nullable restore
#line 35 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1415, item.Value, 1415, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 1465, "\"", 1492, 3);
            WriteAttributeValue("", 1473, "width:", 1473, 6, true);
#nullable restore
#line 35 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1479, item.Value, 1479, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1490, "%;", 1490, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n                                        </div>\n                                    </div>\n                                </div>\n                            </td>\n                            <td> <a");
            BeginWriteAttribute("href", " href=\"", 1699, "\"", 1738, 2);
            WriteAttributeValue("", 1706, "/Skill/DeleteSkill/", 1706, 19, true);
#nullable restore
#line 40 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1725, item.SkillID, 1725, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\n                            <td>  <a");
            BeginWriteAttribute("href", " href=\"", 1820, "\"", 1859, 2);
            WriteAttributeValue("", 1827, "/Skill/UpdateSkill/", 1827, 19, true);
#nullable restore
#line 41 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1846, item.SkillID, 1846, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\n                        </tr>\n");
#nullable restore
#line 43 "C:\Users\sibel.saribas\Desktop\SİBEL SARIBAŞ\Asp.NetCoreExemple-main\My_cv\Views\Skill\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n                <a href=\"/Skill/AddSkill\" class=\"btn btn-outline-info\">Yetenek Ekle</a>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591