#pragma checksum "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\Booking\ShowAllBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb0edf43cecc2a23a887753ef4e90da0857819c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_ShowAllBookings), @"mvc.1.0.view", @"/Views/Booking/ShowAllBookings.cshtml")]
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
#line 1 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\_ViewImports.cshtml"
using MovieApp.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\_ViewImports.cshtml"
using MovieApp.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0edf43cecc2a23a887753ef4e90da0857819c5", @"/Views/Booking/ShowAllBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0118802ba0fd608ae39f8ac9dd7b4c9cd87ab004", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_ShowAllBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieApp.Entity.BookingModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\Booking\ShowAllBookings.cshtml"
  
    ViewData["Title"] = "ShowAllBookings";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>ShowAllBookings</h1>
<hr />

<hr />
<table class=""table table-bordered table-success"">
    <thead>
        <tr>
            <th>BookingId</th>
            <th>MovieId</th>
            <th>TheatreId</th>
            <th>ShowTime</th>
            <th>Date</th>
            <td>UserId</td>
            <th>Ticket Count</th>
");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\Booking\ShowAllBookings.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\Booking\ShowAllBookings.cshtml"
               Write(item.BookingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\Booking\ShowAllBookings.cshtml"
               Write(item.MovieId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\Booking\ShowAllBookings.cshtml"
               Write(item.TheatreId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\Booking\ShowAllBookings.cshtml"
               Write(item.MovieShowTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\Booking\ShowAllBookings.cshtml"
               Write(item.MovieDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\Booking\ShowAllBookings.cshtml"
               Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\Booking\ShowAllBookings.cshtml"
               Write(item.ticketCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "D:\IKS_Training\MovieCoreApplication\MovieApp.UI\Views\Booking\ShowAllBookings.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieApp.Entity.BookingModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
