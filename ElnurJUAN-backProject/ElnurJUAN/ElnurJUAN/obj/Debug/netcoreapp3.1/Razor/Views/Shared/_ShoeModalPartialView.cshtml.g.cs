#pragma checksum "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fa33ca868f2696dcaba31c00edb814d7cb148a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ShoeModalPartialView), @"mvc.1.0.view", @"/Views/Shared/_ShoeModalPartialView.cshtml")]
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
#line 1 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\_ViewImports.cshtml"
using ElnurJUAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\_ViewImports.cshtml"
using ElnurJUAN.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\_ViewImports.cshtml"
using ElnurJUAN.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa33ca868f2696dcaba31c00edb814d7cb148a4", @"/Views/Shared/_ShoeModalPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ef9f60c20a88260d3bc0afccf45bfd2e6b9eb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ShoeModalPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shoe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("modalimage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shoe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addbasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-dialog modal-lg modal-dialog-centered"">
    <div class=""modal-content"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
        </div>
        <div class=""modal-body"">
            <!-- product details inner end -->
            <div class=""product-details-inner"">
                <div class=""row"">
                    <div class=""col-lg-5"">
                        <div class=""product-large-slider mb-20"">
                            <div class=""pro-large-img"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2fa33ca868f2696dcaba31c00edb814d7cb148a45579", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 635, "~/uploads/products/", 635, 19, true);
#nullable restore
#line 14 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
AddHtmlAttributeValue("", 654, Model.ShoeImages.FirstOrDefault(x=>x.PosterStatus==true)?.Image, 654, 64, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-7\">\r\n                        <div class=\"product-details-des\">\r\n                            <h3 class=\"pro-det-title\">");
#nullable restore
#line 20 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"brand-shoe availability mb-10\">\r\n                                <h5 class=\"cat-title\">Category:</h5>\r\n                                <span class=\"text-info categorymodal\" style=\"cursor:pointer\">");
#nullable restore
#line 23 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                                                                        Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"pro-review\">\r\n                                <span><a href=\"#\">");
#nullable restore
#line 26 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                             Write(Model.ShoeComments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Review(s)</a></span>\r\n                            </div>\r\n                            <div class=\"price-box\">\r\n");
#nullable restore
#line 29 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                 if (Model.DiscountPercent > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"price-old\"  style=\"font-size:21px\"><del>$");
#nullable restore
#line 31 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                                                                     Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></span>\r\n                                    <span class=\"price-regular\" style=\"font-size:21px\">$");
#nullable restore
#line 32 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                                                                    Write((Model.SalePrice * (1- Model.DiscountPercent/100)).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <br />\r\n                                    <h6 class=\"text-danger\" style=\"font-size:13px;padding-top:8px\">");
#nullable restore
#line 34 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                                                                              Write(Model.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % Sale</h6>\r\n");
#nullable restore
#line 35 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"price-regular\">$");
#nullable restore
#line 38 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                                            Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 39 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <span class=\"discount-percent-modal text-danger\"></span>\r\n                            <p class=\"shoe-desc-modal\" style=\"padding-top:5px\">");
#nullable restore
#line 42 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                                                          Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <div class=\"quantity-cart-box d-flex align-items-center mb-20\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa33ca868f2696dcaba31c00edb814d7cb148a412773", async() => {
                WriteLiteral("Add To Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2781, "btn", 2781, 3, true);
            AddHtmlAttributeValue(" ", 2784, "btn-default", 2785, 12, true);
            AddHtmlAttributeValue(" ", 2796, "add-to-cart-shoe", 2797, 17, true);
#nullable restore
#line 44 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
AddHtmlAttributeValue(" ", 2813, Model.IsAvailable==false?"disabled":"", 2814, 41, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"availability mb-10\">\r\n                                <h5 class=\"cat-title\">Availability:</h5>\r\n                                <span class=\"shoe-isavailable\"");
            BeginWriteAttribute("style", " style=\"", 3108, "\"", 3162, 2);
            WriteAttributeValue("", 3116, "color:", 3116, 6, true);
#nullable restore
#line 48 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
WriteAttributeValue("", 3122, Model.IsAvailable==true?"green":"red", 3122, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                                                                                                  Write(Model.IsAvailable==true?"In Stock":"Out of Stock");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                            <div class=""brand-shoe availability mb-10"">
                                <h5 class=""cat-title"">Brand:</h5>
                                <span class=""brandmodal text-info"" style=""cursor:pointer"">");
#nullable restore
#line 52 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                                                                     Write(Model.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"brand-shoe availability mb-10\">\r\n                                <h5 class=\"cat-title\">Colors:</h5>\r\n");
#nullable restore
#line 56 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                 foreach (var color in Model.ShoeColors)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span");
            BeginWriteAttribute("style", " style=\"", 3844, "\"", 3926, 2);
            WriteAttributeValue("", 3852, "cursor:pointer;color:", 3852, 21, true);
#nullable restore
#line 58 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
WriteAttributeValue("", 3873, color.Color.Name!="White"?@color.Color.HexValue:"", 3873, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 59 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                   Write(color.Color.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n");
#nullable restore
#line 61 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <div class=""brand-shoe availability mb-10"">
                                <h5 class=""cat-title"">Sexuality:</h5>
                                <span class=""text-info gendermodal"" style=""cursor:pointer"">");
#nullable restore
#line 66 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Shared\_ShoeModalPartialView.cshtml"
                                                                                      Write(Model.Gender.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!-- product details inner end -->\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shoe> Html { get; private set; }
    }
}
#pragma warning restore 1591
