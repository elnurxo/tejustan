#pragma checksum "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26fead3dc844e2169874416619d343491ad194da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26fead3dc844e2169874416619d343491ad194da", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ef9f60c20a88260d3bc0afccf45bfd2e6b9eb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MemberProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logout-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logout-user text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    int orderCounter = 0;
    int orderItemCounter = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main>
    <!-- breadcrumb area start -->
    <div class=""breadcrumb-area bg-img"" data-bg=""assets/img/banner/breadcrumb-banner.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">My Account</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26fead3dc844e2169874416619d343491ad194da6238", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">My Account</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb area end -->
    <!-- my account wrapper start -->
    <div class=""my-account-wrapper section-padding"">
        <div class=""container custom-container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!-- My Account Page Start -->
                    <div class=""myaccount-page-wrapper"">
                        <!-- My Account Tab Menu Start -->
                        <div class=""row"">
                            <div class=""col-lg-3 col-md-4"">
                                <div class=""myaccount-tab-menu nav"" role=""tablist"">
                                    <a href=""#dashboad"" data-toggle=""tab"">
                                        <i class=""fa fa-dashbo");
            WriteLiteral(@"ard""></i>
                                        INFO
                                    </a>
                                    <a href=""#orders"" data-toggle=""tab""><i class=""fa fa-cart-arrow-down""></i> Orders</a>
                                    <a href=""#address-edit"" data-toggle=""tab""><i class=""fa fa-map-marker""></i> address</a>
                                    <a href=""#account-info"" data-toggle=""tab""");
            BeginWriteAttribute("class", " class=\"", 2173, "\"", 2273, 1);
#nullable restore
#line 44 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
WriteAttributeValue("", 2181, (TempData["ProfileTab"]!=null &&TempData["ProfileTab"].ToString()=="Account")?"active":"", 2181, 92, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-user\"></i> Account Details</a>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26fead3dc844e2169874416619d343491ad194da9692", async() => {
                WriteLiteral("<i class=\"fa fa-sign-out\"></i> Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
                            <!-- My Account Tab Menu End -->
                            <!-- My Account Tab Content Start -->
                            <div class=""col-lg-9 col-md-8"">
                                <div class=""tab-content"" id=""myaccountContent"">
                                    <!-- Single Tab DASBOARD Start -->
                                    <div class=""tab-pane fade"" id=""dashboad"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Xoş Gəldiniz!</h3>
                                            <div class=""welcome"">
                                                <p>Salam, <strong>");
#nullable restore
#line 57 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                             Write(Model.Member.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> (Əgər <strong>");
#nullable restore
#line 57 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                                           Write(Model.Member.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" !</strong> deyilsinizsə ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26fead3dc844e2169874416619d343491ad194da12723", async() => {
                WriteLiteral("Sistemdən Çıx");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@")</p>
                                            </div>
                                            <p class=""mb-0"">Bu Səhifədən siz asanlıqla sifarişlərinizi izləyə və hesabınızı idarə edə bilər və məlumatlarınız(şifrəni) üzərində dəyişikliklər edə bilərsiniz :)</p>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab ORDERS Start -->
                      <div class=""col-lg-9 col-12 mt--30 mt-lg--0"">
                                        <div class=""tab-content"" id=""myaccountContent"">
                                            <!-- Single Tab Content Start -->
                                            <div class=""tab-pane fade"" id=""orders"" role=""tabpanel"">
                                                <div class=""myaccount-content"">
                                                    <h3>Orders</h3>
                                 ");
            WriteLiteral(@"                   <div class=""myaccount-table table-responsive text-center"">
                                                        <div class=""col-md-12"">
                                                            <div class=""panel panel-default"">
                                                                <div class=""panel-body"">
                                                                    <table class=""table table-condensed table-striped"">
                                                                        <thead>
                                                                            <tr>
                                                                                <th>#</th>
                                                                                <th>Items count</th>
                                                                                <th>Phone </th>
                                                                                <th>Total</th>
        ");
            WriteLiteral(@"                                                                        <th>Date</th>
                                                                                <th>Status</th>
                                                                            </tr>
                                                                        </thead>

                                                                        <tbody>

");
#nullable restore
#line 88 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                             foreach (var order in Model.Orders)
                                                                            {
                                                                                orderItemCounter = 0;
                                                                                orderCounter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                <tr data-toggle=\"collapse\" data-target=\"#demo-");
#nullable restore
#line 92 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                                                         Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"accordion-toggle\">\r\n                                                                                    <td>");
#nullable restore
#line 93 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                   Write(orderCounter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                    <td>");
#nullable restore
#line 94 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                   Write(order.OrderItems.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                    <td>");
#nullable restore
#line 95 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                   Write(order.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                    <td>");
#nullable restore
#line 96 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                   Write(order.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                    <td>");
#nullable restore
#line 97 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                   Write(order.CreatedAt.ToString("dd-MM-yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                    <td>");
#nullable restore
#line 98 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                   Write(order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                </tr>\r\n");
            WriteLiteral(@"                                                                                <tr>
                                                                                    <td colspan=""12"" class=""hiddenRow"">
                                                                                        <div class=""accordian-body collapse""");
            BeginWriteAttribute("id", " id=\"", 7606, "\"", 7625, 2);
            WriteAttributeValue("", 7611, "demo-", 7611, 5, true);
#nullable restore
#line 103 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
WriteAttributeValue("", 7616, order.Id, 7616, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                                                            <table class=""table table-striped"">
                                                                                                <thead>
                                                                                                    <tr class=""info"">
                                                                                                        <th></th>
                                                                                                        <th>Product Name</th>
                                                                                                        <th>Count</th>
                                                                                                        <th>Unit price</th>
                                                                                                    </tr>
                                                                          ");
            WriteLiteral("                      </thead>\r\n\r\n                                                                                                <tbody>\r\n\r\n");
#nullable restore
#line 116 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                                     foreach (var orderItem in order.OrderItems)
                                                                                                    {
                                                                                                        orderItemCounter++;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                                                        <tr data-toggle=""collapse"" class=""accordion-toggle"" data-target=""#demo10"">
                                                                                                            <td>");
#nullable restore
#line 120 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                                           Write(orderItemCounter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                                            <td>");
#nullable restore
#line 121 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                                           Write(orderItem.Shoe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                                            <td>");
#nullable restore
#line 122 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                                           Write(orderItem.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                                                                                            <td>");
#nullable restore
#line 123 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                                           Write(orderItem.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                                        </tr>\r\n");
#nullable restore
#line 125 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                                                </tbody>
                                                                                            </table>

                                                                                        </div>
                                                                                    </td>
                                                                                </tr>
");
#nullable restore
#line 132 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                        </tbody>
                                                                    </table>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- Single Tab Content End -->
                                            <!-- Single Tab ADDRESS EDIT Start -->
                                            <div class=""tab-pane fade"" id=""address-edit"" role=""tabpanel"">
                                                <div class=""myaccount-content"">
                                                    <h3>Ödəniş Adresi</h3>
");
#nullable restore
#line 146 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                     if (Model.Member.Address != null)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <address>\r\n                                                            <p><strong>");
#nullable restore
#line 149 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                  Write(Model.Member.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 149 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                          Write(Model.Member.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                                                            <p>\r\n                                                                ");
#nullable restore
#line 151 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                           Write(Model.Member.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n                                                                ");
#nullable restore
#line 152 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                           Write(Model.Member.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 152 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                                  Write(Model.Member.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </p>\r\n                                                            <p>Mobile: ");
#nullable restore
#line 154 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                                  Write(Model.Member.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        </address>\r\n");
#nullable restore
#line 156 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p class=\"text-danger mx-auto\">Adres Qeyd Olunmayıb ~.~</p>\r\n");
#nullable restore
#line 160 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <!-- Single Tab Content End -->
                                            <!-- Single Tab ACCOUNT DETAILS Start -->
                                            <div");
            BeginWriteAttribute("class", " class=\"", 13133, "\"", 13248, 4);
            WriteAttributeValue("", 13141, "tab-pane", 13141, 8, true);
            WriteAttributeValue(" ", 13149, "fade", 13150, 5, true);
#nullable restore
#line 166 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
WriteAttributeValue(" ", 13154, (TempData["ProfileTab"]!=null &&TempData["ProfileTab"].ToString()=="Account")?"active":"", 13155, 92, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 13247, "", 13248, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" id=""account-info"" role=""tabpanel"">
                                                <div class=""myaccount-content"">
                                                    <h3>Account Details</h3>
                                                    <div class=""account-details-form"">
                                                        ");
#nullable restore
#line 170 "C:\Users\LENOVO\Desktop\p124_backend_project-elnurxo\ElnurJUAN-backProject\ElnurJUAN\ElnurJUAN\Views\Account\Profile.cshtml"
                                                   Write(Html.Partial("_MemberAccountUpdatePartialView", Model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- Single Tab Content End -->
                                        </div>
                                    </div> 
                                    <!-- My Account Tab Content End -->
                                </div>
                            </div> <!-- My Account Page End -->
                        </div>
                    </div>
                </div>
            </div>
         </div>
    </div>
            <!-- my account wrapper end -->
</main>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
