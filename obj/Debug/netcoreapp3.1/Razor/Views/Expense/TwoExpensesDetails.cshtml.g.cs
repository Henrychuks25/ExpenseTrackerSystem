#pragma checksum "C:\Users\henri\Desktop\Cyborg\Projects\Upwork\Expense-Tracker\Views\Expense\TwoExpensesDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1643437d3eb4d9eb828f4f5506e3771557ff25f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expense_TwoExpensesDetails), @"mvc.1.0.view", @"/Views/Expense/TwoExpensesDetails.cshtml")]
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
#line 1 "C:\Users\henri\Desktop\Cyborg\Projects\Upwork\Expense-Tracker\Views\_ViewImports.cshtml"
using Expense_Tracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\henri\Desktop\Cyborg\Projects\Upwork\Expense-Tracker\Views\_ViewImports.cshtml"
using Expense_Tracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1643437d3eb4d9eb828f4f5506e3771557ff25f8", @"/Views/Expense/TwoExpensesDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d820c63564d32ba99a879ed4c383db21c81ee09", @"/Views/_ViewImports.cshtml")]
    public class Views_Expense_TwoExpensesDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Expense_Tracker.Models.Expense>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<p>Breakdown of Expenses for two date range selection</p>\r\n<table class=\"table table-striped table-bordered\" style=\"width:100%\" id=\"globeTable\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\henri\Desktop\Cyborg\Projects\Upwork\Expense-Tracker\Views\Expense\TwoExpensesDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\henri\Desktop\Cyborg\Projects\Upwork\Expense-Tracker\Views\Expense\TwoExpensesDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpenseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\henri\Desktop\Cyborg\Projects\Upwork\Expense-Tracker\Views\Expense\TwoExpensesDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\henri\Desktop\Cyborg\Projects\Upwork\Expense-Tracker\Views\Expense\TwoExpensesDetails.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\henri\Desktop\Cyborg\Projects\Upwork\Expense-Tracker\Views\Expense\TwoExpensesDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\henri\Desktop\Cyborg\Projects\Upwork\Expense-Tracker\Views\Expense\TwoExpensesDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExpenseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\henri\Desktop\Cyborg\Projects\Upwork\Expense-Tracker\Views\Expense\TwoExpensesDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n             \r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\henri\Desktop\Cyborg\Projects\Upwork\Expense-Tracker\Views\Expense\TwoExpensesDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Expense_Tracker.Models.Expense>> Html { get; private set; }
    }
}
#pragma warning restore 1591
