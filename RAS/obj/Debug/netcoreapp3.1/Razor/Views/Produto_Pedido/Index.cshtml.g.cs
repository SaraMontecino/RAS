#pragma checksum "C:\Users\Usuario\Desktop\RAS-master\RAS\Views\Produto_Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ff78bbc6e9efa521c66acd183efe8eb1ead0a0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Pedido_Index), @"mvc.1.0.view", @"/Views/Produto_Pedido/Index.cshtml")]
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
#line 1 "C:\Users\Usuario\Desktop\RAS-master\RAS\Views\_ViewImports.cshtml"
using RAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\RAS-master\RAS\Views\_ViewImports.cshtml"
using RAS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff78bbc6e9efa521c66acd183efe8eb1ead0a0f", @"/Views/Produto_Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805ddc2e71c2f966614767bae78dd92d21819eaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Produto_Pedido>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br/>\r\n");
#nullable restore
#line 4 "C:\Users\Usuario\Desktop\RAS-master\RAS\Views\Produto_Pedido\Index.cshtml"
 if(@Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 6 "C:\Users\Usuario\Desktop\RAS-master\RAS\Views\Produto_Pedido\Index.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 7 "C:\Users\Usuario\Desktop\RAS-master\RAS\Views\Produto_Pedido\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 10 "C:\Users\Usuario\Desktop\RAS-master\RAS\Views\Produto_Pedido\Index.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <table class=\"table table-hover\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\Usuario\Desktop\RAS-master\RAS\Views\Produto_Pedido\Index.cshtml"
           Write(Model.Qtd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\Usuario\Desktop\RAS-master\RAS\Views\Produto_Pedido\Index.cshtml"
           Write(Model.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 319, "\"", 370, 2);
            WriteAttributeValue("", 326, "/Produto_Pedido/delete/", 326, 23, true);
#nullable restore
#line 16 "C:\Users\Usuario\Desktop\RAS-master\RAS\Views\Produto_Pedido\Index.cshtml"
WriteAttributeValue("", 349, Model.produto_pedido, 349, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a>\r\n                <a class=\"btn btn-sm btn-warning\" href=\"/Produto_Pedido/update\">Editar</a>\r\n            </td>\r\n\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 22 "C:\Users\Usuario\Desktop\RAS-master\RAS\Views\Produto_Pedido\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-primary\" href=\"/Produto_Pedido/create\">Adicionar</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Produto_Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591