#pragma checksum "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e13209ab1592793d58c6ff4994aae77d7155b00a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sets_Set), @"mvc.1.0.view", @"/Views/Sets/Set.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e13209ab1592793d58c6ff4994aae77d7155b00a", @"/Views/Sets/Set.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6bb02eee33595b289adfeefa98a93c4aa0b872", @"/Views/_ViewImports.cshtml")]
    public class Views_Sets_Set : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/sets/setnameupdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/sets/setaddfolder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div id=\"content\" style=\"width:60%;\">\r\n\r\n    <h3>");
#nullable restore
#line 12 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
   Write(ViewBag.setName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <div id=\"setnameform\" style=\"display:none\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e13209ab1592793d58c6ff4994aae77d7155b00a5172", async() => {
                WriteLiteral(@"
            <div class=""form-row align-items-center"">
                <div class=""col-sm-3 my-1"">
                    <label class=""sr-only"" for=""inlineFormInputName"">Name</label>
                    <input type=""text"" class=""form-control"" name=""set_name"" id=""set_name""");
                BeginWriteAttribute("value", " value=\"", 604, "\"", 628, 1);
#nullable restore
#line 18 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
WriteAttributeValue("", 612, ViewBag.setName, 612, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\" name=\"set_id\"");
                BeginWriteAttribute("value", " value=\"", 686, "\"", 708, 1);
#nullable restore
#line 19 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
WriteAttributeValue("", 694, ViewBag.setID, 694, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-auto my-1\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Değiştir</button>\r\n                </div>\r\n            </div>\r\n        ");
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
            WriteLiteral("\r\n    </div>\r\n    <div id=\"setaddfolderform\" style=\"display:none; margin-bottom:20px;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e13209ab1592793d58c6ff4994aae77d7155b00a8154", async() => {
                WriteLiteral("\r\n            <div class=\"form-row align-items-center\">\r\n                <select class=\"custom-select\" size=\"3\" name=\"folder_id\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e13209ab1592793d58c6ff4994aae77d7155b00a8573", async() => {
                    WriteLiteral("Klasör Seçiniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
                     foreach (var folder in @Model.folders)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e13209ab1592793d58c6ff4994aae77d7155b00a10239", async() => {
#nullable restore
#line 34 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
                                                    Write(folder.folderName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
                           WriteLiteral(folder.folderID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1539, "\"", 1561, 1);
#nullable restore
#line 39 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
WriteAttributeValue("", 1547, ViewBag.setID, 1547, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"set_id\" />\r\n            <button type=\"submit\">Ekle</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div style=\"margin-top:20px;\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1705, "\"", 1742, 2);
            WriteAttributeValue("", 1712, "/sets/setdelete/", 1712, 16, true);
#nullable restore
#line 44 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
WriteAttributeValue("", 1728, ViewBag.SetID, 1728, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""background-color: white; padding: 6px; border-radius: 5px;"">Seti Sil</a>
        <a id=""setname"" href=""#"" style=""margin-left:40px; background-color:white; padding:6px; border-radius:5px;"">İsim Değiştir</a>
        <a class=""addfolder"" href=""#"" style=""margin-left:40px; background-color:white; padding:6px; border-radius:5px;"">Klasöre Ekle</a>
    </div>

");
#nullable restore
#line 49 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
     if (@ViewBag.istherecard == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"" style=""margin-top:30px;"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Kelime</th>
                    <th scope=""col"">Anlam</th>
                    <th scope=""col"">Senaryo</th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 63 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
                
                 int i = 1;
                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
                  foreach (var x in @Model.flashCards)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 68 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 69 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
                       Write(x.word);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 70 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
                       Write(x.meaning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 71 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
                       Write(x.story);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2973, "\"", 3007, 2);
            WriteAttributeValue("", 2980, "/cards/updatecard/", 2980, 18, true);
#nullable restore
#line 72 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
WriteAttributeValue("", 2998, x.cardID, 2998, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-pressed=\"true\">Düzenle</a></td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 3091, "\"", 3125, 2);
            WriteAttributeValue("", 3098, "/cards/deletecard/", 3098, 18, true);
#nullable restore
#line 73 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
WriteAttributeValue("", 3116, x.cardID, 3116, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-pressed=\"true\">Sil</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 75 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
                    i = i + 1;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 82 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
    }
    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 style=\"margin:30px; margin-left:0px;\">Sete Henüz Kelime Eklemediniz.</h3>\r\n");
#nullable restore
#line 85 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\Set.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div id=\"add-word\" style=\"margin-top: 30px;\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                Yeni Kart Ekle\r\n            </div>\r\n            <div class=\"card-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e13209ab1592793d58c6ff4994aae77d7155b00a19800", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"formGroupExampleInput\">Kelime</label>\r\n                        <input type=\"text\" name=\"word\" class=\"form-control\" id=\"formGroupExampleInput\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3910, "\"", 3924, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    <div class=""form-group"">
                        <label for=""formGroupExampleInput2"">Anlam</label>
                        <input type=""text"" name=""meaning"" class=""form-control"" id=""formGroupExampleInput2""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4183, "\"", 4197, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleFormControlTextarea1"">Senaryo</label>
                        <textarea class=""form-control"" name=""word_scenario"" id=""exampleFormControlTextarea1"" rows=""3""></textarea>
                    </div>
                    <button type=""submit"" class=""btn btn-primary mb-2"">Ekle</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>


</div>

<script>
    $(""#setname"").click(function () {
        if ($(""#setnameform"").attr(""style"") == """") {
            $(""#setnameform"").attr(""style"", ""display:none"");
        } else {
            $(""#setnameform"").attr(""style"", """");
        }
    });

    $("".addfolder"").click(function () {
        if ($(""#setaddfolderform"").attr(""style"") == """") {
            $(""#setaddfolderform"").attr(""style"", ""display:none"");
        } else {
            $(""#setaddfolderform"").attr(""style"", """");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
