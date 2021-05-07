using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Xml.Linq;

namespace FMS.Common
{
    public static class CommonHelper
    {
        public static MvcHtmlString CustomValidationSummary(this HtmlHelper htmlHelper, bool excludePropertyErrors)
        {
            var htmlString = htmlHelper.ValidationSummary(excludePropertyErrors);

            if (htmlString != null)
            {
                XElement xEl = XElement.Parse(htmlString.ToHtmlString());

                var lis = xEl.Element("ul").Elements("li");

                if (lis.Count() == 1 && lis.First().Value == "")
                    return null;
            }

            return htmlString;
        }
    }
}