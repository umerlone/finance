﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.WebsiteBuilder;
    using MixERP.Finance;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Setup/CashFlowSetups.cshtml")]
    public partial class _Views_Setup_CashFlowSetups_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Setup_CashFlowSetups_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Setup\CashFlowSetups.cshtml"
  
    ViewBag.Title = "Cash Flow Setups";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    var scrudFactory = new Object();\r\n\r\n    scrudFactory.title = \"C" +
"ash Flow Setups\";\r\n\r\n    scrudFactory.viewAPI = \"/api/views/finance/cash-flow-se" +
"tup-scrud-view\";\r\n    scrudFactory.viewTableName = \"finance.cash_flow_setup_scru" +
"d_view\";\r\n\r\n    scrudFactory.formAPI = \"/api/forms/finance/cash-flow-setup\";\r\n  " +
"  scrudFactory.formTableName = \"finance.cash_flow_setup\";\r\n\r\n    scrudFactory.ex" +
"cludedColumns = [\"audit_user_id\", \"audit_ts\"];\r\n\r\n    scrudFactory.allowDelete =" +
" true;\r\n    scrudFactory.allowEdit = true;\r\n\r\n    scrudFactory.live = \"Name\";\r\n\r" +
"\n    scrudFactory.card = {\r\n        header: \"CashFlowHeading\",\r\n        descript" +
"ion: \"AccountMaster\"        \r\n    };\r\n\r\n    //scrudFactory.layout = [\r\n    //   " +
" {\r\n    //        tab: \"\",\r\n    //        fields: [\r\n    //            [\"\", \"\"]," +
"\r\n    //            [\"\", \"\"],\r\n    //        ]\r\n    //    }\r\n    //];\r\n\r\n    scr" +
"udFactory.keys = [\r\n        {\r\n            property: \"CashFlowHeadingId\",\r\n     " +
"       url: \'/api/forms/finance/cash-flow-headings/display-fields\',\r\n           " +
" data: null,\r\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n  " +
"      },\r\n        {\r\n            property: \"AccountMasterId\",\r\n            url: " +
"\'/api/forms/finance/account-masters/display-fields\',\r\n            data: null,\r\n " +
"           valueField: \"Key\",\r\n            textField: \"Value\"\r\n        }\r\n    ];" +
"\r\n\r\n\r\n\r\n    $.get(\'/ScrudFactory/View.html\', function (view) {\r\n        $.get(\'/" +
"ScrudFactory/Form.html\', function (form) {\r\n            $(\"#ScrudFactoryView\").h" +
"tml(view);\r\n            $(\"#ScrudFactoryForm\").html(form);\r\n            $.cached" +
"Script(\"/assets/js/scrudfactory-view.js\");\r\n            $.cachedScript(\"/assets/" +
"js/scrudfactory-form.js\");\r\n        });\r\n    });\r\n</script>\r\n\r\n<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>");

        }
    }
}
#pragma warning restore 1591
