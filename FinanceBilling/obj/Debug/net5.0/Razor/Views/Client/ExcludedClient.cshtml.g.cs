#pragma checksum "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\ExcludedClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db22242c95438b3ebd930a9ab0f8dcf73fd214af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinanceBilling.Models.Client.Views_Client_ExcludedClient), @"mvc.1.0.view", @"/Views/Client/ExcludedClient.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db22242c95438b3ebd930a9ab0f8dcf73fd214af", @"/Views/Client/ExcludedClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d23d327192370632795104f8da9c09dd028d47b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_ExcludedClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinanceBilling.Models.ExcludedClientViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Client/ExcludedClient.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h2>Excluded Client</h2>\r\n\r\n\r\n\r\n<div class=\"form-group\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db22242c95438b3ebd930a9ab0f8dcf73fd214af3805", async() => {
                WriteLiteral("Excluded Clients");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 8 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\ExcludedClient.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SpClientDropDownData);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 10 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\ExcludedClient.cshtml"
Write(Html.DropDownListFor(x => x.SpClientDropDownData, new SelectList(Model.SpClientDropDownData, "ClientID", "ClientName"), "Select Client", new { @class = "form-control dropDownSelect2", @id = "idExcludedClient", @data_filter_select = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\ExcludedClient.cshtml"
Write(Html.ValidationMessageFor(x => x.SpClientDropDownData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n<button id=\"idAddClient\">Add Client </button>\r\n");
#nullable restore
#line 48 "E:\SmartData\User 2\Git\MVC App\FinanceBilling\Views\Client\ExcludedClient.cshtml"
Write(Html.DevExtreme().DataGrid<FinanceBilling.Models.TblExcludedClientViewModel>
    ()
    .DataSource(ds => ds.Mvc()
    .Controller("Client")
    .Key("Id")
    .LoadAction("GetAllExcludedClient")
    //.InsertAction("AddNewQuickBookClient")
    //.UpdateAction("UpdateQuickBookClient")
    .DeleteAction("DeleteExculdedClient")
    )
    .RemoteOperations(true)
    .Columns(columns => {
        columns.AddFor(m => m.ClientName);
        columns.AddFor(m => m.Bencode);
        columns.AddFor(m => m.Description);
        columns.AddFor(m => m.UserID);
        columns.AddFor(m => m.UserName);
        columns.AddFor(m => m.CreateDate);
    })
    .Paging(p => p.PageSize(10))
    .Editing(e => e
    .AllowDeleting(true)
    .AllowAdding(false)
    .AllowUpdating(false)
    )
    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db22242c95438b3ebd930a9ab0f8dcf73fd214af7114", async() => {
                WriteLiteral("\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinanceBilling.Models.ExcludedClientViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
