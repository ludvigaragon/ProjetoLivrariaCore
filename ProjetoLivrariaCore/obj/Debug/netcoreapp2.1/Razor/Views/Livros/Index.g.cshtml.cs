#pragma checksum "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a229cbeee28621fbc11a3b7e891d03d2f122a16f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livros_Index), @"mvc.1.0.view", @"/Views/Livros/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Livros/Index.cshtml", typeof(AspNetCore.Views_Livros_Index))]
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
#line 1 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\_ViewImports.cshtml"
using ProjetoLivrariaCore;

#line default
#line hidden
#line 2 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\_ViewImports.cshtml"
using ProjetoLivrariaCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a229cbeee28621fbc11a3b7e891d03d2f122a16f", @"/Views/Livros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e5ecba5e2273e716b3866279ebd8b5fc0d5c4a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Livros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoLivrariaCore.Models.Livro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 83, true);
            WriteLiteral("\r\n<h2>Consulta de Livros Cadastrados</h2>\r\n\r\n<div id=\"consulta\">\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(227, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b0b7d97ebf4ba3acf46a8f47ea13f5", async() => {
                BeginContext(271, 15, true);
                WriteLiteral("Cadastrar Livro");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(290, 1132, true);
            WriteLiteral(@"
    </p>
    <div class=""row"">
        <label>Pesquisa:</label>
        <div>
            <input type=""radio"" name=""rbGroupFilterGrid"" value=5 checked onclick=""rbGroupFilterChange(this)""/>Todas
            <input type=""radio"" name=""rbGroupFilterGrid"" value=0 onclick=""rbGroupFilterChange(this)""/>ISBN
            <input type=""radio"" name=""rbGroupFilterGrid"" value=1 onclick=""rbGroupFilterChange(this)""/>Autor
            <input type=""radio"" name=""rbGroupFilterGrid"" value=2 onclick=""rbGroupFilterChange(this)""/>Nome
            <input type=""radio"" name=""rbGroupFilterGrid"" value=3 onclick=""rbGroupFilterChange(this)""/>Preço
            <input type=""radio"" name=""rbGroupFilterGrid"" value=4 onclick=""rbGroupFilterChange(this)""/>Data de Publicação
        </div>
        <input class=""form-control"" id=""inputSearch"" type=""text"" placeholder=""ISBN, Autor, Nome, Preço, Data de Publicação..."">
    </div>
    <hr />
    <div id=""divGrid"" class=""row"">
        <table id=""tableLivros"" class=""table table-striped tab");
            WriteLiteral("le-bordered\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1422, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3513a28aac1f45a7a9aae62cf8a144cd", async() => {
                BeginContext(1493, 40, false);
#line 32 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                                                         Write(Html.DisplayNameFor(model => model.ISBN));

#line default
#line hidden
                EndContext();
                BeginContext(1533, 8, true);
                WriteLiteral("&nbsp;<i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1541, "\"", 1631, 1);
#line 32 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
WriteAttributeValue("", 1549, (@ViewData["sortType"].ToString() == "ISBN")? @ViewData["sortDescAsc"]:"oculto", 1549, 82, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1632, 5, true);
                WriteLiteral("></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                       WriteLiteral(ViewData["IsbnSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1641, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1720, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98589cfd65114502be4eaf8fa6428e83", async() => {
                BeginContext(1792, 41, false);
#line 35 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                                                          Write(Html.DisplayNameFor(model => model.Autor));

#line default
#line hidden
                EndContext();
                BeginContext(1833, 8, true);
                WriteLiteral("&nbsp;<i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1841, "\"", 1933, 1);
#line 35 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
WriteAttributeValue("", 1849, (@ViewData["sortType"].ToString() == "Autor")? @ViewData["sortDescAsc"] :"oculto", 1849, 84, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1934, 5, true);
                WriteLiteral("></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                       WriteLiteral(ViewData["AutorSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1943, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2022, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa6b54eb52824434a9ea8781e2a54255", async() => {
                BeginContext(2093, 40, false);
#line 38 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                                                         Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(2133, 8, true);
                WriteLiteral("&nbsp;<i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2141, "\"", 2232, 1);
#line 38 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
WriteAttributeValue("", 2149, (@ViewData["sortType"].ToString() == "Nome")? @ViewData["sortDescAsc"] :"oculto", 2149, 83, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2233, 5, true);
                WriteLiteral("></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                       WriteLiteral(ViewData["NomeSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2242, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2321, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6664a6561cf24dd0b0784487823979bb", async() => {
                BeginContext(2393, 41, false);
#line 41 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                                                          Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
                EndContext();
                BeginContext(2434, 8, true);
                WriteLiteral("&nbsp;<i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2442, "\"", 2534, 1);
#line 41 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
WriteAttributeValue("", 2450, (@ViewData["sortType"].ToString() == "Preco")? @ViewData["sortDescAsc"] :"oculto", 2450, 84, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2535, 5, true);
                WriteLiteral("></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                       WriteLiteral(ViewData["PrecoSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2544, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2623, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2f8d2fd8c6746b685dd0c2cfed47154", async() => {
                BeginContext(2698, 50, false);
#line 44 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                                                             Write(Html.DisplayNameFor(model => model.DataPublicacao));

#line default
#line hidden
                EndContext();
                BeginContext(2748, 8, true);
                WriteLiteral("&nbsp;<i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2756, "\"", 2857, 1);
#line 44 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
WriteAttributeValue("", 2764, (@ViewData["sortType"].ToString() == "DataPublicacao")? @ViewData["sortDescAsc"] :"oculto", 2764, 93, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2858, 5, true);
                WriteLiteral("></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                       WriteLiteral(ViewData["DtPublicSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2867, 142, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody id=\"gridLivros\">\r\n");
            EndContext();
#line 50 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3074, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3159, 39, false);
#line 54 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(3198, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3290, 40, false);
#line 57 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Autor));

#line default
#line hidden
            EndContext();
            BeginContext(3330, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3422, 39, false);
#line 60 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3461, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3553, 40, false);
#line 63 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(3593, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3685, 49, false);
#line 66 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataPublicacao));

#line default
#line hidden
            EndContext();
            BeginContext(3734, 107, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <img width=\"100\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 3841, "", 3902, 1);
#line 69 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
WriteAttributeValue("", 3846, string.Concat("images/CapasLivros/",item.PathCapaLivro), 3846, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3902, 94, true);
            WriteLiteral(" />\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3996, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86c674a0d3204821ad2371dae4168e6a", async() => {
                BeginContext(4070, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                   WriteLiteral(item.LivroId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4080, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(4112, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "637aabe4dc0844038dea10ab3f58fe39", async() => {
                BeginContext(4192, 10, true);
                WriteLiteral("+ Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                      WriteLiteral(item.LivroId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4206, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(4238, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f91c135beb848499b960030a0501682", async() => {
                BeginContext(4316, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                                                     WriteLiteral(item.LivroId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4327, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 77 "F:\Documentos\Documentos\LudvigDocs\repos\ProjetoLivraria\ProjetoLivrariaCore\ProjetoLivrariaCore\Views\Livros\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4406, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoLivrariaCore.Models.Livro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
