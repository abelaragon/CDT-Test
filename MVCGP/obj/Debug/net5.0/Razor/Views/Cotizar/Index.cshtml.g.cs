#pragma checksum "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3145bd56fa671cda24b2b4c91c9b76f20b66451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cotizar_Index), @"mvc.1.0.view", @"/Views/Cotizar/Index.cshtml")]
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
#line 1 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\_ViewImports.cshtml"
using MVCGP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\_ViewImports.cshtml"
using MVCGP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3145bd56fa671cda24b2b4c91c9b76f20b66451", @"/Views/Cotizar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04289372a7b285bdb65ed71485f94137500ee399", @"/Views/_ViewImports.cshtml")]
    public class Views_Cotizar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCGP.Models.Cotizar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3145bd56fa671cda24b2b4c91c9b76f20b664514017", async() => {
                WriteLiteral("Cotizar nuevo producto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table text-center"">
    <thead>
        <tr>
            <td>
                <h6>Producto</h6>
            </td>
            <td>
                <h6>Precio Producto</h6>
            </td>
            <td>
                <h6>Plazos</h6>
            <td>
                <h6>Tasa Puntual</h6>
            </td>
            <td>
                <h6>Tasa Normal</h6>
            </td>
            <td>
                <h6>Abono Puntual</h6>
            </td>
            <td>
                <h6>Abono Normal</h6>
              

            </td>
            <th></th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 40 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
          
            decimal AbonoN = 0;
            decimal AbonoP = 0;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
         foreach (var item in Model)
        {
            AbonoN = (decimal)(item.Semanas.TasaN * item.Producto.PrecioProducto + item.Producto.PrecioProducto) / item.Semanas.Plazoss;
            AbonoP = (decimal)(item.Semanas.TasaP * item.Producto.PrecioProducto + item.Producto.PrecioProducto) / item.Semanas.Plazoss;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"text-center\">\r\n                ");
#nullable restore
#line 51 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Producto.nombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-center\">\r\n                ");
#nullable restore
#line 54 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
           Write(String.Format("{0:C}", item.Producto.PrecioProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               \r\n            </td>\r\n            <td class=\"text-center\">\r\n                ");
#nullable restore
#line 58 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Semanas.Plazoss));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-center\">\r\n                ");
#nullable restore
#line 61 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
           Write(String.Format("{0:C}", item.Semanas.TasaP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </td>\r\n            <td class=\"text-center\">\r\n                ");
#nullable restore
#line 65 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
           Write(String.Format("{0:C}", item.Semanas.TasaN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </td>\r\n\r\n            <td  class=\"text-center\">\r\n                ");
#nullable restore
#line 70 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
           Write(String.Format("{0:C}", AbonoP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n              </td>\r\n                \r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
           Write(String.Format("{0:C}", AbonoN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3145bd56fa671cda24b2b4c91c9b76f20b664519338", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\AbelMñz\source\repos\respow\Respaldo-Salinas - copia\MVCGP\MVCGP\Views\Cotizar\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCGP.Models.Cotizar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
