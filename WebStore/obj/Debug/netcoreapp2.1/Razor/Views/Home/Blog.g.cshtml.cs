#pragma checksum "D:\My\WebStore\WebStore.git\WebStore\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7872ca1882a6b3d5760565de45ad3b274911a67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blog), @"mvc.1.0.view", @"/Views/Home/Blog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Blog.cshtml", typeof(AspNetCore.Views_Home_Blog))]
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
#line 1 "D:\My\WebStore\WebStore.git\WebStore\Views\_ViewImports.cshtml"
using WebStore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7872ca1882a6b3d5760565de45ad3b274911a67", @"/Views/Home/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1930ddb06ae99926c1c9fbb7f57b6b67d93278dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/images/home/shipping.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/~/lib/images/blog/blog-one.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/images/blog/blog-two.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/images/blog/blog-three.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\My\WebStore\WebStore.git\WebStore\Views\Home\Blog.cshtml"
  
    ViewData["Title"] = "Blog";

#line default
#line hidden
            BeginContext(40, 5038, true);
            WriteLiteral(@"
<section>
	<div class=""container"">
		<div class=""row"">
			<div class=""col-sm-3"">
				<div class=""left-sidebar"">
					<h2>Category</h2>
					<div class=""panel-group category-products"" id=""accordian"">
						<!--category-productsr-->
						<div class=""panel panel-default"">
							<div class=""panel-heading"">
								<h4 class=""panel-title"">
									<a data-toggle=""collapse"" data-parent=""#accordian"" href=""#sportswear"">
										<span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
										Sportswear
									</a>
								</h4>
							</div>
							<div id=""sportswear"" class=""panel-collapse collapse"">
								<div class=""panel-body"">
									<ul>
										<li><a href="""">Nike </a></li>
										<li><a href="""">Under Armour </a></li>
										<li><a href="""">Adidas </a></li>
										<li><a href="""">Puma</a></li>
										<li><a href="""">ASICS </a></li>
									</ul>
								</div>
							</div>
						</div>
						<div class=""panel panel-default"">
							<div class=""p");
            WriteLiteral(@"anel-heading"">
								<h4 class=""panel-title"">
									<a data-toggle=""collapse"" data-parent=""#accordian"" href=""#mens"">
										<span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
										Mens
									</a>
								</h4>
							</div>
							<div id=""mens"" class=""panel-collapse collapse"">
								<div class=""panel-body"">
									<ul>
										<li><a href="""">Fendi</a></li>
										<li><a href="""">Guess</a></li>
										<li><a href="""">Valentino</a></li>
										<li><a href="""">Dior</a></li>
										<li><a href="""">Versace</a></li>
										<li><a href="""">Armani</a></li>
										<li><a href="""">Prada</a></li>
										<li><a href="""">Dolce and Gabbana</a></li>
										<li><a href="""">Chanel</a></li>
										<li><a href="""">Gucci</a></li>
									</ul>
								</div>
							</div>
						</div>

						<div class=""panel panel-default"">
							<div class=""panel-heading"">
								<h4 class=""panel-title"">
									<a data-toggle=""collapse"" data-parent=""#accor");
            WriteLiteral(@"dian"" href=""#womens"">
										<span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
										Womens
									</a>
								</h4>
							</div>
							<div id=""womens"" class=""panel-collapse collapse"">
								<div class=""panel-body"">
									<ul>
										<li><a href="""">Fendi</a></li>
										<li><a href="""">Guess</a></li>
										<li><a href="""">Valentino</a></li>
										<li><a href="""">Dior</a></li>
										<li><a href="""">Versace</a></li>
									</ul>
								</div>
							</div>
						</div>
						<div class=""panel panel-default"">
							<div class=""panel-heading"">
								<h4 class=""panel-title""><a href=""#"">Kids</a></h4>
							</div>
						</div>
						<div class=""panel panel-default"">
							<div class=""panel-heading"">
								<h4 class=""panel-title""><a href=""#"">Fashion</a></h4>
							</div>
						</div>
						<div class=""panel panel-default"">
							<div class=""panel-heading"">
								<h4 class=""panel-title""><a href=""#"">Households</a></h4>
							</");
            WriteLiteral(@"div>
						</div>
						<div class=""panel panel-default"">
							<div class=""panel-heading"">
								<h4 class=""panel-title""><a href=""#"">Interiors</a></h4>
							</div>
						</div>
						<div class=""panel panel-default"">
							<div class=""panel-heading"">
								<h4 class=""panel-title""><a href=""#"">Clothing</a></h4>
							</div>
						</div>
						<div class=""panel panel-default"">
							<div class=""panel-heading"">
								<h4 class=""panel-title""><a href=""#"">Bags</a></h4>
							</div>
						</div>
						<div class=""panel panel-default"">
							<div class=""panel-heading"">
								<h4 class=""panel-title""><a href=""#"">Shoes</a></h4>
							</div>
						</div>
					</div><!--/category-products-->

					<div class=""brands_products"">
						<!--brands_products-->
						<h2>Brands</h2>
						<div class=""brands-name"">
							<ul class=""nav nav-pills nav-stacked"">
								<li><a href=""""> <span class=""pull-right"">(50)</span>Acne</a></li>
								<li><a href=""""> <span class=""pull-right"">(");
            WriteLiteral(@"56)</span>Grüne Erde</a></li>
								<li><a href=""""> <span class=""pull-right"">(27)</span>Albiro</a></li>
								<li><a href=""""> <span class=""pull-right"">(32)</span>Ronhill</a></li>
								<li><a href=""""> <span class=""pull-right"">(5)</span>Oddmolly</a></li>
								<li><a href=""""> <span class=""pull-right"">(9)</span>Boudestijn</a></li>
								<li><a href=""""> <span class=""pull-right"">(4)</span>Rösch creative culture</a></li>
							</ul>
						</div>
					</div><!--/brands_products-->

					<div class=""price-range"">
						<!--price-range-->
						<h2>Price Range</h2>
						<div class=""well"">
							<input type=""text"" class=""span2"" value="""" data-slider-min=""0"" data-slider-max=""600"" data-slider-step=""5"" data-slider-value=""[250,450]"" id=""sl2""><br />
							<b>$ 0</b> <b class=""pull-right"">$ 600</b>
						</div>
					</div><!--/price-range-->

					<div class=""shipping text-center"">
						<!--shipping-->
						");
            EndContext();
            BeginContext(5078, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a6d26ee89d0a4a219388d7491a0764d8", async() => {
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
            EndContext();
            BeginContext(5129, 752, true);
            WriteLiteral(@"
					</div><!--/shipping-->
				</div>
			</div>
			<div class=""col-sm-9"">
				<div class=""blog-post-area"">
					<h2 class=""title text-center"">Latest From our Blog</h2>
					<div class=""single-blog-post"">
						<h3>Girls Pink T Shirt arrived in store</h3>
						<div class=""post-meta"">
							<ul>
								<li><i class=""fa fa-user""></i> Mac Doe</li>
								<li><i class=""fa fa-clock-o""></i> 1:33 pm</li>
								<li><i class=""fa fa-calendar""></i> DEC 5, 2013</li>
							</ul>
							<span>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star-half-o""></i>
							</span>
						</div>
						<a href="""">
							");
            EndContext();
            BeginContext(5881, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "24ccfbc421fb4b57ad2ad6dffc55bea0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5936, 1008, true);
            WriteLiteral(@"
						</a>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
						<a class=""btn btn-primary"" href="""">Read More</a>
					</div>
					<div class=""single-blog-post"">
						<h3>Girls Pink T Shirt arrived in store</h3>
						<div class=""post-meta"">
							<ul>
								<li><i class=""fa fa-user""></i> Mac Doe</li>
								<li><i class=""fa fa-clock-o""></i> 1:33 pm</li>
								<li><i class=""fa fa-calendar""></i> DEC 5, 2013</li>
							</ul>
							<span>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star-half-o""></i>
							</span>
						</div>
						<a href="""">
							");
            EndContext();
            BeginContext(6944, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc9148c511d24f5ba1e1bebe8c81f0c5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6993, 1008, true);
            WriteLiteral(@"
						</a>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
						<a class=""btn btn-primary"" href="""">Read More</a>
					</div>
					<div class=""single-blog-post"">
						<h3>Girls Pink T Shirt arrived in store</h3>
						<div class=""post-meta"">
							<ul>
								<li><i class=""fa fa-user""></i> Mac Doe</li>
								<li><i class=""fa fa-clock-o""></i> 1:33 pm</li>
								<li><i class=""fa fa-calendar""></i> DEC 5, 2013</li>
							</ul>
							<span>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star-half-o""></i>
							</span>
						</div>
						<a href="""">
							");
            EndContext();
            BeginContext(8001, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2afa15e9977b4cf896007f3689f28e31", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8052, 772, true);
            WriteLiteral(@"
						</a>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
						<a class=""btn btn-primary"" href="""">Read More</a>
					</div>
					<div class=""pagination-area"">
						<ul class=""pagination"">
							<li><a href="""" class=""active"">1</a></li>
							<li><a href="""">2</a></li>
							<li><a href="""">3</a></li>
							<li><a href=""""><i class=""fa fa-angle-double-right""></i></a></li>
						</ul>
					</div>
				</div>
			</div>
		</div>
	</div>
</section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
