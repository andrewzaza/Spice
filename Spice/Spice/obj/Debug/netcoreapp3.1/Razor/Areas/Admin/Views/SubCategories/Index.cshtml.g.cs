#pragma checksum "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "107d680c2e4c0822d27832b6d5102778aab518ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SubCategories_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SubCategories/Index.cshtml")]
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
#line 1 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"107d680c2e4c0822d27832b6d5102778aab518ec", @"/Areas/Admin/Views/SubCategories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebcb12da3fb30dc708e46b6f878ff8da12ca1911", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SubCategories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SubCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_OperationsButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"whiteBackground \">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\">Sub Categories List</h2>\r\n        </div>\r\n\r\n        <div class=\"col-6 text-right\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "107d680c2e4c0822d27832b6d5102778aab518ec4220", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n");
#nullable restore
#line 21 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml"
         if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-danger\">No Sub Category ...</p> ");
#nullable restore
#line 23 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml"
                                               }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-striped border\">\r\n    <tr class=\"table-secondary\">\r\n        <th>\r\n            ");
#nullable restore
#line 29 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 32 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n\r\n\r\n        <th>\r\n\r\n        </th>\r\n    </tr>\r\n");
#nullable restore
#line 40 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 44 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 47 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"width:150px\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "107d680c2e4c0822d27832b6d5102778aab518ec7553", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 50 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.ID;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n</tr>                ");
#nullable restore
#line 52 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
#nullable restore
#line 53 "G:\courses\Spice\Spice\Spice\Spice\Areas\Admin\Views\SubCategories\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SubCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591