#pragma checksum "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Categories\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5929f36fe1ecbe157bf0357c034e47eaf843fa31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebStore.App.Areas.DataOperator.Views.Categories.Areas_DataOperator_Views_Categories_All), @"mvc.1.0.view", @"/Areas/DataOperator/Views/Categories/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DataOperator/Views/Categories/All.cshtml", typeof(WebStore.App.Areas.DataOperator.Views.Categories.Areas_DataOperator_Views_Categories_All))]
namespace WebStore.App.Areas.DataOperator.Views.Categories
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5929f36fe1ecbe157bf0357c034e47eaf843fa31", @"/Areas/DataOperator/Views/Categories/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcf5cd089ba7605c0e85a2ca471249b800957a27", @"/Areas/DataOperator/Views/_ViewImports.cshtml")]
    public class Areas_DataOperator_Views_Categories_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CategoryConciseViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Categories\All.cshtml"
  
    ViewData["Title"] = "All categories";

#line default
#line hidden
            BeginContext(98, 207, true);
            WriteLiteral("\r\n<h2>All Categories</h2>\r\n\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Products Count</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        ");
            EndContext();
            BeginContext(306, 22, false);
#line 17 "C:\Users\User\Documents\Visual Studio 2017\Projects\WebStoreProject\WebStore.App\Areas\DataOperator\Views\Categories\All.cshtml"
   Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(328, 26, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CategoryConciseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
