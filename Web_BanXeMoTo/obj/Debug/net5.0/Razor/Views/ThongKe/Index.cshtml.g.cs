#pragma checksum "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf680ddf06cc3db09c0354e82633d50f6151cf8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThongKe_Index), @"mvc.1.0.view", @"/Views/ThongKe/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\_ViewImports.cshtml"
using Web_BanXeMoTo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf680ddf06cc3db09c0354e82633d50f6151cf8e", @"/Views/ThongKe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932e652f77ec83008959bfefacc459e116bf9f14", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ThongKe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_BanXeMoTo.Controllers.HoaDonViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 6 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
   ViewData["Title"] = "Thống kê";

    Layout = "~/Views/Shared/_LayoutManager.cshtml";
    double Total = 0;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""app-main__inner"">
    <div class=""app-page-title"">
        <div class=""page-title-wrapper"">
            <div class=""page-title-heading"">
                <div>
                    <h2 style=""font-weight:500"">Thống kê doanh số</h2>
                </div>
            </div>
        </div>
    </div>
    <ul class=""body-tabs body-tabs-layout tabs-animated body-tabs-animated nav"">
        <li class=""nav-item"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf680ddf06cc3db09c0354e82633d50f6151cf8e6088", async() => {
                WriteLiteral("\n                <span>Thống kê doanh số</span>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </li>\n");
            WriteLiteral("    </ul>\n    <div class=\"row\">\n        <div class=\"col-md-12\">\n            <div class=\"main-card mb-3 card\">\n                <div class=\"card-body\">\n");
#nullable restore
#line 39 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                     using (Html.BeginForm("Index", "ThongKe", FormMethod.Get, new { @style = "float: right; width: 40%" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"month\" id=\"searchString\" name=\"searchString\" >\n                        <input type=\"submit\" value=\"Tìm kiếm\" class=\"btn btn-outline-info\" style=\"margin-bottom:5px\" />");
#nullable restore
#line 42 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <table class=\"table table-hover table-sm\">\n                        <thead>\n                            <tr>\n                                <th>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf680ddf06cc3db09c0354e82633d50f6151cf8e8736", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 47 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HoaDon.Idhd);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </th>\n\n                                <th>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf680ddf06cc3db09c0354e82633d50f6151cf8e10407", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 51 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HoaDon.IdkhNavigation.TenKh);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </th>\n\n                                <th>\n                                    <label class=\"control-label\">");
#nullable restore
#line 55 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                                            Write(Html.ActionLink("Ngày đặt", "Index", new { sortOrder = ViewBag.NameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                </th>
                                <th>
                                    <label class=""control-label"">Tổng tiền</label>
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 64 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                             foreach (var item in Model.HoaDons)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>\n                                        ");
#nullable restore
#line 68 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                   Write(item.Idhd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </td>\n\n                                    <td>\n");
#nullable restore
#line 72 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                         foreach (var kh in Model.ListKhachHang)
                                        {

                                            if (item.Idkh == kh.Idkh)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                           Write(kh.TenKh);

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                                         }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\n                                    <td>\n                                        ");
#nullable restore
#line 81 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                   Write(item.NgayDat);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </td>\n                                    <td>\n");
#nullable restore
#line 84 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                           double amount = 0;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                             foreach (var cthd in Model.ListChiTietHd)
                                            {

                                                if (item.Idhd == cthd.Idhd)
                                                {
                                                    amount += ((cthd.KhuyenMai == 0 ? ((Int64)cthd.GiaBan) : (((Int64)cthd.GiaBan) - ((Int64)cthd.GiaBan) * (Int64)cthd.KhuyenMai / 100)));
                                                }
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                       Write(string.Format("{0:N0}", ((double)@amount)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                                                                       
                                            Total += amount;
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ\n                                    </td>\n                                    <td>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf680ddf06cc3db09c0354e82633d50f6151cf8e17110", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                                                  WriteLiteral(item.Idhd);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 101 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td></td>\n                                <td></td>\n                                <td>Tổng doanh thu ");
#nullable restore
#line 105 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                                              Write(ViewBag.monthyear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</td>\n                                <td>\n                                    ");
#nullable restore
#line 107 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
                               Write(string.Format("{0:N0}", ((double)@Total)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ\n                                </td>\n                                <td>\n                                </td>\n                            </tr>\n                        </tbody>\n                    </table>\n                    ");
#nullable restore
#line 114 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\ThongKe\Index.cshtml"
               Write(Html.PagedListPager(Model.HoaDons, page => Url.Action("Index",
                                                     new { page, sortOrder = ViewBag.CurrentSort, currentFilter = ViewBag.CurrentFilter })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_BanXeMoTo.Controllers.HoaDonViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
