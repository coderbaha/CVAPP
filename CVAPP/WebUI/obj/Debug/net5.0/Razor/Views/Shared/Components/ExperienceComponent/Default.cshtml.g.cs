#pragma checksum "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "816d917690c6c14ea639d37c90263a5ec8f365b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ExperienceComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ExperienceComponent/Default.cshtml")]
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
#line 1 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"816d917690c6c14ea639d37c90263a5ec8f365b3", @"/Views/Shared/Components/ExperienceComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1ff0851eae5c75daee8425e24ec616310a8cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ExperienceComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.Concrete.DTOs.ExperienceDtos.ExperienceListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"resume-section\" id=\"experience\">\n    <div class=\"resume-section-content\">\n        <h2 class=\"mb-5\">Deneyim</h2>\n");
#nullable restore
#line 5 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-flex flex-column flex-md-row justify-content-between mb-5\">\n    <div class=\"flex-grow-1\">\n        <h3 class=\"mb-0\">");
#nullable restore
#line 9 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <div class=\"subheading mb-3\">");
#nullable restore
#line 10 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
                                Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <p>");
#nullable restore
#line 11 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n    <div class=\"flex-shrink-0\">\n        <span class=\"text-primary\">\n            ");
#nullable restore
#line 15 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
       Write(item.StartDate.ToString("Y"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -\n");
#nullable restore
#line 16 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
          
            if (item.EndDate.HasValue)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 19 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
                  Write(((DateTime)item.EndDate).ToString("Y"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 20 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Devam Ediyor</span>\n");
#nullable restore
#line 24 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </span>\n</div>\n</div>");
#nullable restore
#line 28 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.Concrete.DTOs.ExperienceDtos.ExperienceListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
