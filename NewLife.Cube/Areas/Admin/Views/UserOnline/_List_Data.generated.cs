﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    
    #line 6 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/UserOnline/_List_Data.cshtml")]
    public partial class _Areas_Admin_Views_UserOnline__List_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.UserOnline>>
    {
        public _Areas_Admin_Views_UserOnline__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var enableSelect = this.EnableSelect();

            
            #line default
            #line hidden
WriteLiteral("\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\n    <thead>\n        <tr>\n");

            
            #line 19 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
             if (enableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\n");

            
            #line 22 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 761), Tuple.Create("\"", 800)
            
            #line 23 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 768), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 768), false)
);

WriteLiteral(">编号</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 852), Tuple.Create("\"", 893)
            
            #line 24 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 859), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Name"))
            
            #line default
            #line hidden
, 859), false)
);

WriteLiteral(">名称</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 945), Tuple.Create("\"", 987)
            
            #line 25 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 952), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Times"))
            
            #line default
            #line hidden
, 952), false)
);

WriteLiteral(">次数</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1039), Tuple.Create("\"", 1082)
            
            #line 26 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1046), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Status"))
            
            #line default
            #line hidden
, 1046), false)
);

WriteLiteral(">状态</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1134), Tuple.Create("\"", 1181)
            
            #line 27 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1141), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("OnlineTime"))
            
            #line default
            #line hidden
, 1141), false)
);

WriteLiteral(">在线时间</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1235), Tuple.Create("\"", 1280)
            
            #line 28 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1242), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateIP"))
            
            #line default
            #line hidden
, 1242), false)
);

WriteLiteral(">创建地址</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1334), Tuple.Create("\"", 1384)
            
            #line 29 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1341), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateAddress"))
            
            #line default
            #line hidden
, 1341), false)
);

WriteLiteral(">物理地址</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1438), Tuple.Create("\"", 1485)
            
            #line 30 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1445), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateTime"))
            
            #line default
            #line hidden
, 1445), false)
);

WriteLiteral(">创建时间</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1539), Tuple.Create("\"", 1586)
            
            #line 31 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1546), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateTime"))
            
            #line default
            #line hidden
, 1546), false)
);

WriteLiteral(">修改时间</a></th>\n");

            
            #line 32 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 32 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
             if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">操作</th>\n");

            
            #line 35 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\n    </thead>\n    <tbody>\n");

            
            #line 39 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 39 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\n");

            
            #line 42 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                 if (enableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1989), Tuple.Create("\"", 2007)
            
            #line 44 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 1997), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 1997), false)
);

WriteLiteral(" /></td>\n");

            
            #line 45 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 46 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                                                 Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");

            
            #line 47 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 48 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                  Write(entity.Times.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td");

WriteLiteral(" style=\"max-width:600px;overflow:hidden;white-space: nowrap;text-overflow: ellips" +
"is;\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2336), Tuple.Create("\"", 2358)
            
            #line 49 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                , Tuple.Create(Tuple.Create("", 2344), Tuple.Create<System.Object, System.Int32>(entity.Status
            
            #line default
            #line hidden
, 2344), false)
);

WriteLiteral(">");

            
            #line 49 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                                                                                                           Write(entity.Status);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 50 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                                  Write(entity.OnlineTime.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");

            
            #line 51 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.CreateIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");

            
            #line 52 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.CreateAddress);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");

            
            #line 53 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.CreateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");

            
            #line 54 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
               Write(entity.UpdateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\n");

            
            #line 55 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 55 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 58 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\n                    </td>\n");

            
            #line 60 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\n");

            
            #line 62 "..\..\Areas\Admin\Views\UserOnline\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\n</table>");

        }
    }
}
#pragma warning restore 1591
