#pragma checksum "C:\Users\Radovan\Desktop\RVAS PROJEKAT\SolRVAS-Hotel\RVAS-Hotel\Views\Room\RoomAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b096bc400f2774a1f29cc9b69ccf33afe1fd0490"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_RoomAdd), @"mvc.1.0.razor-page", @"/Views/Room/RoomAdd.cshtml")]
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
#line 1 "C:\Users\Radovan\Desktop\RVAS PROJEKAT\SolRVAS-Hotel\RVAS-Hotel\Views\_ViewImports.cshtml"
using RVAS_Hotel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Radovan\Desktop\RVAS PROJEKAT\SolRVAS-Hotel\RVAS-Hotel\Views\_ViewImports.cshtml"
using RVAS_Hotel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b096bc400f2774a1f29cc9b69ccf33afe1fd0490", @"/Views/Room/RoomAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0f1b788e745532e7cf29cbc6d64415e51f8ee3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_RoomAdd : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Add room"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b096bc400f2774a1f29cc9b69ccf33afe1fd04905754", async() => {
                WriteLiteral("\r\n    <title>Add a room</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b096bc400f2774a1f29cc9b69ccf33afe1fd04906753", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n    <div class=\"col-md-12\">\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Radovan\Desktop\RVAS PROJEKAT\SolRVAS-Hotel\RVAS-Hotel\Views\Room\RoomAdd.cshtml"
         using (Html.BeginForm("AddRoom", "RoomController", FormMethod.Post, new { encType = "multipart/form-data" }))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Radovan\Desktop\RVAS PROJEKAT\SolRVAS-Hotel\RVAS-Hotel\Views\Room\RoomAdd.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b096bc400f2774a1f29cc9b69ccf33afe1fd04907737", async() => {
                    WriteLiteral(@"

                <div class=""col-md-5"">
                    <div class=""form-group"">
                        <label for=""RoomNumber"">Room number</label>
                        <input type=""text"" class=""form-control"" id=""RoomNumber"" name=""RoomNumber"" aria-describedby=""RoomNumber"" placeholder=""Enter room number"">
                        <small id=""RoomNumber"" class=""form-text text-muted"">Please enter the room number.</small>
                    </div>


                    <div class=""form-group"">
                        <label for=""NumberOfBeds"">Number of beds</label>
                        <input type=""text"" class=""form-control"" id=""NumberOfBeds"" name=""NumberOfBeds"" aria-describedby=""NumberOfBeds"" placeholder=""Enter number of beds"">
                        <small id=""NumberOfBeds"" class=""form-text text-muted"">Please enter the number of beds in room.</small>
                    </div>

                    <div class=""form-group"">
                        <label for=""Price"">Price </label>
  ");
                    WriteLiteral(@"                      <input type=""text"" class=""form-control"" id=""Price"" name=""Price"" aria-describedby=""Price"" placeholder=""Enter price..."">

                    </div>
                </div>
                <div class=""col-md-5"">
                    <div class=""form-group"">
                        <label for=""Floor"">Floor </label>
                        <input type=""text"" class=""form-control"" id=""Floor"" name=""Floor"" aria-describedby=""Floor"" placeholder=""Enter the room floor"">
                        <small id=""Floor"" class=""form-text text-muted"">Please enter the floor of the room.</small>

                    </div>



                    <label for=""IsOccupied"">Is the room occupied?</label>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""IsOccupied"" id=""IsOccupied"" value=""Yes"" checked>
                        <label class=""form-check-label"" for=""IsOccupied"">
                            Yes
                        </l");
                    WriteLiteral(@"abel>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""IsOccupied"" id=""IsOccupied"" value=""No"">
                        <label class=""form-check-label"" for=""IsOccupied"">
                            No
                        </label>
                    </div>


                    <label for=""HasMiniFridge"">Does the room have a mini fridge?</label>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""HasMiniFridge"" id=""HasMiniFridge"" value=""Yes"" checked>
                        <label class=""form-check-label"" for=""HasMiniFridge"">
                            Yes
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""HasMiniFridge"" id=""HasMiniFridge"" value=""No"">
                        <label class=""form-che");
                    WriteLiteral(@"ck-label"" for=""HasMiniFridge"">
                            No
                        </label>
                    </div>



                    <div class=""form-group mt-3"">
                        <label for=""ImageName"">Upload image</label>
                        <input type=""file"" class=""form-control-file"" id=""ImageName"" name=""ImageName"">
                    </div>

                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b096bc400f2774a1f29cc9b69ccf33afe1fd049011757", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 93 "C:\Users\Radovan\Desktop\RVAS PROJEKAT\SolRVAS-Hotel\RVAS-Hotel\Views\Room\RoomAdd.cshtml"
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        \r\n\r\n    \r\n\r\n\r\n\r\n");
#nullable restore
#line 103 "C:\Users\Radovan\Desktop\RVAS PROJEKAT\SolRVAS-Hotel\RVAS-Hotel\Views\Room\RoomAdd.cshtml"
     if (TempData["alertMessage"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script type=\"text/javascript\">\r\n                    alert(\'");
#nullable restore
#line 106 "C:\Users\Radovan\Desktop\RVAS PROJEKAT\SolRVAS-Hotel\RVAS-Hotel\Views\Room\RoomAdd.cshtml"
                      Write(TempData["alertMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n        </script>\r\n");
#nullable restore
#line 108 "C:\Users\Radovan\Desktop\RVAS PROJEKAT\SolRVAS-Hotel\RVAS-Hotel\Views\Room\RoomAdd.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Room_RoomAdd> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Room_RoomAdd> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Room_RoomAdd>)PageContext?.ViewData;
        public Views_Room_RoomAdd Model => ViewData.Model;
    }
}
#pragma warning restore 1591
