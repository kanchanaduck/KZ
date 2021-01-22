#pragma checksum "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f75dd93c72b1cddcf85abbbbe8bda8a2d63fc8db"
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
#line 1 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\_ViewImports.cshtml"
using Ptum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\_ViewImports.cshtml"
using Ptum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75dd93c72b1cddcf85abbbbe8bda8a2d63fc8db", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2a01ef9c207269328f4a53b55d245c5c49efef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PTum.Models.Balance_V>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/products/no-photo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title""><i class=""fas fa-file-alt""></i> Balance</h3>
    </div>
    <div class=""card-body"">
        <table class=""table table-sm table-bordered"" id=""qty-table"">
            <thead>
                <tr>
                    <th class=""text-center"">No</th>
                    <th class=""text-center"">Image</th>
                    <th class=""text-center"">Code</th>
                    <th class=""text-center"">Name</th>
                    <th class=""text-center"">Balance</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml"
                 foreach (var item in Model) {
                    var img = $@"\\cptfile01\Dept\2230\91_ICD_Manual\014496\KAIZEN\assets\pictureall\{item.prd_img}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 26 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml"
                                       Write(item.rownum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">\r\n");
#nullable restore
#line 28 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml"
                         if(item.prd_img==null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f75dd93c72b1cddcf85abbbbe8bda8a2d63fc8db6074", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml"
                        }
                        else{  

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 1250, "\"", 1273, 1);
#nullable restore
#line 32 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml"
WriteAttributeValue("", 1256, Url.Content(img), 1256, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\"/>\r\n");
#nullable restore
#line 33 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml"
                   Write(item.prd_code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml"
                   Write(item.prd_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">");
#nullable restore
#line 37 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml"
                                      Write(item.total_bl.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script>
   

    $(""#qty-table"").DataTable({
        ""responsive"": true, 
        ""lengthChange"": false, 
        ""autoWidth"": false,
        ""buttons"": [
            {
                extend: ""excelHtml5"",
                text: '<i class=""far fa-file-excel""></i> Export excel',
                className: ""btn-sm btn-outline-secondary"",
                init: function(api, node, config) {
                    $(node).removeClass('btn-secondary')
                },
                autoFilter: true,
                sheetName: 'Product',
                exportOptions: {
                    columns: [0,2,3,4]
                }
            },
        ]
    }).buttons().container().appendTo('#qty-table_wrapper .col-md-6:eq(0)')
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PTum.Models.Balance_V>> Html { get; private set; }
    }
}
#pragma warning restore 1591
