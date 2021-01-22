#pragma checksum "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6d69667f37b2f66034c9c39afff67f8c5c22253"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StockOut_Index), @"mvc.1.0.view", @"/Views/StockOut/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6d69667f37b2f66034c9c39afff67f8c5c22253", @"/Views/StockOut/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2a01ef9c207269328f4a53b55d245c5c49efef", @"/Views/_ViewImports.cshtml")]
    public class Views_StockOut_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PTum.Models.Tb_stock_out>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
  
    ViewData["Title"] = "Stock out";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
tr.group, tr.group:hover {
    background-color: #FFCDD2 !important;
}
</style>

<div class=""card"">
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-md-3 col-sm-6"">
                <div class=""form-group"">
                    <label>Date range:</label>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">
                                <i class=""far fa-calendar-alt""></i>
                            </span>
                        </div>
                        <input type=""text"" class=""form-control float-right"" id=""reservation"">
                    </div><!-- /.input group -->
                </div>  
            </div>
            <div class=""col-md-3 col-sm-6"">
            <!-- Date and time range -->
                <div class=""form-group"">
                    <label>Date range button:</label>
                    <div class=""inpu");
            WriteLiteral(@"t-group"">
                        <button type=""button"" class=""btn btn-default float-right"" id=""daterange-btn"">
                            <i class=""far fa-calendar-alt""></i> Choose range
                            <i class=""fas fa-caret-down""></i>
                        </button>
                    </div>
                </div><!-- /.form group --> 
            </div>
        </div>
    </div>
</div>

<div class=""card"">
    <div class=""card-body"">
        <table class=""table table-sm table-bordered"" id=""stock-out"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 50 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.pay_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prd_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prd_outqty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prd_outremark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prd_garron_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prd_borrow_status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.out_datetime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.out_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 76 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.pay_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.prd_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.prd_outqty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 89 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
                 if (item.prd_outremark!="") 
                { 
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.prd_outremark));

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
                                                                     
                }
                else
                { 
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
               Write(string.Format("-"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
                                       ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 100 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
                 if (item.prd_garron_no!="") 
                { 
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.prd_garron_no));

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
                                                                     
                }
                else
                { 
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
               Write(string.Format("-"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
                                       ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td class=\"text-center\">\r\n");
#nullable restore
#line 110 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
                 if (item.prd_borrow_status) 
                { 
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
               Write(string.Format("Y"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
                                       ;
                }
                else
                { 
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
               Write(string.Format("-"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
                                       ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 120 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.out_datetime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 123 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.out_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 126 "C:\Users\014496\Documents\Visual Studio 2017\Projects\PTum\Views\StockOut\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script type=""text/babel"">
    var groupColumn = 0;
    var table = $(""#stock-out"").DataTable({
        ""responsive"": true, 
        ""lengthChange"": false, 
        ""lengthMenu"": [[10, 25, 50, -1], [10, 25, 50, ""All""]],
        ""autoWidth"": false,
        ""columnDefs"": [
            { ""visible"": false, ""targets"": groupColumn }
        ],
        ""order"": [[ groupColumn, 'desc' ]],
        ""drawCallback"": function ( settings ) {
            var api = this.api();
            var rows = api.rows( {page:'current'} ).nodes();
            var last=null;
            api.column(groupColumn, {page:'current'} ).data().each( function ( group, i ) {
                if ( last !== group ) {
                    $(rows).eq( i ).before(
                        '<tr class=""group""><td colspan=""7"" class=""font-weight-bold"">'+group+'</td></tr>'
                    );
                    last = group;
                }
            } );
        },
        ""buttons"": [
            {
                extend:");
                WriteLiteral(@" ""pageLength"",
                className: ""btn-sm"",
            },
            {
                extend: ""excelHtml5"",
                text: '<i class=""far fa-file-excel""></i> Report',
                className: ""btn-sm btn-outline-danger"",
                init: function(api, node, config) {
                    $(node).removeClass('btn-secondary')
                },
                autoFilter: true,
                customize: function ( xlsx ){
                    var sheet = xlsx.xl.worksheets['sheet1.xml'];
                    $('row c[r*=""3""]', sheet).attr( 's', '25' );
                    console.log($('row c', sheet))
                }
");
                WriteLiteral(@"            },
        ]
    })
    
    table.buttons().container().appendTo('#stock-out_wrapper .col-md-6:eq(0)')

    $('#stock-out tbody').on( 'click', 'tr.group', function () {
        console.log(table)
        var currentOrder = table.order()[0];
        if ( currentOrder[0] === groupColumn && currentOrder[1] === 'asc' ) {
            table.order( [ groupColumn, 'desc' ] ).draw();
        }
        else {
            table.order( [ groupColumn, 'asc' ] ).draw();
        }
    });

    var dates = table.column(6).data().unique().sort();
    var minDate = dates[0];
    var maxDate = dates[dates.length-1];

    var datepickers = [{
        id: 'startdate',
        coid: 'enddate',
        value: new Date(minDate).toISOString(),
        limiter: 'minDate'
    }, 
    {
        id: 'enddate',
        coid: 'startdate',
        value: new Date(maxDate).toISOString(),
        limiter: 'maxDate'
    }];
    

    $('#reservation').daterangepicker({
            opens: 'left',");
                WriteLiteral(@"
            ""startDate"": minDate,
            ""endDate"": maxDate,
        }, 
        function(start, end, label) {
            console.log(""A new date selection was made: "" + start.format('YYYY-MM-DD') + ' to ' + end.format('YYYY-MM-DD'));
            datepickers[0].value = new Date(start).toISOString(); 
            datepickers[1].value = new Date(end).toISOString(); 
            table.draw();
        }
    )

    //External search function
    $.fn.DataTable.ext.search.push((settings, row) => {
        var rowDate = new Date(row[6]).toISOString();
        return (rowDate >= datepickers[0].value || datepickers[0].value == null) && (rowDate <= datepickers[1].value || datepickers[1].value == null);
    });

    //Date range as a button
    $('#daterange-btn').daterangepicker(
      {
        ranges   : {
          'Today'       : [moment(), moment()],
          'Yesterday'   : [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
          'Last 7 Days' : [moment().subtract(6,");
                WriteLiteral(@" 'days'), moment()],
          'Last 30 Days': [moment().subtract(29, 'days'), moment()],
          'This Month'  : [moment().startOf('month'), moment().endOf('month')],
          'Last Month'  : [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
        },
        startDate: moment().subtract(29, 'days'),
        endDate  : moment()
      },
      function (start, end) {
            console.log(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'))
            datepickers[0].value = new Date(start).toISOString(); 
            datepickers[1].value = new Date(end).toISOString(); 
            table.draw();
      }
    )  


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PTum.Models.Tb_stock_out>> Html { get; private set; }
    }
}
#pragma warning restore 1591
