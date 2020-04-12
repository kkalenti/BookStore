#pragma checksum "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\Home\SectionDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8ee33b4dc977d68463d672ef2bcabe0c4ebb2c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SectionDetails), @"mvc.1.0.view", @"/Views/Home/SectionDetails.cshtml")]
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
#line 2 "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8ee33b4dc977d68463d672ef2bcabe0c4ebb2c2", @"/Views/Home/SectionDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f98c2058f0725a03780f06f171d8f86e8c01f366", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SectionDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Section>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\Home\SectionDetails.cshtml"
  
    ViewData["Title"] = "SectionDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"jumbotron text-center\">\r\n    <div class=\"container\">\r\n        <h1 class=\"jumbotron-heading\">");
#nullable restore
#line 9 "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\Home\SectionDetails.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h5>");
#nullable restore
#line 10 "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\Home\SectionDetails.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n</section>\r\n\r\n<h2 class=\"text text-center\">Books\' List</h2>\r\n<div class=\"container marketing\">\r\n    <div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 17 "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\Home\SectionDetails.cshtml"
         foreach (var item in Model.BookSection.Select(sc => sc.Book).ToList())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d8ee33b4dc977d68463d672ef2bcabe0c4ebb2c25231", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 551, "~/Images/", 551, 9, true);
#nullable restore
#line 20 "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\Home\SectionDetails.cshtml"
AddHtmlAttributeValue("", 560, item.Image, 560, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\Home\SectionDetails.cshtml"
AddHtmlAttributeValue("", 578, item.Title, 578, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h5>");
#nullable restore
#line 21 "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\Home\SectionDetails.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p><a class=\"btn btn-secondary\"");
            BeginWriteAttribute("href", " href=\"", 690, "\"", 719, 2);
            WriteAttributeValue("", 697, "/home/details/", 697, 14, true);
#nullable restore
#line 22 "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\Home\SectionDetails.cshtml"
WriteAttributeValue("", 711, item.Id, 711, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">View details »</a></p>\r\n            </div><!-- /.col-lg-4 -->\r\n");
#nullable restore
#line 24 "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\Home\SectionDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Section> Html { get; private set; }
    }
}
#pragma warning restore 1591
