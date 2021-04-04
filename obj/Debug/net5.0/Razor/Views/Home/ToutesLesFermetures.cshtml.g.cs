#pragma checksum "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e17af2feb78479dfab7ebd8e4f92e729013c768c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ToutesLesFermetures), @"mvc.1.0.view", @"/Views/Home/ToutesLesFermetures.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e17af2feb78479dfab7ebd8e4f92e729013c768c", @"/Views/Home/ToutesLesFermetures.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f76db85423d1966422131999df760b0ec79fa9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ToutesLesFermetures : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FermeturePont>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
  
    ViewData["Title"] = "Toutes les fermetures";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
  
    List<FermeturePont> passe = new List<FermeturePont>();
    List<FermeturePont> avenir = new List<FermeturePont>();
    Model.Sort((a, b) => a.closing_date.CompareTo(b.closing_date));


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
 foreach (var fermeture in Model)
{
    int LeResultat = DateTime.Compare(Convert.ToDateTime(fermeture.closing_date), Convert.ToDateTime(DateTime.Now.ToString()));
    if (LeResultat == 1)
    {
        avenir.Add(fermeture);
    }
    else
    {
        passe.Add(fermeture);
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Fermeture à venir</h1>
<table style=""list-group"">
    <thead>
        <tr>
            <th>Nom du bateau ou de l'évènement</th>
            <th>Date et heure de la fermeture</th>
            <th>Durée de la fermeture</th>
            <th>Détail</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 37 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
         foreach (var fermeture in avenir)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
               Write(fermeture.boat_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
               Write(fermeture.closing_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
                  TimeSpan DureeFermeture = Convert.ToDateTime(fermeture.reopening_date) - Convert.ToDateTime(@fermeture.closing_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 43 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
               Write(DureeFermeture.Hours);

#line default
#line hidden
#nullable disable
            WriteLiteral(" h et ");
#nullable restore
#line 43 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
                                          Write(DureeFermeture.Minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e17af2feb78479dfab7ebd8e4f92e729013c768c6616", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
                                             WriteLiteral(fermeture.boat_name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<h1>Les Fermetures déja passé</h1>
<table style=""list-group"">
    <thead>
        <tr>
            <th>Nom du bateau ou de l'évènement</th>
            <th>Date et heure de la fermeture</th>
            <th>Durée de la fermeture</th>
            <th>Détail</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 61 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
         foreach (var fermeture in passe)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 64 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
           Write(fermeture.boat_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
           Write(fermeture.closing_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 66 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
              TimeSpan DureeFermeture = Convert.ToDateTime(fermeture.reopening_date) - Convert.ToDateTime(@fermeture.closing_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 67 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
           Write(DureeFermeture.Hours);

#line default
#line hidden
#nullable disable
            WriteLiteral(" h et ");
#nullable restore
#line 67 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
                                      Write(DureeFermeture.Minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e17af2feb78479dfab7ebd8e4f92e729013c768c11075", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
                                         WriteLiteral(fermeture.boat_name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\sacha\Desktop\BridgeMonitor\BridgeMonitor\Views\Home\ToutesLesFermetures.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
