#pragma checksum "D:\project\Project_CMS_Api\Project_CMS_Api\Views\Customer\Booked_consignment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c305c927f179ea86d8206f16b29d627036d03b57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Booked_consignment), @"mvc.1.0.view", @"/Views/Customer/Booked_consignment.cshtml")]
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
#line 1 "D:\project\Project_CMS_Api\Project_CMS_Api\Views\_ViewImports.cshtml"
using Project_CMS_Api;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\project\Project_CMS_Api\Project_CMS_Api\Views\_ViewImports.cshtml"
using Project_CMS_Api.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c305c927f179ea86d8206f16b29d627036d03b57", @"/Views/Customer/Booked_consignment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"700d1f3f6469136f446a8db423f7215aa640872f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Booked_consignment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Operations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\project\Project_CMS_Api\Project_CMS_Api\Views\Customer\Booked_consignment.cshtml"
  
    ViewData["Title"] = "Booked_Consignment";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c305c927f179ea86d8206f16b29d627036d03b574355", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com/"">
    <link href=""https://fonts.googleapis.com/css2?family=Montserrat:wght@300;700&amp;family=Open+Sans:wght@400;700&amp;display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://preview.colorlib.com/theme/foundation2/fonts/icomoon/style.css"">
    <link rel=""stylesheet"" href=""https://preview.colorlib.com/theme/foundation2/css/tiny-slider.css"">
    <link rel=""stylesheet"" href=""https://preview.colorlib.com/theme/foundation2/css/aos.css"">
    <link rel=""stylesheet"" href=""https://preview.colorlib.com/theme/foundation2/css/glightbox.min.css"">
    <link rel=""stylesheet"" href=""https://preview.colorlib.com/theme/foundation2/css/style.css"">
    <link rel=""stylesheet"" href=""https://pro.fontawesome.com/releases/v5.10.0/css/all.css""
          integrity=""sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p"" crossorigi");
                WriteLiteral(@"n=""anonymous"" />
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css""
          integrity=""sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z"" crossorigin=""anonymous"">
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""
            integrity=""sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV"" crossorigin=""anonymous"">
    </script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/animejs/2.0.2/anime.min.js""></script>

    <title>Courier Management System</title>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c305c927f179ea86d8206f16b29d627036d03b577052", async() => {
                WriteLiteral(@"
    <div class=""site-mobile-menu site-navbar-target"">
        <div class=""site-mobile-menu-header"">
            <div class=""site-mobile-menu-close"">
                <span class=""icofont-close js-menu-toggle""></span>
            </div>
        </div>
        <div class=""site-mobile-menu-body""></div>
    </div>
    <nav class=""site-nav mt-3"">
        <div class=""container"">
            <div class=""site-navigation"">
                <a href=""#"" class=""logo m-0 float-start"">Courier Management System</a>
                <ul class=""js-clone-nav d-none d-lg-inline-block text-left site-menu float-end"">
                    <li><a href=""#"">Home</a></li>
                    <li class=""has-children"">
                        <a href=""#"">LogOut</a>
                    </li>
                </ul>
                <a href=""#"" class=""burger ml-auto float-right site-menu-toggle js-menu-toggle d-inline-block d-lg-none light"">
                    <span></span>
                </a>
            </div>
       ");
                WriteLiteral(@" </div>
    </nav>
    <div class=""hero"">
        <div class=""map"">
            <img src=""https://preview.colorlib.com/theme/foundation2/images/world-dotted-map.png"" alt=""Image"" class=""img-fluid"">
        </div>
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-7"">
                    <h1 class=""heading"" data-aos=""fade-up"">Order Placed 🤝</h1>
                    <hr>
                    <p class=""lead"" data-aos=""fade-up"" data-aos-delay=""100"" style=""font-size: x-large;"">Your order has been placed. We are happy to serve you!</p>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c305c927f179ea86d8206f16b29d627036d03b579063", async() => {
                    WriteLiteral("User Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
            </div>
        </div>
    </div>




    <div class=""site-footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4"">
                    <div class=""widget"">

                        <h3>Connect</h3>

                        <!-- Grid container -->
                        <div class=""container"">
                            <!-- Section: Social media -->
                            <section class=""mb-4"">

                                <!-- Twitter -->
                                <a class=""btn btn-light btn-floating m-1"" style=""background-color: #55acee;"" href=""https://twitter.com/LOGIN"" role=""button"">
                                    <i class=""fab fa-twitter""></i>
                                </a>

                                <!-- Google -->
                                <a class=""btn btn-light btn-floating m-1"" style=""background-color: #dd4b39;"" href=""https://accounts.google.com");
                WriteLiteral(@"/signin/v2/identifier?flowName=GlifWebSignIn&flowEntry=ServiceLogin"" role=""button"">
                                    <i class=""fab fa-google""></i>
                                </a>


                                <!-- Linkedin -->
                                <a class=""btn btn-light btn-floating m-1"" style=""background-color: #0082ca;"" href=""https://www.linkedin.com/login"" role=""button"">
                                    <i class=""fab fa-linkedin-in""></i>
                                </a>

                            </section>
                            <!-- Section: Social media -->
                        </div>


                    </div>
                </div>
            </div>


        </div>
    </div>

    <div id=""overlayer""></div>
    <div class=""loader"">
        <div class=""spinner-border text-primary"" role=""status"">
            <span class=""visually-hidden"">Loading...</span>
        </div>
    </div>
    <script src=""https://preview.colorlib.com/them");
                WriteLiteral(@"e/foundation2/js/bootstrap.bundle.min.js""></script>
    <script src=""https://preview.colorlib.com/theme/foundation2/js/tiny-slider.js""></script>
    <script src=""https://preview.colorlib.com/theme/foundation2/js/aos.js""></script>
    <script src=""https://preview.colorlib.com/theme/foundation2/js/glightbox.min.js""></script>
    <script src=""https://preview.colorlib.com/theme/foundation2/js/navbar.js""></script>
    <script src=""https://preview.colorlib.com/theme/foundation2/js/counter.js""></script>
    <script src=""https://preview.colorlib.com/theme/foundation2/js/custom.js""></script>

    <script async src=""https://www.googletagmanager.com/gtag/js?id=UA-23581568-13""></script>
    <script>
                    window.dataLayer = window.dataLayer || [];
                    function gtag(){dataLayer.push(arguments);}
                    gtag('js', new Date());

                    gtag('config', 'UA-23581568-13');
    </script>
");
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
            WriteLiteral("\r\n\r\n\r\n</html>\r\n");
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
