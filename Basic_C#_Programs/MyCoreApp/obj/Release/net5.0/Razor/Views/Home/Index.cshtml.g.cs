#pragma checksum "C:\Users\tanya\Desktop\Basic-C-Sharp-Projects\Basic_C#_Programs\MyCoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5805eeb79aa419af15ba8ba7544a7bb6971726ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\tanya\Desktop\Basic-C-Sharp-Projects\Basic_C#_Programs\MyCoreApp\Views\_ViewImports.cshtml"
using MyCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tanya\Desktop\Basic-C-Sharp-Projects\Basic_C#_Programs\MyCoreApp\Views\_ViewImports.cshtml"
using MyCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5805eeb79aa419af15ba8ba7544a7bb6971726ca", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4a070bca3d3e904ab916d71e6191f038736b754", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tanya\Desktop\Basic-C-Sharp-Projects\Basic_C#_Programs\MyCoreApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 6 "C:\Users\tanya\Desktop\Basic-C-Sharp-Projects\Basic_C#_Programs\MyCoreApp\Views\Home\Index.cshtml"
       var myMessage = "Hello World"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>Server Time</td>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\tanya\Desktop\Basic-C-Sharp-Projects\Basic_C#_Programs\MyCoreApp\Views\Home\Index.cshtml"
       Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <h1>The value of myMessage is: ");
#nullable restore
#line 11 "C:\Users\tanya\Desktop\Basic-C-Sharp-Projects\Basic_C#_Programs\MyCoreApp\Views\Home\Index.cshtml"
                              Write(myMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    <p>Hello ASP.NET Core!</p>\r\n</div>");
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
