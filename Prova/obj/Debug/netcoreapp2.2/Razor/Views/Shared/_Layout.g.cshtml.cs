#pragma checksum "C:\Projetos\Prova\Prova\Prova\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d0a55a5b4d57b8a6b5aeb71831c7a7c43228f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1d0a55a5b4d57b8a6b5aeb71831c7a7c43228f2", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 782, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1d0a55a5b4d57b8a6b5aeb71831c7a7c43228f23248", async() => {
                BeginContext(41, 769, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <title>SB Admin - Dashboard</title>
    <!-- Bootstrap core CSS-->
    <link href=""../vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- Custom fonts for this template-->
    <link href=""../vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <!-- Page level plugin CSS-->
    <link href=""../vendor/datatables/dataTables.bootstrap4.css"" rel=""stylesheet"">
    <!-- Custom styles for this template-->
    <link href=""../css/sb-admin.css"" rel=""stylesheet"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(817, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(819, 2606, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1d0a55a5b4d57b8a6b5aeb71831c7a7c43228f25233", async() => {
                BeginContext(839, 109, true);
                WriteLiteral("\r\n    <nav class=\"navbar navbar-expand navbar-dark bg-dark static-top\">\r\n        <a class=\"navbar-brand mr-1\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 948, "\"", 983, 1);
#line 21 "C:\Projetos\Prova\Prova\Prova\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 955, Url.Action("Index", "Home"), 955, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(984, 375, true);
                WriteLiteral(@">Start Bootstrap</a>
        <button class=""btn btn-link btn-sm text-white order-1 order-sm-0"" id=""sidebarToggle"" href=""#"">
            <i class=""fas fa-bars""></i>
        </button>
    </nav>
    <div id=""wrapper"">
        <!-- Sidebar -->
        <ul class=""sidebar navbar-nav col-md-2"">
            <li class=""nav-item active"">
                <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1359, "\"", 1394, 1);
#line 30 "C:\Projetos\Prova\Prova\Prova\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1366, Url.Action("Index", "Home"), 1366, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1395, 223, true);
                WriteLiteral(">\r\n                    <i class=\"fas fa-fw fa-tachometer-alt\"></i>\r\n                    <span>Dashboard</span>\r\n                </a>\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1618, "\"", 1653, 1);
#line 36 "C:\Projetos\Prova\Prova\Prova\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1625, Url.Action("Index", "Task"), 1625, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1654, 217, true);
                WriteLiteral(">\r\n                    <i class=\"fas fa-fw fa-chart-area\"></i>\r\n                    <span>Tarefas</span>\r\n                </a>\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1871, "\"", 1907, 1);
#line 42 "C:\Projetos\Prova\Prova\Prova\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1878, Url.Action("Create", "Task"), 1878, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1908, 251, true);
                WriteLiteral(">\r\n                    <i class=\"fas fa-fw fa-chart-area\"></i>\r\n                    <span>Nova Tarefa</span>\r\n                </a>\r\n            </li>\r\n        </ul>\r\n\r\n        <!-- /.content-wrapper -->\r\n\r\n        <div class=\"col-md-10\">\r\n            ");
                EndContext();
                BeginContext(2160, 12, false);
#line 52 "C:\Projetos\Prova\Prova\Prova\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2172, 1196, true);
                WriteLiteral(@"
        </div>
        <div id=""modalAjax"" class=""modal"">
            <div style=""text-align:center; padding-top:20%;"">
                Aguarde...
            </div>
        </div>
    </div>
    <!-- /#wrapper -->
    <!-- Scroll to Top Button-->
    <a class=""scroll-to-top rounded"" href=""#page-top"">
        <i class=""fas fa-angle-up""></i>
    </a>
    <!-- Bootstrap core JavaScript-->
    <script src=""../vendor/jquery/jquery.min.js""></script>
    <script src=""../vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- Core plugin JavaScript-->
    <script src=""../vendor/jquery-easing/jquery.easing.min.js""></script>
    <!-- Page level plugin JavaScript-->
    <script src=""../vendor/datatables/jquery.dataTables.js""></script>
    <script src=""../vendor/datatables/dataTables.bootstrap4.js""></script>
    <!-- Custom scripts for all pages-->
    <script src=""../js/sb-admin.min.js""></script>

    <script type=""text/javascript"">
        $(document).ajaxStart(function (param) {
   ");
                WriteLiteral("         $(\"#modalAjax\").modal();\r\n        });\r\n\r\n        $(document).ajaxStop(function () {\r\n            $(\"#modalAjax\").modal(\'hide\');\r\n        });\r\n    </script>\r\n\r\n    ");
                EndContext();
                BeginContext(3369, 45, false);
#line 86 "C:\Projetos\Prova\Prova\Prova\Views\Shared\_Layout.cshtml"
Write(RenderSection("ScriptsReady", required: true));

#line default
#line hidden
                EndContext();
                BeginContext(3414, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3425, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
