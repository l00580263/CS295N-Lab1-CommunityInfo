#pragma checksum "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\Info\People.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dac113e3e1c86795d269372ff471cd67691ad50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_People), @"mvc.1.0.view", @"/Views/Info/People.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Info/People.cshtml", typeof(AspNetCore.Views_Info_People))]
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
#line 1 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\_ViewImports.cshtml"
using CommunityInformation;

#line default
#line hidden
#line 2 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\_ViewImports.cshtml"
using CommunityInformation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dac113e3e1c86795d269372ff471cd67691ad50", @"/Views/Info/People.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ffa799a70419aec2cd173beee98bc5576b95231", @"/Views/_ViewImports.cshtml")]
    public class Views_Info_People : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommunityInformation.Models.PersonEntry>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\Info\People.cshtml"
  
    //Layout = null;

#line default
#line hidden
            BeginContext(77, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n\r\n");
            EndContext();
            BeginContext(108, 198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35c0f4b82cd14c63b643607b1877786f", async() => {
                BeginContext(114, 100, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Donbass People</title>\r\n    ");
                EndContext();
                BeginContext(214, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c66e33147cd429ea1c67b303144d618", async() => {
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
                BeginContext(283, 16, true);
                WriteLiteral("\r\n    <link />\r\n");
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
            BeginContext(306, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(312, 2380, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0da1adc378e41b28a8d36f9c34c38f3", async() => {
                BeginContext(318, 79, true);
                WriteLiteral("\r\n    <h1 class=\"text-center text-primary\">People of Donbass</h1>\r\n    <br>\r\n\r\n");
                EndContext();
#line 22 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\Info\People.cshtml"
      
        List<PersonEntry> peoples = new List<PersonEntry>();
        peoples.Add(new PersonEntry()
        {
            Name = "Denis Vladimirovich Pushilin",
            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ed/2017-09-28_Denis_Pushilin.jpg/528px-2017-09-28_Denis_Pushilin.jpg",
            Description = @" Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore
            et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip
            ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat
            nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id
            est laborum."
        });

        peoples.Add(new PersonEntry()
        {
            Name = "Leonid Ivanovich Pasechnik",
            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/3/3b/%D0%9B%D0%B5%D0%BE%D0%BD%D0%B8%D0%B4_%D0%9F%D0%B0%D1%81%D0%B5%D1%87%D0%BD%D0%B8%D0%BA_2016.png",
            Description = @" Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore
            et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip
            ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat
            nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id
            est laborum."
        });
    

#line default
#line hidden
                BeginContext(2087, 35, true);
                WriteLiteral("\r\n\r\n\r\n    <div class=\"container\">\r\n");
                EndContext();
#line 50 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\Info\People.cshtml"
          
            foreach (var e in peoples)
            {

#line default
#line hidden
                BeginContext(2189, 195, true);
                WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-lg-4\">\r\n                        <div class=\"thumbnail\">\r\n                            <img class=\"img-rounded img-responsive\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2384, "\"", 2401, 1);
#line 56 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\Info\People.cshtml"
WriteAttributeValue("", 2390, e.ImageURL, 2390, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2402, 137, true);
                WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-8\">\r\n                        <h3>");
                EndContext();
                BeginContext(2540, 6, false);
#line 60 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\Info\People.cshtml"
                       Write(e.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2546, 31, true);
                WriteLiteral("</h3>\r\n                        ");
                EndContext();
                BeginContext(2578, 13, false);
#line 61 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\Info\People.cshtml"
                   Write(e.Description);

#line default
#line hidden
                EndContext();
                BeginContext(2591, 54, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
                EndContext();
#line 64 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\Info\People.cshtml"
            }
        

#line default
#line hidden
                BeginContext(2671, 14, true);
                WriteLiteral("    </div>\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2692, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommunityInformation.Models.PersonEntry> Html { get; private set; }
    }
}
#pragma warning restore 1591
