#pragma checksum "C:\Users\082220042\Documents\engenharia_da_computacao\5\2024-S2\LP1\Currilo\Correcao_Currilo_N2_1bim\Views\Shared\Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4ca86c98a54711513f8ae4dbde1ad35a9df9c33c43df8a335daaf0d4a4477d81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\082220042\Documents\engenharia_da_computacao\5\2024-S2\LP1\Currilo\Correcao_Currilo_N2_1bim\Views\_ViewImports.cshtml"
using Correcao_Currilo_N2_1bim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\082220042\Documents\engenharia_da_computacao\5\2024-S2\LP1\Currilo\Correcao_Currilo_N2_1bim\Views\_ViewImports.cshtml"
using Correcao_Currilo_N2_1bim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4ca86c98a54711513f8ae4dbde1ad35a9df9c33c43df8a335daaf0d4a4477d81", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c19af2d96c7818431705ef8bdb157a7e271360b28c42ad8cb80ee36783ca7e0f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\082220042\Documents\engenharia_da_computacao\5\2024-S2\LP1\Currilo\Correcao_Currilo_N2_1bim\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Ocorreu um erro:</h1>\r\n<h3 class=\"text-danger\">");
#nullable restore
#line 7 "C:\Users\082220042\Documents\engenharia_da_computacao\5\2024-S2\LP1\Currilo\Correcao_Currilo_N2_1bim\Views\Shared\Error.cshtml"
                   Write(Model.Erro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
