#pragma checksum "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a770d6dd649d11017926031d1932f2f0ad242809"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AcmeNotas.App.Presentacion.Pages.CrudeFormador.Pages_CrudeFormador_Details), @"mvc.1.0.razor-page", @"/Pages/CrudeFormador/Details.cshtml")]
namespace AcmeNotas.App.Presentacion.Pages.CrudeFormador
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
#line 1 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\_ViewImports.cshtml"
using AcmeNotas.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a770d6dd649d11017926031d1932f2f0ad242809", @"/Pages/CrudeFormador/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b058714d9acaf20abeed3abde626823c0da4523", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CrudeFormador_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Formador</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.CodigoFormador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.CodigoFormador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.CorreoElectronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.CorreoElectronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.Departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.Departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.Municipio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.Municipio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Formador.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Formador.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a770d6dd649d11017926031d1932f2f0ad24280912369", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\AcmeNotas\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudeFormador\Details.cshtml"
                           WriteLiteral(Model.Formador.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a770d6dd649d11017926031d1932f2f0ad24280914537", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcmeNotas.App.Presentacion.Pages.CrudeFormador.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcmeNotas.App.Presentacion.Pages.CrudeFormador.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcmeNotas.App.Presentacion.Pages.CrudeFormador.DetailsModel>)PageContext?.ViewData;
        public AcmeNotas.App.Presentacion.Pages.CrudeFormador.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
