#pragma checksum "C:\Projetos\Prova\Prova\Prova\Views\Task\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44a5d55300975da66cd201ba335560cb5b0da704"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Create), @"mvc.1.0.view", @"/Views/Task/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/Create.cshtml", typeof(AspNetCore.Views_Task_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a5d55300975da66cd201ba335560cb5b0da704", @"/Views/Task/Create.cshtml")]
    public class Views_Task_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projetos\Prova\Prova\Prova\Views\Task\Create.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(54, 1531, true);
            WriteLiteral(@"
<div class=""card mb-3"">
    <div class=""card-header"">
        Nova Tarefa
    </div>
    <div class=""card-body"">
        <div id=""success"" class=""alert alert-success"" style=""display:none;"">
            <strong>Sucesso!</strong>
        </div>
        <div id=""errors"" class=""alert alert-danger"" style=""display:none;"">
            <strong>Erro!</strong>
        </div>
        <form class=""p-t-15"" method=""post"" role=""form"" id=""formCreateTask"">
            <div class=""form-group"">
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""form-group"">
                            <label for=""title"">Título</label>
                            <input type=""text"" id=""Title"" name=""Title"" class=""form-control"" maxlength=""30"" required>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""form-row"">
                    <div class");
            WriteLiteral(@"=""col-md-12"">
                        <div class=""form-group"">
                            <label for=""description"">Descrição</label>
                            <textarea id=""Description"" name=""Description"" class=""form-control"" maxlength=""300"" rows=""3"" required></textarea>
                        </div>
                    </div>
                </div>
            </div>
            <button type=""submit"" class=""btn btn-primary btn-block"">Salvar</button>
        </form>
    </div>
</div>

");
            EndContext();
            DefineSection("ScriptsReady", async() => {
                BeginContext(1607, 745, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var form = $('#formCreateTask');

        form.submit(function (event) {
            event.preventDefault();

            $(""#success"").hide();
            $(""#errors"").hide();

            $.post('/Task/Add/', form.serialize(),
                function (data) {
                    if (data.ok) {
                        $(""#success"").show();
                    }
                    else {
                        $(data.errors).each(function (erro) {
                            $(""#errors"").append(this.message + ""<br/>"")
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591