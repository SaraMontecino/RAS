#pragma checksum "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cbb4a6d54d9dde1b97c6b6573a90b69b48ed506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
#line 1 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\_ViewImports.cshtml"
using RAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\_ViewImports.cshtml"
using RAS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cbb4a6d54d9dde1b97c6b6573a90b69b48ed506", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7470f38c8ccaf92bcb7e391f3e2f7a3c9f5b2490", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br/>\r\n");
#nullable restore
#line 4 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
 if(@Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 6 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 7 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-hover\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Tipo</th>\r\n            <th>Descrição</th>\r\n            <th>Estoque</th>\r\n            <th>Preço</th>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
         foreach (var p in Model)
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
               Write(p.Produtos_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
               Write(p.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
               Write(p.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
               Write(p.Estoque);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
               Write(p.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 634, "\"", 671, 2);
            WriteAttributeValue("", 641, "/produto/delete/", 641, 16, true);
#nullable restore
#line 27 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
WriteAttributeValue("", 657, p.Produtos_id, 657, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a>\r\n                    <a class=\"btn btn-sm btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 738, "\"", 775, 2);
            WriteAttributeValue("", 745, "/produto/update/", 745, 16, true);
#nullable restore
#line 28 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
WriteAttributeValue("", 761, p.Produtos_id, 761, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 34 "C:\Users\guilh\Desktop\Facul\ras\RAS\RAS\Views\Produto\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
