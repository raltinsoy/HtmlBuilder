using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public class Builder
    {
        private List<Table> _tables;

        public IEnumerable<Table> Tables => _tables;

        public Builder()
        {
            _tables = new List<Table>();
        }

        internal void AddTable(Table table)
        {
            _tables.Add(table);
        }

        public static Builder Create()
        {
            return new Builder();
        }
    }

    public static class BuilderExtensions
    {
        public static string SerializeToString(this Builder build)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var table in build.Tables)
            {
                stringBuilder.Append("<table>");

                foreach (var tr in table.Trs)
                {
                    stringBuilder.Append("<tr>");

                    foreach (var th in tr.TrChild)
                    {
                        stringBuilder.Append("<th>");
                        stringBuilder.Append(th.Content);
                        stringBuilder.Append("</th>");
                    }

                    stringBuilder.Append("</tr>");
                }

                stringBuilder.Append("</table>");
            }
            return stringBuilder.ToString();
        }
    }
}
