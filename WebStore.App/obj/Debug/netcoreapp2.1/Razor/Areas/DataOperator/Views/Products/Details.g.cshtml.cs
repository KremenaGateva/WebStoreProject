#pragma checksum "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1e43caffb0c3b27061cdd4af98eca7043bc4e8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebStore.App.Areas.DataOperator.Views.Products.Areas_DataOperator_Views_Products_Details), @"mvc.1.0.view", @"/Areas/DataOperator/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DataOperator/Views/Products/Details.cshtml", typeof(WebStore.App.Areas.DataOperator.Views.Products.Areas_DataOperator_Views_Products_Details))]
namespace WebStore.App.Areas.DataOperator.Views.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\_ViewImports.cshtml"
using WebStore.Common.DataOperator.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\_ViewImports.cshtml"
using WebStore.Common.DataOperator.BindingModels;

#line default
#line hidden
#line 3 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\_ViewImports.cshtml"
using WebStore.App.Helpers;

#line default
#line hidden
#line 4 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\_ViewImports.cshtml"
using WebStore.Models;

#line default
#line hidden
#line 5 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\_ViewImports.cshtml"
using WebStore.App.Extensions;

#line default
#line hidden
#line 6 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\_ViewImports.cshtml"
using WebStore.App.Helpers.Messages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e43caffb0c3b27061cdd4af98eca7043bc4e8f", @"/Areas/DataOperator/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcf5cd089ba7605c0e85a2ca471249b800957a27", @"/Areas/DataOperator/Views/_ViewImports.cshtml")]
    public class Areas_DataOperator_Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "DataOperator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 18, true);
            WriteLiteral("\r\n<h2>Details for ");
            EndContext();
            BeginContext(96, 10, false);
#line 7 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(106, 124, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-8\">\r\n        <img style=\"width: 500px; height: 300px\" class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 230, "\"", 252, 1);
#line 12 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml"
WriteAttributeValue("", 236, Model.ImagePath, 236, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 253, "\"", 270, 1);
#line 12 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml"
WriteAttributeValue("", 259, Model.Name, 259, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(271, 99, true);
            WriteLiteral(">\r\n    </div>\r\n\r\n    <div class=\"col-md-4\">\r\n        <h3 class=\"my-3\">Description</h3>\r\n        <p>");
            EndContext();
            BeginContext(371, 17, false);
#line 17 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml"
      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(388, 44, true);
            WriteLiteral("</p>\r\n        <ul>\r\n            <li>Price: $");
            EndContext();
            BeginContext(433, 26, false);
#line 19 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml"
                   Write(Model.Price.ToString("f2"));

#line default
#line hidden
            EndContext();
            BeginContext(459, 33, true);
            WriteLiteral("</li>\r\n            <li>Quantity: ");
            EndContext();
            BeginContext(493, 21, false);
#line 20 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml"
                     Write(Model.QuantityInStock);

#line default
#line hidden
            EndContext();
            BeginContext(514, 38, true);
            WriteLiteral(" pcs.</li>\r\n            <li>Discount: ");
            EndContext();
            BeginContext(553, 24, false);
#line 21 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml"
                     Write(Model.DiscountPercentage);

#line default
#line hidden
            EndContext();
            BeginContext(577, 35, true);
            WriteLiteral(" %</li>\r\n            <li>Added on: ");
            EndContext();
            BeginContext(613, 15, false);
#line 22 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml"
                     Write(Model.AddedDate);

#line default
#line hidden
            EndContext();
            BeginContext(628, 46, true);
            WriteLiteral("</li>\r\n            <li>Category:\r\n            ");
            EndContext();
            BeginContext(674, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d11f631473e4fb4aa142c39506cc31e", async() => {
                BeginContext(787, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(806, 18, false);
#line 25 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml"
           Write(Model.CategoryName);

#line default
#line hidden
                EndContext();
                BeginContext(824, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Products\Details.cshtml"
                                                                                            WriteLiteral(Model.CategoryName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(842, 58, true);
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
