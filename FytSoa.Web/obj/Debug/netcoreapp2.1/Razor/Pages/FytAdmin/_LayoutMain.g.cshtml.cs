#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7579a5eac9b784e1849fceaa30c96879a966fa27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Pages_FytAdmin__LayoutMain), @"mvc.1.0.view", @"/Pages/FytAdmin/_LayoutMain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/FytAdmin/_LayoutMain.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Pages_FytAdmin__LayoutMain))]
namespace FytSoa.Web.Pages.FytAdmin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7579a5eac9b784e1849fceaa30c96879a966fa27", @"/Pages/FytAdmin/_LayoutMain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin__LayoutMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/layui/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/css/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/css/nprogress.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/css/app.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/modules/vue.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/img/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/echarts.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/macarons.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/nprogress.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(59, 592, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63f821e0fcea4cc89824f8fdd60c58b2", async() => {
                BeginContext(65, 169, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    ");
                EndContext();
                BeginContext(234, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31d239e39333425eb1c86da004007a76", async() => {
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
                BeginContext(293, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(299, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "910c91ad2b8d4be7b94d169a82576f0c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(353, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(359, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "903fbd636d1d42299ba26e5959b3690a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(418, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(424, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "893ebf813f2b4faeb75fdb68a4cb80a7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(475, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(481, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dde0d6a4d0d744e4a8754cb4b3cc54d7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(554, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(560, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88c4d030775400984b334b84d23d5f8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(607, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(621, 13, false);
#line 15 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(634, 10, true);
                WriteLiteral("</title>\r\n");
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
            BeginContext(651, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(653, 9026, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1175a1f7a334b09895752a2785e3665", async() => {
                BeginContext(659, 248, true);
                WriteLiteral("\r\n    <div class=\"layui-layout layui-layout-admin\">\r\n        <div class=\"layui-header\">\r\n            <div class=\"layui-logo\">FytErp-SaaS平台</div>\r\n            <ul class=\"layui-nav layui-layout-left\">\r\n                <li class=\"layui-nav-item pr50\">");
                EndContext();
                BeginContext(907, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b891c481901405593403b954e5727ee", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(959, 552, true);
                WriteLiteral(@"</li>
            </ul>
            <ul class=""layui-nav layui-layout-right"">
                <li class=""layui-nav-item"">
                    <a data-pjax href=""/fytadmin/default""><i class=""layui-icon""></i></a>
                </li>
                <li class=""layui-nav-item"">
                    <a href=""/demo/""><i class=""layui-icon""></i><span class=""layui-badge-dot""></span></a>
                </li>
                <li class=""layui-nav-item"">
                    <a href=""javascript:;"">
                        <span class=""username"">");
                EndContext();
                BeginContext(1512, 78, false);
#line 33 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
                                          Write(User.Identities.First(u => u.IsAuthenticated).FindFirst(ClaimTypes.Name).Value);

#line default
#line hidden
                EndContext();
                BeginContext(1590, 65, true);
                WriteLiteral(" <i class=\"layui-icon\"></i></span>\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1655, "\"", 1746, 1);
#line 34 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
WriteAttributeValue("", 1661, User.Identities.First(u => u.IsAuthenticated).FindFirst(ClaimTypes.Thumbprint).Value, 1661, 85, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1747, 6249, true);
                WriteLiteral(@" class=""layui-nav-img"">
                    </a>
                    <dl class=""layui-nav-child"">
                        <dd><a data-pjax href=""/fytadmin/sys/admin/"">个人中心</a></dd>
                        <hr />
                        <dd><a href=""/fytadmin/logout/"">退出登录</a></dd>
                    </dl>
                </li>
            </ul>
        </div>

        <div class=""layui-side layui-bg-black"">
            <div class=""layui-side-scroll"">
                <!-- 左侧导航区域（可配合layui已有的垂直导航） -->
                <ul class=""layui-nav layui-nav-tree fyt-nav-tree"" lay-filter=""test"">
                    <li class=""layui-nav-item"">
                        <a class="""" href=""javascript:;""><i class=""layui-icon""></i>系统管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pjax href=""/fytadmin/sys/organize/"">部门管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/sys/role/"">角色管理</a></dd>
                            <dd><a data-pjax ");
                WriteLiteral(@"href=""/fytadmin/sys/admin/"">用户管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/sys/menu/"">菜单管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/sys/log/"">系统日志</a></dd>
                            <dd><a data-pjax href=""/fytadmin/sys/codes/"">字典管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/app/setting/"">APP版本更新</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a class="""" href=""javascript:;""><i class=""layui-icon""></i>采购管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pjax href=""/fytadmin/purchase/index/1"">未完成入库</a></dd>
                            <dd><a data-pjax href=""/fytadmin/purchase/index/2"">未完成付款</a></dd>
                            <dd><a data-pjax href=""/fytadmin/purchase/index/3"">未完成到票</a></dd>
                            <dd><a data-pjax href=""/fytadmin/purchase/index/4"">已完成采购</a>");
                WriteLiteral(@"</dd>
                            <dd><a data-pjax href=""/fytadmin/purchase/supplier"">供应商管理</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a class="""" href=""javascript:;""><i class=""layui-icon""></i>加盟商管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pjax href=""/fytadmin/shop/index/"">加盟商列表</a></dd>
                            <dd><a data-pjax href=""/fytadmin/shop/activityindex/"">活动管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/shop/staffindex/"">店员管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/shop/push/"">消息通知</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a class="""" href=""javascript:;""><i class=""layui-icon""></i>库存管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pja");
                WriteLiteral(@"x href=""/fytadmin/goods/barcode/"">条形码管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/goods/loss/"">报损管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/stock/import/"">入库管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/stock/export/"">出库管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/stock/transfer/"">调拨管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/goods/index/"">商品管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/stock/inventory/"">库存盘点</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;""><i class=""layui-icon""></i>财务管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pjax href=""/fytadmin/finance/accounting/"">核算总账</a></dd>
                            <dd><a data-pjax href=""/fytadmin/finance/report/"">报表中心</");
                WriteLiteral(@"a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;""><i class=""layui-icon""></i>会员管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pjax href=""/fytadmin/member/index/"">会员列表</a></dd>
                            <dd><a data-pjax href=""/fytadmin/member/grade/"">会员等级</a></dd>
                            <dd><a data-pjax href=""/fytadmin/member/statistics/"">注册统计</a></dd>
                            <dd><a data-pjax href=""/fytadmin/member/birthday/"">生日祝福</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;""><i class=""layui-icon""></i>销售管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pjax href=""/fytadmin/sale/index/"">订单明细</a></dd>
                            <dd><a data-pjax href=""/fytadmin/sal");
                WriteLiteral(@"e/goods/"">商品明细</a></dd>
                            <dd><a data-pjax href=""/fytadmin/sale/back/"">退货管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/sale/return/"">返货管理</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;""><i class=""layui-icon""></i>报表管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pjax href=""/fytadmin/report/platformInStock/"">平台入库报表</a></dd>
                            <dd><a data-pjax href=""/fytadmin/report/platformOutStock/"">平台出库报表</a></dd>
                            <dd><a data-pjax href=""/fytadmin/report/shopstock/"">加盟商库存报表</a></dd>
                            <dd><a data-pjax href=""/fytadmin/report/shopback/"">加盟商退货报表</a></dd>
                            <dd><a data-pjax href=""/fytadmin/report/shopreturn/"">加盟商返货报表</a></dd>
                        </dl>
                    </li>
                <");
                WriteLiteral("/ul>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"layui-body\" id=\"container\">\r\n            ");
                EndContext();
                BeginContext(7997, 12, false);
#line 132 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(8009, 185, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"load-container load8\">\r\n        <div class=\"load-wall\">\r\n            <div class=\"loader\">Loading...</div>\r\n        </div>\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(8194, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1faf244e8b54c358f6bda78cafa4718", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8267, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8273, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cd152e912a84fd5b674a15d9174615c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8343, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8349, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "034edde37d6f45be9fbea4ea91db3091", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8420, 1208, true);
                WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['element', 'layer', 'jquery', 'common', 'pjax'], function () {
            var os = layui.common
                , element = layui.element
                , $ = layui.jquery;
            $(document).pjax('a', '#container',
                {
                    fragment: ""#container"",
                    cache: false,
                    show: 'fade'
                }
            );
            //定位到菜单
            $("".layui-bg-black .fyt-nav-tree li a"").each(function () {
                if (window.location.pathname === $(this).attr('href')) {
                    $("".layui-bg-black .fyt-nav-tree li"").removeClass('layui-nav-itemed');
                    $(this).parents('.layui-nav-item').addClass('layui-nav-itemed');
                    $(this).parent().addClass('layui-this');
                }
            });
            $("".load8"").fadeOut(200);
            $(document).on('pjax:start', function");
                WriteLiteral(" () { NProgress.start(); $(\".load8\").show(); });\r\n            $(document).on(\'pjax:end\', function () { NProgress.done(); $(\".load8\").fadeOut(200); });\r\n        });\r\n    </script>\r\n    ");
                EndContext();
                BeginContext(9629, 41, false);
#line 170 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(9670, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(9679, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
