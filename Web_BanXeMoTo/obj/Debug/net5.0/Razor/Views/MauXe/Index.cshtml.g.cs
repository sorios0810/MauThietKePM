#pragma checksum "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9f9f5591fad3b47147c7a17ed3f479cfd40d0e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MauXe_Index), @"mvc.1.0.view", @"/Views/MauXe/Index.cshtml")]
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
#line 5 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f9f5591fad3b47147c7a17ed3f479cfd40d0e4", @"/Views/MauXe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932e652f77ec83008959bfefacc459e116bf9f14", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MauXe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_BanXeMoTo.Controllers.ViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Duplicate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
   ViewData["Tittle"] = "Danh sách mẫu xe";
    Layout = "~/Views/Shared/_LayoutManager.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"
<div class=""app-main__inner"">
    <div class=""app-page-title"">
        <div class=""page-title-wrapper"">
            <div class=""page-title-heading"">
                <div>

                    Quản lý Mẫu xe

                </div>
            </div>
        </div>
    </div>
    <ul class=""body-tabs body-tabs-layout tabs-animated body-tabs-animated nav"">
        <li class=""nav-item"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f9f5591fad3b47147c7a17ed3f479cfd40d0e48273", async() => {
                WriteLiteral("\n                <span>Mẫu xe</span>\n            ");
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
            WriteLiteral("\n        </li>\n        <li class=\"nav-item\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f9f5591fad3b47147c7a17ed3f479cfd40d0e49614", async() => {
                WriteLiteral("\n                <span>Thêm mẫu xe</span>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n        </li>\n    </ul>\n    <div class=\"row\">\n        <div class=\"col-md-12\">\n            <div class=\"main-card mb-3 card\">\n                <div class=\"card-body\">\n");
#nullable restore
#line 38 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                     using (Html.BeginForm("Index", "MauXe", FormMethod.Get, new { @style = "float: right; width: 40%" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"text\" id=\"searchString\" name=\"searchString\" placeholder=\"Find by id or name\">\n                        <input type=\"submit\" value=\"Search\" class=\"btn btn-outline-info\" style=\"margin-bottom:5px\" />\n");
#nullable restore
#line 42 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <br />
                    <table class=""table table-hover table-sm"">
                        <thead>
                            <tr>
                                <th>
                                    <label class=""control-label"">");
#nullable restore
#line 48 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                                                            Write(Html.ActionLink("ID Mẫu", "Index", new { sortOrder = ViewBag.NameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                </th>
                                <th>
                                    <label class=""control-label"">Hình</label>
                                </th>
                                <th>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f9f5591fad3b47147c7a17ed3f479cfd40d0e412859", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 54 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.mauXe.TenXe);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </th>\n\n                                <th>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f9f5591fad3b47147c7a17ed3f479cfd40d0e414529", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 58 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.hang.TenHang);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </th>\n\n                                <th>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f9f5591fad3b47147c7a17ed3f479cfd40d0e416200", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 62 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.mauXe.GiaBan);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </th>\n                                <th class=\"text-center\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f9f5591fad3b47147c7a17ed3f479cfd40d0e417891", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 65 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.mauXe.BaoHanh);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </th>
                                <th class=""text-center"">
                                    <label class=""control-label"">Khuyến mãi</label>
                                </th>
                                <th class=""text-center"">
                                    <label class=""control-label"">Số lượng</label>
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 77 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                             foreach (var item in Model.ListMauXes)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 81 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                   Write(item.Idmau);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3428, "\"", 3458, 1);
#nullable restore
#line 84 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
WriteAttributeValue("", 3434, "/img/"+item.HinhAnh1, 3434, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"120\" height=\"90\" />\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 87 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                   Write(item.TenXe);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n");
#nullable restore
#line 90 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                         foreach (var hang in Model.ListHang)
                        {
                            if (hang.Idhang == item.Idhang)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                           Write(hang.TenHang);

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                                             
                                break;
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n\n                    <td>\n                        ");
#nullable restore
#line 101 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                    Write((int)@item.GiaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ\n                    </td>\n                    <td class=\"text-center\">\n                        ");
#nullable restore
#line 104 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                   Write(item.BaoHanh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"text-center\">\n");
#nullable restore
#line 107 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                         foreach (var khuyenmai in Model.ListKhuyenMai)
                        {
                            if (khuyenmai.Idkm == item.Idkm)
                            {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
   Write(khuyenmai.GiaTri);

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                          break;
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("%\n                    </td>\n                    <td class=\"text-center\">\n");
#nullable restore
#line 116 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                           int amount = 0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                             foreach (var mauxe in Model.ListXe)
                            {
                                if (mauxe.Idmau == item.Idmau)
                                {
                                    amount++;
                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                                       Write(amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f9f5591fad3b47147c7a17ed3f479cfd40d0e425470", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                                                  WriteLiteral(item.Idmau);

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
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f9f5591fad3b47147c7a17ed3f479cfd40d0e427775", async() => {
                WriteLiteral("Xóa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                                                 WriteLiteral(item.Idmau);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f9f5591fad3b47147c7a17ed3f479cfd40d0e430383", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                                               WriteLiteral(item.Idmau);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f9f5591fad3b47147c7a17ed3f479cfd40d0e432681", async() => {
                WriteLiteral("Nhân bản");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
                                                    WriteLiteral(item.Idmau);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 133 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n\n                    ");
#nullable restore
#line 137 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\MauXe\Index.cshtml"
               Write(Html.PagedListPager(Model.ListMauXes, page => Url.Action("Index",
                                                      new { page, sortOrder = ViewBag.CurrentSort, currentFilter = ViewBag.CurrentFilter })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_BanXeMoTo.Controllers.ViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
