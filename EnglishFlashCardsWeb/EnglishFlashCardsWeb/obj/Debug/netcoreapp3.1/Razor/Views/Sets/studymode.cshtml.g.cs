#pragma checksum "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\studymode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3273f095ea1fe210feb382a576a7624e2b9e6c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sets_studymode), @"mvc.1.0.view", @"/Views/Sets/studymode.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3273f095ea1fe210feb382a576a7624e2b9e6c8", @"/Views/Sets/studymode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6bb02eee33595b289adfeefa98a93c4aa0b872", @"/Views/_ViewImports.cshtml")]
    public class Views_Sets_studymode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FlashCard>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div id=\"content\" style=\"width:50%;\">\r\n    <div class=\"gallery js-flickity\"\r\n         data-flickity-options=\'{ \"wrapAround\": true }\'>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\studymode.cshtml"
         foreach (var x in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"gallery-cell\"><h1 class=\"display-3\" style=\"margin:auto;\"");
            BeginWriteAttribute("front", " front=\"", 424, "\"", 439, 1);
#nullable restore
#line 16 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\studymode.cshtml"
WriteAttributeValue("", 432, x.word, 432, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("back", " back=\"", 440, "\"", 457, 1);
#nullable restore
#line 16 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\studymode.cshtml"
WriteAttributeValue("", 447, x.meaning, 447, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" status=\"front\">");
#nullable restore
#line 16 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\studymode.cshtml"
                                                                                                                             Write(x.word);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></div>\r\n");
#nullable restore
#line 17 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Sets\studymode.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<script>
    $("".display-3"").click(
        function () {
            var status = $(this).attr(""status"")
            if (status == ""front"") {
                $(this).text($(this).attr(""back""));
                $(this).attr(""status"", ""back"");
            } else {
                $(this).text($(this).attr(""front""));
                $(this).attr(""status"", ""front"");
            }
        }
    );
 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FlashCard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
