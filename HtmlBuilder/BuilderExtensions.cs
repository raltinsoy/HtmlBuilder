using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public static class BuilderExtensions
    {
        public static string SerializeToString(this Builder build)
        {
            //TODO: think better solution
            if (build.WithHtmlTag)
            {
                StringBuilder stringBuilder = new StringBuilder("<html><head>");

                if (!string.IsNullOrEmpty(build.HeadStyle))
                {
                    stringBuilder.Append("<style>" +
                                         $"{build.HeadStyle}" +
                                         "</style>");
                }

                stringBuilder.Append("</head><body>");

                foreach (var content in build.Contents)
                {
                    stringBuilder.Append(content.SerializeToString());
                }

                stringBuilder.Append("</body></html>");
                return stringBuilder.ToString();
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var content in build.Contents)
                {
                    stringBuilder.Append(content.SerializeToString());
                }
                return stringBuilder.ToString();
            }
        }
    }
}
