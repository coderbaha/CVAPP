#pragma checksum "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\SkillComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06f18d470d786f7a0635811faa56cad7fc0d8fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f18d470d786f7a0635811faa56cad7fc0d8fee", @"/Views/Shared/Components/SkillComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1ff0851eae5c75daee8425e24ec616310a8cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SkillComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.Concrete.DTOs.SkillDtos.SkillListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"resume-section\" id=\"skills\">\n    <div class=\"resume-section-content\">\n        <h2 class=\"mb-5\">Programlama Bilgisi</h2>\n        <ul class=\"fa-ul mb-0\">\n");
#nullable restore
#line 6 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\SkillComponent\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\n                    <span class=\"fa-li\"><i class=\"fas fa-check\"></i></span>\n                    ");
#nullable restore
#line 10 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\SkillComponent\Default.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </li>\n");
#nullable restore
#line 12 "C:\TFS\THE Hiring Challenge\BAHADIRASIK\CVAPP\CVAPP\WebUI\Views\Shared\Components\SkillComponent\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.Concrete.DTOs.SkillDtos.SkillListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591