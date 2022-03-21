#pragma checksum "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e79ead28356b6aff49c42a43a5e3df4aa9a47c7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinanceBilling.Models.Client.Views_Client_NewClient), @"mvc.1.0.view", @"/Views/Client/NewClient.cshtml")]
namespace FinanceBilling.Models.Client
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
#line 1 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\_ViewImports.cshtml"
using FinanceBilling;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e79ead28356b6aff49c42a43a5e3df4aa9a47c7d", @"/Views/Client/NewClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d23d327192370632795104f8da9c09dd028d47b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_NewClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinanceBilling.Models.ClientViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h2>New Client</h2>
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
#line 27 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
          
            foreach (var item in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                <td>");
#nullable restore
#line 31 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.ClientGroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.BillingStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.EIN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.ClientDivisionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.ClientID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.ClientDivisionID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.Active);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.ClientAlternate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.DeactivationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.TPACode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.Linetype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.AccountTypeCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.MyProperty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
               Write(item.PlanID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\NewClient.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinanceBilling.Models.ClientViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
