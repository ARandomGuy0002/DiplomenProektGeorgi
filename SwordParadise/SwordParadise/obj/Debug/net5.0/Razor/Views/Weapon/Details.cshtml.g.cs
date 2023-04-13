#pragma checksum "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54f5a6323b341a5de61e1cf86676d186815e9230"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Weapon_Details), @"mvc.1.0.view", @"/Views/Weapon/Details.cshtml")]
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
#line 1 "D:\Diploma\SwordParadise\SwordParadise\Views\_ViewImports.cshtml"
using SwordParadise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Diploma\SwordParadise\SwordParadise\Views\_ViewImports.cshtml"
using SwordParadise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54f5a6323b341a5de61e1cf86676d186815e9230", @"/Views/Weapon/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c866673fb75a52759e6b624055069d1cf698be6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Weapon_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SwordParadise.Models.Weapon.WeaponDetailsVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("gradient-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Details</h1>
<style>
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

#reviews {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  margin-bottom: 20px;
}

.review {
  width: 48%;
  padding: 20px;
  background-color: #fff;
  border-radius: 5px;
  box-shadow: 0 0 5px rgba(0, 0, 0, 0.1);
  transition: box-shadow 0.3s ease-in-out;
}

.review:hover {
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
}

.review:not(.active) {
  display: none;
}

.name {
  font-weight: bold;
  margin-bottom: 10px;
}

.stars {
  font-size: 20px;
  margin-bottom: 10px;");
            WriteLiteral(@"
}

.star {
  color: #ffcc00;
}

.comment {
  font-size: 14px;
  line-height: 1.5;
  color: #555;
}

.arrows {
  display: flex;
  justify-content: space-between;
  margin-bottom: 20px;
}

.arrow {
  width: 50px;
  height: 50px;
  font-size: 20px;
  text-align: center;
  line-height: 50px;
  color: #fff;
  background-color: #333;
  border-radius: 50%;
  cursor: pointer;
  transition: background-color 0.3s ease-in-out;
}

.arrow:hover {
  background-color: #555;
}

.arrow:active {
  background-color: #777;
}

#reviews {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  gap: 20px;
}

.review {
  width: 400px;
  padding: 20px;
  background-color: #f8f8f8;
  border-radius: 10px;
  box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
  text-align: left;
}

.review.active {
  border: 2px solid #0077FF;
}

.name {
  font-weight: bold;
}

.stars {
  display: flex;
  margin-bottom: 10px;
}

.star {
  color: #FFD700;
  font-size: 18px;
}

.co");
            WriteLiteral("mment {\r\n  margin-top: 10px;\r\n  font-style: italic;\r\n}\r\n\r\n  .review {\r\n    width: 100%;\r\n    margin-bottom: 20px;\r\n  }\r\n}\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54f5a6323b341a5de61e1cf86676d186815e92306703", async() => {
                WriteLiteral("\r\n<div>\r\n    <h4>WeaponDetailsVM</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WeaponName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayFor(model => model.WeaponName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 165 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BrandName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 168 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayFor(model => model.BrandName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img");
                BeginWriteAttribute("src", " src=\"", 3182, "\"", 3228, 1);
#nullable restore
#line 180 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
WriteAttributeValue("", 3188, Html.DisplayFor(model => model.Picture), 3188, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Image\" width=\"100\" />\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 183 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 186 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 189 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 192 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 195 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 198 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 201 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 204 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <h1>Reviews</h1>\r\n    <div id=\"reviews\"></div>\r\n    <div class=\"arrows\">\r\n        <div id=\"prev-arrow\" class=\"arrow\">&#10094;</div>\r\n        <div id=\"next-arrow\" class=\"arrow\">&#10095;</div>\r\n    </div><br />\r\n");
#nullable restore
#line 213 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
     if ((this.User.Identity.IsAuthenticated) && (this.User.IsInRole("Administrator")))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54f5a6323b341a5de61e1cf86676d186815e923012791", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 215 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 216 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("|\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54f5a6323b341a5de61e1cf86676d186815e923015216", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    function generateRandomReview() {
        const names = [""John"", ""Jane"", ""Bob"", ""Samantha"", ""Emily"", ""Ethan"", ""Olivia"", ""Liam"", ""Sophia"", ""Noah"", ""Emma"", ""William"", ""Isabella"", ""James"", ""Mia""];
        const comments = [
            ""This product is amazing!"",
            ""I love this product so much."",
            ""This product exceeded my expectations."",
            ""I would definitely recommend this product."",
            ""This is the best product I have ever purchased."",
            ""This was a game changer for me!"",
            ""I'm blown away by the performance!"",
            ""This exceeded my expectations!"",
            ""Absolutely amazing!"",
            ""I've never felt more confident with a weapon!"",
            ""Such a fantastic addition to my collection!"",
            ""I can't believe how accurate this is!"",
            ""Incredible craftsmanship and quality!"",
            ""This has quickly become my go-to weapon!"",
            ""I am thoroughly impressed with this pr");
            WriteLiteral(@"oduct!""

        ];
        const stars = Math.floor(Math.random() * 2) + 4;
        const name = names[Math.floor(Math.random() * names.length)];
        const comment = comments[Math.floor(Math.random() * comments.length)];
        return { name, comment, stars };
    }

    let currentReviewIndex = 0;

    function generateReviews(numReviews) {
        const reviewsContainer = document.getElementById(""reviews"");

        for (let i = 0; i < numReviews; i++) {
            const review = generateRandomReview();
            const reviewContainer = document.createElement(""div"");
            reviewContainer.classList.add(""review"");

            const nameElement = document.createElement(""span"");
            nameElement.classList.add(""name"");
            nameElement.textContent = review.name;
            reviewContainer.appendChild(nameElement);

            const starsElement = document.createElement(""span"");
            starsElement.classList.add(""stars"");
            reviewContainer.");
            WriteLiteral(@"appendChild(starsElement);
            for (let j = 0; j < review.stars; j++) {
                const starElement = document.createElement(""span"");
                starElement.classList.add(""star"");
                starElement.textContent = ""★"";
                starsElement.appendChild(starElement);
            }

            const commentElement = document.createElement(""p"");
            commentElement.classList.add(""comment"");
            commentElement.textContent = review.comment;
            reviewContainer.appendChild(commentElement);

            reviewsContainer.appendChild(reviewContainer);
        }

        const prevArrow = document.getElementById(""prev-arrow"");
        const nextArrow = document.getElementById(""next-arrow"");

        prevArrow.addEventListener(""click"", () => {
            const reviews = document.querySelectorAll("".review"");
            reviews[currentReviewIndex].classList.remove(""active"");
            currentReviewIndex--;
            if (currentReviewInd");
            WriteLiteral(@"ex < 0) {
                currentReviewIndex = reviews.length - 1;
            }
            reviews[currentReviewIndex].classList.add(""active"");
        });

        nextArrow.addEventListener(""click"", () => {
            const reviews = document.querySelectorAll("".review"");
            reviews[currentReviewIndex].classList.remove(""active"");
            currentReviewIndex++;
            if (currentReviewIndex >= reviews.length) {
                currentReviewIndex = 0;
            }
            reviews[currentReviewIndex].classList.add(""active"");
        });

        const reviews = document.querySelectorAll("".review"");
        reviews[currentReviewIndex].classList.add(""active"");
    }

    generateReviews(5);
</script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 310 "D:\Diploma\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SwordParadise.Models.Weapon.WeaponDetailsVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
