#pragma checksum "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847b8210c0cb15154e5db6d5a844e19734d3c3c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consumidor_Index), @"mvc.1.0.view", @"/Views/Consumidor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847b8210c0cb15154e5db6d5a844e19734d3c3c1", @"/Views/Consumidor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7470f38c8ccaf92bcb7e391f3e2f7a3c9f5b2490", @"/Views/_ViewImports.cshtml")]
    public class Views_Consumidor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Consumidor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br/>\r\n");
#nullable restore
#line 4 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
 if(@Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 6 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 7 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-hover\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nome</th>\r\n            <th>Cpf</th>\r\n            <th>Sexo</th>\r\n            <th>Telefone</th>\r\n            <th>Idade</th>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
         foreach (var con in Model)
        {   

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
               Write(con.Pessoas_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
               Write(con.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
               Write(con.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
               Write(con.Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
               Write(con.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
               Write(con.FaixaEtaria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 709, "\"", 750, 2);
            WriteAttributeValue("", 716, "/consumidor/delete/", 716, 19, true);
#nullable restore
#line 29 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
WriteAttributeValue("", 735, con.Pessoas_id, 735, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a>\r\n                    <a class=\"btn btn-sm btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 817, "\"", 858, 2);
            WriteAttributeValue("", 824, "/consumidor/update/", 824, 19, true);
#nullable restore
#line 30 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
WriteAttributeValue("", 843, con.Pessoas_id, 843, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 36 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Consumidor\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-primary\" href=\"/consumidor/create\">Adicionar</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Consumidor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
