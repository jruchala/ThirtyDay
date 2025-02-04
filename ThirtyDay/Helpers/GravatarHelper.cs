﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Security.Cryptography;


namespace ThirtyDay.Helpers
{
    public static class GravatarHelper
    {
        public static HtmlString GravatarImage(this HtmlHelper htmlHelper, string emailAddress, GravatarOptions options = null)
        {
            if (options == null)
                options = GravatarOptions.GetDefaults();

            var imgTag = new TagBuilder("img");

            emailAddress = string.IsNullOrEmpty(emailAddress) ? string.Empty : emailAddress.Trim().ToLower();

            if (!string.IsNullOrEmpty(options.CssClass))
            {
                imgTag.AddCssClass(options.CssClass);
            }

            imgTag.Attributes.Add("src",
                string.Format("http://www.gravatar.com/avatar/{0}?s={1}{2}{3}",
                GetMd5Hash(emailAddress),
                options.Size,
                "&d=" + options.DefaultImageType,
                "&r=" + options.RatingLevel
                )
                );

            return new HtmlString(imgTag.ToString(TagRenderMode.SelfClosing));
        }

        private static string GetMd5Hash(string input)
        {
            byte[] data = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

    }
}