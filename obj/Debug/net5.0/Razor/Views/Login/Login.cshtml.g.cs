#pragma checksum "C:\Users\Naveen.Kumar\source\repos\LoginPageCreation\LoginPageCreation\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c6f79ed70098eb9d7e3bedbd6abbcb11865be36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
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
#line 1 "C:\Users\Naveen.Kumar\source\repos\LoginPageCreation\LoginPageCreation\Views\_ViewImports.cshtml"
using LoginPageCreation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Naveen.Kumar\source\repos\LoginPageCreation\LoginPageCreation\Views\_ViewImports.cshtml"
using LoginPageCreation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c6f79ed70098eb9d7e3bedbd6abbcb11865be36", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157f96a3ec4a54f5445e96b97b0cf746614a201a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginPageCreation.Models.UserModel>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Naveen.Kumar\source\repos\LoginPageCreation\LoginPageCreation\Views\Login\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c6f79ed70098eb9d7e3bedbd6abbcb11865be363616", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <style>
        body {
          
           /* background-color: deepskyblue;*/
           background-image:url(""https://miro.medium.com/max/800/1*YoHBCwurgo2bDO6Piozp5A.png"");
           background-repeat:no-repeat;
           background-size:cover;
            height: 100vh;
        }

        #login .container #login-row #login-column #login-box {
            margin-top: 140px;
            max-width: 400px;
            height: 270px;
            border: 1px solid #9C9C9C;
            background-color: #EAEAEA;
            border-radius:10px;
        }

       #login .container #login-row #login-column #login-box #l");
                WriteLiteral("ogin-form {\r\n            padding: 20px;\r\n         }\r\n\r\n            #login .container #login-row #login-column #login-box #login-form #register-link {\r\n              margin-top: -85px;\r\n             }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c6f79ed70098eb9d7e3bedbd6abbcb11865be365885", async() => {
                WriteLiteral(@"

    <div id=""login"">
        <div class=""container"">
            <div id=""login-row"" class=""row justify-content-center align-items-center"">
                <div id=""login-column"" class=""col-md-6"">
                    <div id=""login-box"" class=""col-md-12"">
");
#nullable restore
#line 49 "C:\Users\Naveen.Kumar\source\repos\LoginPageCreation\LoginPageCreation\Views\Login\Login.cshtml"
                         using (Html.BeginForm("Verify", "Login", FormMethod.Post))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h3 class=\"text-center text-info\">Login</h3>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"username\" class=\"text-info\">Username:</label><br>\r\n                                ");
#nullable restore
#line 53 "C:\Users\Naveen.Kumar\source\repos\LoginPageCreation\LoginPageCreation\Views\Login\Login.cshtml"
                           Write(Html.TextBoxFor(m => m.username, new { @class = "form-control", @placeholder = "Email", @required = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"password\" class=\"text-info\">Password:</label><br>\r\n                                ");
#nullable restore
#line 57 "C:\Users\Naveen.Kumar\source\repos\LoginPageCreation\LoginPageCreation\Views\Login\Login.cshtml"
                           Write(Html.PasswordFor(m => m.password, new { @class = "form-control", @placeholder = "Password", @required = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                            <div class=""form-group text-center"">
                               
                                <input type=""submit"" name=""submit"" class=""btn btn-info btn-md"" value=""submit"">
                            </div>
");
#nullable restore
#line 63 "C:\Users\Naveen.Kumar\source\repos\LoginPageCreation\LoginPageCreation\Views\Login\Login.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div style=\"color:red;\">");
#nullable restore
#line 64 "C:\Users\Naveen.Kumar\source\repos\LoginPageCreation\LoginPageCreation\Views\Login\Login.cshtml"
                                           Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                </div>S\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginPageCreation.Models.UserModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591