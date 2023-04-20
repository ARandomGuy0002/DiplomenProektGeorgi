#pragma checksum "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3169a9a9ed5cbf2d26559e46e9164418e8262f3b"
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
#line 1 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
using SwordParadise.Models.Order;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3169a9a9ed5cbf2d26559e46e9164418e8262f3b", @"/Views/Weapon/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c866673fb75a52759e6b624055069d1cf698be6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Weapon_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SwordParadise.Models.Weapon.WeaponDetailsVM>
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
#line 4 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
  
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

    .body-container {
        max-width: 1160px;
        margin: 0 auto;
        padding: 20px;
        background-color: #fff;
        border-radius: 10px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
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

.revi");
            WriteLiteral(@"ew:hover {
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
  margin-bottom: 10px;
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
  text-a");
            WriteLiteral(@"lign: left;
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

.comment {
  margin-top: 10px;
  font-style: italic;
}

  .review {
    width: 100%;
    margin-bottom: 20px;
  }

    .weapon-details-container {
        display: flex;
        justify-content: center;
        margin-top: 50px;
    }

    .weapon-details {
        display: flex;
        flex-direction: row;
        align-items: center;
        background-color: #f5f5f5;
        border-radius: 10px;
        box-shadow: 0px 5px 10px rgba(0, 0, 0, 0.2);
        padding: 30px;
        width: 80%;
    }

    .weapon-image img {
        max-width: 400px;
    }

    .weapon-info {
        margin-left: 50px;
    }

    .weapon-name {
        font-size: 36px;
        margin-top: 0;
        margin-bottom: 20px;
    }

    .brand,
    .category,
    .quantity,
  ");
            WriteLiteral(@"  .description {
        margin: 0;
        font-size: 18px;
    }

        .brand:before,
        .category:before,
        .quantity:before,
        .description:before {
            font-weight: bold;
            content: attr(data-display-name) "": "";
        }

    .price-section {
        margin-top: 20px;
    }

    .price {
        margin: 0;
        font-size: 24px;
        font-weight: bold;
    }

    .discount {
        margin: 0;
        font-size: 24px;
        color: #ff0000;
        font-weight: bold;
        margin-left: 10px;
    }

    .create-new-container {
        text-align: center;
    }

    .create-new-btn {
        background-color: #fe90d2;
        color: white;
        text-decoration: none;
        padding: 10px 20px;
        border: none;
        border-radius: 5px;
        text-decoration: none;
        cursor: pointer;
        transition: background-color 0.3s ease;
    }

        .create-new-btn:hover {
            background-col");
            WriteLiteral(@"or: #ff6fba;
            text-decoration: none;
            color: black;
        }

        .create-new-btn:focus {
            outline: none;
        }

    .order-part {
        margin-top: 20px;
        text-align: center;
    }

        .order-part form {
            display: inline-block;
        }

        .order-part .btn-order {
            background-color: #00bcd4;
            color: white;
            padding: 10px 20px;
            border-radius: 5px;
            font-size: 16px;
            border: none;
            cursor: pointer;
        }

            .order-part .btn-order:hover {
                background-color: #008c9e;
            }

        .order-part .form-group {
            margin-bottom: 10px;
        }

        .order-part .form-control {
            display: inline-block;
            width: 60px;
            margin-left: 10px;
            margin-right: 10px;
        }

</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3169a9a9ed5cbf2d26559e46e9164418e8262f3b9085", async() => {
                WriteLiteral("\r\n<div>\r\n        <div class=\"weapon-details-container\">\r\n            <div class=\"weapon-details\">\r\n                <div class=\"weapon-image\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 5392, "\"", 5438, 1);
#nullable restore
#line 292 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
WriteAttributeValue("", 5398, Html.DisplayFor(model => model.Picture), 5398, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Image\" />\r\n                </div>\r\n                <div class=\"weapon-info\">\r\n                    <h2 class=\"weapon-name\">");
#nullable restore
#line 295 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.WeaponName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                    <p class=\"brand\">");
#nullable restore
#line 296 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                Write(Html.DisplayNameFor(model => model.BrandName));

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 296 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                                                                Write(Html.DisplayFor(model => model.BrandName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p class=\"category\">");
#nullable restore
#line 297 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 297 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                                                                      Write(Html.DisplayFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p class=\"quantity\">");
#nullable restore
#line 298 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 298 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p class=\"description\">");
#nullable restore
#line 299 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 299 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                                                                        Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <div class=\"price-section\">\r\n                        <p class=\"price\">");
#nullable restore
#line 301 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                    Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 301 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                                                                Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 302 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                         if (Model.Discount > 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p class=\"discount\">");
#nullable restore
#line 304 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 304 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                                                                                          Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
                WriteLiteral("%</p>\r\n");
#nullable restore
#line 305 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n");
#nullable restore
#line 307 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                     if (this.User.Identity.IsAuthenticated)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 309 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                   Write(await Html.PartialAsync("_OrderPartialView", new OrderConfirmVM
                    {
                    WeaponId = Model.Id
                    }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 312 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
                      
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
            </div>
        </div>
    <h1>Reviews</h1>
    <div id=""reviews""></div>
    <div class=""arrows"">
        <div id=""prev-arrow"" class=""arrow"">&#10094;</div>
        <div id=""next-arrow"" class=""arrow"">&#10095;</div>
    </div><br />
");
#nullable restore
#line 323 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
     if ((this.User.Identity.IsAuthenticated) && (this.User.IsInRole("Administrator")))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 7292, "\"", 7339, 1);
#nullable restore
#line 325 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
WriteAttributeValue("", 7299, Url.Action("Edit", new {id = Model.Id}), 7299, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"create-new-btn\">Edit</a>\r\n");
#nullable restore
#line 326 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <a");
                BeginWriteAttribute("href", " href=\"", 7387, "\"", 7414, 1);
#nullable restore
#line 327 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
WriteAttributeValue("", 7394, Url.Action("index"), 7394, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"create-new-btn\">Back to List</a>\r\n</div>\r\n");
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
            WriteLiteral(@"
<script>
    function generateRandomReview() {
        const names = [""John"", ""Jane"", ""Bob"", ""Samantha"", ""Emily"", ""Ethan"", ""Olivia"", ""Liam"", ""Sophia"", ""Noah"", ""Emma"", ""William"", ""Isabella"", ""James"", ""Mia""];
        const lastNames = [""Smith"", ""Johnson"", ""Williams"", ""Jones"", ""Brown"", ""Garcia"", ""Miller"", ""Davis"", ""Rodriguez"", ""Martinez"", ""Hernandez"", ""Lopez"", ""Gonzalez"", ""Perez"", ""Taylor"", ""Anderson"", ""Wilson"", ""Jackson"", ""Graham"", ""Nelson"", ""White"", ""Harris"", ""Moore"", ""Clark"", ""Lewis"", ""Walker"", ""Young"", ""Allen"", ""King"", ""Wright"", ""Scott"", ""Green"", ""Baker"", ""Adams"", ""Hall"", ""Rivera"", ""Mitchell"", ""Carter"", ""Thomas"", ""Lee"", ""Collins"", ""Roberts"", ""Phillips"", ""Edwards"", ""Turner"", ""Campbell"", ""Parker"", ""Evans"", ""Cooper"", ""Reed"", ""Stewart"", ""Morris"", ""Nguyen"", ""Murphy"", ""Cook"", ""Rogers"", ""Gray"", ""Hughes"", ""Flores"", ""Wood"", ""James"", ""Kim"", ""Watson"", ""Dean"", ""Morgan"", ""Reyes"", ""Bennett"", ""Ross"", ""Hill"", ""Powell"", ""Foster"", ""Perry"", ""Long"", ""Butler""];
        const comments = [
            ""This product is amazi");
            WriteLiteral(@"ng!"",
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
            ""I am thoroughly impressed with this product!""

        ];
        const stars = Math.floor(Math.random() * 2) + 4;
        const name = names[Math.floor(Math.random() * names.length)];
        const lastName = lastNames[Math.floor(Math.random() * lastNames.length)];
        const comment = comments[Math.f");
            WriteLiteral(@"loor(Math.random() * comments.length)];
        return { name, lastName, comment, stars };
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
            nameElement.textContent = review.name + "" "" + review.lastName; // include last name in nameElement
            reviewContainer.appendChild(nameElement);

            const starsElement = document.createElement(""span"");
            starsElement.classList.add(""stars"");
            reviewContainer.appendChild(starsElement);
            for (let j = 0; j < review.stars; j++) {
                const starElement = doc");
            WriteLiteral(@"ument.createElement(""span"");
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
            if (currentReviewIndex < 0) {
                currentReviewIndex = reviews.length - 1;
            }
            reviews[currentReviewInde");
            WriteLiteral(@"x].classList.add(""active"");
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
#line 422 "D:\Diplomna\SwordParadise\SwordParadise\Views\Weapon\Details.cshtml"
      
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
