#pragma checksum "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbaa0ac60affa4f65deb007d817079a4aaa308e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DevExtremeAspNetCoreApp.Models.Client.Views_Client_TerminatedClient), @"mvc.1.0.view", @"/Views/Client/TerminatedClient.cshtml")]
namespace DevExtremeAspNetCoreApp.Models.Client
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
#line 1 "E:\SmartData\User 4\FinanceBilling\Views\_ViewImports.cshtml"
using DevExtremeAspNetCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SmartData\User 4\FinanceBilling\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbaa0ac60affa4f65deb007d817079a4aaa308e9", @"/Views/Client/TerminatedClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c08de55ed213945938be8fb11c044eab3636d72", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_TerminatedClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevExtremeAspNetCoreApp.Models.ClientViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Terminated Client</h2>
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">ClientName</th>
            <th scope=""col"">ClientGroupName</th>
            <th scope=""col"">BillingStartDate</th>
            <th scope=""col"">EIN</th>
            <th scope=""col"">ClientDivisionName</th>
            <th scope=""col"">ClientID</th>
            <th scope=""col"">ClientDivisionID</th>
            <th scope=""col"">Active</th>
            <th scope=""col"">ClientAlternate</th>
            <th scope=""col"">DeactivationDate</th>
            <th scope=""col"">TPACode</th>
            <th scope=""col"">Linetype</th>
            <th scope=""col"">AccountTypeCode</th>
            <th scope=""col"">MyProperty</th>
            <th scope=""col"">PlanID</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 26 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
          
            foreach (var item in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.ClientGroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.BillingStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.EIN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.ClientDivisionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.ClientID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.ClientDivisionID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.Active);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.ClientAlternate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.DeactivationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.TPACode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.Linetype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.AccountTypeCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.MyProperty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
                   Write(item.PlanID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "E:\SmartData\User 4\FinanceBilling\Views\Client\TerminatedClient.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevExtremeAspNetCoreApp.Models.ClientViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
