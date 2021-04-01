#pragma checksum "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0f44d1056adb782e664cb27b2a86d5221d84271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\_ViewImports.cshtml"
using BridgeMonitor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\_ViewImports.cshtml"
using BridgeMonitor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0f44d1056adb782e664cb27b2a86d5221d84271", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f76db85423d1966422131999df760b0ec79fa9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FermeturePont>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Prochaine fermeture";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
  string date = "2021-10-11T02:09:00+0200";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Information</h1>\r\n</div>\r\n\r\n<p>Prochaine fermeture du pont :</p>\r\n");
#nullable restore
#line 12 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
 foreach (var fermeture in Model)
{
    int LeResultat = DateTime.Compare(Convert.ToDateTime(fermeture.closing_date), Convert.ToDateTime(DateTime.Now.ToString()));
    if (LeResultat == 1)
    {
        var date3 = Convert.ToDateTime(date);
        int LeResultat2 = DateTime.Compare(date3, Convert.ToDateTime(fermeture.closing_date));

        if (LeResultat2 == 1)
        {
            date = @fermeture.closing_date.ToString();
        }
    }
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
 foreach (var fermeture in Model)
{
    if (@fermeture.closing_date.ToString() == date)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Cause : ");
#nullable restore
#line 30 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
              Write(fermeture.boat_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Fermeture : ");
#nullable restore
#line 31 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                  Write(fermeture.closing_date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                                          Write(fermeture.closing_date.DayOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Rouverture du pont : ");
#nullable restore
#line 32 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                           Write(fermeture.reopening_date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                                                     Write(fermeture.reopening_date.DayOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
         TimeSpan DureeFermeture = Convert.ToDateTime(fermeture.reopening_date) - Convert.ToDateTime(@fermeture.closing_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Durée de la fermeture : ");
#nullable restore
#line 34 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                              Write(DureeFermeture.TotalHours);

#line default
#line hidden
#nullable disable
            WriteLiteral(" h.</p>\r\n");
#nullable restore
#line 35 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FermeturePont>> Html { get; private set; }
    }
}
#pragma warning restore 1591
