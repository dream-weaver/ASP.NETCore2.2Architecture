#pragma checksum "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b32f6007b9e13308cab78028cfc0a23f212b54e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pay_Payslip), @"mvc.1.0.view", @"/Views/Pay/Payslip.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pay/Payslip.cshtml", typeof(AspNetCore.Views_Pay_Payslip))]
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
#line 1 "F:\SandBox\Paycompute\Paycompute\Views\_ViewImports.cshtml"
using Paycompute;

#line default
#line hidden
#line 2 "F:\SandBox\Paycompute\Paycompute\Views\_ViewImports.cshtml"
using Paycompute.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b32f6007b9e13308cab78028cfc0a23f212b54e9", @"/Views/Pay/Payslip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82a17a92ca28dc354efe5ab80300d7aa4b038b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pay_Payslip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentRecordDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
   ViewBag.Title = "Payslip";

#line default
#line hidden
#line 3 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
   Layout = null;

#line default
#line hidden
            BeginContext(89, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b32f6007b9e13308cab78028cfc0a23f212b54e94030", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(160, 807, true);
            WriteLiteral(@"
<div class=""row"">
          <div class=""class-md-12 grid-margin"">
                    <div class=""card"">
                              <div class=""card-body"">
                                        <div class=""container-fluid d-flex justify-content-between"">
                                                  <div class=""col-md-3 pl-0"">
                                                            <p class=""mt-5 mb-2""><b>PayCompute Ltd.</b></p>
                                                            <p>11 Downing Street<br />London<br />W1C2XB</p>
                                                  </div>
                                                  <div class=""col-md-3 pr-0"">
                                                            <p class=""mt-5 mb-2 text-right""><b>Pay Date: ");
            EndContext();
            BeginContext(968, 36, false);
#line 15 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                                                    Write(Model.PayDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 102, true);
            WriteLiteral("</b></p>\r\n                                                            <p class=\"text-right\">Tax Code: ");
            EndContext();
            BeginContext(1107, 13, false);
#line 16 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                                       Write(Model.TaxCode);

#line default
#line hidden
            EndContext();
            BeginContext(1120, 11, true);
            WriteLiteral("<br/>Year: ");
            EndContext();
            BeginContext(1132, 10, false);
#line 16 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                                                                Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1142, 418, true);
            WriteLiteral(@"<br />HMRC</p>
                                                  </div>
                                        </div>
                                        <br /><br/>
                                              <div class=""col-md-12 row"">
                                                        <div class=""col-md-8"">
                                                                  <h5>Employee's Name : ");
            EndContext();
            BeginContext(1561, 14, false);
#line 22 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                                   Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1575, 250, true);
            WriteLiteral(" </h5>\r\n                                                        </div>\r\n                                                        <div class=\"col-md-4\">\r\n                                                                  <h5>National Insurance Number : ");
            EndContext();
            BeginContext(1826, 10, false);
#line 25 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                                             Write(Model.NiNo);

#line default
#line hidden
            EndContext();
            BeginContext(1836, 1478, true);
            WriteLiteral(@" </h5>
                                                        </div>
                                              </div>

                              </div>
                              <div class=""row"">
                                        <div class=""col-md-12 table-responsive-md"">
                                                  <table class=""table table-striped"">
                                                  <thead class=""table-dark"">
                                                            <tr>
                                                                      <th>Earnings</th>
                                                                      <th>Hours</th>
                                                                      <th>Rates</th>
                                                                      <th>Amount</th>
                                                                      <th>Deductions</th>
                                                      ");
            WriteLiteral(@"                <th>Amount</th>
                                                            </tr>
                                                  </thead>
                                                  <tbody>
                                                            <tr>
                                                                      <td><b>Basic :</b></td>
                                                                      <td>");
            EndContext();
            BeginContext(3315, 36, false);
#line 46 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.ContractualHours.ToString("f"));

#line default
#line hidden
            EndContext();
            BeginContext(3351, 81, true);
            WriteLiteral("</td>\r\n                                                                      <td>");
            EndContext();
            BeginContext(3433, 30, false);
#line 47 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.HourlyRate.ToString("f"));

#line default
#line hidden
            EndContext();
            BeginContext(3463, 81, true);
            WriteLiteral("</td>\r\n                                                                      <td>");
            EndContext();
            BeginContext(3545, 39, false);
#line 48 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.ContractualEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3584, 175, true);
            WriteLiteral("</td>\r\n                                                                      <td><b>Tax : </b></td>\r\n                                                                      <td>");
            EndContext();
            BeginContext(3760, 23, false);
#line 50 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.Tax.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3783, 312, true);
            WriteLiteral(@"</td>
                                                            </tr>
                                                            <tr>
                                                                      <td><b>Overtime :</b></td>
                                                                      <td>");
            EndContext();
            BeginContext(4096, 33, false);
#line 54 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.OvertimeHours.ToString("f"));

#line default
#line hidden
            EndContext();
            BeginContext(4129, 81, true);
            WriteLiteral("</td>\r\n                                                                      <td>");
            EndContext();
            BeginContext(4211, 33, false);
#line 55 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.OvertimeRate.ToString("f2"));

#line default
#line hidden
            EndContext();
            BeginContext(4244, 81, true);
            WriteLiteral("</td>\r\n                                                                      <td>");
            EndContext();
            BeginContext(4326, 36, false);
#line 56 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.OvertimeEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4362, 175, true);
            WriteLiteral("</td>\r\n                                                                      <td><b>NIC : </b></td>\r\n                                                                      <td>");
            EndContext();
            BeginContext(4538, 23, false);
#line 58 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.NIC.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4561, 634, true);
            WriteLiteral(@"</td>
                                                            </tr>
                                                            <tr>
                                                                      <td></td>
                                                                      <td></td>
                                                                      <td></td>
                                                                      <td></td>
                                                                      <td><b>Union : </b></td>
                                                                      <td>");
            EndContext();
            BeginContext(5196, 34, false);
#line 66 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.UnionFee.Value.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(5230, 310, true);
            WriteLiteral(@"</td>
                                                            </tr>
                                                            <tr>
                                                                      <td><b>Total : </b></td>
                                                                      <td>");
            EndContext();
            BeginContext(5541, 17, false);
#line 70 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.HoursWorked);

#line default
#line hidden
            EndContext();
            BeginContext(5558, 162, true);
            WriteLiteral("</td>\r\n                                                                      <td></td>\r\n                                                                      <td>");
            EndContext();
            BeginContext(5721, 33, false);
#line 72 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.TotalEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(5754, 169, true);
            WriteLiteral("</td>\r\n                                                                      <td><b></b></td>\r\n                                                                      <td>");
            EndContext();
            BeginContext(5924, 20, false);
#line 74 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.TotalDeduction);

#line default
#line hidden
            EndContext();
            BeginContext(5944, 811, true);
            WriteLiteral(@" .ToString(""C"")</td>
                                                            </tr>
 
                                                  </tbody>
                                                  <tfoot>
                                                            <tr>
                                                                      <td></td>
                                                                      <td></td>
                                                                      <td></td>
                                                                      <td></td>
                                                                      <td class=""table-dark""><b>NET PAY : </b></td>
                                                                      <td class=""table-dark"">");
            EndContext();
            BeginContext(6756, 30, false);
#line 85 "F:\SandBox\Paycompute\Paycompute\Views\Pay\Payslip.cshtml"
                                                                                        Write(Model.NetPayment.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(6786, 334, true);
            WriteLiteral(@"</td>
                                                            </tr>
                                                  </tfoot>
                                                  </table>
                                        </div>
                              </div>
                    </div>
          </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentRecordDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
