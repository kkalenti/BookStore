#pragma checksum "C:\Other\lessons\c#\BookStoreRepo\BookStore\BookStore\Views\Shared\Admin\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c85394c6d2c2a933e3c8c5c33caa8628cbe33f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Admin__Header), @"mvc.1.0.view", @"/Views/Shared/Admin/_Header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c85394c6d2c2a933e3c8c5c33caa8628cbe33f0a", @"/Views/Shared/Admin/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f98c2058f0725a03780f06f171d8f86e8c01f366", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Admin__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-auto w-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- Topbar -->
<nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

    <!-- Sidebar Toggle (Topbar) -->
    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
        <i class=""fa fa-bars""></i>
    </button>

    <!-- Topbar Search -->
");
            WriteLiteral(@"
    <!-- Topbar Navbar -->
    <ul class=""navbar-nav ml-auto"">

        <!-- Nav Item - Search Dropdown (Visible Only XS) -->
        <li class=""nav-item dropdown no-arrow d-sm-none"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-search fa-fw""></i>
            </a>
            <!-- Dropdown - Messages -->
            <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in"" aria-labelledby=""searchDropdown"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85394c6d2c2a933e3c8c5c33caa8628cbe33f0a4630", async() => {
                WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-primary"" type=""button"">
                                <i class=""fas fa-search fa-sm""></i>
                            </button>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </li>

        <!-- Nav Item - Alerts -->
        <li class=""nav-item dropdown no-arrow mx-1"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-bell fa-fw""></i>
                <!-- Counter - Alerts -->
                <span class=""badge badge-danger badge-counter"">3+</span>
            </a>
            <!-- Dropdown - Alerts -->
            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""alertsDropdown"">
                <h6 class=""dropdown-header"">
                    Alerts Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div class=""icon-circle bg-primary"">
                            <i class=""fas fa-file-alt text-white""></i>
                     ");
            WriteLiteral(@"   </div>
                    </div>
                    <div>
                        <div class=""small text-gray-500"">December 12, 2019</div>
                        <span class=""font-weight-bold"">A new monthly report is ready to download!</span>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div class=""icon-circle bg-success"">
                            <i class=""fas fa-donate text-white""></i>
                        </div>
                    </div>
                    <div>
                        <div class=""small text-gray-500"">December 7, 2019</div>
                        $290.29 has been deposited into your account!
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div class=""icon-circle bg-warning"">
 ");
            WriteLiteral(@"                           <i class=""fas fa-exclamation-triangle text-white""></i>
                        </div>
                    </div>
                    <div>
                        <div class=""small text-gray-500"">December 2, 2019</div>
                        Spending Alert: We've noticed unusually high spending for your account.
                    </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Show All Alerts</a>
            </div>
        </li>

        <!-- Nav Item - Messages -->
        <li class=""nav-item dropdown no-arrow mx-1"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-envelope fa-fw""></i>
                <!-- Counter - Messages -->
                <span class=""badge badge-danger badge-counter"">7</span>
            </a>
            <!-- Dropdown - Messages -->
");
            WriteLiteral(@"            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""messagesDropdown"">
                <h6 class=""dropdown-header"">
                    Message Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/fn_BT9fwg_E/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 5613, "\"", 5619, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator bg-success""></div>
                    </div>
                    <div class=""font-weight-bold"">
                        <div class=""text-truncate"">Hi there! I am wondering if you can help me with a problem I've been having.</div>
                        <div class=""small text-gray-500"">Emily Fowler · 58m</div>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/AU4VPcFN4LE/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 6285, "\"", 6291, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">I have the photos that you ordered last month, how would you like them sent to you?</div>
                        <div class=""small text-gray-500"">Jae Chun · 1d</div>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/CS2uCrpNzJY/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 6923, "\"", 6929, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator bg-warning""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">Last month's report looks great, I am very happy with the progress so far, keep up the good work!</div>
                        <div class=""small text-gray-500"">Morgan Alvarez · 2d</div>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/Mv9hjnEUHR4/60x60""");
            BeginWriteAttribute("alt", " alt=\"", 7592, "\"", 7598, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""status-indicator bg-success""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">Am I a good boy? The reason I ask is because someone told me that people say this to all dogs, even if they aren't good...</div>
                        <div class=""small text-gray-500"">Chicken the Dog · 2w</div>
                    </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Read More Messages</a>
            </div>
        </li>

        <div class=""topbar-divider d-none d-sm-block""></div>

        <!-- Nav Item - User Information -->
        <li class=""nav-item dropdown no-arrow"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">Valerie Luna</span>
                <img cl");
            WriteLiteral(@"ass=""img-profile rounded-circle"" src=""https://source.unsplash.com/QAB-WJcbgJk/60x60"">
            </a>
            <!-- Dropdown - User Information -->
            <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""userDropdown"">
                <a class=""dropdown-item"" href=""#"">
                    <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                    Profile
                </a>
                <a class=""dropdown-item"" href=""#"">
                    <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                    Settings
                </a>
                <a class=""dropdown-item"" href=""#"">
                    <i class=""fas fa-list fa-sm fa-fw mr-2 text-gray-400""></i>
                    Activity Log
                </a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                    <i class=""fas fa-sign-ou");
            WriteLiteral("t-alt fa-sm fa-fw mr-2 text-gray-400\"></i>\r\n                    Logout\r\n                </a>\r\n            </div>\r\n        </li>\r\n\r\n    </ul>\r\n\r\n</nav>\r\n<!-- End of Topbar -->");
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
