#pragma checksum "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b648e4cab5018eed0e229acbf8d3ab0dacde474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Cart), @"mvc.1.0.view", @"/Views/Order/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b648e4cab5018eed0e229acbf8d3ab0dacde474", @"/Views/Order/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ef9f60c20a88260d3bc0afccf45bfd2e6b9eb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagenatedList<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-page", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
  
    ViewData["Title"] = "Index";
    int counter = (Model.PageIndex - 1) * Model.PageSize;
    var temp = -1;
    decimal total = 0;
    if (Model.PageIndex == 1)
    {
        temp = 0;
    }
    if (Model.PageIndex == 0)
    {
        temp = 1;
    }
    if (temp == Model.TotalPages)
    {
        temp = -2;
    }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""breadcrumb-area bg-img"" data-bg=""~/assets/img/banner/breadcrumb-banner.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""breadcrumb-wrap text-center"">
                    <nav aria-label=""breadcrumb"">
                        <h1 class=""breadcrumb-title"">Cart</h1>
                        <ul class=""breadcrumb"">
                            <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b648e4cab5018eed0e229acbf8d3ab0dacde4746953", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Cart</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- breadcrumb area end -->
<!-- cart main wrapper start -->
<div class=""cart-main-wrapper section-padding"">
    <div class=""container"">
        <div class=""section-bg-color"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!-- Cart Table Area -->
                    <div class=""cart-table table-responsive"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th scope=""col"">#</th>
                                    <th scope=""col"">Item count</th>
                                    <th scope=""col"">FulName</th>
                                    <th scope=""col"">Phone</th>
                         ");
            WriteLiteral(@"           <th scope=""col"">Total</th>
                                    <th scope=""col"">Date</th>
                                    <th scope=""col"">Status</th>
                                    <th scope=""col""></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 63 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                 foreach (var item in Model)
                                {
                                    counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 67 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                                   Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 68 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                       Write(item.OrderItems.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 69 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                       Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 70 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                       Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 71 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                       Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 72 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                       Write(item.CreatedAt.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 73 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                       Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 75 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                    <!-- Cart Update Option -->
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
");
#nullable restore
#line 82 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                             if (Model.HasPrev)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b648e4cab5018eed0e229acbf8d3ab0dacde47413587", async() => {
                WriteLiteral("<i class=\"fas fa-angle-double-left\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-isDeleted", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                                                                                                         WriteLiteral(ViewBag.IsDeleted);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeleted"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-isDeleted", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeleted"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b648e4cab5018eed0e229acbf8d3ab0dacde47416590", async() => {
                WriteLiteral("<i class=\"fas fa-angle-left\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                                                                                  WriteLiteral(Model.PageIndex-1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                                                                                                                            WriteLiteral(ViewBag.IsDeleted);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeleted"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-isDeleted", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeleted"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 86 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 88 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                             for (int i = 1; i <= 3; i++, temp++)
                            {
                                if ((Model.PageIndex + temp) != 0 && (Model.PageIndex + temp) != -1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b648e4cab5018eed0e229acbf8d3ab0dacde47420633", async() => {
#nullable restore
#line 92 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                                                                                                                                                                                                                                         Write(Model.PageIndex+temp);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                                                                                      WriteLiteral(Model.PageIndex+temp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                                                                                                                                   WriteLiteral(ViewBag.IsDeleted);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeleted"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-isDeleted", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeleted"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4234, "display:", 4234, 8, true);
#nullable restore
#line 92 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
AddHtmlAttributeValue("", 4242, (Model.PageIndex+temp)>Model.TotalPages?"none":"block", 4242, 57, false);

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
            WriteLiteral("</li>\r\n");
#nullable restore
#line 93 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 97 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                             if (Model.HasNext)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b648e4cab5018eed0e229acbf8d3ab0dacde47425593", async() => {
                WriteLiteral("<i class=\"fas fa-angle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                                                                                  WriteLiteral(Model.PageIndex+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                                                                                                                            WriteLiteral(ViewBag.IsDeleted);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeleted"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-isDeleted", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeleted"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b648e4cab5018eed0e229acbf8d3ab0dacde47428901", async() => {
                WriteLiteral("<i class=\"fas fa-angle-double-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                                                                                 WriteLiteral(Model.TotalPages);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                                                                                                                         WriteLiteral(ViewBag.IsDeleted);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeleted"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-isDeleted", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isDeleted"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 101 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                    </nav>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-5 ml-auto"">
                    <!-- Cart Calculation Area -->
                    <div class=""cart-calculator-wrapper"">
                        <div class=""cart-calculate-items"">
                            <h3>Cart Totals</h3>
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <tr class=""total"">
                                        <td>Total</td>
");
#nullable restore
#line 117 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                         foreach (var item in Model)
                                        {
                                            total += item.TotalPrice;
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 121 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Order\Cart.cshtml"
                                       Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                </table>\r\n                            </div>\r\n                        </div>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b648e4cab5018eed0e229acbf8d3ab0dacde47434054", async() => {
                WriteLiteral("Proceed Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagenatedList<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
