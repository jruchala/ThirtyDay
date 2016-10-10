using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirtyDay.Helpers
{
    public class Bootstrap
    {
        public const string BundleBase = "~/Content/css/";

        public class Theme
        {
            public const string Stock = "Stock";
            public const string Cerulean = "Cerulean";
            public const string Darkly = "Darkly";
        }

        public static HashSet<string> Themes = new HashSet<string>
        {
            Theme.Stock,
            Theme.Cerulean,
            Theme.Darkly
        };
        public static string Bundle(string themename)
        {
            return BundleBase + themename;
        }

        internal static string Bundle(object theme)
        {
            throw new NotImplementedException();
        }
    }
}