#pragma checksum "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Folders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a800b5d87d9522f8b4212c9e1d6391bf8e2d716f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Folders_Index), @"mvc.1.0.view", @"/Views/Folders/Index.cshtml")]
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
#line 1 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\_ViewImports.cshtml"
using EnglishFlashCardsWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\_ViewImports.cshtml"
using EnglishFlashCardsWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a800b5d87d9522f8b4212c9e1d6391bf8e2d716f", @"/Views/Folders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6bb02eee33595b289adfeefa98a93c4aa0b872", @"/Views/_ViewImports.cshtml")]
    public class Views_Folders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Folder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/folders/add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div style=\"width:900px\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a800b5d87d9522f8b4212c9e1d6391bf8e2d716f4032", async() => {
                WriteLiteral(@"
        <div class=""form-row align-items-center"">
            <div class=""col-sm-3 my-1"">
                <label class=""sr-only"" for=""inlineFormInputName"">Klasör Adı</label>
                <input type=""text"" class=""form-control"" name=""folder_name"" placeholder=""Set Adı"">
            </div>
            <div class=""col-auto my-1"">
                <button type=""submit"" class=""btn btn-primary"">Yeni Klasör Oluştur</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n<div style=\"margin-top:30px;\">\r\n");
#nullable restore
#line 24 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Folders\Index.cshtml"
     foreach (var x in @Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-warning mb-3\" style=\"max-width: 900px;\">\r\n            <div class=\"card-header\">");
#nullable restore
#line 27 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Folders\Index.cshtml"
                                Write(x.setCount());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Set</div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 29 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Folders\Index.cshtml"
                                  Write(x.folderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1102, "\"", 1136, 2);
            WriteAttributeValue("", 1109, "/folders/folder/", 1109, 16, true);
#nullable restore
#line 32 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Folders\Index.cshtml"
WriteAttributeValue("", 1125, x.folderID, 1125, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Klasöre Git</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Folders\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
#nullable restore
#line 38 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Folders\Index.cshtml"
     if (ViewBag.istherefolder == 0) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 style=\"margin:30px; margin-left:0px;\">Henüz Klasör Oluşturmadınız.</h3>\r\n");
#nullable restore
#line 40 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Folders\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <script>
        $("".rename_folder"").click(function () {
            if ($("".rename_form"").attr(""style"") == """") {
                $("".rename_form"").attr(""style"", ""display:none"");
            } else {
                $("".rename_form"").attr(""style"", """");
            }
        });
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Folder>> Html { get; private set; }
    }
}
#pragma warning restore 1591