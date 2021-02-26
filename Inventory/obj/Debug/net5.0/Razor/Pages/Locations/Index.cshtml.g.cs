#pragma checksum "C:\ASPNET\AgileProgramming\2021_agile_inventory\Inventory\Pages\Locations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa2a3c0d354e27d54e73acf4498a80f3b44ef21f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Inventory.Pages.Locations.Pages_Locations_Index), @"mvc.1.0.razor-page", @"/Pages/Locations/Index.cshtml")]
namespace Inventory.Pages.Locations
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa2a3c0d354e27d54e73acf4498a80f3b44ef21f", @"/Pages/Locations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc4c5ed31820425d5cf502ec8126d736b9edb9e9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Locations_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\ASPNET\AgileProgramming\2021_agile_inventory\Inventory\Pages\Locations\Index.cshtml"
  
    ViewData["Title"] = "Locations";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Locations</h1>\r\n\r\n<section id=\"tools\">\r\n    <h2>Tools</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa2a3c0d354e27d54e73acf4498a80f3b44ef21f3555", async() => {
                WriteLiteral(@"
        <div id=""toolModule"" onclick=""toolClick('create')"">
            <div id=""toolIcon"">
                <img src=""res/ic_add.png"">
            </div>
            <div id=""toolText"">
                Create a new location
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <div id=""toolModule"" onClick=""toolClick('delete')"">
        <div id=""toolIcon"">
            <img src=""res/ic_remove.png"">
        </div>
        <div id=""toolText"">
            Delete an existing location
        </div>
    </div>

    <div id=""toolModule"" onClick=""toolClick('edit')"">
        <div id=""toolIcon"">
            <img src=""res/ic_edit.png"">
        </div>
        <div id=""toolText"">
            Edit an existing location
        </div>
    </div>
</section>





<section id=""listview"">
    <table>
        <thead>
            <tr>
                <th>
                    ");
#nullable restore
#line 51 "C:\ASPNET\AgileProgramming\2021_agile_inventory\Inventory\Pages\Locations\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Location[0].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 56 "C:\ASPNET\AgileProgramming\2021_agile_inventory\Inventory\Pages\Locations\Index.cshtml"
             foreach (var item in Model.Location)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=\"", 1313, "\"", 1338, 2);
            WriteAttributeValue("", 1318, "row-", 1318, 4, true);
#nullable restore
#line 58 "C:\ASPNET\AgileProgramming\2021_agile_inventory\Inventory\Pages\Locations\Index.cshtml"
WriteAttributeValue("", 1322, item.LocationID, 1322, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1339, "\"", 1376, 3);
            WriteAttributeValue("", 1349, "itemClick(", 1349, 10, true);
#nullable restore
#line 58 "C:\ASPNET\AgileProgramming\2021_agile_inventory\Inventory\Pages\Locations\Index.cshtml"
WriteAttributeValue("", 1359, item.LocationID, 1359, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1375, ")", 1375, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\ASPNET\AgileProgramming\2021_agile_inventory\Inventory\Pages\Locations\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 63 "C:\ASPNET\AgileProgramming\2021_agile_inventory\Inventory\Pages\Locations\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</section>







<script type=""text/javascript"">

    // Last clicked item in the list view.
    // Set to -1, because whole numbers exist
    // in the database
    var lastClickedID = -1;


    // Function that handles onClick events from the tools section
    function toolClick(toolName) {

        // Check to see if the last clicked item is valid
        if (lastClickedID > -1) {
            // Temp code to view button clicks
            switch (toolName) {
                case ""create"":
                    alert(""You clicked the create tool"");
                    break;

                case ""edit"":
                    // Take the user to the edit page
                    window.location = ""/Locations/Edit?id="" + lastClickedID;
                    break;

                case ""delete"":
                    // Take the user to the delete page
                    window.location = ""/Locations/Delete?id="" + lastClickedID;
                   ");
            WriteLiteral(@" break;
            }

        } else {
            alert(""Select an item from the table to preform this action."");
        }

    }


    // Function that handles onClick events for rows in the table (#listview)
    function itemClick(itemID) {

        // Remove the last selected item if anything was selected
        if (lastClickedID > -1) {
            document.querySelector(""#row-"" + lastClickedID).classList.remove(""selected"");
        }

        // Store the last clicked ID
        lastClickedID = itemID;

        // Highlight the selected item
        document.querySelector(""#row-"" + lastClickedID).classList.add(""selected"");

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inventory.Pages.Locations.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Inventory.Pages.Locations.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Inventory.Pages.Locations.IndexModel>)PageContext?.ViewData;
        public Inventory.Pages.Locations.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
