#pragma checksum "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d77ac4d61c037ec07b56a2f1b30c38ae9bfe48f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Index), @"mvc.1.0.view", @"/Views/Roles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/Index.cshtml", typeof(AspNetCore.Views_Roles_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d77ac4d61c037ec07b56a2f1b30c38ae9bfe48f3", @"/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fe636adca25ead6fb63ace546151b5290011d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZORI_KIDS_KG.Models.Roles>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Roles\Index.cshtml"
  
    ViewData["Title"] = "Roles";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";

#line default
#line hidden
            BeginContext(146, 861, true);
            WriteLiteral(@"
<section class=""content-header"">
    <h1>
        Roluri admin
    </h1>
</section>
<section class=""content container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Tabelul cu roluri de administrare</h3>
                </div>                
                <div class=""box-body"">
                    <table id=""example2"" class=""table table-bordered table-hover"">
                        <thead>
                            <tr>                                
                                <th>Title</th>
                                <th>Description</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 30 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Roles\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1096, 140, true);
            WriteLiteral("                            <tr>                                \r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1237, 40, false);
#line 34 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Roles\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1393, 46, false);
#line 37 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Roles\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 117, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1556, "\"", 1583, 2);
            WriteAttributeValue("", 1563, "/Roles/Edit/", 1563, 12, true);
#line 40 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Roles\Index.cshtml"
WriteAttributeValue("", 1575, item.Id, 1575, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1584, 61, true);
            WriteLiteral(">Update</a> |\r\n                                    <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1645, "\"", 1673, 3);
            WriteAttributeValue("", 1655, "Delete(\'", 1655, 8, true);
#line 41 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Roles\Index.cshtml"
WriteAttributeValue("", 1663, item.Id, 1663, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1671, "\')", 1671, 2, true);
            EndWriteAttribute();
            BeginContext(1674, 87, true);
            WriteLiteral(">Delete</a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 44 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Roles\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1792, 742, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</section>

<script>
    $(function () {
        $('#example1').DataTable()
        $('#example2').DataTable({
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
        var r = confirm(""Sigur vrei sa stergi?"");
        if (r == true) {

            $.ajax(
            {
                type: ""POST"",
                url: '");
            EndContext();
            BeginContext(2535, 29, false);
#line 77 "D:\FAST TRACK IT PROIECT\ZORI_KIDS_KG\ZORI_KIDS_KG\Views\Roles\Index.cshtml"
                 Write(Url.Action("Delete", "Roles"));

#line default
#line hidden
            EndContext();
            BeginContext(2564, 564, true);
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl = ""/Roles"";
                        window.location.reload(true);
                    }
                    else {
                        alert(""Exista o problema!"");
                    }
                }
            });
        }
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZORI_KIDS_KG.Models.Roles>> Html { get; private set; }
    }
}
#pragma warning restore 1591