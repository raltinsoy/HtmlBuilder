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
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var content in build.Contents)
            {
                stringBuilder.Append(content.SerializeToString());
            }
            return stringBuilder.ToString();
        }
    }
}
