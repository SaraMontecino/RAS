#pragma checksum "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0adccd713cc36f60ab8d26ce213761f9c25575e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
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
#line 1 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\_ViewImports.cshtml"
using RAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\_ViewImports.cshtml"
using RAS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0adccd713cc36f60ab8d26ce213761f9c25575e1", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805ddc2e71c2f966614767bae78dd92d21819eaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pedido>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br/>\r\n");
#nullable restore
#line 4 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Pedido\Index.cshtml"
 if(@Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 6 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Pedido\Index.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 7 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Pedido\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 10 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Pedido\Index.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <table class=\"table table-hover\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Pedido\Index.cshtml"
           Write(Model.Pedidos_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Pedido\Index.cshtml"
           Write(Model.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Pedido\Index.cshtml"
           Write(Model.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Pedido\Index.cshtml"
           Write(Model.Desconto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 390, "\"", 429, 2);
            WriteAttributeValue("", 397, "/pedido/delete/", 397, 15, true);
#nullable restore
#line 18 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 412, Model.Pedidos_id, 412, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a>\r\n                <a class=\"btn btn-sm btn-warning\" href=\"/pedido/update\">Editar</a>\r\n            </td>\r\n\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 24 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Pedido\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-primary\" href=\"/produto/create\">Adicionar</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
