#pragma checksum "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3c1fe282468d31b498716146c749c42a65c07c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Pages_User), @"mvc.1.0.razor-page", @"/Pages/User.cshtml")]
namespace WebApp.Pages
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
#line 1 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\_ViewImports.cshtml"
using WebApp.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c1fe282468d31b498716146c749c42a65c07c0", @"/Pages/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d12f322e13ed74b138a0957b605ec52ca5247b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_User : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
  
    Layout = "_LayoutUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\">\r\n\r\n<div class=\"container-fluid\">\r\n  <div class=\"row content\">\r\n    \r\n<div class=\"col-sm-9\">\r\n");
#nullable restore
#line 13 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
  
    ViewBag.items = ViewData["Data"];
    //LANJUT DISINI OK//
    //mau detect apakah user login kalo ga login komen ga tampil
    ViewBag.user = ViewData["Data-user"];
    var a = ViewBag.items;
    var is_login = ViewBag.user;
    
    foreach(var item in a){

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <div class=\"col-md-10 blogShort\">\r\n                     <br>\r\n                     <h2 style=\"color:black\">");
#nullable restore
#line 24 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
                                        Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                     <img");
            BeginWriteAttribute("src", " src=", 699, "", 715, 1);
#nullable restore
#line 25 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
WriteAttributeValue("", 704, item.image, 704, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"post img\" class=\"pull-left img-responsive thumb margin10 img-thumbnail\">\r\n                     <article><p>\r\n                         ");
#nullable restore
#line 27 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
                    Write(item.highlight);

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n                         </p></article>\r\n                     <button class=\"btn btn-blog pull-right marginBottom10\"");
            BeginWriteAttribute("onclick", " onclick=\"", 992, "\"", 1058, 5);
            WriteAttributeValue("", 1002, "window.location.href=\'/Read?id=", 1002, 31, true);
#nullable restore
#line 29 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
WriteAttributeValue("", 1033, item.id, 1033, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1041, "&login=", 1041, 7, true);
#nullable restore
#line 29 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
WriteAttributeValue("", 1048, is_login, 1048, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1057, "\'", 1057, 1, true);
            EndWriteAttribute();
            WriteLiteral(">READ MORE</button> <br>\r\n                 </div><br> ");
#nullable restore
#line 30 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"col-sm-3 sidenav\">\r\n        <br>\r\n      <h3><b>My Blog</b></h3>\r\n      <div class=\"input-group\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3c1fe282468d31b498716146c749c42a65c07c06779", async() => {
                WriteLiteral(@"
        <input type=""text"" name=""search"" class=""form-control"" placeholder=""Search Blog.."">
        <span class=""input-group-btn"">
          <button class=""btn btn-success"" type=""submit"">
            <span class=""glyphicon glyphicon-search""></span>
          </button>
        </span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <br>\r\n        <h4>Recent Posts</h4>\r\n");
#nullable restore
#line 47 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
          
            ViewBag.recent = ViewData["Recent"];
            foreach (var b in ViewBag.recent) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1740, "\"", 1761, 2);
            WriteAttributeValue("", 1747, "/Read?id=", 1747, 9, true);
#nullable restore
#line 50 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
WriteAttributeValue("", 1756, b.id, 1756, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
                                    Write(b.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <br><br>\r\n");
#nullable restore
#line 52 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\User.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
      </div></div>
      
</div></div>

<div class=""container"" style=""float:left"">
<div>
<nav aria-label=""..."">
  <ul class=""pagination marginleft"">
    <li class=""page-item"">
      <a class=""page-link"" href=""/Home/Paging?prev=1"">Previous</a>
    </li>
    <li class=""page-item""><a class=""page-link"" value=""1"" id=""btn1"" href=""/User?_crntpage=1"">1</a></li>
    <li class=""page-item""><a class=""page-link"" value=""2"" id=""btn2"" href=""/User?_crntpage=2"">2</a></li>
    <li class=""page-item""><a class=""page-link"" value=""3"" id=""btn3"" href=""/User?_crntpage=3"">3</a></li>
    <li class=""page-item""><a class=""page-link"" value=""4"" id=""btn4"" href=""/User?_crntpage=4"">4</a></li>
    <li class=""page-item""><a class=""page-link"" value=""5"" id=""btn5"" href=""/User?_crntpage=5"">5</a></li>
    <li class=""page-item""><a class=""page-link"" value=""6"" id=""btn6"" href=""/User?_crntpage=6"">6</a></li>
    <li class=""page-item"">
      <a class=""page-link"" href=""/Home/Paging?next=1"">Next</a>
    </li>
  </ul>
<br></div>

<br><br>");
            WriteLiteral("<br><br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserModel>)PageContext?.ViewData;
        public UserModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
