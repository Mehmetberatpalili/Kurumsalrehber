#pragma checksum "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58fc3a76f831fc9c3d325a2a1199ebe9abbba8a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Birim_BirimDetay), @"mvc.1.0.view", @"/Views/Birim/BirimDetay.cshtml")]
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
#line 1 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
using telefonrehberi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58fc3a76f831fc9c3d325a2a1199ebe9abbba8a0", @"/Views/Birim/BirimDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37cce4fbc4dbb7a27c8a721fcc8078b0fcb08d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Birim_BirimDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<personel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
  
    ViewData["Title"] = "BirimDetay";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2>");
#nullable restore
#line 9 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
Write(ViewBag.brm);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Departmanı </h2>
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Tc</th>
        <th>Ad</th>
        <th>Soyad</th>
        <th>Telefon</th>
        <th>Adres</th>
        <th>Birim</th>
        <th>Görev</th>
    </tr>
");
#nullable restore
#line 21 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
           Write(x.perid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
           Write(x.Tc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
           Write(x.ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
           Write(x.soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
           Write(x.telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
           Write(x.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
           Write(x.CalistigiBirim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
           Write(x.Gorev);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\mutqs\OneDrive\Masaüstü\Rehber\telefonrehberi\Views\Birim\BirimDetay.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
