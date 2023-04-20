#pragma checksum "D:\Diplomna\SwordParadise\SwordParadise\Views\Statistics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abbce17b73dd3472acf0a03130cfbcf05d3040d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_Index), @"mvc.1.0.view", @"/Views/Statistics/Index.cshtml")]
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
#line 1 "D:\Diplomna\SwordParadise\SwordParadise\Views\_ViewImports.cshtml"
using SwordParadise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Diplomna\SwordParadise\SwordParadise\Views\_ViewImports.cshtml"
using SwordParadise.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Diplomna\SwordParadise\SwordParadise\Views\Statistics\Index.cshtml"
using SwordParadise.Models.Statistics;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abbce17b73dd3472acf0a03130cfbcf05d3040d5", @"/Views/Statistics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c866673fb75a52759e6b624055069d1cf698be6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Statistics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StatisticsVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("gradient-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Diplomna\SwordParadise\SwordParadise\Views\Statistics\Index.cshtml"
  
    ViewData["Title"] = "Statistics";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .gradient-custom {
        background: linear-gradient(to bottom, #fe90d2, #fefa3f);
    }
    * {
        box-sizing: border-box;
        margin: 0;
        padding: 0;
    }

    body {
        font-family: Arial, sans-serif;
        background-color: #f2f2f2;
    }

    .container {
        width: 80%;
        margin: 0 auto;
        padding: 20px;
        background-color: #fff;
        border-radius: 10px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
    }

    h1 {
        text-align: center;
        margin-bottom: 20px;
    }

    .table-container {
        max-width: 860px;
        max-height: 600px;
        margin: 0 auto;
        background-color: #fff;
        border: 1px solid #ddd;
        border-radius: 10px;
        padding: 20px;
        box-shadow: 0px 0px 20px rgba(0, 0, 0, 0.1);
        overflow-y: auto;
    }

        /* Style the scrollbar */
        .table-container::-webkit-scrollbar {
            width: 8px;
        }

     ");
            WriteLiteral(@"   .table-container::-webkit-scrollbar-thumb {
            background-color: #fe90d2;
            border-radius: 20px;
        }

        .table-container::-webkit-scrollbar-track {
            background-color: #f3f3f3;
        }

    /* Add a box shadow effect to the table rows */
    .table tbody tr {
        box-shadow: 0px 2px 5px rgba(0, 0, 0, 0.1);
        transition: all 0.3s ease-in-out;
    }

        .table tbody tr:hover {
            box-shadow: 0px 2px 5px rgba(0, 0, 0, 0.3);
            background-color: #f9f9f9;
        }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abbce17b73dd3472acf0a03130cfbcf05d3040d55513", async() => {
                WriteLiteral(@"
<div class=""text-center"">
    <div class=""col-x1-8"">
        <div class=""card-group pb-0"">
            <div class=""card-columns text-center"">
            </div>
        </div>
        <div class=""table-container"">
        <table class=""table table-striped"" style=""width:100%"">
            <h1>Statistics</h1>
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 86 "D:\Diplomna\SwordParadise\SwordParadise\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CountClients));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 89 "D:\Diplomna\SwordParadise\SwordParadise\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CountWeapons));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 92 "D:\Diplomna\SwordParadise\SwordParadise\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CountOrders));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 95 "D:\Diplomna\SwordParadise\SwordParadise\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SumOrders));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 102 "D:\Diplomna\SwordParadise\SwordParadise\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayFor(model => model.CountClients));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 105 "D:\Diplomna\SwordParadise\SwordParadise\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayFor(model => model.CountWeapons));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 108 "D:\Diplomna\SwordParadise\SwordParadise\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayFor(model => model.CountOrders));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 111 "D:\Diplomna\SwordParadise\SwordParadise\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayFor(model => model.SumOrders));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StatisticsVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
