#pragma checksum "C:\Users\tgsv\OneDrive - GFT Technologies SE\Documents\Projetos\dotnet_project\PortifolioMVC\PortifolioMVC\Views\Home\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a99db31ce690e39d5db2f0e24d69be69dc2f4679"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lista), @"mvc.1.0.view", @"/Views/Home/Lista.cshtml")]
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
#line 1 "C:\Users\tgsv\OneDrive - GFT Technologies SE\Documents\Projetos\dotnet_project\PortifolioMVC\PortifolioMVC\Views\_ViewImports.cshtml"
using PortifolioMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tgsv\OneDrive - GFT Technologies SE\Documents\Projetos\dotnet_project\PortifolioMVC\PortifolioMVC\Views\_ViewImports.cshtml"
using PortifolioMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a99db31ce690e39d5db2f0e24d69be69dc2f4679", @"/Views/Home/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eddc1974bab832d1831a586dc3882494856207bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Aula>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tgsv\OneDrive - GFT Technologies SE\Documents\Projetos\dotnet_project\PortifolioMVC\PortifolioMVC\Views\Home\Lista.cshtml"
  
    ViewData["Title"] = "Aulas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div id=""wrapper"">
        
        <h1>Aulas do Portifolio</h1>
    
    </div>

    <section class=""cards"">
        <div class=""card"" id=""x4FdZd2-_uU"">
            <div class=""card_image-conteiner"">
                <img src=""https://img.youtube.com/vi/x4FdZd2-_uU/maxresdefault.jpg"" alt=""Video-aula"">
            </div>
            <div class=""card__content"">
                <a href=""https://youtu.be/x4FdZd2-_uU"" target=""_blank"">Visualizar aula 1</a>
            </div>
            <div class=""card__info"">
                <p>57 min</p>
                <p class=""card-price"">Free</p>
            </div>
        </div>

         <div class=""card"" id=""GykTLqODQuU"">
         <div class=""card_image-conteiner"">
            <img src=""https://img.youtube.com/vi/GykTLqODQuU/maxresdefault.jpg"" alt=""Video-aula"">
        </div>
        <div class=""card__content"">
            <a href=""https://youtu.be/GykTLqODQuU "" target=""_blank"">Visualizar aula 2</a>
        </div>
        <div class=""card__in");
            WriteLiteral(@"fo"">
            <p>57 min</p>
            <p class=""card-price"">Free</p>
        </div>
        </div>

         <div class=""card"" id=""HN1UjzRSdBk"">
         <div class=""card_image-conteiner"">
            <img src=""https://img.youtube.com/vi/HN1UjzRSdBk/maxresdefault.jpg"" alt=""Video-aula"">
        </div>
        <div class=""card__content"">
           <a href=""https://youtu.be/HN1UjzRSdBk"" target=""_blank"">Visualizar aula 3</a>
        </div>
        <div class=""card__info"">
            <p>57 min</p>
            <p class=""card-price"">Free</p>
        </div>
        </div>

");
#nullable restore
#line 53 "C:\Users\tgsv\OneDrive - GFT Technologies SE\Documents\Projetos\dotnet_project\PortifolioMVC\PortifolioMVC\Views\Home\Lista.cshtml"
         foreach (Aula aula in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" id=\"ghTrp1x_1As\">\r\n                <div class=\"card_image-conteiner\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1859, "\"", 1880, 1);
#nullable restore
#line 57 "C:\Users\tgsv\OneDrive - GFT Technologies SE\Documents\Projetos\dotnet_project\PortifolioMVC\PortifolioMVC\Views\Home\Lista.cshtml"
WriteAttributeValue("", 1865, aula.ImagemUrl, 1865, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Video-aula\">\r\n                </div>\r\n                <div class=\"card__content\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1992, "\"", 2013, 1);
#nullable restore
#line 60 "C:\Users\tgsv\OneDrive - GFT Technologies SE\Documents\Projetos\dotnet_project\PortifolioMVC\PortifolioMVC\Views\Home\Lista.cshtml"
WriteAttributeValue("", 1999, aula.VideoUrl, 1999, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Visualizar ");
#nullable restore
#line 60 "C:\Users\tgsv\OneDrive - GFT Technologies SE\Documents\Projetos\dotnet_project\PortifolioMVC\PortifolioMVC\Views\Home\Lista.cshtml"
                                                                   Write(aula.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                 </div>\r\n                <div class=\"card__info\">\r\n                    <p>");
#nullable restore
#line 63 "C:\Users\tgsv\OneDrive - GFT Technologies SE\Documents\Projetos\dotnet_project\PortifolioMVC\PortifolioMVC\Views\Home\Lista.cshtml"
                  Write(aula.Duracao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</p>\r\n                    <p class=\"card-price\">");
#nullable restore
#line 64 "C:\Users\tgsv\OneDrive - GFT Technologies SE\Documents\Projetos\dotnet_project\PortifolioMVC\PortifolioMVC\Views\Home\Lista.cshtml"
                                     Write(aula.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral(" R$</p>\r\n                </div>\r\n             </div>\r\n");
#nullable restore
#line 67 "C:\Users\tgsv\OneDrive - GFT Technologies SE\Documents\Projetos\dotnet_project\PortifolioMVC\PortifolioMVC\Views\Home\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n         \r\n\r\n        \r\n         \r\n        \r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Aula>> Html { get; private set; }
    }
}
#pragma warning restore 1591
