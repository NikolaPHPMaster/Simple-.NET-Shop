using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NasaProdavnica.Helper
{
    public static class Helperi
    {
        public static MvcHtmlString popustHelper(double cena,double popust)
        {
            var e = new TagBuilder("div");
            double novaCena=0;
            if(popust != 0)
            {
                novaCena = cena - (cena * popust / 100);
                e.AddCssClass("popust");
                e.InnerHtml = "<h4>" + cena + " din. </h4>" +
                            "<h2>" + novaCena + "din. </h2>";
            }
            else
            {
             e.InnerHtml= "<h2>" + cena + "din. </h2>";
            }
            return new MvcHtmlString(e.ToString());
        }
    }
}