#pragma checksum "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be35c6e048a90cec6517bef8741af0be4030dc7"
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
#line 1 "C:\Users\lenovo\OneDrive\Desktop\School\Views\_ViewImports.cshtml"
using School;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\OneDrive\Desktop\School\Views\_ViewImports.cshtml"
using School.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be35c6e048a90cec6517bef8741af0be4030dc7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    table {
        font-family: arial, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

    td,
    th {
        border: 1px solid #dddddd;
        text-align: left;
        padding: 8px;
    }

    tr:nth-child(even) {
        background-color: #dddddd;
    }
</style>
<div style=""margin-bottom:25px;"">
    <a href=""Home/Student"" class=""btn btn-primary"">AddStudent</a>
    <a href=""Home/Teacher"" class=""btn btn-primary"">AddTeacher</a>
</div>

<table>
    <h1>Student</h1>
    <tr>
        <th>Id</th>
        <th>FirstName</th>
        <th>LastName</th>
        <th>score1</th>
        <th>score2</th>
        <th>score3</th>
        <th>SumScore</th>
    </tr>
");
#nullable restore
#line 36 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
 foreach (var item in ViewBag.adstu)
{
    int a=@item.score1 + @item.score2 + @item.score3;
       @item.SumScore = a;
    
      

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n        <td>");
#nullable restore
#line 42 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 43 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 44 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 45 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.score1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 46 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.score2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 47 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.score3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 48 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.SumScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 1110, "\"", 1144, 2);
            WriteAttributeValue("", 1117, "Home/UpdateStudent/", 1117, 19, true);
#nullable restore
#line 49 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
WriteAttributeValue("", 1136, item.Id, 1136, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Update</a></td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 1201, "\"", 1230, 2);
            WriteAttributeValue("", 1208, "Home/DeleteSt/", 1208, 14, true);
#nullable restore
#line 50 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
WriteAttributeValue("", 1222, item.Id, 1222, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Delete</a></td>\r\n    </tr> \r\n");
#nullable restore
#line 52 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n</table>\r\n\r\n  <h1 style=\"margin-top:100px;\">Teacher</h1>\r\n<table>\r\n  \r\n    <tr>\r\n        <th>Id</th>\r\n        <th>FirstName</th>\r\n        <th>LastName</th>\r\n        <th>Age</th>\r\n        <th>RelatedEvidence</th>\r\n        <th>Lesson</th>\r\n    </tr>\r\n");
#nullable restore
#line 68 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
 foreach (var item in ViewBag.adteach)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\r\n        <td>");
#nullable restore
#line 71 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 72 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 73 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 74 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 75 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.RelatedEvidence);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 76 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
       Write(item.Lesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 1800, "\"", 1834, 2);
            WriteAttributeValue("", 1807, "Home/UpdateTeacher/", 1807, 19, true);
#nullable restore
#line 77 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
WriteAttributeValue("", 1826, item.Id, 1826, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Update</a></td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 1891, "\"", 1925, 2);
            WriteAttributeValue("", 1898, "Home/DeleteTeacher/", 1898, 19, true);
#nullable restore
#line 78 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
WriteAttributeValue("", 1917, item.Id, 1917, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Delete</a></td>\r\n    </tr>  \r\n");
#nullable restore
#line 80 "C:\Users\lenovo\OneDrive\Desktop\School\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n</table>");
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
