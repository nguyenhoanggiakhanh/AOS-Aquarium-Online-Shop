#pragma checksum "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8e2fec6bdf948b7f962698e7bc40d33a3561851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchByName), @"mvc.1.0.view", @"/Views/Search/SearchByName.cshtml")]
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
#line 1 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8e2fec6bdf948b7f962698e7bc40d33a3561851", @"/Views/Search/SearchByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92e2ba627270339132bff3ddc82f3cdb3fe61485", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/category-img1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/category-img2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Retis lapen casen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddtoWishlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-wishlist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchByName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex align-items-center justify-content-between"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    IEnumerable<Brand> Brand = ViewData["ProductBrand"] as IEnumerable<Brand>;
    IEnumerable<Color> Color = ViewData["ProductColor"] as IEnumerable<Color>;
    IEnumerable<Shop.Models.Type> Type = ViewData["ProductType"] as IEnumerable<Shop.Models.Type>;
    IEnumerable<Size> Size = ViewData["ProductSize"] as IEnumerable<Size>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""main-container col2-left-layout bounceInUp animated"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-9 col-sm-push-3"">
                <div class=""category-description std"">
                    <div class=""slider-items-products"">
                        <div id=""category-desc-slider"" class=""product-flexslider hidden-buttons"">
                            <div class=""slider-items slider-width-col1 owl-carousel owl-theme"">

                                <!-- Item -->
                                <div class=""item"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8e2fec6bdf948b7f962698e7bc40d33a35618518180", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <!-- End Item -->\r\n                                <!-- Item -->\r\n                                <div class=\"item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8e2fec6bdf948b7f962698e7bc40d33a35618519530", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <div class=""cat-img-title cat-bg cat-box"">
                                    </div>
                                    <!-- End Item -->

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <article class=""col-main"">
                    <h2 class=""page-heading""> <span class=""page-heading-title"">Sản phẩm</span> </h2>
                    <div class=""display-product-option"">
                        <div class=""pager hidden-xs"">
                            <div class=""pages"">
                                <ul class=""pagination"">
                                    <li><a href=""#"">&laquo;</a></li>
                                    <li class=""active""><a href=""#"">1</a></li>
                                    <li><a href=""#"">2</a></li>
                                    <li><a href=""#"">3</a></li>
                                    <li");
            WriteLiteral(@"><a href=""#"">4</a></li>
                                    <li><a href=""#"">5</a></li>
                                    <li><a href=""#"">&raquo;</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""category-products"">
                        <ul class=""products-grid"">
");
#nullable restore
#line 57 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                             foreach (var item in Model)
                            {

                                string[] arrListStr = item.ProductImage.Split(" ");


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""item col-lg-4 col-md-4 col-sm-4 col-xs-6"">
                                    <div class=""item-inner"">
                                        <div class=""item-img"">
                                            <div class=""item-img-info"">
                                                <a href=""#""");
            BeginWriteAttribute("title", " title=\"", 3356, "\"", 3381, 1);
#nullable restore
#line 66 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
WriteAttributeValue("", 3364, item.ProductName, 3364, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-image\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8e2fec6bdf948b7f962698e7bc40d33a356185113249", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3415, "~/images/", 3415, 9, true);
#nullable restore
#line 66 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
AddHtmlAttributeValue("", 3424, arrListStr[0], 3424, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                                <div class=\"box-hover\">\r\n                                                    <ul class=\"add-to-links\">\r\n                                                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8e2fec6bdf948b7f962698e7bc40d33a356185115038", async() => {
                WriteLiteral("Yêu thích");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""item-info"">
                                            <div class=""info-inner"">
                                                <div class=""item-title""><a");
            BeginWriteAttribute("href", " href=\"", 4229, "\"", 4262, 2);
            WriteAttributeValue("", 4236, "/Products/Details/", 4236, 18, true);
#nullable restore
#line 76 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
WriteAttributeValue("", 4254, item.Id, 4254, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Retis lapen casen\">");
#nullable restore
#line 76 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                                                                                                                  Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> </div>
                                                <div class=""item-content""> 
                                                    <div class=""item-price"">
                                                        <div class=""price-box""><span class=""regular-price""><span class=""price"">");
#nullable restore
#line 79 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                                                                                                          Write(item.OutPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </span> </div>
                                                    </div>
                                                    <div class=""action"">
                                                        <button class=""button btn-cart"" type=""button""");
            BeginWriteAttribute("title", " title=\"", 4875, "\"", 4883, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-original-title=""Add to Cart""><span>Thêm vào giỏ hàng</span></button>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </li>
");
#nullable restore
#line 89 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </ul>
                    </div>
                    <div class=""toolbar"">
                        <div class=""row"">
                            <div class=""col-lg-3 col-md-4"">
                                
                            </div>
                            <div class=""col-lg-6 col-sm-7 col-md-5"">
                                <div class=""pager"">
                                    <div class=""pages"">
                                        <label>Trang:</label>
                                        <ul class=""pagination"">
                                            <li><a href=""#"">&laquo;</a></li>
                                            <li class=""active""><a href=""#"">1</a></li>
                                            <li><a href=""#"">2</a></li>
                                            <li><a href=""#"">3</a></li>
                                            <li><a href=""#"">4</a></li>
                                            <li><a href");
            WriteLiteral(@"=""#"">5</a></li>
                                            <li><a href=""#"">&raquo;</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-3 col-sm-12 col-md-3"">

                            </div>
                        </div>
                    </div>
                </article>
                <!--	///*///======    End article  ========= //*/// -->
            </div>
            <div class=""col-left sidebar col-sm-3 col-xs-12 col-sm-pull-9"">
                <aside class=""col-left sidebar"">
                    <div class=""side-nav-categories"">
                        <div class=""block-title""> Danh mục </div>
                        <!--block-title-->
                        <!-- BEGIN BOX-CATEGORY -->
                        <div class=""box-content box-category"">
                            <ul>

");
#nullable restore
#line 132 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                 foreach (Shop.Models.Type type in Type)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 7463, "\"", 7504, 3);
            WriteAttributeValue("", 7470, "/Search/SearchByName/", 7470, 21, true);
#nullable restore
#line 134 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
WriteAttributeValue("", 7491, type.Id, 7491, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 7499, "type", 7500, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 134 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                                                                Write(type.Tilte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 135 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </ul>
                        </div>
                        <!--box-content box-category-->
                    </div>
                    <div class=""hot-banner""><img alt=""banner"" src=""./images/hot-trends-banner.jpg""></div>
                    <div class=""block block-layered-nav"">
                        <div class=""block-title"">Lọc</div>
                        <div class=""block-content"">
                            <p class=""block-subtitle""></p>
                            <dl id=""narrow-by-list"">
                                <dt class=""odd"">Giá</dt>
                                <dd class=""odd"">
                                    <ol>
                                        <div class=""price-range-wrap"">
");
#nullable restore
#line 151 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                              
                                                double min = Convert.ToDouble(ViewData["min"]);
                                                double max = Convert.ToDouble(ViewData["max"]);
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"price-range \" data-min=\"");
#nullable restore
#line 155 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                                                           Write(min);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-max=\"");
#nullable restore
#line 155 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                                                                           Write(max);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\r\n                                            <div class=\"range-slider\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8e2fec6bdf948b7f962698e7bc40d33a356185126012", async() => {
                WriteLiteral(@"
                                                    <div class=""price"">
                                                        <input style=""outline:hidden;border:none"" readonly name=""pricesearch"" type=""text"" id=""amount"">
                                                    </div>
                                                    <button type=""submit"" class=""filter-btn"">Lọc</button>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </ol>
                                </dd>
                                <dt class=""even"">Đơn Vị Tính : </dt>
                                <dd class=""even"">
                                    <ol>
");
#nullable restore
#line 170 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                         foreach (Brand brand in Brand)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 9927, "\"", 9970, 3);
            WriteAttributeValue("", 9934, "/Search/SearchByName/", 9934, 21, true);
#nullable restore
#line 172 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
WriteAttributeValue("", 9955, brand.Id, 9955, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 9964, "brand", 9965, 6, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 172 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                                                                          Write(brand.Tilte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 173 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ol>\r\n                                </dd>\r\n                                <dt class=\"odd\">Nhà Cung Cấp</dt>\r\n                                <dd class=\"odd\">\r\n                                    <ol>\r\n");
#nullable restore
#line 179 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                         foreach (Size size in Size)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 10442, "\"", 10483, 3);
            WriteAttributeValue("", 10449, "/Search/SearchByName/", 10449, 21, true);
#nullable restore
#line 181 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
WriteAttributeValue("", 10470, size.Id, 10470, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 10478, "size", 10479, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 181 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                                                                        Write(size.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 182 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ol>\r\n                                </dd>\r\n                                <dt class=\"odd\">Nước Cung Cấp</dt>\r\n                                <dd class=\"odd\">\r\n                                    <ol>\r\n");
#nullable restore
#line 188 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                         foreach (Color color in Color)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 10958, "\"", 11001, 3);
            WriteAttributeValue("", 10965, "/Search/SearchByName/", 10965, 21, true);
#nullable restore
#line 190 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
WriteAttributeValue("", 10986, color.Id, 10986, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 10995, "color", 10996, 6, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 190 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                                                                          Write(color.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 191 "E:\SU22\Thesis\AOS-Aquarium-Online-Shop\Shop\Views\Search\SearchByName.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ol>
                                </dd>
                            </dl>
                        </div>
                    </div>

                </aside>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
