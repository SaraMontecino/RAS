#pragma checksum "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1dbb860344c3e42df6b518956074679b24c20ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Colaborador_Index), @"mvc.1.0.view", @"/Views/Colaborador/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1dbb860344c3e42df6b518956074679b24c20ce", @"/Views/Colaborador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805ddc2e71c2f966614767bae78dd92d21819eaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Colaborador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Colaborador>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br/>\r\n");
#nullable restore
#line 4 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
 if(@Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 6 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 7 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-hover\">\r\n");
#nullable restore
#line 11 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
         foreach (var c in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 14 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
               Write(c.Pessoas_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 15 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
               Write(c.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
               Write(c.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
               Write(c.DataNascimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
               Write(c.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
               Write(c.Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
               Write(c.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
               Write(c.Remuneracao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
               Write(c.Comissao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
               Write(c.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
               Write(c.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 687, "\"", 727, 2);
            WriteAttributeValue("", 694, "/colaborador/delete/", 694, 20, true);
#nullable restore
#line 26 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
WriteAttributeValue("", 714, c.Pessoas_id, 714, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a>\r\n                    <a class=\"btn btn-sm btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 794, "\"", 834, 2);
            WriteAttributeValue("", 801, "/colaborador/update/", 801, 20, true);
#nullable restore
#line 27 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
WriteAttributeValue("", 821, c.Pessoas_id, 821, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 33 "C:\Users\sara_\Desktop\FATEC\4° Semeste\INTER\RAS\RAS\Views\Colaborador\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-primary\" href=\"/colaborador/create\">Adicionar</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Colaborador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
