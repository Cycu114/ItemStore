#pragma checksum "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Shared\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13f4f1659c7f955769f42493a1989c23f75b456e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Index), @"mvc.1.0.view", @"/Views/Shared/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\_ViewImports.cshtml"
using ItemStoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\_ViewImports.cshtml"
using ItemStoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f4f1659c7f955769f42493a1989c23f75b456e", @"/Views/Shared/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4536ede3daa130c180c3f3a6fd13921a177b69f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Shared\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\" xmlns=\"http://www.w3.org/1999/html\">\r\n\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Shared\Index.cshtml"
   Write(Model?.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <br/>\r\n    <h1>Hello ");
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Shared\Index.cshtml"
         Write(Model?.UserLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n    <br/>\r\n    <h1>Bye ");
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Shared\Index.cshtml"
       Write(Model?.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <br/>\r\n    ");
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Shared\Index.cshtml"
Write(Model?.whatever);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <br/>\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
