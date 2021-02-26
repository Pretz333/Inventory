#pragma checksum "C:\ASPNET\AgileProgramming\2021_agile_inventory\Inventory\Pages\Export.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8272f0bc0abc72b305caa61f28dd769671d4df5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Inventory.Pages.Pages_Export), @"mvc.1.0.razor-page", @"/Pages/Export.cshtml")]
namespace Inventory.Pages
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
#line 1 "C:\ASPNET\AgileProgramming\2021_agile_inventory\Inventory\Pages\_ViewImports.cshtml"
using Inventory;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8272f0bc0abc72b305caa61f28dd769671d4df5d", @"/Pages/Export.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc4c5ed31820425d5cf502ec8126d736b9edb9e9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Export : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\ASPNET\AgileProgramming\2021_agile_inventory\Inventory\Pages\Export.cshtml"
  
    ViewData["Title"] = "Export";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""tools"">
    <h2>Tools</h2>

    <div id=""toolModule"" onClick=""toolClick('import')"">
        <div id=""toolIcon"">
            <img src=""res/ic_import.png"">
        </div>
        <div id=""toolText"">
            Import from a CVS file
        </div>
    </div>

    <div id=""toolModule"" onClick=""toolClick('export')"">
        <div id=""toolIcon"">
            <img src=""res/ic_export.png"">
        </div>
        <div id=""toolText"">
            Export to a CVS file
        </div>
    </div>

    <div id=""toolModule"" onClick=""toolClick('export_pdf')"">
        <div id=""toolIcon"">
            <img src=""res/ic_export_pdf.png"">
        </div>
        <div id=""toolText"">
            Export to a PDF file
        </div>
    </div>

</section>


<!--	Simple javascript function to tell if an item in the list
view is clicked since each list view item IS NOT an href tag -->
<script type=""text/javascript"">

    // Clicks for the tool module
    function toolClick(toolName) {
  ");
            WriteLiteral(@"      switch (toolName) {

            case ""import"":
                    alert(""You clicked import"");
                break;

            case ""export"":
                    alert(""You clicked export"");
                break;

            case ""export_pdf"":
                    alert(""You clicked pdf export"");
                break;

        }

    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inventory.Pages.ExportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Inventory.Pages.ExportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Inventory.Pages.ExportModel>)PageContext?.ViewData;
        public Inventory.Pages.ExportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
