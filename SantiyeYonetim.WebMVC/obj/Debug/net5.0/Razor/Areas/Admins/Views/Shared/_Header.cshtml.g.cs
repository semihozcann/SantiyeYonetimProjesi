#pragma checksum "C:\Users\semih\Desktop\C# Kodları\Devam Eden Projeler\SantiyeYonetim\SantiyeYonetim.WebMVC\Areas\Admins\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f21326b74099b38d03feda6f636a77481b69a674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admins_Views_Shared__Header), @"mvc.1.0.view", @"/Areas/Admins/Views/Shared/_Header.cshtml")]
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
#line 1 "C:\Users\semih\Desktop\C# Kodları\Devam Eden Projeler\SantiyeYonetim\SantiyeYonetim.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using SantiyeYonetim.WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semih\Desktop\C# Kodları\Devam Eden Projeler\SantiyeYonetim\SantiyeYonetim.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using SantiyeYonetim.WebMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\semih\Desktop\C# Kodları\Devam Eden Projeler\SantiyeYonetim\SantiyeYonetim.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using SantiyeYonetim.WebMVC.Helpers.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\semih\Desktop\C# Kodları\Devam Eden Projeler\SantiyeYonetim\SantiyeYonetim.WebMVC\Areas\Admins\Views\_ViewImports.cshtml"
using SantiyeYonetim.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f21326b74099b38d03feda6f636a77481b69a674", @"/Areas/Admins/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d3adfce4c975b181624cc5b829d3beb068bb6", @"/Areas/Admins/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admins_Views_Shared__Header : SantiyeYonetim.WebMVC.Helpers.Concrete.BaseViewPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_UserMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"                <!-- Topbar -->
                <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

                    <!-- Sidebar Toggle (Topbar) -->
                    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
                        <i class=""fa fa-bars""></i>
                    </button>

                    <h3>YÖNETİCİ PANELİ</h3>

                    <!-- Topbar Navbar -->
                    <ul class=""navbar-nav ml-auto"">
                        <!-- Nav Item - User Information -->
                        <li class=""nav-item dropdown no-arrow"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
                                data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">");
#nullable restore
#line 17 "C:\Users\semih\Desktop\C# Kodları\Devam Eden Projeler\SantiyeYonetim\SantiyeYonetim.WebMVC\Areas\Admins\Views\Shared\_Header.cshtml"
                                                                                     Write(CurrentUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <img class=""img-profile rounded-circle"" src=""img/undraw_profile.svg"">
                            </a>
                            <!-- Dropdown - User Information -->
                            <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in""
                                aria-labelledby=""userDropdown"">

                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f21326b74099b38d03feda6f636a77481b69a6745920", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </li>\r\n\r\n                    </ul>\r\n\r\n                </nav>\r\n                <!-- End of Topbar -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591