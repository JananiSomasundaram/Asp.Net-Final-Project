#pragma checksum "C:\Users\JananiS\source\Training\Asp.Net\WFManagementSystemClient\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "751f79a0e4c5bbae8c7763a64e73d13499088901"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "C:\Users\JananiS\source\Training\Asp.Net\WFManagementSystemClient\Views\_ViewImports.cshtml"
using WFManagementSystemClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JananiS\source\Training\Asp.Net\WFManagementSystemClient\Views\_ViewImports.cshtml"
using WFManagementSystemClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JananiS\source\Training\Asp.Net\WFManagementSystemClient\Views\Home\Login.cshtml"
using WFManagementSystemClient.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"751f79a0e4c5bbae8c7763a64e73d13499088901", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf6895e0d0a481da75ab411d90c1fdc71eba5215", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WFManagementSystemClient.Models.UserProfile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\JananiS\source\Training\Asp.Net\WFManagementSystemClient\Views\Home\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n<div class=\"login\">\r\n    <h1>Login</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "751f79a0e4c5bbae8c7763a64e73d134990889014436", async() => {
                WriteLiteral("\r\n        <p><input type=\"text\" name=\"login\"");
                BeginWriteAttribute("value", " value=\"", 272, "\"", 280, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Username or Email\"></p>\r\n        <p><input type=\"password\" name=\"password\"");
                BeginWriteAttribute("value", " value=\"", 369, "\"", 377, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Password""></p>
        <p class=""remember_me"">
            <label>
                <input type=""checkbox"" name=""remember_me"" id=""remember_me"">
                Remember me on this computer
            </label>
        </p>
        <p class=""submit""><input type=""submit"" name=""commit"" value=""Login""></p>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<div class=""login-help"">
    <p>Forgot your password? <a href=""#"">Click here to reset it</a>.</p>
</div>

</html>
<style>
    body {
        font: 13px/20px ""Lucida Grande"", Tahoma, Verdana, sans-serif;
        color: #404040;
        background: #0ca3d2;
    }

    .login {
        position: relative;
        margin: 30px auto;
        padding: 20px 20px 20px;
        width: 310px;
        background: white;
        border-radius: 3px;
        -webkit-box-shadow: 0 0 200px rgba(255, 255, 255, 0.5), 0 1px 2px rgba(0, 0, 0, 0.3);
        box-shadow: 0 0 200px rgba(255, 255, 255, 0.5), 0 1px 2px rgba(0, 0, 0, 0.3);
    }

        .login:before {
            content: '';
            position: absolute;
            top: -8px;
            right: -8px;
            bottom: -8px;
            left: -8px;
            z-index: -1;
            background: rgba(0, 0, 0, 0.08);
            border-radius: 4px;
        }

        .login h1 {
            margin: -20px -20px 21px");
            WriteLiteral(@";
            line-height: 40px;
            font-size: 15px;
            font-weight: bold;
            color: #555;
            text-align: center;
            text-shadow: 0 1px white;
            background: #f3f3f3;
            border-bottom: 1px solid #cfcfcf;
            border-radius: 3px 3px 0 0;
            background-image: -webkit-linear-gradient(top, whiteffd, #eef2f5);
            background-image: -moz-linear-gradient(top, whiteffd, #eef2f5);
            background-image: -o-linear-gradient(top, whiteffd, #eef2f5);
            background-image: linear-gradient(to bottom, whiteffd, #eef2f5);
            -webkit-box-shadow: 0 1px whitesmoke;
            box-shadow: 0 1px whitesmoke;
        }

        .login p {
            margin: 20px 0 0;
        }

            .login p:first-child {
                margin-top: 0;
            }

        .login input[type=text], .login input[type=password] {
            width: 278px;
        }

        .login p.remember_me {
     ");
            WriteLiteral(@"       float: left;
            line-height: 31px;
        }

            .login p.remember_me label {
                font-size: 12px;
                color: #777;
                cursor: pointer;
            }

            .login p.remember_me input {
                position: relative;
                bottom: 1px;
                margin-right: 4px;
                vertical-align: middle;
            }

        .login p.submit {
            text-align: right;
        }

    .login-help {
        margin: 20px 0;
        font-size: 11px;
        color: white;
        text-align: center;
        text-shadow: 0 1px #2a85a1;
    }

        .login-help a {
            color: #cce7fa;
            text-decoration: none;
        }

            .login-help a:hover {
                text-decoration: underline;
            }

    :-moz-placeholder {
        color: #c9c9c9 !important;
        font-size: 13px;
    }

    ::-webkit-input-placeholder {
        color: #ccc;
     ");
            WriteLiteral(@"   font-size: 13px;
    }

    input {
        font-family: 'Lucida Grande', Tahoma, Verdana, sans-serif;
        font-size: 14px;
    }

        input[type=text], input[type=password] {
            margin: 5px;
            padding: 0 10px;
            width: 200px;
            height: 34px;
            color: #404040;
            background: white;
            border: 1px solid;
            border-color: #c4c4c4 #d1d1d1 #d4d4d4;
            border-radius: 2px;
            outline: 5px solid #eff4f7;
            -moz-outline-radius: 3px;
            -webkit-box-shadow: inset 0 1px 3px rgba(0, 0, 0, 0.12);
            box-shadow: inset 0 1px 3px rgba(0, 0, 0, 0.12);
        }

            input[type=text]:focus, input[type=password]:focus {
                border-color: #7dc9e2;
                outline-color: #dceefc;
                outline-offset: 0;
            }

        input[type=submit] {
            padding: 0 18px;
            height: 29px;
            font-size: 12px;");
            WriteLiteral(@"
            font-weight: bold;
            color: #527881;
            text-shadow: 0 1px #e3f1f1;
            background: #cde5ef;
            border: 1px solid;
            border-color: #b4ccce #b3c0c8 #9eb9c2;
            border-radius: 16px;
            outline: 0;
            -webkit-box-sizing: content-box;
            -moz-box-sizing: content-box;
            box-sizing: content-box;
            background-image: -webkit-linear-gradient(top, #edf5f8, #cde5ef);
            background-image: -moz-linear-gradient(top, #edf5f8, #cde5ef);
            background-image: -o-linear-gradient(top, #edf5f8, #cde5ef);
            background-image: linear-gradient(to bottom, #edf5f8, #cde5ef);
            -webkit-box-shadow: inset 0 1px white, 0 1px 2px rgba(0, 0, 0, 0.15);
            box-shadow: inset 0 1px white, 0 1px 2px rgba(0, 0, 0, 0.15);
        }

            input[type=submit]:active {
                background: #cde5ef;
                border-color: #9eb9c2 #b3c0c8 #b4ccce;
    ");
            WriteLiteral("            -webkit-box-shadow: inset 0 0 3px rgba(0, 0, 0, 0.2);\r\n                box-shadow: inset 0 0 3px rgba(0, 0, 0, 0.2);\r\n            }\r\n\r\n    .lt-ie9 input[type=text], .lt-ie9 input[type=password] {\r\n        line-height: 34px;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WFManagementSystemClient.Models.UserProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
