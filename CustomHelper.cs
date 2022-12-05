using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject_MVC
{
    public static class CustomHelper
    {
        public static IHtmlString Image(string src, string alt, string width, string height)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt = '{1}' width='{2}' height='{3}'></img>", src, alt, width,height));
        }

        public static IHtmlString Img(this HtmlHelper helper, string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt = '{1}'></img>", src, alt));
        }
        public static IHtmlString ImgTag(this HtmlHelper helper, string src, string alt)
        {
            TagBuilder tagBuilder = new TagBuilder("img");
            tagBuilder.Attributes.Add("src", src);
            tagBuilder.Attributes.Add("alt", alt);
            return new MvcHtmlString(tagBuilder.ToString());
        }
    }
}