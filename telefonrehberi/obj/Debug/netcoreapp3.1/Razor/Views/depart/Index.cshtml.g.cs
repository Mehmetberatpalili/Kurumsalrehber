#pragma checksum "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\depart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104ce0339ab7fa13b68c49db850e419e587cfe99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_depart_Index), @"mvc.1.0.view", @"/Views/depart/Index.cshtml")]
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
#line 1 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\_ViewImports.cshtml"
using telefonrehberi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\depart\Index.cshtml"
using telefonrehberi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104ce0339ab7fa13b68c49db850e419e587cfe99", @"/Views/depart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37cce4fbc4dbb7a27c8a721fcc8078b0fcb08d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_depart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<departmanlar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\depart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Departman</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\depart\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\depart\Index.cshtml"
           Write(x.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\depart\Index.cshtml"
           Write(x.departmanad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 480, "\"", 513, 2);
            WriteAttributeValue("", 487, "/depart/DepartmanSil/", 487, 21, true);
#nullable restore
#line 23 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\depart\Index.cshtml"
WriteAttributeValue("", 508, x.id, 508, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">SİL</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 570, "\"", 605, 2);
            WriteAttributeValue("", 577, "/depart/DepartmanGetir/", 577, 23, true);
#nullable restore
#line 24 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\depart\Index.cshtml"
WriteAttributeValue("", 600, x.id, 600, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">GÜNCELLE</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-default\"style=\"background-color:#ffd800\">DETAYLAR</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\depart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n  <a href=\"/depart/YeniDepartman/\" class=\"btn btn-primary\">Yeni Departman ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<departmanlar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
