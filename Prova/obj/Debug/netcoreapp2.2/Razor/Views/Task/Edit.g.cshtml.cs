#pragma checksum "C:\Projetos\Prova\Prova\Prova\Views\Task\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcc63a5a3a42f962f63c2c2cdffb88fa8d32ace1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Edit), @"mvc.1.0.view", @"/Views/Task/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/Edit.cshtml", typeof(AspNetCore.Views_Task_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcc63a5a3a42f962f63c2c2cdffb88fa8d32ace1", @"/Views/Task/Edit.cshtml")]
    public class Views_Task_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Prova.ViewModels.TaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Projetos\Prova\Prova\Prova\Views\Task\Edit.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(93, 670, true);
            WriteLiteral(@"
<div class=""card mb-3"">
    <div class=""card-header"">
        Editar Tarefa
    </div>
    <div class=""card-body"">
        <div id=""success"" class=""alert alert-success"" style=""display:none;"">
            <strong>Sucesso!</strong> Alteração realizada com sucesso.
        </div>
        <div id=""errors"" class=""alert alert-danger"" style=""display:none;"">
            
        </div>
        <form class=""p-t-15"" method=""post"" role=""form"" id=""formEditTask"">
            <div class=""form-group"">
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""form-group"">
                            ");
            EndContext();
            BeginContext(764, 25, false);
#line 22 "C:\Projetos\Prova\Prova\Prova\Views\Task\Edit.cshtml"
                       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(789, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(820, 34, false);
#line 23 "C:\Projetos\Prova\Prova\Prova\Views\Task\Edit.cshtml"
                       Write(Html.HiddenFor(m => m.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(854, 93, true);
            WriteLiteral("\r\n                            <label for=\"title\">Título</label>\r\n                            ");
            EndContext();
            BeginContext(948, 97, false);
#line 25 "C:\Projetos\Prova\Prova\Prova\Views\Task\Edit.cshtml"
                       Write(Html.TextBoxFor(m => m.Title, new { @class = "form-control", @maxlength = 30, @required = true }));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 379, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""form-group"">
                            <label for=""description"">Descrição</label>
                            ");
            EndContext();
            BeginContext(1425, 116, false);
#line 35 "C:\Projetos\Prova\Prova\Prova\Views\Task\Edit.cshtml"
                       Write(Html.TextAreaFor(m => m.Description, new { @class = "form-control", @maxlength = 300, @required = true, @rows = 3 }));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 106, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 40 "C:\Projetos\Prova\Prova\Prova\Views\Task\Edit.cshtml"
              
                var attDropDownList = new Dictionary<string, object>();

                attDropDownList.Add("class", "form-control");
                attDropDownList.Add("required", "true");

                var list = new List<SelectListItem>();
                list.Add(new SelectListItem("Novo", "1"));
                list.Add(new SelectListItem("Para Fazer", "2"));
                list.Add(new SelectListItem("Fazendo", "3"));
                list.Add(new SelectListItem("Parado", "4"));
                list.Add(new SelectListItem("Reaberto", "5"));
                list.Add(new SelectListItem("Pronto", "6"));
            

#line default
#line hidden
            BeginContext(2309, 265, true);
            WriteLiteral(@"            <div class=""form-group"">
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""form-group"">
                            <label for=""status"">Status</label>
                            ");
            EndContext();
            BeginContext(2575, 58, false);
#line 59 "C:\Projetos\Prova\Prova\Prova\Views\Task\Edit.cshtml"
                       Write(Html.DropDownListFor(x => x.Status, list, attDropDownList));

#line default
#line hidden
            EndContext();
            BeginContext(2633, 230, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary btn-block\">Salvar</button>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("ScriptsReady", async() => {
                BeginContext(2885, 815, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var form = $('#formEditTask');

        form.submit(function (event) {
            event.preventDefault();

            $(""#success"").hide();
            $(""#errors"").hide();

            $.post('/Task/Edit/', form.serialize(),
                function (data) {
                    if (data.ok) {
                        $(""#success"").show();
                    }
                    else {
                        $(data.errors).each(function (erro) {
                            $(""#errors"").empty();
                            $(""#errors"").append('<strong>Erro!</strong> ' + this.message + ""<br/>"")
                        });
                        $(""#errors"").show();
                    }
                });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prova.ViewModels.TaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
