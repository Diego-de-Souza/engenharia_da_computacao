#pragma checksum "W:\Professores\Prof. Eduardo\2024-S2\LP1\CadAlunoMVC v9 - Imagem\CadAlunoMVC\Views\Cidade\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "248da3a0979b839f101d5c333612f62b2c4228aa92d360f4bfc87f5d700268a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cidade_Index), @"mvc.1.0.view", @"/Views/Cidade/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "W:\Professores\Prof. Eduardo\2024-S2\LP1\CadAlunoMVC v9 - Imagem\CadAlunoMVC\Views\_ViewImports.cshtml"
using CadAlunoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "W:\Professores\Prof. Eduardo\2024-S2\LP1\CadAlunoMVC v9 - Imagem\CadAlunoMVC\Views\_ViewImports.cshtml"
using CadAlunoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"248da3a0979b839f101d5c333612f62b2c4228aa92d360f4bfc87f5d700268a0", @"/Views/Cidade/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"920eddd16055001f106ef38d389e50d42a2834e714f4cae3e3c7f1420f883f57", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cidade_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CidadeViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "W:\Professores\Prof. Eduardo\2024-S2\LP1\CadAlunoMVC v9 - Imagem\CadAlunoMVC\Views\Cidade\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2>Listagem de Cidades</h2>

<a href=""/cidade/create"" class=""btn btn-info"">Novo Registro</a>
<br />

<table class=""table table-responsive table-striped"">
    <tr>
        <th>Ações</th>
        <th>Código</th>
        <th>Nome</th>        
        <th>Foto</th>
    </tr>
");
#nullable restore
#line 19 "W:\Professores\Prof. Eduardo\2024-S2\LP1\CadAlunoMVC v9 - Imagem\CadAlunoMVC\Views\Cidade\Index.cshtml"
     foreach (var c in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 461, "\"", 489, 2);
            WriteAttributeValue("", 468, "/cidade/edit?id=", 468, 16, true);
#nullable restore
#line 23 "W:\Professores\Prof. Eduardo\2024-S2\LP1\CadAlunoMVC v9 - Imagem\CadAlunoMVC\Views\Cidade\Index.cshtml"
WriteAttributeValue("", 484, c.Id, 484, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n                    <img src=\"/img/edit_48.png\" class=\"iconeAluno\" />\r\n                </a>\r\n                &nbsp;&nbsp;\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 635, "\"", 666, 3);
            WriteAttributeValue("", 642, "javascript:apagar(", 642, 18, true);
#nullable restore
#line 27 "W:\Professores\Prof. Eduardo\2024-S2\LP1\CadAlunoMVC v9 - Imagem\CadAlunoMVC\Views\Cidade\Index.cshtml"
WriteAttributeValue("", 660, c.Id, 660, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 665, ")", 665, 1, true);
            EndWriteAttribute();
            WriteLiteral(" >\r\n                    <img src=\"/img/delete_48.png\" class=\"iconeAluno\" />\r\n                </a>\r\n            </td>\r\n            <td>");
#nullable restore
#line 31 "W:\Professores\Prof. Eduardo\2024-S2\LP1\CadAlunoMVC v9 - Imagem\CadAlunoMVC\Views\Cidade\Index.cshtml"
           Write(c.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "W:\Professores\Prof. Eduardo\2024-S2\LP1\CadAlunoMVC v9 - Imagem\CadAlunoMVC\Views\Cidade\Index.cshtml"
           Write(c.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n            <td>\r\n                <img id=\"imgPreview\"");
            BeginWriteAttribute("src", " src=\"", 899, "\"", 945, 2);
            WriteAttributeValue("", 905, "data:image/jpeg;base64,", 905, 23, true);
#nullable restore
#line 34 "W:\Professores\Prof. Eduardo\2024-S2\LP1\CadAlunoMVC v9 - Imagem\CadAlunoMVC\Views\Cidade\Index.cshtml"
WriteAttributeValue("", 928, c.ImagemEmBase64, 928, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                      class=\"img-responsive\" width=\"50\">\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "W:\Professores\Prof. Eduardo\2024-S2\LP1\CadAlunoMVC v9 - Imagem\CadAlunoMVC\Views\Cidade\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n<script>\r\n    function apagar(id) {\r\n        if (confirm(\'Deseja apagar?\'))\r\n            location.href = \'/cidade/delete?id=\' + id;\r\n    }\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CidadeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
