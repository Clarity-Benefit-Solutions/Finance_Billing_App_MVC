#pragma checksum "C:\Users\HLakera_Beneflex.V057\source\repos\DevExtremeAspNetCoreApp\DevExtremeAspNetCoreApp\Views\UploadFIle\UploadFile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbaf1758eee12ddf0ac49b7234f580da1f15daa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DevExtremeAspNetCoreApp.Models.UploadFIle.Views_UploadFIle_UploadFile), @"mvc.1.0.view", @"/Views/UploadFIle/UploadFile.cshtml")]
namespace DevExtremeAspNetCoreApp.Models.UploadFIle
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
#line 1 "C:\Users\HLakera_Beneflex.V057\source\repos\DevExtremeAspNetCoreApp\DevExtremeAspNetCoreApp\Views\_ViewImports.cshtml"
using DevExtremeAspNetCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HLakera_Beneflex.V057\source\repos\DevExtremeAspNetCoreApp\DevExtremeAspNetCoreApp\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HLakera_Beneflex.V057\source\repos\DevExtremeAspNetCoreApp\DevExtremeAspNetCoreApp\Views\UploadFIle\UploadFile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbaf1758eee12ddf0ac49b7234f580da1f15daa3", @"/Views/UploadFIle/UploadFile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c08de55ed213945938be8fb11c044eab3636d72", @"/Views/_ViewImports.cshtml")]
    public class Views_UploadFIle_UploadFile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UploadFile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("drop-zone-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("readURL(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UploadFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\HLakera_Beneflex.V057\source\repos\DevExtremeAspNetCoreApp\DevExtremeAspNetCoreApp\Views\UploadFIle\UploadFile.cshtml"
  

	ViewBag.Title = "Upload Files";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\" style=\"border:1px solid green\">\r\n\t<div class=\"col-md-5\">\r\n\t\t<div class=\"card text-center\">\r\n\t\t\t<div class=\"card-header\">\r\n\t\t\t\tUpload Files using below dropzone area\r\n\t\t\t</div>\r\n\t\t\t<div class=\"card-body text-center\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbaf1758eee12ddf0ac49b7234f580da1f15daa36676", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t<div class=\"col-md-10\">\r\n\t\t\t\t\t\t\t<div class=\"drop-zone d-flex justify-content-center align-items-center\">\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t<span class=\"drop-zone-prompt\">Drag and drop , Browse</span>\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbaf1758eee12ddf0ac49b7234f580da1f15daa37277", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 24 "C:\Users\HLakera_Beneflex.V057\source\repos\DevExtremeAspNetCoreApp\DevExtremeAspNetCoreApp\Views\UploadFIle\UploadFile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UploadedFiles);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("multiple", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("\t\t\t\t\t\t\t</div>\r\n");
                WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t<div class=\"col-md-10\">\r\n\t\t\t\t\t\t\t<input class=\"btn btn-success\" type=\"submit\" value=\"Upload\" />\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div class=\"card-footer text-muted\">\r\n\t\t\t\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t\r\n\r\n\t</div>\r\n\r\n\t<div class=\"col-md-5\">\r\n\t\t");
#nullable restore
#line 46 "C:\Users\HLakera_Beneflex.V057\source\repos\DevExtremeAspNetCoreApp\DevExtremeAspNetCoreApp\Views\UploadFIle\UploadFile.cshtml"
   Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
	</div>
</div>


<script>
	document.querySelectorAll("".drop-zone-input"").forEach((inputElement) => {
		const dropZoneElement = inputElement.closest("".drop-zone"");

		dropZoneElement.addEventListener(""click"", (e) => {
			inputElement.click();
		});

		inputElement.addEventListener(""change"", (e) => {
			if (inputElement.files.length) {
				updateThumbnail(dropZoneElement, inputElement.files.length);
				inputElement.files = e.dataTransfer.files;
			}
		});

		dropZoneElement.addEventListener(""dragover"", (e) => {
			e.preventDefault();
			dropZoneElement.classList.add(""drop-zone--over"");
		});

		[""dragleave"", ""dragend""].forEach((type) => {
			dropZoneElement.addEventListener(type, (e) => {
				dropZoneElement.classList.remove(""drop-zone--over"");
			});
		});

		dropZoneElement.addEventListener(""drop"", (e) => {
			e.preventDefault();

			if (e.dataTransfer.files.length) {
				inputElement.files = e.dataTransfer.files;
				updateThumbnail(dropZoneElement, e.dataTransfer.files.");
            WriteLiteral(@"length);
			}
			dropZoneElement.classList.remove(""drop-zone--over"");
		});
	});

	/**
	 * Updates the thumbnail on a drop zone element.
	 *
	 *
	 */
	function updateThumbnail(dropZoneElement, filelength) {
		let thumbnailElement = dropZoneElement.querySelector("".drop-zone__thumb"");

		// First time - remove the prompt
		if (dropZoneElement.querySelector("".drop-zone-prompt"")) {
			dropZoneElement.querySelector("".drop-zone-prompt"").remove();
		}

		// First time - there is no thumbnail element, so lets create it
		if (!thumbnailElement) {
			thumbnailElement = document.createElement(""div"");
			thumbnailElement.classList.add(""drop-zone__thumb"");
			dropZoneElement.appendChild(thumbnailElement);
		}

		thumbnailElement.dataset.label = filelength+"" Files Selected"";

		
			thumbnailElement.style.backgroundImage = null;
		
	}


	function readURL(input) {

		if (input.files && input.files[0]) {
			var reader = new FileReader();
			reader.onload = function (e) {
				$('#Logo')
");
            WriteLiteral("\t\t\t\t\t.attr(\'src\', e.target.result)\r\n\t\t\t\t$(\'#Logo\').css(\"visible:true;\")\r\n\t\t\t};\r\n\t\t\treader.readAsDataURL(input.files[0]);\r\n\t\t\t$(\'#Logo\').attr(\"visibility\", \"false\");\r\n\t\t}\r\n\t}\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UploadFile> Html { get; private set; }
    }
}
#pragma warning restore 1591