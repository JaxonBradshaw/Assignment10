#pragma checksum "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "198246c24ddfadda7f9a2d48f7184a6206fb16df"
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
#line 1 "C:\Users\Jaxon\source\repos\Assignment10\Views\_ViewImports.cshtml"
using Assignment10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jaxon\source\repos\Assignment10\Views\_ViewImports.cshtml"
using Assignment10.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jaxon\source\repos\Assignment10\Views\_ViewImports.cshtml"
using Assignment10.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"198246c24ddfadda7f9a2d48f7184a6206fb16df", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"199e4e7a0109d67a8c68bacf4b0295522127f8c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
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
        private global::Assignment10.Infrastructure.PaginationTagHelper __Assignment10_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 7 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
Write(Model.Team);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
 foreach (var x in Model.Bowlers)
{
    
    //making the bowler and their info drop down

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container, text-left"">
        <div class=""panel-group"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title p-3"">
                        <a data-toggle=""collapse""");
            BeginWriteAttribute("href", " href=\"", 456, "\"", 475, 2);
            WriteAttributeValue("", 463, "#", 463, 1, true);
#nullable restore
#line 18 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
WriteAttributeValue("", 464, x.BowlerId, 464, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
                                                                 Write(x.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
                                                                                    Write(x.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </h4>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 590, "\"", 606, 1);
#nullable restore
#line 21 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
WriteAttributeValue("", 595, x.BowlerId, 595, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n                    <div class=\"panel-body\">\r\n                        <p>First Name: ");
#nullable restore
#line 23 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
                                  Write(x.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Middle Initial: ");
#nullable restore
#line 24 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
                                      Write(x.BowlerMiddleInit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Last Name: ");
#nullable restore
#line 25 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
                                 Write(x.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Address: ");
#nullable restore
#line 26 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
                               Write(x.BowlerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>City: ");
#nullable restore
#line 27 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
                            Write(x.BowlerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>State: ");
#nullable restore
#line 28 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
                             Write(x.BowlerState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Zip: ");
#nullable restore
#line 29 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
                           Write(x.BowlerZip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Phone Number: ");
#nullable restore
#line 30 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
                                    Write(x.BowlerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "198246c24ddfadda7f9a2d48f7184a6206fb16df8200", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            __Assignment10_Infrastructure_PaginationTagHelper = CreateTagHelper<global::Assignment10.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__Assignment10_Infrastructure_PaginationTagHelper);
#nullable restore
#line 39 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
__Assignment10_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumberingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __Assignment10_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-team", "Assignment10.Infrastructure.PaginationTagHelper", "KeyValuePairs"));
            }
#nullable restore
#line 39 "C:\Users\Jaxon\source\repos\Assignment10\Views\Home\Index.cshtml"
__Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs["team"] = Model.Team;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-team", __Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs["team"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
