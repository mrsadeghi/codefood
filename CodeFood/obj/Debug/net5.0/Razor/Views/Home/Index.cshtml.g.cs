#pragma checksum "D:\MohammadReza\Projects\DontNetCore\CodeFood\CodeFood\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31372552f76f47ad813a684e1c02d1aa58328891"
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
#line 1 "D:\MohammadReza\Projects\DontNetCore\CodeFood\CodeFood\Views\_ViewImports.cshtml"
using CodeFood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MohammadReza\Projects\DontNetCore\CodeFood\CodeFood\Views\_ViewImports.cshtml"
using CodeFood.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31372552f76f47ad813a684e1c02d1aa58328891", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a883bf36b2b6a9bb884d2e9aa57f65685e26365", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-lg-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:0 auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\MohammadReza\Projects\DontNetCore\CodeFood\CodeFood\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .red-border {\r\n        border: 1px solid #F00;\r\n    }\r\n\r\n    #message-box {\r\n        display: none;\r\n    }\r\n</style>\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31372552f76f47ad813a684e1c02d1aa583288914293", async() => {
                WriteLiteral(@"
        <div class=""form-group input-group"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text""> <i class=""fa fa-user""></i> </span>
            </div>
            <input name=""FirstName"" id=""firstName"" class=""form-control"" placeholder=""First name"" type=""text"">
        </div> <!-- form-group// -->
        <div class=""form-group input-group"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text""> <i class=""fa fa-user""></i> </span>
            </div>
            <input name=""LastName"" id=""lastName"" class=""form-control"" placeholder=""Last name"" type=""text"">
        </div> <!-- form-group// -->
        <div class=""form-group input-group"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text""> <i class=""fa fa-envelope""></i> </span>
            </div>
            <input name=""Email"" id=""email"" class=""form-control"" placeholder=""Email address"" type=""email"">
        </div> <!-- form-");
                WriteLiteral(@"group// -->
        <div class=""form-group input-group"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text""> <i class=""fa fa-phone""></i> </span>
            </div>
            <input name=""PhoneNumber"" id=""phoneNumber"" class=""form-control"" placeholder=""Phone number"" type=""text"">
        </div> <!-- form-group// -->
        <div class=""form-group input-group"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text""> <i class=""fab fa-linkedin""></i> </span>
            </div>
            <input name=""LinkedInUrl"" id=""linkedInUrl"" class=""form-control"" placeholder=""LinkedIn URL"" type=""text"">
        </div> <!-- form-group// -->
        <div class=""form-group"">
            <button type=""button"" id=""createBtn"" class=""btn btn-primary btn-block""> Create Account  </button>
        </div> <!-- form-group// -->

        <div class=""alert alert-success"" id=""message-box"">
            <button type=""button"" class=""close"" data-dis");
                WriteLiteral("miss=\"alert\">x</button>\r\n            <strong id=\"message\"></strong>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
    $(document).ready(function () {
        $('#createBtn').click(function () {
            let $firstName = $('#firstName');
            let $lastName = $('#lastName');
            let $email = $('#email');
            let $phoneNumber = $('#phoneNumber');
            let $linkedInUrl = $('#linkedInUrl');
            !$firstName.val() ? $firstName.addClass('red-border') : $firstName.removeClass('red-border');
            !$lastName.val() ? $lastName.addClass('red-border') : $lastName.removeClass('red-border');
            !$email.val() ? $email.addClass('red-border') : $email.removeClass('red-border');
            !$phoneNumber.val() ? $phoneNumber.addClass('red-border') : $phoneNumber.removeClass('red-border');
            !$linkedInUrl.val() ? $linkedInUrl.addClass('red-border') : $linkedInUrl.removeClass('red-border');

            if (!$firstName.val() || !$lastName.val() || !$email.val() || !$phoneNumber.val() || !$linkedInUrl.val())
                r");
                WriteLiteral(@"eturn;
            let data = {
                firstName: $firstName.val(),
                lastName: $lastName.val(),
                email: $email.val(),
                phoneNumber: $phoneNumber.val(),
                linkedInUrl: $linkedInUrl.val(),
            }
            $.ajax({
                method: ""POST"",
                url: """);
#nullable restore
#line 81 "D:\MohammadReza\Projects\DontNetCore\CodeFood\CodeFood\Views\Home\Index.cshtml"
                 Write(Url.Action("Register"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                data:data
            }).done(function (result) {
                debugger
                let $messageBox = $('#message-box');
                let $message = $('#message');
                $messageBox.hide();
                $messageBox.removeClass('alert-success');
                $messageBox.removeClass('alert-danger');
                if (result.isSuccess == true) {
                    $messageBox.addClass('alert-success');
                }
                else {
                    $messageBox.addClass('alert-danger');
                }
                $message.text(result.message);

                $messageBox.fadeTo(2000, 500)//.slideUp(500, function () {
                    //$messageBox.slideUp(500);
                //});
            });
        })
    })
    </script>
");
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