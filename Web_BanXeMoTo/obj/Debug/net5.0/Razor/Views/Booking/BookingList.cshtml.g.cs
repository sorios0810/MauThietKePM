#pragma checksum "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42473d2b751bec6133e173ff26ae5e9b1b62d7a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_BookingList), @"mvc.1.0.view", @"/Views/Booking/BookingList.cshtml")]
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
#line 1 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\_ViewImports.cshtml"
using Web_BanXeMoTo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42473d2b751bec6133e173ff26ae5e9b1b62d7a7", @"/Views/Booking/BookingList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932e652f77ec83008959bfefacc459e116bf9f14", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Booking_BookingList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_BanXeMoTo.Controllers.ViewModelCus>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
   ViewData["Title"] = "BookingList";
                Layout = "~/Views/Shared/_LayoutCustomer.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--about-us start -->
<section id=""home"" class=""about-us"">
    <div class=""container"">
        <div class=""about-us-content"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""single-about-us"">
                        <div class=""about-us-txt"">
                            <h2>If passion is the path to success, persistence is your motorcycle</h2>
                        </div><!--/.about-us-txt-->
                    </div><!--/.single-about-us-->
                </div><!--/.col-->
                <div class=""col-sm-0"">
                    <div class=""single-about-us"">

                    </div><!--/.single-about-us-->
                </div><!--/.col-->
            </div><!--/.row-->
        </div><!--/.about-us-content-->
    </div><!--/.container-->

</section><!--/.about-us-->
<!--about-us end -->

<style>
    .layer {
        margin: 50px 0;
        border: 5px solid #00ffff;
        border-radius: 10px;
    }
</style>

<div class=""container"">
    <div ");
            WriteLiteral("class=\"layer\">\n        <table class=\"table\">\n            <thead>\n                <tr>\n                    <th>\n                        ");
#nullable restore
#line 46 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
                   Write(Html.DisplayNameFor(model => model.datLich.NgayDat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 49 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
                   Write(Html.DisplayNameFor(model => model.datLich.XacNhan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n");
            WriteLiteral("                    <th>\n                        ");
#nullable restore
#line 55 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
                   Write(Html.DisplayNameFor(model => model.mauXe.TenXe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 58 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
                   Write(Html.DisplayNameFor(model => model.datLich.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th></th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 64 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
                 foreach (var kh in Model.ListKhachHang)
                {
                    if (Context.Session.GetString("email") == kh.Email)
                    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
     foreach (var dl in Model.ListDatLich)
    {
        if (dl.Idkh == kh.Idkh)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 74 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
   Write(Html.DisplayFor(modelItem => dl.NgayDat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 77 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
   Write(Html.DisplayFor(modelItem => dl.XacNhan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n");
            WriteLiteral("    <td>\n");
#nullable restore
#line 83 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
         foreach (var mau in Model.ListMauXe)
        {
            if (dl.Idmau == mau.Idmau)
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
Write(Html.DisplayFor(modelItem => mau.TenXe));

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
                                        }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 92 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
   Write(Html.DisplayFor(modelItem => dl.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n");
#nullable restore
#line 95 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
         if (dl.XacNhan != true)
        {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42473d2b751bec6133e173ff26ae5e9b1b62d7a79902", async() => {
                WriteLiteral("Cập nhật ");
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
#line 97 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
                       WriteLiteral(dl.IddatLich);

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
            WriteLiteral(" <span> |</span> ");
#nullable restore
#line 97 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
                                                                                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42473d2b751bec6133e173ff26ae5e9b1b62d7a712422", async() => {
                WriteLiteral("Hủy lịch hẹn");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
                                 WriteLiteral(dl.IddatLich);

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
            WriteLiteral("\n    </td>\n\n</tr>");
#nullable restore
#line 101 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
     }

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "D:\Document\Mẫu thiết kế phần mềm\Báo cáo\BuiHoangLong_18DH110321\DA1_WEB\Web_BanXeMoTo\Views\Booking\BookingList.cshtml"
                     }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </tbody>\n        </table>\n\n        </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_BanXeMoTo.Controllers.ViewModelCus> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
