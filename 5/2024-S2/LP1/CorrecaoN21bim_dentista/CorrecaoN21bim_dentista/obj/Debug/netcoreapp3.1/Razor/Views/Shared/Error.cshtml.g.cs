#pragma checksum "C:\eduardo\LP1\CorrecaoN21bim_dentista\CorrecaoN21bim_dentista\Views\Shared\Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e7a08cdacb46c31b2025b5fbccd7c90fa081a37e2f73c6ca01ad8f5f71352613"
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
#line 1 "C:\eduardo\LP1\CorrecaoN21bim_dentista\CorrecaoN21bim_dentista\Views\_ViewImports.cshtml"
using CorrecaoN21bim_dentista;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\eduardo\LP1\CorrecaoN21bim_dentista\CorrecaoN21bim_dentista\Views\_ViewImports.cshtml"
using CorrecaoN21bim_dentista.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e7a08cdacb46c31b2025b5fbccd7c90fa081a37e2f73c6ca01ad8f5f71352613", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"14dcd79f592c57576dc4435e7f0c9e4d840aba466b4d45f207c7edc182daa542", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\eduardo\LP1\CorrecaoN21bim_dentista\CorrecaoN21bim_dentista\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n<h2 class=\"text-danger\">");
#nullable restore
#line 9 "C:\eduardo\LP1\CorrecaoN21bim_dentista\CorrecaoN21bim_dentista\Views\Shared\Error.cshtml"
                   Write(Model.Erro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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