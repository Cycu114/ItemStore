#pragma checksum "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "146c14dbd3677a15b5b83026444c3986d4469ded"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Products), @"mvc.1.0.view", @"/Views/Items/Products.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"146c14dbd3677a15b5b83026444c3986d4469ded", @"/Views/Items/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4536ede3daa130c180c3f3a6fd13921a177b69f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/items/AddProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
  
    ViewData["Title"] = "Add Item Type";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
 if (Model.errorMessage != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b> ");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
   Write(Model.errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n");
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
  
    var index = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Item Types</h1>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "146c14dbd3677a15b5b83026444c3986d4469ded5943", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <table cellspacing=""10"">
        <tr>
            <th>
                Item ID
            </th>
            <th>
                Item Category
            </th>
            <th>
                Item Type Name
            </th>
            <th>
                Item Image Link
            </th>
        </tr>

");
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
         foreach (var ItemType in Model.Products)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 37 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
                Write(index);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td>\r\n");
#nullable restore
#line 39 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
                      
                        var CategoryName = "None";
                        foreach (var CategoryFind in Model.Categories)
                        {
                            if (CategoryFind.Id == ItemType.CategoryId) CategoryName = CategoryFind.Name;
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
#nullable restore
#line 46 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
               Write(CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n\r\n                <td> ");
#nullable restore
#line 49 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
                Write(ItemType.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </td>\r\n                <td> <img style=\" height: 100px;\"");
                BeginWriteAttribute("src", " src=\'", 1294, "\'", 1342, 1);
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
WriteAttributeValue("", 1300, Url.Content(Url.Content(ItemType.ImgUrl)), 1300, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> </td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
            index++;

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n\r\n            <td> Add new ItemType:  </td>\r\n            <td>\r\n                <label for=\"Category\" style=\"margin:10px\">Choose a category:</label>\r\n                <select name=\"CategoryId\" id=\"Category\">\r\n");
#nullable restore
#line 61 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
                     foreach (var Category  in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "146c14dbd3677a15b5b83026444c3986d4469ded9714", async() => {
#nullable restore
#line 63 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
                                                Write(Category.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
                           WriteLiteral(Category.Id);

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
#line 64 "C:\Users\ASUS\Desktop\ItemStoreProject\ItemStoreProject\Views\Items\Products.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </td>
            <td> <input type=""text"" name=""Name"" placeholder=""ItemType Name"" /> </td>
            <td> <input type=""file"" name=""FormFile"" placeholder=""Image Link"" /> </td>

            <td> <input type=""submit"" name=""submit"" value=""Add"" /> </td>
        </tr>
    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
