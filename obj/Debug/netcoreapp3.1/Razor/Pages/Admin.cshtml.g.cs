#pragma checksum "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2bd43492b2031cab3e7de78ea0e5dea452ac8fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Pages_Admin), @"mvc.1.0.razor-page", @"/Pages/Admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bd43492b2031cab3e7de78ea0e5dea452ac8fb", @"/Pages/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d12f322e13ed74b138a0957b605ec52ca5247b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
  
    ViewData["Title"] = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-center"">Article List</h2>

<button id=""Add Article"" type=""button"" class=""btn btn-primary marginleft"" value=""Admin"" onclick=""location.href='/Add'""><span class=""glyphicon glyphicon-plus""></span> New Article</button><br> <br>
<div class=""margin"">
<table class=""table"">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">No</th>
      <th scope=""col"">Title</th>
      <th scope=""col"">Image</th>
      <th scope=""col"">Highlight</th>
      <th scope=""col"">Updated</th>
      <th scope=""col"">Action</th>
      <th scope=""col""></th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 24 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
          var count = 0; 
          ViewBag.items = ViewData["Data"];
          var articles = ViewBag.items;
          foreach(var a in articles) {
            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <th>");
#nullable restore
#line 30 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
     Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <td>");
#nullable restore
#line 31 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
     Write(a.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td><img style=\"width:120px\"");
            BeginWriteAttribute("src", " src=", 941, "", 954, 1);
#nullable restore
#line 32 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
WriteAttributeValue("", 946, a.image, 946, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n      <td>");
#nullable restore
#line 33 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
     Write(a.highlight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 34 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
     Write(a.Edited_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>\r\n              <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1076, "\"", 1089, 1);
#nullable restore
#line 36 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
WriteAttributeValue("", 1084, a.id, 1084, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n              <button type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("id", " id=\"", 1152, "\"", 1167, 2);
            WriteAttributeValue("", 1157, "edit-", 1157, 5, true);
#nullable restore
#line 37 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
WriteAttributeValue("", 1162, a.id, 1162, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 37 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
                                                                                Write(a.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-title=\"");
#nullable restore
#line 37 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
                                                                                                   Write(a.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-content=\"");
#nullable restore
#line 37 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
                                                                                                                           Write(a.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-highlight=\"");
#nullable restore
#line 37 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
                                                                                                                                                       Write(a.highlight);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-image=\"");
#nullable restore
#line 37 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
                                                                                                                                                                                 Write(a.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#exampleModal\">Edit</button>\r\n");
            WriteLiteral("      </td>\r\n      <td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2bd43492b2031cab3e7de78ea0e5dea452ac8fb8604", async() => {
                WriteLiteral("\r\n              <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1570, "\"", 1587, 2);
                WriteAttributeValue("", 1578, "rmv-", 1578, 4, true);
#nullable restore
#line 42 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
WriteAttributeValue("", 1582, a.id, 1582, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n              <button id=\"btn\" class=\"btn btn-danger\">Remove</button>\r\n            ");
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
            WriteLiteral("\r\n      </td>\r\n    </tr> ");
#nullable restore
#line 46 "D:\TRAININGC#\FEBRUARI\25Feb\WebApp\Pages\Admin.cshtml"
          }
      

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table> </div> 


<div class=""modal fade"" id=""myModal"" role=""dialog"">
    <div class=""modal-dialog"">
    
      <!-- Modal content-->
      <div class=""modal-content"">
        <div class=""modal-header"">
          <h4 class=""modal-title"">Edit Article</h4>
        </div>
        <div class=""modal-body"">
          <input  id=""title"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 2074, "\"", 2082, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"title\" placeholder=\"  Title\">\r\n                <input  id=\"image\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2167, "\"", 2175, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"cart\"  placeholder=\"  Image (url)\">\r\n                <input  id=\"desc\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2265, "\"", 2273, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"cart\"  placeholder=\"  Highlight\">\r\n                <input  id=\"price\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2362, "\"", 2370, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"cart\"  placeholder=\"  Content\">\r\n                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2bd43492b2031cab3e7de78ea0e5dea452ac8fb12104", async() => {
                WriteLiteral("\r\n              <button id=\"btnedit\" class=\"btn btn-success\">Edit</button>\r\n                 ");
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
            WriteLiteral(@"
        </div>
        <div class=""modal-footer"">
          <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
        </div>
      </div>    
    </div>
  </div>
</div>


<div class=""modal"" id=""exampleModal"" tabindex=""-1"" role=""dialog"">
      <div class=""modal-dialog"" role=""document"" >
        <div class=""modal-content"" style=""width:500px;height:550px"">
          <div class=""modal-header"">
            <h4 class=""modal-title""><b>Update Data</b></h4>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
              <span aria-hidden=""true"">&times;</span>
            </button>
          </div>
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2bd43492b2031cab3e7de78ea0e5dea452ac8fb14366", async() => {
                WriteLiteral("\r\n          <div class=\"modal-body\">\r\n            <label for=\"title\"><b>Title</b></label><br>\r\n            <input type=\"text\" name=\"edit\" class=\"form-control\" value=\"update\" hidden>\r\n            <input type=\"text\" name=\"id\" id=\"id1\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3519, "\"", 3527, 0);
                EndWriteAttribute();
                WriteLiteral(@" hidden>
            <input type=""text"" name=""title"" id=""title1"" class=""form-control"">
            <br>
            <label for=""highlight""><b>Highlight</b></label><br>
            <input type=""text""  name=""highlight"" id=""description1"" class=""form-control"">
            <br>
            <label for=""content""><b>Content</b></label><br>
            <input type=""text""  name=""content"" id=""description1"" class=""form-control"">
            <br>
            <label for=""image""><b>Image</b></label><br>
            <input type=""text"" name=""image"" id=""image1"" class=""form-control"">
          </div>
          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" style=""background-color: red;color:white;"">Close</button>
            <button type=""submit"" class=""btn btn-primary"" id=""savechanges"" id=""edit"">Save changes</button>
          </div>
          ");
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
            WriteLiteral(@"
        </div>
      </div>
    </div>
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js""
    integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n""
    crossorigin=""anonymous""></script>
<script>
    $(document).ready(function(){
        console.log('Masuk Sini')
        $('#exampleModal').on('show.bs.modal', function (e) {
        $('#id1').val($(e.relatedTarget).data('id'))
        $('#title1').val($(e.relatedTarget).data('title'))
        $('#description1').val($(e.relatedTarget).data('detail'))
        $('#image1').val($(e.relatedTarget).data('image'))
    })
})
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdminModel>)PageContext?.ViewData;
        public AdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591