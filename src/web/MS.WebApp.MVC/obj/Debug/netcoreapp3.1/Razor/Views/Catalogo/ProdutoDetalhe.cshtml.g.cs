#pragma checksum "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\Catalogo\ProdutoDetalhe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23cbbb5cc7704ab875ec3969f2bbbb288c925368"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogo_ProdutoDetalhe), @"mvc.1.0.view", @"/Views/Catalogo/ProdutoDetalhe.cshtml")]
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
#line 1 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\_ViewImports.cshtml"
using MS.WebApp.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\_ViewImports.cshtml"
using MS.WebApp.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\Catalogo\ProdutoDetalhe.cshtml"
using MS.WebApp.MVC.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23cbbb5cc7704ab875ec3969f2bbbb288c925368", @"/Views/Catalogo/ProdutoDetalhe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51c9163f2783c57b404b331654f1c8083b36069e", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogo_ProdutoDetalhe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MS.WebApp.MVC.Models.ProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\Catalogo\ProdutoDetalhe.cshtml"
  
    ViewData["Title"] = Model.Nome;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""section-content padding-y bg container"">
    <div class=""card"">
        <div class=""row no-gutters"">
            <aside class=""col-md-6"">
                <article class=""gallery-wrap"">
                    <div class=""img-big-wrap"" style=""text-align: center"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23cbbb5cc7704ab875ec3969f2bbbb288c9253686497", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 438, "~/images/produtos/", 438, 18, true);
#nullable restore
#line 12 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\Catalogo\ProdutoDetalhe.cshtml"
AddHtmlAttributeValue("", 456, Model.Imagem, 456, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\Catalogo\ProdutoDetalhe.cshtml"
AddHtmlAttributeValue("", 476, Model.Nome, 476, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </article>\r\n            </aside>\r\n            <main class=\"col-md-6 border-left\">\r\n                <article class=\"content-body\">\r\n\r\n                    <h2 class=\"title\">");
#nullable restore
#line 19 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\Catalogo\ProdutoDetalhe.cshtml"
                                 Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                    <div class=""rating-wrap my-3"">
                        <ul class=""rating-stars"">
                            <li style=""width: 80%"" class=""stars-active"">
                                <i class=""fa fa-star""></i> <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i> <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                            </li>
                            <li>
                                <i class=""fa fa-star""></i> <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i> <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                            </li>
                        </ul>
                        <small class=""label-rating text-muted"">132 avaliações</small>
                        <small class=""label-rating text-success""> <i class=""fa fa-clipboard-check""></i> 154 peças vendidas</small>
                ");
            WriteLiteral("    </div>\r\n\r\n                    <div class=\"mb-3\">\r\n                        <var class=\"price h4\">");
#nullable restore
#line 39 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\Catalogo\ProdutoDetalhe.cshtml"
                                         Write(this.FormatoMoeda(Model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</var>\r\n                    </div>\r\n\r\n                    <h5>");
#nullable restore
#line 42 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\Catalogo\ProdutoDetalhe.cshtml"
                   Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5><br />\r\n                    <p> ");
#nullable restore
#line 43 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\Catalogo\ProdutoDetalhe.cshtml"
                   Write(this.MensagemEstoque(Model.QuantidadeEstoque));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    <hr>\r\n\r\n");
#nullable restore
#line 47 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\Catalogo\ProdutoDetalhe.cshtml"
                      
                        if (Model.QuantidadeEstoque > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""form-row"">
                                <div class=""form-group col-md flex-grow-0"">
                                    <label>Quantidade</label>
                                    <div class=""input-group input-spinner"">
                                        <select class=""form-control"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23cbbb5cc7704ab875ec3969f2bbbb288c92536812103", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23cbbb5cc7704ab875ec3969f2bbbb288c92536813302", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23cbbb5cc7704ab875ec3969f2bbbb288c92536814501", async() => {
                WriteLiteral("3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23cbbb5cc7704ab875ec3969f2bbbb288c92536815700", async() => {
                WriteLiteral("4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23cbbb5cc7704ab875ec3969f2bbbb288c92536816899", async() => {
                WriteLiteral("5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>

                            </div>
                            <br />
                            <a href=""#"" class=""btn  btn-outline-primary"">
                                <span class=""text"">Adicionar ao carrinho</span> <i class=""fas fa-shopping-cart""> &nbsp;</i>
                            </a>
");
#nullable restore
#line 69 "C:\Projetos\Desenvolvedor.IO\ASP.NET Core Enterprise Applications\MStore\src\web\MS.WebApp.MVC\Views\Catalogo\ProdutoDetalhe.cshtml"

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23cbbb5cc7704ab875ec3969f2bbbb288c92536818843", async() => {
                WriteLiteral("\r\n                        <span class=\"text\">Voltar</span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </article>\r\n            </main>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MS.WebApp.MVC.Models.ProdutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
