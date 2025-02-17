#pragma checksum "H:\VM\PCs\XP32\vmCenterData\api_nodejs_example-master\RptNET\Views\Home\Viewer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4af97bcc173e043f30bb24f9ec5d048c9959f203"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Viewer), @"mvc.1.0.view", @"/Views/Home/Viewer.cshtml")]
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
#line 1 "H:\VM\PCs\XP32\vmCenterData\api_nodejs_example-master\RptNET\Views\_ViewImports.cshtml"
using RptNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\VM\PCs\XP32\vmCenterData\api_nodejs_example-master\RptNET\Views\_ViewImports.cshtml"
using DevExpress.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "H:\VM\PCs\XP32\vmCenterData\api_nodejs_example-master\RptNET\Views\Home\Viewer.cshtml"
using RptNET.PredefinedReports;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af97bcc173e043f30bb24f9ec5d048c9959f203", @"/Views/Home/Viewer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21ac8487105ba198e446acac8514abad1305765b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Viewer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\VM\PCs\XP32\vmCenterData\api_nodejs_example-master\RptNET\Views\Home\Viewer.cshtml"
  
    var viewerRender = Html.DevExpress().WebDocumentViewer("DocumentViewer")
        .Height("1000px")
        .Bind("TestReport");
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\VM\PCs\XP32\vmCenterData\api_nodejs_example-master\RptNET\Views\Home\Viewer.cshtml"
Write(viewerRender.RenderHtml());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <link href=""https://hrm.dnd.vn/src/rptcore/css/dx-reporting-skeleton-screen.css"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""https://hrm.dnd.vn/src/rptcore/css/viewer.part.bundle.css"" />
    <script src=""https://hrm.dnd.vn/src/rptcore/js/reporting.thirdparty.bundle.js""></script>
    <script src=""https://hrm.dnd.vn/src/rptcore/js/viewer.part.bundle.js""></script>
    <script src=""https://hrm.dnd.vn/src/rptcore/js/testhitdebug.js""></script>
    ");
#nullable restore
#line 16 "H:\VM\PCs\XP32\vmCenterData\api_nodejs_example-master\RptNET\Views\Home\Viewer.cshtml"
Write(viewerRender.RenderScripts());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
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
