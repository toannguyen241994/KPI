#pragma checksum "C:\Users\toannguyen\Project\KPI\bluecore-master\bluecore-master\Blue.IdentityServer\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca0e249decb4ea943c866006360fd8ba74cc6c7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\toannguyen\Project\KPI\bluecore-master\bluecore-master\Blue.IdentityServer\Views\Shared\Error.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0e249decb4ea943c866006360fd8ba74cc6c7b", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blue.IdentityServer.Models.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(118, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\toannguyen\Project\KPI\bluecore-master\bluecore-master\Blue.IdentityServer\Views\Shared\Error.cshtml"
  
    var error = Model?.Error?.Error;
    var errorDescription = host.IsDevelopment() ? Model?.Error?.ErrorDescription : null;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
            BeginContext(296, 384, true);
            WriteLiteral(@"
<div id=""wrapper"">
    <div class=""content-wrapper"">
        <div class=""content custom-scrollbar"">
            <div id=""error-500"" class=""d-flex flex-column align-items-center justify-content-center"">
                <div class=""content"">
                    <div class=""error-code display-1 text-center"">401</div>
                    <div class=""message h3 text-center text-muted"">");
            EndContext();
            BeginContext(681, 5, false);
#line 17 "C:\Users\toannguyen\Project\KPI\bluecore-master\bluecore-master\Blue.IdentityServer\Views\Shared\Error.cshtml"
                                                              Write(error);

#line default
#line hidden
            EndContext();
            BeginContext(686, 117, true);
            WriteLiteral("</div>\n                    <div class=\"sub-message h5 mt-4 mb-12 text-center text-muted\">\n                        <p>");
            EndContext();
            BeginContext(804, 16, false);
#line 19 "C:\Users\toannguyen\Project\KPI\bluecore-master\bluecore-master\Blue.IdentityServer\Views\Shared\Error.cshtml"
                      Write(errorDescription);

#line default
#line hidden
            EndContext();
            BeginContext(820, 44, true);
            WriteLiteral("</p>\n                        <p>Request ID: ");
            EndContext();
            BeginContext(865, 10, false);
#line 20 "C:\Users\toannguyen\Project\KPI\bluecore-master\bluecore-master\Blue.IdentityServer\Views\Shared\Error.cshtml"
                                  Write(request_id);

#line default
#line hidden
            EndContext();
            BeginContext(875, 222, true);
            WriteLiteral("</p>\n                    </div>\n                    <a class=\"report-link d-block text-center text-light-blue-600\" href=\"/\">Report this problem</a>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHostingEnvironment host { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blue.IdentityServer.Models.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591