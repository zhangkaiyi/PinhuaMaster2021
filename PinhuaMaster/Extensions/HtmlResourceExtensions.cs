using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Mvc.Rendering
{
    public static class HtmlResourceExtensions
    {
        private const string scriptsResource = "__scripts__";
        private const string stylesResource = "__styles__";

        public static IHtmlContent Script(this IHtmlHelper htmlHelper, Func<object, HelperResult> template)
        {
            var Scripts = htmlHelper.ViewContext.HttpContext.Items[scriptsResource] as List<Func<object, HelperResult>> ?? new List<Func<object, HelperResult>>();
            Scripts.Add(template);
            htmlHelper.ViewContext.HttpContext.Items[scriptsResource] = Scripts;
            return HtmlString.Empty;
        }
        public static IHtmlContent RenderScripts(this IHtmlHelper htmlHelper)
        {
            var Scripts = htmlHelper.ViewContext.HttpContext.Items[scriptsResource] as List<Func<object, HelperResult>>;
            foreach (var script in Scripts)
            {

                if (script != null)
                {
                    htmlHelper.ViewContext.Writer.Write(script(null));
                }
            }
            // 清空数据
            htmlHelper.ViewContext.HttpContext.Items[scriptsResource] = null;
            return HtmlString.Empty;
        }

        public static IHtmlContent Style(this IHtmlHelper htmlHelper, Func<object, HelperResult> template)
        {
            var styles = htmlHelper.ViewContext.HttpContext.Items[stylesResource] as List<Func<object, HelperResult>> ?? new List<Func<object, HelperResult>>();
            styles.Add(template);
            htmlHelper.ViewContext.HttpContext.Items[stylesResource] = styles;
            return HtmlString.Empty;
        }
        public static IHtmlContent RenderStyles(this IHtmlHelper htmlHelper)
        {
            var styles = htmlHelper.ViewContext.HttpContext.Items[stylesResource] as List<Func<object, HelperResult>>;
            foreach (var style in styles)
            {

                if (style != null)
                {
                    htmlHelper.ViewContext.Writer.Write(style(null));
                }
            }
            // 清空数据
            htmlHelper.ViewContext.HttpContext.Items[stylesResource] = null;
            return HtmlString.Empty;
        }
    }

}
