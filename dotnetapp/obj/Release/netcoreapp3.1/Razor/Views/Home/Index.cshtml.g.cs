#pragma checksum "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e80775e23303d6fbed77ab039171b464a844b6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\_ViewImports.cshtml"
using Swamid.Errorurl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\_ViewImports.cshtml"
using Swamid.Errorurl.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e80775e23303d6fbed77ab039171b464a844b6c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d79b8cd3bbb4f0ca6220aa8917d3d356e4cef1ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Swamid.Errorurl.Models.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div>\r\n        <div class=\"float-right\">\r\n");
#nullable restore
#line 25 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
             foreach (var n in Model.Navigations)
            {
                //var o = 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 931, "\"", 1222, 1);
#nullable restore
#line 28 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
WriteAttributeValue("", 938, Url.Action("Index","Home",new {errorurl_code=@Model.Parameters.errorurl_code,errorurl_ts=Model.Parameters.errorurl_ts,errorurl_rp=Model.Parameters.errorurl_rp,
                    errorurl_tid=Model.Parameters.errorurl_tid,errorurl_ctx=Model.Parameters.errorurl_ctx,lang=n.Culture}), 938, 284, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1250, "\"", 1270, 1);
#nullable restore
#line 30 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1256, n.CultureLogo, 1256, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 30 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                                           Write(n.CultureText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 31 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
             foreach (var err in Model.LoginError)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>");
#nullable restore
#line 38 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
               Write(err.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 39 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                 foreach (var s in err.Body)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 41 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                  Write(Html.Raw(s));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 42 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>");
#nullable restore
#line 43 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
              Write(Html.Raw(Model.ContactInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 44 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                 if (Model.Parameters.HaveDetails())
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 47 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                  Write(Html.DisplayFor(model => model.TechnicalInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"alert-warning\">\r\n");
            WriteLiteral("                        ");
#nullable restore
#line 50 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Parameters.errorurl_ts));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 50 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                                                                                Write(Html.Raw(Model.Parameters.errorurl_ts));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 51 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Parameters.errorurl_rp));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 51 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                                                                                Write(Html.Raw(Model.Parameters.errorurl_rp));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 52 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Parameters.errorurl_tid));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 52 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                                                                                 Write(Html.Raw(Model.Parameters.errorurl_tid));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 53 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Parameters.errorurl_ctx));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 53 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                                                                                 Write(Html.Raw(Model.Parameters.errorurl_ctx));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                    </div>\r\n");
#nullable restore
#line 55 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\BizTalk\source\repos\swamid-errorurl\dotnetapp\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Swamid.Errorurl.Models.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
