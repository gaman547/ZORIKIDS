#pragma checksum "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05f747923a46cd0e8767cb9fbd12b73d4bbb4203"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parinte_Index), @"mvc.1.0.view", @"/Views/Parinte/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parinte/Index.cshtml", typeof(AspNetCore.Views_Parinte_Index))]
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
#line 1 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\_ViewImports.cshtml"
using ZORI_KIDS_KG;

#line default
#line hidden
#line 2 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\_ViewImports.cshtml"
using ZORI_KIDS_KG.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05f747923a46cd0e8767cb9fbd12b73d4bbb4203", @"/Views/Parinte/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fe636adca25ead6fb63ace546151b5290011d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Parinte_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZORI_KIDS_KG.Models.Parinte>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";

#line default
#line hidden
            BeginContext(148, 154, true);
            WriteLiteral("\r\n<section class=\"content-header\">\r\n    <h1>\r\n        Parinti\r\n        <small>Date personale</small>\r\n    </h1>\r\n    <ol class=\"breadcrumb\">\r\n        <li>");
            EndContext();
            BeginContext(302, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f747923a46cd0e8767cb9fbd12b73d4bbb42034311", async() => {
                BeginContext(351, 36, true);
                WriteLiteral("<i class=\"fa fa-dashboard\"></i> Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(391, 1269, true);
            WriteLiteral(@"</li>        
        <li class=""active"">Parinti</li>
    </ol>
</section>

<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">

            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Tabel cu informatii personale ale parintiilor</h3>
                </div>

                <div class=""box-body"">
                    <table id=""example1"" class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Email</th>
                                <th>Pass</th>
                                <th>CNP</th>
                                <th>Nume</th>
                                <th>Prenume</th>
                                <th>Varsta</th>
                                <th>Sex</th>
                                <th>Telefon</th>                                
                                <th>Localitate</th>
    ");
            WriteLiteral("                            <th>Judet</th>\r\n                                <th>Adresa</th>\r\n                                <th>Functii</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 47 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1749, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1828, 40, false);
#line 50 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1916, 43, false);
#line 51 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1959, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2007, 38, false);
#line 52 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Cnp));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2093, 39, false);
#line 53 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Nume));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2180, 42, false);
#line 54 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Prenume));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2270, 41, false);
#line 55 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Varsta));

#line default
#line hidden
            EndContext();
            BeginContext(2311, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2359, 38, false);
#line 56 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(2397, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2445, 42, false);
#line 57 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Telefon));

#line default
#line hidden
            EndContext();
            BeginContext(2487, 83, true);
            WriteLiteral("</td>                                    \r\n                                    <td>");
            EndContext();
            BeginContext(2571, 45, false);
#line 58 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Localitate));

#line default
#line hidden
            EndContext();
            BeginContext(2616, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2664, 40, false);
#line 59 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Judet));

#line default
#line hidden
            EndContext();
            BeginContext(2704, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2752, 41, false);
#line 60 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Adresa));

#line default
#line hidden
            EndContext();
            BeginContext(2793, 49, true);
            WriteLiteral("</td>\r\n                                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2842, "\"", 2872, 2);
            WriteAttributeValue("", 2849, "Parinte/Update/", 2849, 15, true);
#line 61 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
WriteAttributeValue("", 2864, item.Id, 2864, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2873, 24, true);
            WriteLiteral(">Update</a> | <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2897, "\"", 2925, 3);
            WriteAttributeValue("", 2907, "Delete(\'", 2907, 8, true);
#line 61 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
WriteAttributeValue("", 2915, item.Id, 2915, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2923, "\')", 2923, 2, true);
            EndWriteAttribute();
            BeginContext(2926, 57, true);
            WriteLiteral(">Delete</a></td>\r\n                                </tr>\r\n");
            EndContext();
#line 63 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3014, 1541, true);
            WriteLiteral(@"                        </tbody>
                        <tfoot>
                            <tr>
                                <th>Email</th>
                                <th>Pass</th>
                                <th>CNP</th>
                                <th>Nume</th>
                                <th>Prenume</th>
                                <th>Varsta</th>
                                <th>Sex</th>
                                <th>Telefon</th>                                
                                <th>Localitate</th>
                                <th>Judet</th>
                                <th>Adresa</th>
                                <th>Functii</th>
                            </tr>
                        </tfoot>
                    </table>
                </div>                
            </div>            
        </div>        
    </div>    
</section>

<script>
    $(function () {
        $('#example1').DataTable()
        $('#exam");
            WriteLiteral(@"ple2').DataTable({
            'paging': true,
            'lengthChange': false,
            'searching': false,
            'ordering': true,
            'info': true,
            'autoWidth': false
        })
    })

    $(function () {
        $('#example1').DataTable();
    });
    function Delete(id){
        var txt;
        var r = confirm(""Esti sigur ca vrei sa stergi?"");
        if (r == true) {

            $.ajax(
            {
                type: ""POST"",
                url: '");
            EndContext();
            BeginContext(4556, 31, false);
#line 112 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Parinte\Index.cshtml"
                 Write(Url.Action("Delete", "Parinte"));

#line default
#line hidden
            EndContext();
            BeginContext(4587, 564, true);
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl = ""/Parinte"";
                        window.location.reload(true);
                    }
                    else {
                        alert(""Exista o problema!"");
                    }
                }
            });
        }
    }
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZORI_KIDS_KG.Models.Parinte>> Html { get; private set; }
    }
}
#pragma warning restore 1591
